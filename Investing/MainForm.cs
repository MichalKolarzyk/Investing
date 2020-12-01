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
using Settings;

namespace Investing
{
    public partial class MainForm : Form
    {
        CompanyPresenter DetailPresenter { get; }
        CompanyListPresenter CompanyListPresenter { get; }
        AutoUserComponent AutoUserComponent { get; set; }
        ICompanyRepository CompanyRepository { get; set; }
        IPriceRepository PriceRepository { get; set; }
        IPricesOutSource PricesOutSource { get; set; }
        IAppSettings AppSettings { get; set; }
        public MainForm()
        {
            InitializeComponent();

            try
            {
                AppSettings = SettingsAppManager.GetAppSettings();
                
                CompanyRepository = new CompanySqlightRepository(AppSettings.DataBasePath);
                
                PriceRepository = new PricesSqlightRepository(AppSettings.DataBasePath);
                
                PricesOutSource = new PriceYahooRepository();
                
                DetailPresenter = new CompanyPresenter(detailInfoControl1);
                
                CompanyListPresenter = new CompanyListPresenter(addCompanyControl1, CompanyRepository);
                CompanyListPresenter.OnSelectedCompany += changeViewOndetailPresenter_Event;
                
                AutoUserComponent = new AutoUserComponent(CompanyRepository, PriceRepository, PricesOutSource);
                AutoUserComponent.OnUpdate += (obj, args) => Invoke(new Action(delegate ()
                {
                    CompanyListPresenter.Update();
                    changeViewOndetailPresenter_Event(obj, args);
                }));

                CompanyListPresenter.Update();
            }
            catch (Exception exception)
            {
                ExceptionMessageHandler.ShowError(exception);
            }
        }

        private void changeViewOndetailPresenter_Event(object sender, EventArgs e)
        {
            DetailPresenter.SetCompany(CompanyListPresenter.GetSelectedCompany());
        }
    }
}
