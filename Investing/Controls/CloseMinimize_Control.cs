using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Investing.BasicControls;

namespace Investing.Controls
{
    public partial class CloseMinimize_Control : BasicControl
    {
        public CloseMinimize_Control()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

            Form form = (Form)Parent;
            form.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Form form = (Form)Parent;
            form.WindowState = FormWindowState.Minimized;
        }
    }
}
