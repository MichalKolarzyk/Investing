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
    class CompanyListPresenter
    {
        ICompanyListView View;

        public CompanyListPresenter(ICompanyListView view)
        {
            View = view;
        }

        public void Add(Company company)
        {
            View.Add(company);
        }

        public void Remove(Company company)
        {
            View.Remove(company);
        }
    }
}
