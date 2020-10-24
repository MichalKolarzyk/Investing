using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.View;
using DataAccess;

namespace UserControls
{
    public partial class DetailInfoControl : UserControl, ICompanyView
    {
        private Company company;
        public DetailInfoControl()
        {
            InitializeComponent();
            Hide();
        }

        public Company Company 
        {
            get
            {
                company.ID = basicLabel_CompanyID.Text;
                company.FullName = basicLabel_CompanyName.Text;
                return company;

            }
            set
            {
                company = value;
                basicLabel_CompanyID.Text = value.ID;
                basicLabel_CompanyName.Text = value.FullName;
                basicLabel_CurrentPrice.Text = value.Prices != null ? value.Prices[0].Value.ToString() : "0";
                basicChart_Prices.Series[0].Points.DataBindY(company.Prices.GetPricesValues());
                Show();
            }

        }
    }
}
