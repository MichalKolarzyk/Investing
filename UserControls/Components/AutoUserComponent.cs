using AutoUser;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControls.Repository;

namespace UserControls
{
    public class AutoUserComponent : Component
    {
        public ICompanyRepository CompanyRepository { get; set; }
        public IPricesOutSource PricesOutSource { get; set; } 
        public IPriceRepository PriceRepository { get; set; }
        public event EventHandler OnUpdate;

        public Trigger Trigger = new Trigger();
        public AutoJob AutoJob = new AutoJob();
        public AutoUserManager AutoUserManager = new AutoUserManager();

        public AutoUserComponent()
        {
            CompanyRepository = new CompanySqlRepository(@"Server = DESKTOP-LPG7P5E\COROPLUS; Database = Investing; Trusted_Connection = True;");
            PricesOutSource = new PriceYahooRepository();
            PriceRepository = new PricesSqlRepository(@"Server = DESKTOP-LPG7P5E\COROPLUS; Database = Investing; Trusted_Connection = True;");
            AutoJob.AddAction(() => UpdatePriceRepository());
            AutoUserManager.ScheduleJob(AutoJob, Trigger);
            AutoUserManager.Start();
        }

        public void UpdatePriceRepository()
        {
            Companies companies = CompanyRepository.GetCompanies();
            Prices prices = PricesOutSource.GetPrices(companies);
            PriceRepository.InserPrices(prices);
            OnUpdate.Invoke(this, EventArgs.Empty);
        }
    }
}