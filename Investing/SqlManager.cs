using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControls.Presenter;

namespace Investing
{
    public static class SqlManager
    {
        static SqlAccess sqlAccess { get; set; }

        static SqlManager()
        {
            sqlAccess = new SqlAccess(@"Server = DESKTOP-LPG7P5E\COROPLUS; Database = Investing; Trusted_Connection = True;");
        }

        public static void Init()
        {
            ;
        }

        public static void OnCompanyListPresenterInit_Event(object sender, EventArgs e)
        {
            CompanyListPresenter companyListPresenter = (CompanyListPresenter)sender;
            Companies companies = sqlAccess.Get<Company>();
            foreach (Company company in companies)
            {
                companyListPresenter.Add(company);
            }
        }

        public static void OnCompanyPresenterUpate_Event(object sender, EventArgs e)
        {
            CompanyPresenter companyPresenter = (CompanyPresenter)sender;
            companyPresenter.View.Company.Prices = sqlAccess.Get<Price>(companyPresenter.View.Company);
        }

    }
}
