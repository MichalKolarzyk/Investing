using Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControls.Presenter;
using UserControls.View;

namespace Investing.Factories
{
    public static class PresentersFactory
    {
        public static MainPresenter CreateMainPresenter()
        {
            return new MainPresenter();
        }
    }
}
