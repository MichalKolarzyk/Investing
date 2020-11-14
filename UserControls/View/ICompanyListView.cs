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
        void Add(ICompany company);
        void Remove(ICompany company);
        void Clear();
        ICompany GetSelectedCompany();
        Presenter.CompanyListPresenter Presenter { set; }

        event EventHandler OnSelectedCompany;


    }
}
