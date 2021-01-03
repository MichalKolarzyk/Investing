using Investing.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investing.View
{
    public interface ISettingsBarView 
    {
        SettingBarPresenter _presenter { get; set; }
    }
}
