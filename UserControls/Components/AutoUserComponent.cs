using AutoUser;
using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicModels;
using Repositories.Interfaces;
using Repositories.Sql;
using Repositories.Yahoo;

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
            CompanyRepository = new CompanySqlRepository(Properties.Settings.Default.ConnectionString);
            PricesOutSource = new PriceYahooRepository();
            PriceRepository = new PricesSqlRepository(Properties.Settings.Default.ConnectionString);
            AutoJob.AddAction(() => UpdatePriceRepository());
            AutoUserManager.ScheduleJob(AutoJob, Trigger);
            AutoUserManager.Start();
        }
        public AutoUserComponent(ICompanyRepository cr, IPriceRepository pr, IPricesOutSource po)
        {
            CompanyRepository = cr;
            PricesOutSource = po;
            PriceRepository = pr;
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