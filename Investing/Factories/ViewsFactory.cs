using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControls.View;

namespace Investing.Factories
{
    public static class ViewsFactory
    {
        public static IMainView CreateMainForm()
        {
            return new MainForm();
        }
    }
}
