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

        public void AddCompanyIcon(CompanyIcon companyIcon)
        {
            if(companyIcons.Contains(companyIcon) == false)
            {
                companyIcons.Add(companyIcon);
            }
            refreshCompanyIconsList();
        }

        private void refreshCompanyIconsList()
        {
            addAllIcons();
        }

        public void AddCompanyIcon()
        {
            Panel_CompaniesList.Controls.Add(new CompanyIcon());
        }

        public void RemoveCompanyIcon()
        {
            if(Panel_CompaniesList.Controls.Count > 0)
            {
                Panel_CompaniesList.Controls.RemoveAt(Panel_CompaniesList.Controls.Count - 1);
            }
        }

        private void addAllIcons()
        {
            foreach(CompanyIcon companyIcon in companyIcons)
            {
                Panel_CompaniesList.Controls.Add(companyIcon);
            }
        }

        private void customButton1_Click_1(object sender, EventArgs e)
        {
            AddCompanyIcon();
            refreshCompanyIconsList();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            RemoveCompanyIcon();
        }
    }
}
