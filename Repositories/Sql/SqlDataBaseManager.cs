using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositories.Sql.Api;
using Repositories.Interfaces;

namespace Repositories.Sql
{
    public class SqlDataBaseManager : IDataBaseManager
    {
        private readonly SqlAccess sqlAccess;
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
