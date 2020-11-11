using DataAccess;
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


namespace Investing
{
    public partial class MainForm : Form
    {
        CompanyPresenter detailPresenter;
        CompanyListPresenter companyListPresenter;
        public AutoUserComponent AutoUserComponent { get; set; }

        public MainForm()
        {
            InitializeComponent();

            detailPresenter = new CompanyPresenter(detailInfoControl1);

            companyListPresenter = new CompanyListPresenter(addCompanyControl1);
            companyListPresenter.Update();

            companyListPresenter.OnSelectedCompany += changeViewOndetailPresenter_Event;
            AutoUserComponent = new AutoUserComponent();

        }

        private void changeViewOndetailPresenter_Event(object sender, EventArgs e)
        {
            detailPresenter.SetCompany(companyListPresenter.GetSelectedCompany());
            companyListPresenter.Update();
            Task.Run(() => AutoUserComponent.UpdatePriceRepository());
        }
    }
}
