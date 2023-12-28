using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GulYapan.API.Domain.Entity.Sql
{
    public class Log
    {
       
        public string? KULLANICI_ADI { get; set; }
        public string? ISLEM { get; set; }
        public string? HATA_MESAJI { get; set; }
        public DateTime? ISLEM_TARIHI { get; set; }
        public string? SIRKET { get; set; }
        public string? LOG_DURUMU { get; set; }
        public int? REF_ID { get; set; }
        public string? REF_ERP_NO { get; set; }
        
        
        
        
        
        
        
    }
}
