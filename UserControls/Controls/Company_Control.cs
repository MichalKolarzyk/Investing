using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.BasicControls;
using UserControls.View;
using BasicModels;

namespace UserControls
{
    public class Company_Control : BasicButton, ICompanyView
    {
        private ICompany company;
        public ICompany Company {
            get
            {
                company.ID = Text.Split(':')[0];
                return company;
            }
            set
            {
                Text = value.ID;
                if(value.Prices.Count > 0)
                {
                    IPrice lastPrice = value.Prices[value.Prices.Count - 1];
                    Text += $": {lastPrice.Value}";
                }
                company = value;
            }
        }

    }
}
