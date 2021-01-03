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
using UserControls.Presenter;

namespace UserControls
{
    public partial class SettingsBarControl : UserControl, ISettingsBarView
    {
        public BasicDialog InformationDialog { get; set; }
        public BasicDialog SettingsDialog { get; set; }
        public BasicDialog CalendarDialog { get; set; }
        public BasicDialog DataBaseDialog { get; set; }
        public SettingBarPresenter _presenter { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DataBasePresenter DataBasePresenter;

        public SettingsBarControl()
        {
            InitializeComponent();

            InformationDialog = new InfoDialog();
            SettingsDialog = new SettingsDialog();
            CalendarDialog = new CalendarDialog();
            DataBaseDialog = new DataBaseDialog();
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

        private void button_DataBase_Click(object sender, EventArgs e)
        {
            DataBaseDialog.ShowDialog();
        }
    }
}
