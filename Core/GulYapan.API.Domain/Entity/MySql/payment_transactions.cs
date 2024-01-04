using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GulYapan.API.Domain.Entity.MySql
{
    public class payment_transactions
    {  
        public int Id { get; set; }
        public string? OrderCode { get; set; }
        public string? ERPCode { get; set; }
        public string? InvoiceGibERPCode { get; set; }
        public short Installment { get; set; }
        public decimal InstallmentRate { get; set; }
        public decimal TotalPrice { get; set; }
        public string? CCNo { get; set; }
        public string? CVV { get; set; }
        public string? ExpMount { get; set; }
        public string? ExpYear { get; set; }
        public string? GatewayMethod { get; set; }
        public string? Description { get; set; }
        public string? ClientIP { get; set; }
        public DateTime CreateDate { get; set; }
        public string SyncStatus { get; set; }
        public string Status { get; set; }
        public int? AuthorUser_id { get; set; }
        public int? Current_id { get; set; }
        public int? Gateway_id { get; set; }
        public int? PaymentRequest_id { get; set; }
        public int? Seller_id { get; set; }
        public int? InstallmentObj_id { get; set; }
        public string? AuthCode { get; set; }
        public string? Note { get; set; }
        public string? RefCode { get; set; }
        public byte HasDeleted { get; set; }
        public byte HasPrint { get; set; }
        public string? NameSurname { get; set; }
        public string? Phone { get; set; }
        public string ConfirmStatus { get; set; }
        public string? CampaignKoiCode { get; set; }
        public string? InvoiceERPCode { get; set; }
        public string InvoiceSyncStatus { get; set; }
    

}
}
