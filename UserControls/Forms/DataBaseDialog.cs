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
using UserControls.Presenter;

namespace UserControls.Forms
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
