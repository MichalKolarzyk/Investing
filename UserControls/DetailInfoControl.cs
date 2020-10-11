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
        public DetailInfoControl()
        {
            InitializeComponent();
        }

        public Company Company 
        {
            get
            {
                Company company =new Company();
                company.ID = basicLabel_CompanyID.Text;
                company.FullName = basicLabel_CompanyName.Text;
                return company;

            }
            set
            {
                basicLabel_CompanyID.Text = value.ID;
                basicLabel_CompanyName.Text = value.FullName;
            }

        }
    }
}
