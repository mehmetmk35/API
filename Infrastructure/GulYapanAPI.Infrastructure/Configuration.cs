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
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager?.GetSection("Rest")["RestUrl"];
            }
        }
        static public string Rest_grant_type
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager?.GetSection("Rest")["grant_type"];
            }
        }
        static public string Rest_branchcode
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager?.GetSection("Rest")["branchcode"];
            }
        }
        static public string Rest_password
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager?.GetSection("Rest")["password"];
            }
        }
        static public string Rest_username
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager?.GetSection("Rest")["username"];
            }
        }
        static public string Rest_dbname
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager?.GetSection("Rest")["dbname"];
            }
        }
        static public string Rest_dbuser
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager?.GetSection("Rest")["dbuser"];
            }
        }
        static public string Rest_dbpassword
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager?.GetSection("Rest")["dbpassword"];
            }
        }
        static public string Rest_dbtype
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager?.GetSection("Rest")["dbtype"];
            }
        }
        static public int kdv
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return Convert.ToInt32(configurationManager?.GetSection("Installment")["KDV"]);
            }
        }
        static public int w_code
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return Convert.ToInt32(configurationManager?.GetSection("Installment")["depo"]);
            }
        }
        static public string MuhasebeKodu
        {
            get
            {
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/GulYapanAPI.API"));
                configurationManager.AddJsonFile("appsettings.json");
                return  configurationManager?.GetSection("Installment")["MuhasebeKodu"];
            }
        }

    }
}
