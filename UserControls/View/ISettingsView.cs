using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControls.BasicControls;

namespace UserControls.View
{
    public interface ISettingsView
    {
        BasicDialog InformationDialog { get; set; }
        BasicDialog SettingsDialog { get; set; }
        BasicDialog SearchDialog { get; set; }
        BasicDialog CalendarDialog { get; set; }
    }
}
