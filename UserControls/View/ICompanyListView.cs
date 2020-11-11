using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserControls.View
{
    public interface ICompanyListView
    {
        void Add(Company company);
        void Remove(Company company);
        void Clear();
        Company GetSelectedCompany();
        Presenter.CompanyListPresenter Presenter { set; }

        event EventHandler OnSelectedCompany;


    }
}
