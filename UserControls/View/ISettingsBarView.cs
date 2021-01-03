using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControls.BasicControls;
using UserControls.Presenter;

namespace UserControls.View
{
    public interface ISettingsBarView 
    {
        SettingBarPresenter _presenter { get; set; }
    }
}
