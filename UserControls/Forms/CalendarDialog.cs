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
using UserControls.Presenter;

namespace UserControls.Forms
{
    public partial class CalendarDialog : BasicDialog
    {
        CronoPresenter CronoPresenter;
        public CalendarDialog()
        {
            InitializeComponent();
            CronoPresenter = new CronoPresenter(crono_Control1);
            okCancel_Control1.OnOk_Click += saveSettings;
        }

        private void saveSettings(object sender, EventArgs eventArgs)
        {
            Properties.Settings.Default.CronoExpression = CronoPresenter.GetCronoExpression();
        }
    }
}
