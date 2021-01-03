using Repositories.Interfaces;
using Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControls.View;

namespace UserControls.Presenter
{
    public class MainPresenter
    {
        public CompanyPresenter DetailPresenter { get; set; }
        public CompanyListPresenter CompanyListPresenter { get; set; }
        public AutoUserComponent AutoUserComponent { get; set; }
        public ICompanyRepository CompanyRepository { get; set; }
        public IPriceRepository PriceRepository { get; set; }
        public IPricesOutSource PricesOutSource { get; set; }
        public IMainView View { get; set; }
        public void ChangeViewOndetailPresenter()
        {
            
        }
    }
}
