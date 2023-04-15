using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_api.Configurations
{
    public class SQLServer
    {
        public static string getConnectionString()
        {
            //return @"Server=DESKTOP-D9F9UIL;Database=consultorio;Trusted_Connection=True;";

            return System.Configuration.ConfigurationManager.ConnectionStrings["consultorio"].ConnectionString;
        }
    }
}