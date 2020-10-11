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
using DataAccess;

namespace UserControls
{
    public partial class CompanyControl : UserControl
    {
        private List<CompanyIcon> companyIcons= new List<CompanyIcon>();
        private AddCompanyDialog addCompanyDialog = new AddCompanyDialog();

        public CompanyControl()
        {
            InitializeComponent();
            Panel_CompaniesList.Controls.Add(addCompanyDialog);
            addCompanyDialog.Hide();
        }

        private void ResizeUserControl(object sender, EventArgs e)
        {
            panel_CompanyList.Height = (int)(Height * 0.8f);
        }



        public void RemoveCompanyIcon()
        {
            if(Panel_CompaniesList.Controls.Count > 0)
            {
                Panel_CompaniesList.Controls.RemoveAt(Panel_CompaniesList.Controls.Count - 1);
            }
        }

        private void customButton_AddCompany(object sender, EventArgs e)
        {
            //AddCompanyIcon();
            //refreshCompanyIconsList();
            addCompanyDialog.Show();
        }

        public void AddCompanyIcon()
        {
            Panel_CompaniesList.Controls.Add(new CompanyIcon());
        }

        private void refreshCompanyIconsList()
        {
            addAllIcons();
        }

        private void addAllIcons()
        {
            foreach (CompanyIcon companyIcon in companyIcons)
            {
                Panel_CompaniesList.Controls.Add(companyIcon);
            }
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            //RemoveCompanyIcon();
            addCompanyDialog.Hide();
        }
    }
}
