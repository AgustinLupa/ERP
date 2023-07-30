using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace SystemERP.Data
{
    public static class Connection
    {
        public static string Connec()
        {
            string connect = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
            return connect;
        }
    }
}
