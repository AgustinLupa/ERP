using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using SystemERP.Model;

namespace SystemERP.Data
{
    public static class Connection
    {
        public static string Connec()
        {
            string? connect = "Server=localhost;Database=erp;user=root;password=;";//ConfigurationManager.AppSettings.Get("default"); 
            //ConfigurationManager.ConnectionStrings["default"].ConnectionString;                                                                                          // Console.WriteLine(ConfigurationManager.AppSettings.ToString());
            return connect;
        }
    }
}
