using GulYapan.API.Domain.Entity.Response;
using GulYapan.API.Domain.Entity.Rest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GulYapanAPI.Application.Rest
{
    public interface IRest
    {
       Task<TokenDto> GetToken();
        Task<Response<string>> CreateRestInvoice(string Customer_Code, string InvoiceNumber, bool EInvoiceRecipient, DateTime CreateDate, decimal KdvsizTutar, string Token);
         void revokeToken(string Token);
    }
}
