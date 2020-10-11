using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.BasicControls.BasicComponents;

namespace UserControls.BasicControls
{
    class CustomButton : Button
    {
        public CustomButton() : base()
        {
            Text = "Custom Button";
            Font = Fonts.NewTimesRoman;
            FlatStyle = FlatStyle.Flat;
            Size = new Size(130, 30);
            ForeColor = Colors.Clouds;
            BackColor = Colors.WetAsphalt;
        }
    }
}
