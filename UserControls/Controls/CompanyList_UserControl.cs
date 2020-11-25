using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using UserControls.View;
using UserControls.Presenter;
using UserControls.Forms;
using BasicModels;
using Miscellaneous;

namespace UserControls
{
    public partial class CompanyList_UserControl : UserControl, ICompanyListView
    {
        public EventHandler OnCompanyAdd { get; set; }
        public EventHandler OnCompanySelected { get; set; }
        public EventHandler OnCompanyRemove { get; set; }
        private Companies companies { get; set; } = new Companies();
        public Companies Companies
        {
            get
            {
                return companies;
            }
            set
            {
                companies = value;
                Panel_CompaniesList.Controls.Clear();
                foreach (ICompany company in companies)
                {
                    Company_Control company_Control = new Company_Control();
                    company_Control.Dock = DockStyle.Top;
                    company_Control.Click += selectedCompanyUpdate_Click;

                    CompanyPresenter companyPresenter = new CompanyPresenter(company_Control);
                    companyPresenter.SetCompany(company);
                    Panel_CompaniesList.Controls.Add(companyPresenter.View as Control);
                }
            }
        }

        public ICompany SelectedCompany { get; set; }

        public CompanyList_UserControl()
        {
            InitializeComponent();
        }

        public void Clear()
        {
            Panel_CompaniesList.Controls.Clear();
        }

        private void customButton_AddCompany_Click(object sender, EventArgs e)
        {
            OnCompanyAdd?.Invoke(this, EventArgs.Empty);
        }

        private void customButton_RemoveCompany_Click(object sender, EventArgs e)
        {
            OnCompanyRemove?.Invoke(this, EventArgs.Empty);
        }

        private void selectedCompanyUpdate_Click(object sender, EventArgs e)
        {
            Company_Control companyControl = (Company_Control)sender;
            SelectedCompany = companyControl.Company;
            OnCompanySelected?.Invoke(sender, e);
        }
    }
}
