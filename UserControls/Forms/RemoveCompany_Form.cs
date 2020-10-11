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
using UserControls.View;

namespace UserControls.Forms
{
    public partial class RemoveCompany_Form : Form
    {
        public RemoveCompany_Form()
        {
            InitializeComponent();
        }

        public Company GetCompany()
        {
            Company company = new Company();
            company.ID = textBox_CompanyID.Text;
            return company;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
