using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Investing.BasicControls
{
    public partial class BasicDialog : Form
    {
        public BasicDialog()
        {
            InitializeComponent();
            Size = new Size(315, 173);
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }
    }
}
