using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicModels;
using Investing.View;

namespace Investing
{
    public partial class DetailInfo_Control : UserControl, ICompanyView
    {
        private ICompany company = new Company();
        public DetailInfo_Control()
        {
            InitializeComponent();
            Hide();
        }

        public ICompany Company 
        {
            get
            {
                //company.ID = basicLabel_CompanyID.Text;
                //company.FullName = basicLabel_CompanyName.Text;
                return company;

            }
            set
            {

                company = value;
                basicLabel_CompanyID.Text = value.ID;
                basicLabel_CompanyName.Text = value.FullName;

                if(value.Prices.Count > 0)
                {
                    int lastPriceIndex = value.Prices.Count - 1;
                    basicLabel_CurrentPrice.Text = value.Prices != null ? value.Prices[lastPriceIndex].Value.ToString() : "0";
                    basicChart_Prices.Series[0].Points.DataBindY(company.Prices.GetPricesValues());
                    basicChart_Prices.ChartAreas[0].AxisY.Minimum = Math.Floor(company.Prices.GetPricesValues().Min());
                }
                else
                {
                    basicLabel_CurrentPrice.Text = "?";
                    basicChart_Prices.Series[0].Points.DataBindY(new List<float>());
                }
                Show();
            }

        }
    }
}
