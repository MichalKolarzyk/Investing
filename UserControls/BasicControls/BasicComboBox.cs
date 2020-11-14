using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.BasicControls.BasicComponents;

namespace UserControls.BasicControls
{
    class BasicComboBox : ComboBox
    {
        public BasicComboBox() : base()
        {
            DropDownStyle = ComboBoxStyle.DropDownList;
            FlatStyle = FlatStyle.Flat;
            BackColor = Colors.MidnightBlue;
            ForeColor = Colors.Clouds;
            Font = Fonts.NewTimesRoman;
        }

    }
}
