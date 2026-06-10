using Microsoft.IdentityModel.Protocols;
using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace Data
{
    public class ConnectionString
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["esportsUAI"].ConnectionString;
    }
}
