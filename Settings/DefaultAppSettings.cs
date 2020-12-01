using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Settings
{
    class DefaultAppSettings : IAppSettings
    {
        public string DataBasePath { get; set; } = "Database.db";
        public string CronoExpression { get; set; } = "0 * 15-22 ? * MON-FRI";
        public string UserName { get; set; } = "NotKnowUser";
    }
}
