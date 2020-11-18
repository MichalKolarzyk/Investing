using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace UserControls.Repository
{
    class SqlDataBaseManager : IDataBaseManager
    {
        private SqlAccess sqlAccess;
        public SqlDataBaseManager(string connectionString)
        {
            sqlAccess = new SqlAccess(connectionString);
        }
        public void Clear()
        {
            sqlAccess.ClearData();
        }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }
}
