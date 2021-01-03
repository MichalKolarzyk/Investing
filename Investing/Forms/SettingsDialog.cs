using Investing.BasicControls;
using Investing.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Investing.Forms
{
    public partial class SettingsDialog : BasicDialog
    {
        public IDataBaseSettingsView DataBaseSettingsView { get; set; }
        public SettingsDialog()
        {
            InitializeComponent();
            DataBaseSettingsView = dataBaseSettings_Control1;
            okCancel_Control1.OnOk_Click += saveSettings;
            initSettings();
        }

        private void initSettings()
        {
            
        }

        private void saveSettings(object sender, EventArgs eventArgs)
        {

        }
    }
}
