using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GulYapanAPI.Persistence
{
    static   class Configuration
    {
        
        static public string ConnectionStringSql
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("GulYapanSQL");
            }
        }
        static public string ConnectionStringSqlNetsis
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("GulYapanNetsisSQL");
            }
        }

        static public string ConnectionStringMysql
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("GulYapanMysql");
            }
        }

        static public int Installment
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.AddJsonFile("appsettings.json");

                return Convert.ToInt32(configurationManager?.GetSection("Installment")["Installment"]);

            }
        }
        static public int InstallmentRate
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return Convert.ToInt32(configurationManager?.GetSection("Installment")["InstallmentRate"]);
            }
        }
       
    }
     
}
