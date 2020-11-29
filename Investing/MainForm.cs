using System;
using System.Windows.Forms;
using UserControls;
using UserControls.Presenter;
using BasicModels;
using Miscellaneous;
using Repositories.Interfaces;
using Repositories.Sql;
using Repositories.Sqlight;
using Repositories.Yahoo;
using System.IO;

namespace Investing
{
    public partial class MainForm : Form
    {
        CompanyPresenter detailPresenter { get; }
        CompanyListPresenter companyListPresenter { get; }
        AutoUserComponent AutoUserComponent { get; set; }
        ICompanyRepository CompanyRepository { get; set; }
        IPriceRepository PriceRepository { get; set; }
        IPricesOutSource PricesOutSource { get; set; }
        public MainForm()
        {
            InitializeComponent();

            try
            {
                CompanyRepository = new CompanySqlRepository(Properties.Settings.Default.ConnectionString);

                string databasePath = Path.Combine(Directory.GetCurrentDirectory(), "Database.db");
                CompanyRepository = new CompanySqlightRepository(databasePath);
                PriceRepository = new PricesSqlightRepository(databasePath);
                PricesOutSource = new PriceYahooRepository();

                detailPresenter = new CompanyPresenter(detailInfoControl1);

                companyListPresenter = new CompanyListPresenter(addCompanyControl1, CompanyRepository);
                companyListPresenter.Update();
                companyListPresenter.OnSelectedCompany += changeViewOndetailPresenter_Event;

                AutoUserComponent = new AutoUserComponent(CompanyRepository, PriceRepository, PricesOutSource);

                AutoUserComponent.OnUpdate += (obj, args) => Invoke(new Action(delegate ()
                {
                    companyListPresenter.Update();
                    changeViewOndetailPresenter_Event(obj, args);
                }));
            }
            catch (Exception exception)
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
