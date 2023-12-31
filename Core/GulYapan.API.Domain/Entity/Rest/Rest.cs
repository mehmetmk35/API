using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GulYapan.API.Domain.Entity.Rest
{
    public class Rest
    {
        public class FaturaUst
        {
            public string FATIRS_NO { get; set; }
            public string CariKod { get; set; }
            public DateTime Tarih { get; set; }
            public DateTime ENTEGRE_TRH { get; set; }
            public DateTime FiiliTarih { get; set; }
            public DateTime SIPARIS_TEST { get; set; }
            public DateTime ODEMETARIHI { get; set; }
            public DateTime FIYATTARIHI { get; set; }
            public string Aciklama { get; set; }
            public int Tip { get; set; }
            public string KOD1 { get; set; }
            public string KOD2 { get; set; }
            public double GEN_ISK1O { get; set; }
            public int TIPI { get; set; }
            public bool KDV_DAHILMI { get; set; }
            public string PLA_KODU { get; set; }
            public string KS_KODU { get; set; }
            public string Proje_Kodu { get; set; }
            public string EKACK1 { get; set; }
            public string GIB_FATIRS_NO { get; set; }
            public int Sube_Kodu { get; set; }
            public string Bform { get; set; }
            public string EKACK11 { get; set; }
            public bool EfaturaCarisiMi { get; set; } = true;

        }
        public class FatKalem
        {

            public string StokKodu { get; set; }
            public double STra_GCMIK { get; set; }
            public string STra_NF { get; set; }
            public string STra_BF { get; set; }
            public string STra_IAF { get; set; }
            public string Plasiyer_Kodu { get; set; }
            public int DEPO_KODU { get; set; }
            public int Stok_SubeKod { get; set; }
            public int Stra_SubeKodu { get; set; }
            public string STra_SATISK { get; set; }
            public double STra_KDV { get; set; }
            public string MuhasebeKodu { get; set; }
            public string ProjeKodu { get; set; }
            public string STra_GC { get; set; }
            public string STra_ACIK { get; set; }
            public string STra_CARI_KOD { get; set; }
            public string STra_FTIRSIP { get; set; }
            public string STra_HTUR { get; set; }
            public string STra_BGTIP { get; set; }
            public int Sira { get; set; }
            public DateTime STra_testar { get; set; }
            public DateTime Vadetar { get; set; }
            public DateTime D_YEDEK10 { get; set; }
            public string Stra_OnayTipi { get; set; }
            public int Stra_OnayNum { get; set; }
            public string Ekalanneden { get; set; }
            public string Ekalan { get; set; }

        }
        public class Fatura
        {
            public string Seri { get; set; }
            public string GIB_FATIRS_NO { get; set; }
            public bool KayitliNumaraOtomatikGuncellensin { get; set; }
            public FaturaUst FatUst { get; set; }
            public bool EPostaGonderilsin { get; set; }
            public List<FatKalem> Kalems { get; set; }
            

        }

    }
}
