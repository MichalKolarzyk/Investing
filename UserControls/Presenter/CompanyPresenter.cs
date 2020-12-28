using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControls.View;
using BasicModels;

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

        public void SetCompany(ICompany company)
        {
            View.Company = company;
        }
    }
}
