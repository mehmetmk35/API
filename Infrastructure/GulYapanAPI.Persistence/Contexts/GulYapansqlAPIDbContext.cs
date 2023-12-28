using GulYapan.API.Domain.Entity.Sql;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace GulYapanAPI.Persistence.Contexts
{
    public class GulYapansqlAPIDbContext : DbContext
    {
        public GulYapansqlAPIDbContext()
        {
        }

        public GulYapansqlAPIDbContext(DbContextOptions<GulYapansqlAPIDbContext> options) : base(options)
        {
        }
        public virtual DbSet<TBLFATUIRS> TBLFATUIRSS { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TBLFATUIRS>(entity =>
            {
                entity.HasKey(e => new { e.Ftirsip, e.FatirsNo, e.CariKodu }).HasName("TBLFATUIRSPKEY");

                entity.ToTable("TBLFATUIRS", tb => tb.HasTrigger("NLTTBLFATUIRS"));

                entity.HasIndex(e => new { e.FatirsNo, e.CariKodu, e.Ftirsip }, "TBLFATUIRS_IND_11");

                entity.HasIndex(e => new { e.Ftirsip, e.CariKodu }, "TBLFATUIRS_IND_2");

                entity.HasIndex(e => new { e.Tarih, e.Ftirsip }, "TBLFATUIRS_IND_3");

                entity.HasIndex(e => new { e.Ftirsip, e.Sirano }, "TBLFATUIRS_IND_4");

                entity.HasIndex(e => new { e.Ftirsip, e.UpdateKodu }, "TBLFATUIRS_IND_5");

                entity.HasIndex(e => new { e.SubeKodu, e.Ftirsip }, "TBLFATUIRS_IND_6");

                entity.HasIndex(e => e.SYedek1, "TBLFATUIRS_IND_7");

                entity.HasIndex(e => new { e.IsletmeKodu, e.SubeKodu }, "TBLFATUIRS_IND_8");

                entity.HasIndex(e => e.Onaynum, "TBLFATUIRS_IND_ONUM");

                entity.HasIndex(e => e.Onaytipi, "TBLFATUIRS_IND_OTIP");

                entity.Property(e => e.Ftirsip)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("FTIRSIP");
                entity.Property(e => e.FatirsNo)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("FATIRS_NO");
                entity.Property(e => e.CariKodu)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CARI_KODU");
                entity.Property(e => e.Aciklama)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ACIKLAMA");
                entity.Property(e => e.AmbarKblno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AMBAR_KBLNO");
                entity.Property(e => e.BYedek7)
                    .HasDefaultValueSql("(0)")
                    .HasColumnName("B_YEDEK7");
                entity.Property(e => e.BagTutar)
                    .HasDefaultValueSql("(0)")
                    .HasColumnType("decimal(28, 8)")
                    .HasColumnName("BAG_TUTAR");
                entity.Property(e => e.Bform)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("BFORM");
                entity.Property(e => e.Brmaliyet)
                    .HasDefaultValueSql("(0)")
                    .HasColumnType("decimal(28, 8)")
                    .HasColumnName("BRMALIYET");
                entity.Property(e => e.Bruttutar)
                    .HasDefaultValueSql("(0)")
                    .HasColumnType("decimal(28, 8)")
                    .HasColumnName("BRUTTUTAR");
                entity.Property(e => e.CYedek6)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("C_YEDEK6");
                entity.Property(e => e.CariKod2)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("CARI_KOD2");
                entity.Property(e => e.DYedek10)
                    .HasColumnType("datetime")
                    .HasColumnName("D_YEDEK10");
                entity.Property(e => e.Dovbaztar)
                    .HasColumnType("datetime")
                    .HasColumnName("DOVBAZTAR");
                entity.Property(e => e.Doviztip)
                    .HasDefaultValueSql("(0)")
                    .HasColumnName("DOVIZTIP");
                entity.Property(e => e.Doviztut)
                    .HasDefaultValueSql("(0)")
                    .HasColumnType("decimal(28, 8)")
                    .HasColumnName("DOVIZTUT");
                entity.Property(e => e.Duzeltmetarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("DUZELTMETARIHI");
                entity.Property(e => e.Duzeltmeyapankul)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("DUZELTMEYAPANKUL");
                entity.Property(e => e.Ebelge).HasColumnName("EBELGE");
                entity.Property(e => e.Exfiilitarih)
                    .HasColumnType("datetime")
                    .HasColumnName("EXFIILITARIH");
                entity.Property(e => e.Exgumrukno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EXGUMRUKNO");
                entity.Property(e => e.Exgumtarih)
                    .HasColumnType("datetime")
                    .HasColumnName("EXGUMTARIH");
                entity.Property(e => e.Exportrefno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EXPORTREFNO");
                entity.Property(e => e.Exporttype)
                    .HasDefaultValueSql("(0)")
                    .HasColumnName("EXPORTTYPE");
                entity.Property(e => e.Externalappid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EXTERNALAPPID");
                entity.Property(e => e.Externalrefid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EXTERNALREFID");
                entity.Property(e => e.FYedek3)
                    .HasDefaultValueSql("(0)")
                    .HasColumnType("decimal(28, 8)")
                    .HasColumnName("F_YEDEK3");
                entity.Property(e => e.FYedek4)
                    .HasDefaultValueSql("(0)")
                    .HasColumnType("decimal(28, 8)")
                    .HasColumnName("F_YEDEK4");
                entity.Property(e => e.FYedek5)
                    .HasDefaultValueSql("(0)")
                    .HasColumnType("decimal(28, 8)")
                    .HasColumnName("F_YEDEK5");
                entity.Property(e => e.FatAltm1)
                    .HasDefaultValueSql("(0)")
                    .HasColumnType("decimal(28, 8)")
                    .HasColumnName("FAT_ALTM1");
                entity.Property(e => e.FatAltm2)
                    .HasDefaultValueSql("(0)")
                    .HasColumnType("decimal(28, 8)")
                    .HasColumnName("FAT_ALTM2");
                entity.Property(e => e.FatAltm3)
                    .HasDefaultValueSql("((0))")
                    .HasColumnType("decimal(28, 8)")
                    .HasColumnName("FAT_ALTM3");
                entity.Property(e => e.FatkalemAdedi)
                    .HasDefaultValueSql("(0)")
                    .HasColumnName("FATKALEM_ADEDI");
                entity.Property(e => e.Faturalasmayacak)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("FATURALASMAYACAK");
                entity.Property(e => e.Fiyattarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("FIYATTARIHI");
                entity.Property(e => e.GelsubeKodu).HasColumnName("GELSUBE_KODU");
                entity.Property(e => e.GenIsk1o)
                    .HasDefaultValueSql("(0)")
                    .HasColumnType("decimal(28, 8)")
                    .HasColumnName("GEN_ISK1O");
                entity.Property(e => e.GenIsk1t)
                    .HasDefaultValueSql("(0)")
                    .HasColumnType("decimal(28, 8)")
                    .HasColumnName("GEN_ISK1T");
                entity.Property(e => e.GenIsk2o)
                    .HasDefaultValueSql("(0)")
                    .HasColumnType("decimal(28, 8)")
                    .HasColumnName("GEN_ISK2O");
                entity.Property(e => e.GenIsk2t)
                    .HasDefaultValueSql("(0)")
                    .HasColumnType("decimal(28, 8)")
                    .HasColumnName("GEN_ISK2T");
                entity.Property(e => e.GenIsk3o)
                    .HasDefaultValueSql("(0)")
                    .HasColumnType("decimal(28, 8)")
                    .HasColumnName("GEN_ISK3O");
                entity.Property(e => e.GenIsk3t)
                    .HasDefaultValueSql("(0)")
                    .HasColumnType("decimal(28, 8)")
                    .HasColumnName("GEN_ISK3T");
                entity.Property(e => e.Geneltoplam)
                    .HasDefaultValueSql("(0)")
                    .HasColumnType("decimal(28, 8)")
                    .HasColumnName("GENELTOPLAM");
                entity.Property(e => e.Genisk1tip)
                    .HasDefaultValueSql("(0)")
                    .HasColumnName("GENISK1TIP");
                entity.Property(e => e.Genisk2tip)
                    .HasDefaultValueSql("(0)")
                    .HasColumnName("GENISK2TIP");
                entity.Property(e => e.Genisk3tip)
                    .HasDefaultValueSql("(0)")
                    .HasColumnName("GENISK3TIP");
                entity.Property(e => e.GibFatirsNo)
                    .HasMaxLength(16)
                    .IsUnicode(false)
                    .HasColumnName("GIB_FATIRS_NO");
                entity.Property(e => e.GitsubeKodu).HasColumnName("GITSUBE_KODU");
                entity.Property(e => e.Halfat)
                    .HasDefaultValueSql("((0))")
                    .HasColumnName("HALFAT");
                entity.Property(e => e.HizmetFat)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("HIZMET_FAT");
                entity.Property(e => e.IYedek8)
                    .HasDefaultValueSql("(0)")
                    .HasColumnName("I_YEDEK8");
                entity.Property(e => e.IsletmeKodu).HasColumnName("ISLETME_KODU");
                entity.Property(e => e.Kapatilmis)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("KAPATILMIS");
                entity.Property(e => e.Kayittarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("KAYITTARIHI");
                entity.Property(e => e.Kayityapankul)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("KAYITYAPANKUL");
                entity.Property(e => e.Kdv)
                    .HasDefaultValueSql("(0)")
                    .HasColumnType("decimal(28, 8)")
                    .HasColumnName("KDV");
                entity.Property(e => e.KdvDahilBrutTop)
                    .HasDefaultValueSql("(0)")
                    .HasColumnType("decimal(28, 8)")
                    .HasColumnName("KDV_DAHIL_BRUT_TOP");
                entity.Property(e => e.KdvDahilmi)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("KDV_DAHILMI");
                entity.Property(e => e.KdvTenzil)
                    .HasDefaultValueSql("(0)")
                    .HasColumnType("decimal(28, 8)")
                    .HasColumnName("KDV_TENZIL");
                entity.Property(e => e.Kod1)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("KOD1");
                entity.Property(e => e.Kod2)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("KOD2");
                entity.Property(e => e.Konaklama)
                    .HasDefaultValueSql("((0))")
                    .HasColumnName("KONAKLAMA");
                entity.Property(e => e.Kosulkodu)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("KOSULKODU");
                entity.Property(e => e.Kosultarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("KOSULTARIHI");
                entity.Property(e => e.Kosvadegunu).HasColumnName("KOSVADEGUNU");
                entity.Property(e => e.KsKodu)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("KS_KODU");
                entity.Property(e => e.LYedek9)
                    .HasDefaultValueSql("(0)")
                    .HasColumnName("L_YEDEK9");
                entity.Property(e => e.Malfazlasikdvsi)
                    .HasDefaultValueSql("(0)")
                    .HasColumnType("decimal(28, 8)")
                    .HasColumnName("MALFAZLASIKDVSI");
                entity.Property(e => e.MfazIskt)
                    .HasDefaultValueSql("(0)")
                    .HasColumnType("decimal(28, 8)")
                    .HasColumnName("MFAZ_ISKT");
                entity.Property(e => e.Naktevkodu)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("NAKTEVKODU");
                entity.Property(e => e.Naktevtutar)
                    .HasColumnType("decimal(28, 8)")
                    .HasColumnName("NAKTEVTUTAR");
                entity.Property(e => e.Odekod)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ODEKOD");
                entity.Property(e => e.Odemegunu)
                    .HasDefaultValueSql("(0)")
                    .HasColumnName("ODEMEGUNU");
                entity.Property(e => e.Odemetarihi)
                    .HasColumnType("datetime")
                    .HasColumnName("ODEMETARIHI");
                entity.Property(e => e.Onaynum)
                    .HasDefaultValueSql("(0)")
                    .HasColumnName("ONAYNUM");
                entity.Property(e => e.Onaytipi)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('A')")
                    .IsFixedLength()
                    .HasColumnName("ONAYTIPI");
                entity.Property(e => e.Otvtevtutar)
                    .HasDefaultValueSql("((0))")
                    .HasColumnType("decimal(28, 8)")
                    .HasColumnName("OTVTEVTUTAR");
                entity.Property(e => e.PlaKodu)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PLA_KODU");
                entity.Property(e => e.ProjeKodu)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PROJE_KODU");
                entity.Property(e => e.SYedek1)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("S_YEDEK1");
                entity.Property(e => e.SYedek2)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("S_YEDEK2");
                entity.Property(e => e.SatIskt)
                    .HasDefaultValueSql("(0)")
                    .HasColumnType("decimal(28, 8)")
                    .HasColumnName("SAT_ISKT");
                entity.Property(e => e.SatisKond)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("SATIS_KOND");
                entity.Property(e => e.SiparisTest)
                    .HasColumnType("datetime")
                    .HasColumnName("SIPARIS_TEST");
                entity.Property(e => e.Sirano)
                    .HasDefaultValueSql("(0)")
                    .HasColumnName("SIRANO");
                entity.Property(e => e.SubeKodu).HasColumnName("SUBE_KODU");
                entity.Property(e => e.Tarih)
                    .HasColumnType("datetime")
                    .HasColumnName("TARIH");
                entity.Property(e => e.Tevkifatiade)
                    .HasDefaultValueSql("((0))")
                    .HasColumnName("TEVKIFATIADE");
                entity.Property(e => e.Tipi)
                    .HasDefaultValueSql("(0)")
                    .HasColumnName("TIPI");
                entity.Property(e => e.Topdepo)
                    .HasDefaultValueSql("((0))")
                    .HasColumnName("TOPDEPO");
                entity.Property(e => e.Topgirdepo)
                    .HasDefaultValueSql("((0))")
                    .HasColumnName("TOPGIRDEPO");
                entity.Property(e => e.ToplamMik)
                    .HasDefaultValueSql("(0)")
                    .HasColumnType("decimal(15, 5)")
                    .HasColumnName("TOPLAM_MIK");
                entity.Property(e => e.UpdateKodu)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("UPDATE_KODU");
                entity.Property(e => e.Vadebazt)
                    .HasColumnType("datetime")
                    .HasColumnName("VADEBAZT");
                entity.Property(e => e.Yapkod)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("YAPKOD");
                entity.Property(e => e.Yedek)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength()
                    .HasColumnName("YEDEK");
                entity.Property(e => e.Yedek2)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("YEDEK2");
                entity.Property(e => e.Yedek22)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("YEDEK22");
                entity.Property(e => e.Yuvarlama)
                    .HasDefaultValueSql("(0)")
                    .HasColumnType("decimal(28, 8)")
                    .HasColumnName("YUVARLAMA");
            });


        }




    }
}
