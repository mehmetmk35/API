using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GulYapan.API.Domain.Entity.MySql
{
    public class GetFilteredTransactions
    {
        public string OrderCode { get; set; }
        public string ERPCode { get; set; }
        public string Code { get; set; }
        public decimal TotalPrice { get; set; }
        public int Installment { get; set; }
        public decimal InstallmentRate { get; set; }
    }
}
