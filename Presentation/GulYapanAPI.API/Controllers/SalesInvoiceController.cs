using GulYapan.API.Domain.Entity.MySql;
using GulYapan.API.Domain.Entity.Response;
using GulYapan.API.Domain.Entity.Rest;
using GulYapanAPI.Application.Repositorys;
using GulYapanAPI.Application.Repositorys.Payment;
using GulYapanAPI.Application.Rest;
using GulYapanAPI.Persistence.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System.Linq.Expressions;

namespace GulYapanAPI.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesInvoiceController : ControllerBase
    {
        private readonly ITBLFATUIRSReadRepository _TestReadRepository;     
        private readonly IRest _Rest;
        private readonly IPayment_TraWriteRepositorycs _PaymentTraWriteRepository;
        private ITBLEFATCARISReadRepository _TBLEFATCARISReadRepository;
        private ISellers_sellersWriteepository _SellersWriteepository;

        public SalesInvoiceController(ITBLFATUIRSReadRepository testReadRepository, IRest rest, IPayment_TraWriteRepositorycs paymentTraWriteRepository, ITBLEFATCARISReadRepository tBLEFATCARISReadRepository, ISellers_sellersWriteepository sellersWriteepository)
        {
            _TestReadRepository = testReadRepository;
            _Rest = rest;
            _PaymentTraWriteRepository = paymentTraWriteRepository;
            _TBLEFATCARISReadRepository = tBLEFATCARISReadRepository;
            _SellersWriteepository = sellersWriteepository;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<payment_transactions> payment_Transactions = await _PaymentTraWriteRepository.GetFilteredTransactions();

            if (payment_Transactions.Count>0)
            {
                foreach (var transaction in payment_Transactions)
                {
                   sellers_sellers Customer = await _SellersWriteepository.GetSellers(x => x.id == transaction.Seller_id);
                    Boolean control = await _TBLEFATCARISReadRepository.EInvoiceRecipient(x => x.IDENTIFIER == Customer.TaxNo);
                    if (control)
                    {
                        var InvoiceNumber = await _TestReadRepository.GetLastInvoiceNumberAsync(x => x.FatirsNo.StartsWith(Configuration.EFAT));
                        TokenDto tokenDto = await _Rest.GetToken();
                        if (tokenDto.status)
                        {
                            Response<string> response = await _Rest.CreateRestInvoice(Customer.Code, InvoiceNumber, control, Customer.CreateDate, "10", tokenDto.token);
                        }
                        
                    }
                    else
                    {
                        var InvoiceNumber = await _TestReadRepository.GetLastInvoiceNumberAsync(x => x.FatirsNo.StartsWith(Configuration.EARV));
                        var rst = await _Rest.GetToken();
                    }
                }

            }
            return Ok();
        }
    }
}
