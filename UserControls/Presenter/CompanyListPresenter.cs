using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControls.Forms;
using UserControls.View;

namespace UserControls.Presenter
{
    public class CompanyListPresenter
    {
        ICompanyListView View;
        public event EventHandler OnSelectedCompany;
        public event EventHandler OnInit;

        public CompanyListPresenter(ICompanyListView view)
        {
            View = view;
            View.OnSelectedCompany += (s, args) => OnSelectedCompany?.Invoke(s, args);
            SqlAccess sqlAccess = new SqlAccess(@"Server = DESKTOP-LPG7P5E\COROPLUS; Database = Investing; Trusted_Connection = True;");
            Companies companies = new Companies(sqlAccess.Get<Company>());
            addCompanies(companies);
        }

        public void Add(Company company)
        {
            View.Add(company);
        }

        public void Remove(Company company)
        {
            View.Remove(company);
        }

        public Company GetSelectedCompany()
        {
            return View.GetSelectedCompany();
        }

        private void addCompanies(Companies companies)
        {
            foreach (Company company in companies)
            {
                Add(company);
            }
        }
    }
}
