using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicForms;

namespace UserControls
{
    public partial class AddCompanyControl : UserControl
    {
        private List<CompanyIcon> companyIcons= new List<CompanyIcon>();

        public AddCompanyControl()
        {
            InitializeComponent();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {

        }

        private void ResizeUserControl(object sender, EventArgs e)
        {
            panel_CompanyList.Height = (int)(Height * 0.8f);
        }

    }
}
