using System;
using System.Windows.Forms;
using UserControls;
using UserControls.Presenter;
using BasicModels;


namespace Investing
{
    public partial class MainForm : Form
    {
        CompanyPresenter detailPresenter { get; }
        CompanyListPresenter companyListPresenter { get; }
        AutoUserComponent AutoUserComponent { get; set; }

        public MainForm()
        {
            InitializeComponent();

            detailPresenter = new CompanyPresenter(detailInfoControl1);

            companyListPresenter = new CompanyListPresenter(addCompanyControl1);
            companyListPresenter.Update();
            companyListPresenter.OnSelectedCompany += changeViewOndetailPresenter_Event;

            AutoUserComponent = new AutoUserComponent();
            AutoUserComponent.OnUpdate += (obj, args) => Invoke(new Action(delegate ()
                {
                    companyListPresenter.Update();
                }));

        }

        private void changeViewOndetailPresenter_Event(object sender, EventArgs e)
        {
            detailPresenter.SetCompany(companyListPresenter.GetSelectedCompany());
        }
    }
}
