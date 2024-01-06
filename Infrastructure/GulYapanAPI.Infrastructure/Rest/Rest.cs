using GulYapan.API.Domain.Entity.Response;
using GulYapan.API.Domain.Entity.Rest;
using GulYapan.API.Domain.Entity.Rest.FaturaResponse;
using GulYapanAPI.Application.Rest;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GulYapan.API.Domain.Entity.Rest.Rest;


namespace GulYapanAPI.Infrastructure
{
       public class Rest : IRest
    {      
        public async Task<TokenDto> GetToken()
        {
            TokenDto tokenModel = new TokenDto();
            tokenModel.status = false;
            tokenModel.token = String.Empty;
            try
            {
                HttpResponseMessage response;

                var formContent = new FormUrlEncodedContent(new[]
                        {
                        new KeyValuePair<string, string>("grant_type", Configuration.Rest_grant_type),
                        new KeyValuePair<string, string>("branchcode", Configuration.Rest_branchcode),
                        new KeyValuePair<string, string>("password", Configuration.Rest_password),
                        new KeyValuePair<string, string>("username", Configuration.Rest_username),                       
                        new KeyValuePair<string, string>("dbname", Configuration.Rest_dbname),
                        new KeyValuePair<string, string>("dbuser", Configuration.Rest_dbuser),
                        new KeyValuePair<string, string>("dbpassword", Configuration.Rest_dbpassword),
                        new KeyValuePair<string, string>("dbtype", Configuration.Rest_dbtype)
                    });

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(new Uri(Configuration.Rest_RestUrl), "api/v2/token");

                    response = client.PostAsync(client.BaseAddress.AbsoluteUri, formContent).Result;
                }
                var result = response.Content.ReadAsStringAsync().Result;
                response.Dispose();
                string asd = result.Split(',')[0];
                asd.Split(':');
                if (result.IndexOf("access_token") > 0)
                {
                    tokenModel.token = asd.Split(':')[1].Trim('"');
                    tokenModel.status = true;
                }
                else
                {
                    tokenModel.token = asd.Split(':')[1].Trim('"');
                    tokenModel.status = false;
                }
            }
            catch (Exception ex)
            {
                //LogKaydet("", "TOKEN", ex.Message, "", "", "HATA", 0, "");
                tokenModel.status = false;
                tokenModel.token = ex.Message;
            }
            return tokenModel;
        }

        public void revokeToken(string token)
        {
            HttpResponseMessage response;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(new Uri(Configuration.Rest_RestUrl), "api/v2/revoke");
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
                response = client.GetAsync(client.BaseAddress.AbsoluteUri).Result;
            }
            var result = response.Content.ReadAsStringAsync().Result;
            response.Dispose();
        }

        public async Task<Response<string>> CreateRestInvoice(string Customer_Code,string InvoiceNumber,bool EInvoiceRecipient,DateTime CreateDate,decimal KdvsizTutar,string Token)
        {
            Response<string> response = new();
            try
            {

           
            
            response.Message = "false";
            response.Success = false;
            HttpResponseMessage responseMessage;
            Fatura fatura = new Fatura();
            fatura.FatUst = new FaturaUst();
            fatura.FatUst.CariKod = Customer_Code;
            fatura.FatUst.EfaturaCarisiMi = EInvoiceRecipient;
            fatura.FatUst.FATIRS_NO = InvoiceNumber;
            fatura.FatUst.Tarih = CreateDate;
            fatura.FatUst.Tip = 0;
            fatura.FatUst.TIPI = 2;
            fatura.FatUst.KOD1 = Configuration.OzelKod1;
            fatura.FatUst.KOD2 = Configuration.OzelKod2;
             
            fatura.Kalems = new List<FatKalem>();

            FatKalem fatkalem = new FatKalem();
            fatkalem.StokKodu = Configuration.Stok_Kodu;           
            fatkalem.STra_ACIK = Customer_Code;
            fatkalem.STra_CARI_KOD = Customer_Code;
            fatkalem.STra_GCMIK = 1;
            fatkalem.STra_BF = KdvsizTutar.ToString().Replace(',', '.');
            fatkalem.STra_NF = KdvsizTutar.ToString().Replace(',', '.');

            fatkalem.STra_KDV = Configuration.kdv;

            fatkalem.DEPO_KODU = Configuration.w_code;
            fatkalem.STra_FTIRSIP = "1";
            fatkalem.STra_HTUR = "J";
            fatkalem.STra_BGTIP = "F";
            fatkalem.STra_GC = "C";
                
            fatkalem.Sira = 1;
            fatkalem.D_YEDEK10 = CreateDate;
            fatkalem.MuhasebeKodu = Configuration.MuhasebeKodu;
            fatkalem.Stra_OnayNum = 0;
            fatkalem.Stra_OnayTipi = "A";
            fatura.Kalems.Add(fatkalem);
            var jsonval = JsonConvert.SerializeObject(fatura);
            var content = new StringContent(jsonval, Encoding.UTF8, "application/json");
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(new Uri(Configuration.Rest_RestUrl), "api/v2/ItemSlips");
                client.DefaultRequestHeaders.Add("Authorization", "Bearer " + Token);

                    responseMessage = client.PostAsync(client.BaseAddress.AbsoluteUri, content).Result;
            }
            var result = responseMessage.Content.ReadAsStringAsync().Result;
            var response1 = JsonConvert.DeserializeObject<FaturaResponse>(result);                 
            var GIB_FATIRS_NO = response1?.Data?.FatUst?.GIB_FATIRS_NO;
            String value = response1?.IsSuccessful;
            responseMessage.Dispose();
                 
            if (Convert.ToBoolean(value))
            {                                       
                response.Message = "SATIŞ FATURA OLUŞTURMA İŞLEMİ BAŞARILIDIR. NO: " + InvoiceNumber;
                response.Success = true;
                response.Data = GIB_FATIRS_NO;
            }
            else
            {
                response.Message = "SATIŞ FATURA OLUŞTURMA İŞLEMİ HATA. NO: " + InvoiceNumber;
                response.Success = false;
                response.Data = result;
            }
            }
            finally
            {
               revokeToken(Token);
            }

            return  response;
        }

        
    }
}
