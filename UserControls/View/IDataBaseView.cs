using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls.View
{
    public interface IDataBaseView
    {
        EventHandler OnDataBaseCreate { get; set; }
        EventHandler OnDataBaseDelete { get; set; }
        EventHandler OnDataBaseClean { get; set; }
    }
}
