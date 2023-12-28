using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GulYapan.API.Domain.Entity.MySql
{
    public class sellers_sellers
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string? Code { get; set; }
        public string? Manager { get; set; }
        public string? City { get; set; }
        public string? County { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Logo { get; set; }
        public string? TaxTitle { get; set; }
        public string? TaxNo { get; set; }
        public string? TaxOffice { get; set; }
        public string? Fax { get; set; }
        public string? ReconEmail { get; set; }
        public string? ReconGsm { get; set; }
        public string? Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastUpdateDate { get; set; }
        public string? PlasiyerCode { get; set; }
        public decimal Limit { get; set; }
        public int Lock { get; set; }
        public int Status { get; set; }
        public int? PriceType_id { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string? PostalCode { get; set; }
        public decimal? Balance { get; set; }
        public decimal? BondBalance { get; set; }
        public decimal? BondRisk { get; set; }
        public decimal? CheckBalance { get; set; }
        public decimal? CheckRisk { get; set; }
        public decimal? EndorseBalance { get; set; }
        public decimal? EndorseRisk { get; set; }
        public int? LimitCurrency_id { get; set; }
        public int PaymentRotation { get; set; }
        public int RouteCycle { get; set; }
        public int VisitDay { get; set; }
        public int specialPermission { get; set; }
        public int? AdditionalField1 { get; set; }
        public int? AdditionalField2 { get; set; }
        public int? AdditionalField3 { get; set; }
        public int HidePrice { get; set; }
    }
}
