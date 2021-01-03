using Investing.BasicControls;
using Investing.Presenter;
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
    public partial class DataBaseDialog : BasicDialog
    {
        IDataBaseView dataBaseView;
        DataBasePresenter dataBasePresenter;
        public DataBaseDialog()
        {
            InitializeComponent();
            dataBaseView = dataBase_Control1;
            dataBasePresenter = new DataBasePresenter(dataBaseView);
        }
    }
}
