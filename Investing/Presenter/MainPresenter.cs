using BasicModels;
using Investing.View;
using Repositories.Interfaces;
using Repositories.SqLite;
using Repositories.Yahoo;
using Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControls;

namespace Investing.Presenter
{
    public class MainPresenter : IPresenter<IMainView>
    {
        public IPresenter<ICompanyView> DetailPresenter { get; set; }
        public IPresenter<ICompanyListView> CompanyListPresenter { get; set; }
        public IPresenter<ISettingsBarView> SettingBarPresenter { get; set; }

        public AutoUserComponent AutoUserComponent { get; set; }
        public IMainView View { get; set; }

        public MainPresenter(IMainView view, IAppSettings appSettings)
        {
            View = view;

            ICompanyRepository companyRepository = new CompanySqlightRepository(appSettings.DataBasePath);
            IPriceRepository priceRepository = new PricesSqLiteRepository(appSettings.DataBasePath);
            IPricesOutSource pricesOutSource = new PriceYahooRepository();

            DetailPresenter = new CompanyPresenter(View.DetailCompanyView);
            CompanyListPresenter = new CompanyListPresenter(View.CompanyListView, companyRepository);
            SettingBarPresenter = new SettingBarPresenter(view.SettingBarView);

            AutoUserComponent = new AutoUserComponent(
                companyRepository,
                priceRepository,
                pricesOutSource);

            View.CompanyListView.OnCompanySelected += ChangeViewOndetailPresenter;
            AutoUserComponent.OnUpdate += AutoUserComponent_OnUpdate;
        }

        private void AutoUserComponent_OnUpdate(object sender, EventArgs e)
        {
            (CompanyListPresenter as CompanyListPresenter).Update();
            ChangeViewOndetailPresenter(sender, e);
        }

        public void ChangeViewOndetailPresenter(object sender, EventArgs e)
        {
            int selectedIndex = View.CompanyListView.SelectedIndex;
            ICompany selectedCompany = View.CompanyListView.Companies[selectedIndex];
            View.DetailCompanyView.Company = selectedCompany;
        }
    }
}
