namespace GulYapanAPI.API
{
    static class Configuration
    {
        static public string EFAT
        {
            get
            {
                ConfigurationManager configurationManager = new();
              
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager?.GetSection("Seriler")["EFAT"];
            }
        }
        static public string EARV
        {
            get
            {
                ConfigurationManager configurationManager = new();               
                configurationManager.AddJsonFile("appsettings.json");                
                return configurationManager?.GetSection("Seriler")["EARV"];
            }
        }
         
    }
}
