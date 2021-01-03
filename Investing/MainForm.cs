using System;
using System.Windows.Forms;
using UserControls;
using BasicModels;
using Miscellaneous;
using Repositories.Interfaces;
using Repositories.Sql;
using Repositories.SqLite;
using Repositories.Yahoo;
using System.IO;
using Settings;
using Investing.View;
using Investing.Presenter;

namespace Investing
{
    public partial class MainForm : Form, IMainView
    {
        public ICompanyView DetailCompanyView => detailInfoControl1;
        public ICompanyListView CompanyListView => addCompanyControl1;
        public ISettingsBarView SettingBarView => settingsControl1;
        public MainPresenter Presenter { get; set; }

        
        public MainForm()
        {
            InitializeComponent();

            //    AutoUserComponent = new AutoUserComponent(CompanyRepository, PriceRepository, PricesOutSource);
            //    AutoUserComponent.OnUpdate += (obj, args) => Invoke(new Action(delegate ()
            //    {
            //        CompanyListPresenter.Update();
            //        ChangeViewOndetailPresenter_Event(obj, args);
            //    }));
        }
    }
}
