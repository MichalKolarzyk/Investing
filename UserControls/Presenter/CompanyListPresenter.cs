using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControls.Forms;
using UserControls.Model;
using UserControls.View;

namespace UserControls.Presenter
{
    public class CompanyListPresenter
    {
        ICompanyListView View { get; }
        public ICompanyRepository Repository { get; private set; }
        public event EventHandler OnSelectedCompany;

        public CompanyListPresenter(ICompanyListView view)
        {
            Repository = new CompanySqlRepository(@"Server = DESKTOP-LPG7P5E\COROPLUS; Database = Investing; Trusted_Connection = True;");
            View = view;
            View.Presenter = this;

            View.OnSelectedCompany += (s, args) => OnSelectedCompany?.Invoke(s, args);
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

        public void Update()
        {
            Companies companies = Repository.GetCompanies();
            View.Clear();
            foreach (Company company in companies)
            {
                Add(company);
            }
        }
    }
}
