using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GulYapan.API.Domain.Entity.Sql
{
    public class TBLEFATCARI
    {
        [Key]
        public string IDENTIFIER { get; set; }
        public string ALIAS { get; set; }
        public string TITLE { get; set; }
        public string EFATTYPE { get; set; }
        public DateTime TARIH { get; set; }
        public byte PROFILEID { get; set; }
        public string UPDATE_KODU { get; set; }
        public string AKTIF { get; set; }
        public string C_YEDEK1 { get; set; }
        public string C_YEDEK2 { get; set; }
        public int I_YEDEK3 { get; set; }

        public int I_YEDEK4 { get; set; }

        public int I_YEDEK5 { get; set; }

        public int I_YEDEK6 { get; set; }

        public float F_YEDEK5 { get; set; }

        public float F_YEDEK7 { get; set; }

        public float F_YEDEK8 { get; set; }

        public float F_YEDEK6 { get; set; }

        public DateTime D_YEDEK7 { get; set; }

        public DateTime D_YEDEK8 { get; set; }

        public DateTime D_YEDEK9 { get; set; }

        public DateTime D_YEDEK10 { get; set; }

    }
}
