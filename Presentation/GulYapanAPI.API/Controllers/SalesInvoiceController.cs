using GulYapan.API.Domain.Entity.MySql;
using GulYapan.API.Domain.Entity.Response;
using GulYapan.API.Domain.Entity.Rest;
using GulYapanAPI.Application.Repositorys;
using GulYapanAPI.Application.Repositorys.ILogger; 
using GulYapanAPI.Application.Repositorys.Payment;
using GulYapanAPI.Application.Rest; 
using Microsoft.AspNetCore.Mvc;
 

namespace GulYapanAPI.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
   
    public class SalesInvoiceController : ControllerBase
    {
        
        private readonly ITBLFATUIRSReadRepository _TestReadRepository;     
        private readonly IRest _Rest;
        private readonly IPayment_TraWriteRepositorycs _PaymentTraWriteRepository;
        private readonly ITBLEFATCARISReadRepository _TBLEFATCARISReadRepository;
        private readonly ISellers_sellersWriteepository _SellersWriteepository;
        private readonly ILog _Ilog;

        public SalesInvoiceController(ILog log, ITBLFATUIRSReadRepository testReadRepository, IRest rest, IPayment_TraWriteRepositorycs paymentTraWriteRepository, ITBLEFATCARISReadRepository tBLEFATCARISReadRepository, ISellers_sellersWriteepository sellersWriteepository)
        {
            
            _TestReadRepository = testReadRepository;
            _Rest = rest;
            _PaymentTraWriteRepository = paymentTraWriteRepository;
            _TBLEFATCARISReadRepository = tBLEFATCARISReadRepository;
            _SellersWriteepository = sellersWriteepository;
            _Ilog = log;
             
        }

        [HttpGet]
        public async Task<IActionResult> CreateRestInvoice()
        {
             
           
            List<payment_transactions> payment_Transactions = await _PaymentTraWriteRepository.GetFilteredTransactions();

            if (payment_Transactions.Count>0)
            {
                foreach (var transaction in payment_Transactions)
                {
                    if (transaction.Seller_id==null || transaction.Current_id==null)
                    {
                        transaction.InvoiceSyncStatus = "error";
                        transaction.InvoiceERPCode = "";
                        transaction.InvoiceGibERPCode = "seller_id_null";
                        _PaymentTraWriteRepository.Update(transaction);
                        await _PaymentTraWriteRepository.SaveAsync();
                        _Ilog.TextLog("hta");
                         
                        
                    }
                    else
                    {
                        sellers_sellers Customer = await _SellersWriteepository.GetSellers(x => x.id == transaction.Seller_id);
                        Boolean control = await _TBLEFATCARISReadRepository.EInvoiceRecipient(x => x.IDENTIFIER == Customer.TaxNo && x.AKTIF=="E");
                        decimal Price = transaction.TotalPrice * (transaction.InstallmentRate / 100);
                        if (control)
                        {
                            var asd = Configuration.EFAT;
                            var InvoiceNumber = await _TestReadRepository.GetLastInvoiceNumberAsync(x => x.FatirsNo.StartsWith(Configuration.EFAT),invoiceseries:Configuration.EFAT);
                            TokenDto tokenDto = await _Rest.GetToken();
                            if (tokenDto.status)
                            {


                                Response<string> response = await _Rest.CreateRestInvoice(Customer.Code, InvoiceNumber, control, transaction.CreateDate, Price, tokenDto.token);
                                if (!response.Success)
                                {

                                    _Ilog.TextLog(response.Data);
                                    _Ilog.TextLog(response.Message);


                                    transaction.InvoiceSyncStatus = "error";
                                    transaction.InvoiceERPCode = "";
                                    transaction.InvoiceGibERPCode = "";
                                    _PaymentTraWriteRepository.Update(transaction);
                                    await _PaymentTraWriteRepository.SaveAsync();


                                }
                                else
                                {
                                    _Ilog.TextLog(response.Message);
                                    transaction.InvoiceSyncStatus = "complete";
                                    transaction.InvoiceERPCode = InvoiceNumber;
                                    transaction.InvoiceGibERPCode = response.Data;
                                    _PaymentTraWriteRepository.Update(transaction);
                                    await _PaymentTraWriteRepository.SaveAsync();

                                }
                            }

                        }
                        else
                        {
                            var InvoiceNumber = await _TestReadRepository.GetLastInvoiceNumberAsync(x => x.FatirsNo.StartsWith(Configuration.EARV), invoiceseries: Configuration.EARV);
                            var tokenDto = await _Rest.GetToken();
                            if (tokenDto.status)
                            {

                                Response<string> response = await _Rest.CreateRestInvoice(Customer.Code, InvoiceNumber, control, transaction.CreateDate, Price, tokenDto.token);
                                if (!response.Success)
                                {

                                    _Ilog.TextLog(response.Data);
                                    _Ilog.TextLog(response.Message);
                                    transaction.InvoiceSyncStatus = "error";
                                    transaction.InvoiceERPCode = "";
                                    transaction.InvoiceGibERPCode = "";
                                    _PaymentTraWriteRepository.Update(transaction);
                                    await _PaymentTraWriteRepository.SaveAsync();
                                }
                                else
                                {
                                    _Ilog.TextLog(response.Message);
                                    transaction.InvoiceSyncStatus = "complete";
                                    transaction.InvoiceERPCode = InvoiceNumber;
                                    transaction.InvoiceGibERPCode = response.Data;
                                    _PaymentTraWriteRepository.Update(transaction);
                                    await _PaymentTraWriteRepository.SaveAsync();
                                }
                            }
                        }
                    }
                   
                }

            }
            else
            {
                _Ilog.TextLog("kayıt yok");
            }
            return NoContent();
        }
    }
}
