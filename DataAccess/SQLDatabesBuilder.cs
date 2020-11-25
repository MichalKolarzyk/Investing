using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class SQLDatabesBuilder
    {
        public string ConnectionString { get; set; }
        public SQLDatabesBuilder(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public void Create()
        {

        }

        public void Delete()
        {

        }
    }
}
