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
                var path = Environment.CurrentDirectory;

                ConfigurationManager configurationManager = new();
                //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.SetBasePath(path);
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("GulYapanSQL");
            }
        }
        static public string ConnectionStringSqlNetsis
        {
            get
            {
                var path = Environment.CurrentDirectory;

                ConfigurationManager configurationManager = new();
                //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.SetBasePath(path);
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("GulYapanNetsisSQL");
            }
        }

        static public string ConnectionStringMysql
        {
            get
            {
                var path = Environment.CurrentDirectory;

                ConfigurationManager configurationManager = new();
                //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.SetBasePath(path);
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("GulYapanMysql");
            }
        }

        static public int Installment
        {
            get
            {
                var path = Environment.CurrentDirectory;

                ConfigurationManager configurationManager = new();
                //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.SetBasePath(path);
                configurationManager.AddJsonFile("appsettings.json");

                return Convert.ToInt32(configurationManager?.GetSection("Installment")["Installment"]);

            }
        }
        static public int InstallmentRate
        {
            get
            {
                var path = Environment.CurrentDirectory;

                ConfigurationManager configurationManager = new();
                //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.SetBasePath(path);
                configurationManager.AddJsonFile("appsettings.json");
                return Convert.ToInt32(configurationManager?.GetSection("Installment")["InstallmentRate"]);
            }
        }
       
    }
     
}
