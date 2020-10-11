using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls;
using UserControls.Presenter;
using UserControls.View;

namespace Investing
{
    public partial class Form1 : Form
    {
        CompanyPresenter detailPresenter;
        CompanyListPresenter companyListPresenter;
        public Form1()
        {
            InitializeComponent();
            detailPresenter = new CompanyPresenter(detailInfoControl1);
            companyListPresenter = new CompanyListPresenter(addCompanyControl1);
            companyListPresenter.OnSelectedCompany += changeViewOndetailPresenter_Event;

        }

        private void changeViewOndetailPresenter_Event(object sender, EventArgs e)
        {
            detailPresenter.SetCompany(companyListPresenter.GetSelectedCompany());
        }
    }
}
