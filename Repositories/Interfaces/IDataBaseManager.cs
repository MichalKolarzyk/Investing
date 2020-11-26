using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface IDataBaseManager
    {
        void Create();
        void Clear();
        void Delete();
    }
}
