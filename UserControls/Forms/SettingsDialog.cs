using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.BasicControls;
using UserControls.View;

namespace UserControls.Forms
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
            DataBaseSettingsView.ConnectionString = Properties.Settings.Default.ConnectionString;
        }

        private void saveSettings(object sender, EventArgs eventArgs)
        {
            Properties.Settings.Default.ConnectionString = DataBaseSettingsView.ConnectionString;
            Properties.Settings.Default.Save();
        }
    }
}
