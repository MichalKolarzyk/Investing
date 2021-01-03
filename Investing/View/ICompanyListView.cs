using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicModels;

namespace Investing.View
{
    public interface ICompanyListView
    {
        int SelectedIndex { get; }
        Companies Companies { get; set; }
        EventHandler OnCompanySelected { get; set; }
        EventHandler OnCompanyRemove { get; set; }
        EventHandler OnCompanyAdd { get; set; }
    }
}
