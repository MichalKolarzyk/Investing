using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.BasicControls;
using UserControls.View;

namespace UserControls.Controls
{
    public partial class OkCancel_Control : BasicControl, IOkCancelView
    {
        public OkCancel_Control()
        {
            InitializeComponent();
        }

        private void basicButton_Ok_Click(object sender, EventArgs e)
        {
            Form form = (Form)Parent;
            form.DialogResult = DialogResult.OK;
            form.Close();
        }

        private void basicButton_Cancel_Click(object sender, EventArgs e)
        {
            Form form = (Form)Parent;
            form.DialogResult = DialogResult.Cancel;
            form.Close();
        }
    }
}
