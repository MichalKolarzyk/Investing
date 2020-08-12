using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessTest
{
    public static class Helper
    {
        public static string GetConnectionString()
        {
            return @"Server = DESKTOP-LPG7P5E\COROPLUS; Database = Investing; Trusted_Connection = True;";
        }
    }
}
