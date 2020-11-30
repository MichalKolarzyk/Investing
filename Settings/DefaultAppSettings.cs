using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Settings
{
    class DefaultAppSettings : IAppSettings
    {
        public string DataBasePath { get; set; }
        public string CronoExpression { get; set; }
    }
}
