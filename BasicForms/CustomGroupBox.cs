using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicForms
{
    public class CustomGroupBox : GroupBox
    {
        public CustomGroupBox() : base()
        {
            Font = CustomComponents.GetRegularFont();
            ForeColor = CustomColors.Clouds;
            BackColor = CustomColors.MidnightBlue;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

    }
}
