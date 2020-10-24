using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControls.View;

namespace UserControls.Presenter
{
    public class CompanyPresenter
    {
        public ICompanyView View { get; set; }
        public CompanyPresenter(ICompanyView view)
        {
            View = view;
        }

        public ICompany GetCompany()
        {
            return View.Company;
        }

        public void SetCompany(Company company)
        {
            View.Company = company;
            Update();
        }

        public void Update()
        {
            SqlAccess sqlAccess = new SqlAccess(@"Server = DESKTOP-LPG7P5E\COROPLUS; Database = Investing; Trusted_Connection = True;");
            View.Company.Prices = sqlAccess.Get<Price>(View.Company);
        }
    }
}
