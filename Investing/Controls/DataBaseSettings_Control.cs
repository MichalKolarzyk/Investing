using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Investing.View;
using Investing.BasicControls;

namespace Investing.Controls
{
    public partial class DataBaseSettings_Control : BasicControl, IDataBaseSettingsView
    {
        public DataBaseSettings_Control()
        {
            InitializeComponent();
        }

        public string ConnectionString
        {
            get { return basicTextBox_ConnestionStrin.Text; }
            set { basicTextBox_ConnestionStrin.Text = value; }
        }
        public string Password
        {
            get { return basicTextBox_Password.Text; }
            set { basicTextBox_Password.Text = value; }
        }
    }
}
