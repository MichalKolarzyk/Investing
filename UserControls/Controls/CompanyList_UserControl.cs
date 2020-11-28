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
                string serach = basicTextBox_Search.Text;

                Panel_CompaniesList.Controls.Clear();
                foreach (ICompany company in companies)
                {
                    if (company.ID.Contains(serach) == false)
                    {
                        continue;
                    }
                    Company_Control company_Control = new Company_Control();
                    company_Control.Dock = DockStyle.Top;
                    company_Control.Click += selectedCompanyUpdate_Click;

                    CompanyPresenter companyPresenter = new CompanyPresenter(company_Control);
                    companyPresenter.SetCompany(company);
                    Panel_CompaniesList.Controls.Add(companyPresenter.View as Control);
                }
            }
        }

        public int SelectedIndex { get; private set; }

        public CompanyList_UserControl()
        {
            InitializeComponent();
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
            SelectedIndex = Panel_CompaniesList.Controls.GetChildIndex(companyControl);
            OnCompanySelected?.Invoke(sender, e);
        }
        private void basicTextBox_Search_TextChanged(object sender, EventArgs e)
        {
            Companies = companies;
        }
    }
}
