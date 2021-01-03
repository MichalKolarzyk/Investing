using Investing.BasicControls.BasicComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Investing.BasicControls
{
    public class BasicGroupBox : GroupBox
    {
        public BasicGroupBox() : base()
        {
            Font = Fonts.NewTimesRoman;
            ForeColor = Colors.Clouds;
        }
    }
}
