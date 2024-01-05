using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GulYapanAPI.Infrastructure
{
    static class Configuration
    {
        static public string Rest_RestUrl
        {
            get
            {
                
                var path = Environment.CurrentDirectory;

                ConfigurationManager configurationManager = new();
                //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.SetBasePath(path); ;
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager?.GetSection("Rest")["RestUrl"];
            }
        }
        static public string Rest_grant_type
        {
            get
            {
                var path = Environment.CurrentDirectory;

                ConfigurationManager configurationManager = new();
                //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.SetBasePath(path);
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager?.GetSection("Rest")["grant_type"];
            }
        }
        static public string Rest_branchcode
        {
            get
            {
                var path = Environment.CurrentDirectory;

                ConfigurationManager configurationManager = new();
                //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.SetBasePath(path);
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager?.GetSection("Rest")["branchcode"];
            }
        }
        static public string Rest_password
        {
            get
            {
                var path = Environment.CurrentDirectory;

                ConfigurationManager configurationManager = new();
                //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.SetBasePath(path);
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager?.GetSection("Rest")["password"];
            }
        }
        static public string Rest_username
        {
            get
            {
                var path = Environment.CurrentDirectory;

                ConfigurationManager configurationManager = new();
                //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.SetBasePath(path);
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager?.GetSection("Rest")["username"];
            }
        }
        static public string Rest_dbname
        {
            get
            {
                var path = Environment.CurrentDirectory;

                ConfigurationManager configurationManager = new();
                //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.SetBasePath(path);
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager?.GetSection("Rest")["dbname"];
            }
        }
        static public string Rest_dbuser
        {
            get
            {
                var path = Environment.CurrentDirectory;

                ConfigurationManager configurationManager = new();
                //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.SetBasePath(path);
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager?.GetSection("Rest")["dbuser"];
            }
        }
        static public string Rest_dbpassword
        {
            get
            {
                var path = Environment.CurrentDirectory;

                ConfigurationManager configurationManager = new();
                //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.SetBasePath(path);
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager?.GetSection("Rest")["dbpassword"];
            }
        }
        static public string Rest_dbtype
        {
            get
            {
                var path = Environment.CurrentDirectory;

                ConfigurationManager configurationManager = new();
                //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.SetBasePath(path);
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager?.GetSection("Rest")["dbtype"];
            }
        }
        static public int kdv
        {
            get
            {
                var path = Environment.CurrentDirectory;

                ConfigurationManager configurationManager = new();
                //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.SetBasePath(path);
                configurationManager.AddJsonFile("appsettings.json");
                return Convert.ToInt32(configurationManager?.GetSection("Installment")["KDV"]);
            }
        }
        static public int w_code
        {
            get
            {
                var path = Environment.CurrentDirectory;

                ConfigurationManager configurationManager = new();
                //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.SetBasePath(path);
                configurationManager.AddJsonFile("appsettings.json");
                return Convert.ToInt32(configurationManager?.GetSection("Installment")["depo"]);
            }
        }
        static public string MuhasebeKodu
        {
            get
            {
                var path = Environment.CurrentDirectory;

                ConfigurationManager configurationManager = new();
                //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.SetBasePath(path);
                configurationManager.AddJsonFile("appsettings.json");
                return  configurationManager?.GetSection("Installment")["MuhasebeKodu"];
            }
        }
        static public string Stok_Kodu
        {
            get
            {
                var path = Environment.CurrentDirectory;

                ConfigurationManager configurationManager = new();
                //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.SetBasePath(path);
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager?.GetSection("Installment")["Stok_Kodu"];
            }
        } 
        static public string Log_Path
        {
            get
            {
                var path = Environment.CurrentDirectory;

                ConfigurationManager configurationManager = new();
                //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.SetBasePath(path);
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager?.GetSection("Log")["Path"];
            }
        }
        static public string OzelKod1
        {
            get
            {
                var path = Environment.CurrentDirectory;

                ConfigurationManager configurationManager = new();
                //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.SetBasePath(path);
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager?.GetSection("Installment")["OzelKod1"];
            }
        }
        static public string OzelKod2
        {
            get
            {
                var path = Environment.CurrentDirectory;

                ConfigurationManager configurationManager = new();
                //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.SetBasePath(path);
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager?.GetSection("Installment")["OzelKod2"];
            }
        }

    }
}
