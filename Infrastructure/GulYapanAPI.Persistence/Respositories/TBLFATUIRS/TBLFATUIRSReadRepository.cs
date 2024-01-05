using GulYapan.API.Domain.Entity.Sql;
using GulYapanAPI.Application.Repositorys;
using GulYapanAPI.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace GulYapanAPI.Persistence.Respositories
{
    public class TBLFATUIRSReadRepository : ReadRepository<TBLFATUIRS>, ITBLFATUIRSReadRepository 
    {
        public TBLFATUIRSReadRepository(GulYapansqlAPIDbContext context) : base(context)
        {
        }

        bool IsNumeric(string text)
        {
            foreach (char chr in text)
            {
                if (!Char.IsNumber(chr)) return false;
            }
            return true;
        }

        public async Task<string> GetLastInvoiceNumberAsync(Expression<Func<TBLFATUIRS, bool>> metod, string invoiceseries, bool tracking = true )
        {
            var invoiceNum=string.Empty;
            try
            {
                var query = Table.AsQueryable();
                if (!tracking)
                    query = query.AsNoTracking();
                  invoiceNum = await query.Where(metod).OrderByDescending(x => x.FatirsNo).Select(x => x.FatirsNo).FirstOrDefaultAsync();
                List<String> StringDegerler = new List<string>();
                List<int> SayisalDegerler = new List<int>();
                if (!String.IsNullOrEmpty(invoiceNum))
                {
                    for (int sayac = 0; sayac < invoiceNum.Length; sayac++)
                    {
                        if (IsNumeric(invoiceNum.Substring(sayac, 1)))
                        {
                            SayisalDegerler.Add(Convert.ToInt32(invoiceNum.Substring(sayac, 1)));
                        }
                        else
                        {
                            StringDegerler.Add(invoiceNum.Substring(sayac, 1));
                        }
                    }
                    if (StringDegerler.Count > 0)
                    {
                        String StringHarfler = invoiceNum.Substring(0, StringDegerler.Count);
                        var ArtanNo = Convert.ToInt64(invoiceNum.Substring(StringDegerler.Count, SayisalDegerler.Count)) + 1;
                        String SonHali = StringHarfler + ArtanNo.ToString().PadLeft(SayisalDegerler.Count, '0');
                        invoiceNum = SonHali;
                    }
                    else
                    {
                        invoiceNum = (Convert.ToInt32(invoiceNum) + 1).ToString().PadLeft(15, '0');
                    }
                }
                else
                {

                    invoiceNum = invoiceseries;
                    invoiceNum = invoiceNum.PadRight(14, '0') + "1";
                }
            }
            catch (Exception ex)
            {
                //LogKaydet olucak 
                invoiceNum = String.Empty;
            }
            finally
            {

            }
             return invoiceNum;

        }

       
    }
}
