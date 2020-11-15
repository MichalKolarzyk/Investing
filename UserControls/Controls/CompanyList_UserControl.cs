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

namespace UserControls
{
    public partial class CompanyList_UserControl : UserControl, ICompanyListView
    {
        public event EventHandler OnSelectedCompany;

        AddCompany_Form AddCompanyDialog { get; } = new AddCompany_Form();
        RemoveCompany_Form RemoveCompanyDialog { get; } = new RemoveCompany_Form();
        Company_Control selectecCompanyControl;

        public CompanyListPresenter Presenter { get; set; }

        public CompanyList_UserControl()
        {
            InitializeComponent();
        }
        public void Add(ICompany company)
        {
            Company_Control company_Control = new Company_Control();
            company_Control.Dock = DockStyle.Top;
            company_Control.Click += selectedCompanyUpdate_Click;

            CompanyPresenter companyPresenter = new CompanyPresenter(company_Control);
            companyPresenter.SetCompany(company);
            Panel_CompaniesList.Controls.Add(companyPresenter.View as Control);
        }

        public ICompany GetSelectedCompany()
        {
            return selectecCompanyControl.Company;
        }

        public void Remove(ICompany company)
        {
            foreach(Company_Control control in Panel_CompaniesList.Controls.OfType<Company_Control>())
            {
                if(control.Company == company)
                {
                    Panel_CompaniesList.Controls.Remove(control);
                }
            }
        }

        public void Clear()
        {
            Panel_CompaniesList.Controls.Clear();
        }

        private void customButton_AddCompany_Click(object sender, EventArgs e)
        {
            AddCompanyDialog.ShowDialog();
            if(AddCompanyDialog.DialogResult == DialogResult.OK)
            {
                try
                {
                    ICompany newCompany = AddCompanyDialog.GetCompany();
                    Presenter.Repository.SetCompany(newCompany);
                    Add(newCompany);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        private void customButton_RemoveCompany_Click(object sender, EventArgs e)
        {
            RemoveCompanyDialog.ShowDialog();
            if(RemoveCompanyDialog.DialogResult == DialogResult.OK)
            {
                ICompany comapnyToRemove = RemoveCompanyDialog.GetCompany();
                Presenter.Repository.RemoveCompany(comapnyToRemove);
                Remove(comapnyToRemove);
            }
        }

        private void selectedCompanyUpdate_Click(object sender, EventArgs e)
        {
            selectecCompanyControl = (Company_Control)sender;
            OnSelectedCompany?.Invoke(sender, e);
        }
    }
}
