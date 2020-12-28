using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicModels;

namespace UserControls.View
{
    public interface ICompanyListView
    {
        int SelectedIndex { get; }
        EventHandler OnCompanySelected { get; set; }
        EventHandler OnCompanyRemove { get; set; }
        EventHandler OnCompanyAdd { get; set; }
        Companies Companies { get; set; }
    }
}
