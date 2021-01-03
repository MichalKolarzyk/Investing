using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicModels;
using Investing.View;

namespace Investing.Presenter
{
    public class CompanyPresenter : IPresenter<ICompanyView>
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
