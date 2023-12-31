using GulYapan.API.Domain.Entity.Rest.FaturaResponse;
using GulYapanAPI.Application.Repositorys.ILogger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GulYapanAPI.Infrastructure.ErrorLog
{
    public class ErrorLog : ILog
    {
        string path = string.Empty;
        string date = string.Empty;
        string date_time = string.Empty;
        public ErrorLog()
        {
            date = $"{DateTime.Now:ddMMyyyy}";
            date_time = $"{DateTime.Now:dd:MM.yyyy HH:mm: ss}";
            path = $"{Configuration.Log_Path}/Logs/ErrorLog{date}.txt";
            if (!File.Exists(path))
            {
                using (File.Create(path)) { };

            }
        }

        public void TextLog(string Exceptions)
        {
            using (StreamWriter streamWriter = new(path, true, Encoding.UTF8))
            {
                streamWriter.WriteLine($"{date_time} ---{Exceptions}");
            };

        }
    }

}
