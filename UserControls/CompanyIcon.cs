using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using DataAccess;

namespace UserControls
{
    public partial class CompanyIcon : UserControl
    {
        private Company company { get; set; }
        public CompanyIcon()
        {
            InitializeComponent();
            Dock = DockStyle.Top;
            company = new Company();
        }

        public void SetCompany(Company company)
        {
            this.company = company;
        }

        public Company GetCompany()
        {
            return company;
        }
        
    }
}
