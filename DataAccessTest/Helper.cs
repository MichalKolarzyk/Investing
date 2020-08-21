using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace DataAccessTest
{
    public static class Helper
    {
        public static string GetConnectionString()
        {
            return @"Server = DESKTOP-LPG7P5E\COROPLUS; Database = InvestingTest; Trusted_Connection = True;";
        }

        public static SQLAccess GetTestSqlAccess()
        {
            return new SQLAccess(GetConnectionString());
        }
    }
}
