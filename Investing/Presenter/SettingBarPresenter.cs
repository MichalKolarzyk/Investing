using Investing.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investing.Presenter
{
    public class SettingBarPresenter : IPresenter<ISettingsBarView>
    {
        public SettingBarPresenter(ISettingsBarView view)
        {
            View = view;
        }
        public ISettingsBarView View { get; set; }
    }
}
