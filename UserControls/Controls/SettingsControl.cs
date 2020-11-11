using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.View;
using UserControls.BasicControls;
using UserControls.Forms;

namespace UserControls
{
    public partial class SettingsControl : UserControl, ISettingsView
    {
        public BasicDialog InformationDialog { get; set; }
        public BasicDialog SettingsDialog { get; set; }
        public BasicDialog SearchDialog { get; set; }
        public BasicDialog CalendarDialog { get; set; }

        public SettingsControl()
        {
            InitializeComponent();

            InformationDialog = new InfoDialog();
            SettingsDialog = new SettingsDialog();
            SearchDialog = new SearchDialog();
            CalendarDialog = new CalendarDialog();
        }

        private void button_Informations_Click(object sender, EventArgs e)
        {
            InformationDialog.ShowDialog();
        }

        private void button_Settings_Click(object sender, EventArgs e)
        {
            SettingsDialog.ShowDialog();
        }

        private void button_Calendar_Click(object sender, EventArgs e)
        {
            CalendarDialog.ShowDialog();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            SearchDialog.ShowDialog();
        }
    }
}
