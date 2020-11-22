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
    public partial class OkCancel_Control : BasicControl
    {
        public EventHandler OnOk_Click;
        public EventHandler OnCancel_Click;
        public OkCancel_Control()
        {
            InitializeComponent();
        }

        private void basicButton_Ok_Click(object sender, EventArgs e)
        {
            OnOk_Click?.Invoke(sender, e);
            Form form = (Form)Parent;
            form.DialogResult = DialogResult.OK;
            form.Close();
        }

        private void basicButton_Cancel_Click(object sender, EventArgs e)
        {
            OnCancel_Click?.Invoke(sender, e);
            Form form = (Form)Parent;
            form.DialogResult = DialogResult.Cancel;
            form.Close();
        }
    }
}
