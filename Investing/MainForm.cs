using System;
using System.Windows.Forms;
using UserControls;
using UserControls.Presenter;
using BasicModels;
using Miscellaneous;


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

            try
            {
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
            catch(Exception exception)
            {
                ExceptionMessageHandler.ShowError(exception);
            }

        }

        private void changeViewOndetailPresenter_Event(object sender, EventArgs e)
        {
            detailPresenter.SetCompany(companyListPresenter.GetSelectedCompany());
        }
    }
}
