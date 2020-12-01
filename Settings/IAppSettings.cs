using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Settings
{
    public interface IAppSettings
    {
        string DataBasePath { get; set; }
        string CronoExpression { get; set; }
        string UserName { get; set; }
    }
}
