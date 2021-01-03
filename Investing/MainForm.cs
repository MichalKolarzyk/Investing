using System;
using System.Windows.Forms;
using UserControls;
using UserControls.Presenter;
using BasicModels;
using Miscellaneous;
using Repositories.Interfaces;
using Repositories.Sql;
using Repositories.SqLite;
using Repositories.Yahoo;
using System.IO;
using Settings;
using UserControls.View;

namespace Investing
{
    public partial class MainForm : Form, IMainView
    {
        CompanyPresenter DetailPresenter { get; }
        CompanyListPresenter CompanyListPresenter { get; }
        AutoUserComponent AutoUserComponent { get; set; }
        ICompanyRepository CompanyRepository { get; set; }
        IPriceRepository PriceRepository { get; set; }
        IPricesOutSource PricesOutSource { get; set; }
        IAppSettings AppSettings { get; set; }


        public ICompanyView DetailCompanyView => detailInfoControl1;
        public ICompanyListView CompanyListView => addCompanyControl1;
        public ISettingsBarView SettingBarView => settingsControl1;
        public MainPresenter Presenter { get; set; }

        
        public MainForm()
        {
            InitializeComponent();

            try
            {
                AppSettings = SettingsAppManager.GetAppSettings();

                CompanyRepository = new CompanySqlightRepository(AppSettings.DataBasePath);

                PriceRepository = new PricesSqLiteRepository(AppSettings.DataBasePath);

                PricesOutSource = new PriceYahooRepository();

                DetailPresenter = new CompanyPresenter(detailInfoControl1);

                CompanyListPresenter = new CompanyListPresenter(addCompanyControl1, CompanyRepository);
                CompanyListPresenter.OnSelectedCompany += ChangeViewOndetailPresenter_Event;

                AutoUserComponent = new AutoUserComponent(CompanyRepository, PriceRepository, PricesOutSource);
                AutoUserComponent.OnUpdate += (obj, args) => Invoke(new Action(delegate ()
                {
                    CompanyListPresenter.Update();
                    ChangeViewOndetailPresenter_Event(obj, args);
                }));

                CompanyListPresenter.Update();
            }
            catch (Exception exception)
            {
                ExceptionMessageHandler.ShowError(exception);
            }
}

        private void ChangeViewOndetailPresenter_Event(object sender, EventArgs e)
        {
            DetailPresenter.SetCompany(CompanyListPresenter.GetSelectedCompany());
        }
    }
}
