using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.BasicControls.BasicComponents;
using System.Drawing;

namespace UserControls.BasicControls
{
    public class IconButton : BasicButton
    {
        public IconButton() : base()
        {
            FlatStyle = FlatStyle.Flat;
            BackColor = Colors.MidnightBlue;
            Size = new Size(62, 55);
            Text = "";
            FlatAppearance.BorderSize = 0;
        }
    }
}
