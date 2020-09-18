using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicForms
{
    public class CustomLabel : Label
    {
        public CustomLabel() : base()
        {
            this.Font = CustomComponents.GetRegularFont();
            ForeColor = CustomColors.Clouds;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
        }
    }
}
