using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls.View
{
    public interface IDataBaseSettingsView
    {
        string ConnectionString { get; set; }
        string Password { get; set; }
    }
}
