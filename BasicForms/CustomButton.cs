using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BasicForms
{
    public class CustomButton : Button
    {
        public CustomButton() : base()
        {
            Text = "Custom Button";
            Font = CustomComponents.GetRegularFont();
            FlatStyle = FlatStyle.Flat;
            Size = new Size(130, 30);
            ForeColor = CustomColors.Clouds;
            BackColor = CustomColors.WetAsphalt;
        }


        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
        }

    }
}
