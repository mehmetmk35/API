using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GulYapan.API.Domain.Entity.Rest.FaturaResponse
{
    public class FaturaResponse
    {
        public Data Data { get; set; }
        public  string IsSuccessful { get; set; }
        
}
    public class FatUst
    {
        public string GIB_FATIRS_NO { get; set; }
        
    }

    public class Data
    {
        public FatUst FatUst { get; set; }
       
    }

     

}
