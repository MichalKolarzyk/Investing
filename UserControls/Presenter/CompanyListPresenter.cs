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

        public CompanyListPresenter(ICompanyListView view)
        {
            View = view;
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
    }
}
