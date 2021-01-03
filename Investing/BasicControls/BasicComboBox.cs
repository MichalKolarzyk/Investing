using Investing.BasicControls.BasicComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Investing.BasicControls
{
    public class BasicComboBox : ComboBox
    {
        public BasicComboBox() : base()
        {
            DropDownStyle = ComboBoxStyle.DropDownList;
            FlatStyle = FlatStyle.Flat;
            BackColor = Colors.MidnightBlue;
            ForeColor = Colors.Clouds;
            Font = Fonts.NewTimesRoman;
            Margin = new Padding(10);
        }

    }
}
