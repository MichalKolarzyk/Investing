using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.BasicControls.BasicComponents;

namespace UserControls.BasicControls
{
    class BasicGroupBox : GroupBox
    {
        public BasicGroupBox() : base()
        {
            Font = Fonts.NewTimesRoman;
            ForeColor = Colors.Clouds;
        }
    }
}
