using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.BasicControls;
using UserControls.View;

namespace UserControls.Forms
{
    public partial class AddCompany_Form : Dialog_OkCancel
    {
        public AddCompany_Form()
        {
            InitializeComponent();
        }

        public Company GetCompany()
        {
            Company company = new Company();
            company.ID = textBox_CompanyID.Text;
            return company;
        }

        private void basicButton_Ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void basicButton_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
