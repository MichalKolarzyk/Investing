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

namespace UserControls
{
    public partial class CompanyList_UserControl : UserControl, ICompanyListView
    {
        public event EventHandler OnSelectedCompany;

        AddCompany_Form addCompanyDialog = new AddCompany_Form();
        RemoveCompany_Form removeCompanyDialog = new RemoveCompany_Form();
        Company_Control selectecCompanyControl;

        public CompanyList_UserControl()
        {
            InitializeComponent();
        }
        public void Add(Company company)
        {
            Company_Control company_Control = new Company_Control();
            company_Control.Dock = DockStyle.Top;
            company_Control.Click += selectedCompanyUpdate_Click;

            CompanyPresenter companyPresenter = new CompanyPresenter(company_Control);
            companyPresenter.SetCompany(company);
            Panel_CompaniesList.Controls.Add(companyPresenter.View as Control);
        }

        public Company GetSelectedCompany()
        {
            return selectecCompanyControl.Company;
        }

        public void Remove(Company company)
        {
            foreach(Company_Control control in Panel_CompaniesList.Controls.OfType<Company_Control>())
            {
                if(control.Company == company)
                {
                    Panel_CompaniesList.Controls.Remove(control);
                }
            }
        }

        private void customButton_AddCompany_Click(object sender, EventArgs e)
        {
            addCompanyDialog.ShowDialog();
            if(addCompanyDialog.DialogResult == DialogResult.OK)
            {
                Add(addCompanyDialog.GetCompany());
            }
        }

        private void customButton_RemoveCompany_Click(object sender, EventArgs e)
        {
            removeCompanyDialog.ShowDialog();
            if(removeCompanyDialog.DialogResult == DialogResult.OK)
            {
                Remove(removeCompanyDialog.GetCompany());
            }
        }

        private void selectedCompanyUpdate_Click(object sender, EventArgs e)
        {
            selectecCompanyControl = (Company_Control)sender;
            OnSelectedCompany?.Invoke(sender, e);
        }
    }
}
