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
        OkCancelPresenter OkCancelPresenter;
        public CalendarDialog()
        {
            InitializeComponent();
            CronoPresenter = new CronoPresenter(crono_Control1);
            OkCancelPresenter = new OkCancelPresenter(okCancel_Control1);
        }

        public string GetCronoExpresion()
        {
            return CronoPresenter.GetCronoExpression().ToString();
        }
    }
}
