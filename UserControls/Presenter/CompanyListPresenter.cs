using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControls.Forms;
using UserControls.View;
using BasicModels;
using System.Windows.Forms;
using Miscellaneous;
using Repositories.Interfaces;

namespace UserControls.Presenter
{
    public class CompanyListPresenter
    {
        ICompanyListView View { get; }
        public ICompanyRepository Repository { get; private set; }
        public EventHandler OnSelectedCompany { get; set; }
        AddCompany_Form AddCompanyDialog { get; } = new AddCompany_Form();
        RemoveCompany_Form RemoveCompanyDialog { get; } = new RemoveCompany_Form();

        public CompanyListPresenter(ICompanyListView view, ICompanyRepository companyRepository)
        {
            Repository = companyRepository;
            View = view;

            View.OnCompanySelected += (args, e) => OnSelectedCompany?.Invoke(args, e);
            View.OnCompanyRemove += onCompanyRemove;
            View.OnCompanyAdd += onCompanyAdd;
        }

        private void onCompanyRemove(object sender, EventArgs eventArgs)
        {
            RemoveCompanyDialog.ShowDialog();
            if (RemoveCompanyDialog.DialogResult == DialogResult.OK)
            {
                ICompany comapnyToRemove = RemoveCompanyDialog.GetCompany();
                Repository.RemoveCompany(comapnyToRemove);
                View.Companies = Repository.GetCompanies();
            }
        }

        private void onCompanyAdd(object sender, EventArgs eventArgs)
        {
            AddCompanyDialog.ShowDialog();
            if (AddCompanyDialog.DialogResult == DialogResult.OK)
            {
                try
                {
                    ICompany newCompany = AddCompanyDialog.GetCompany();
                    Repository.SetCompany(newCompany);
                    View.Companies = Repository.GetCompanies();
                }
                catch (Exception exception)
                {
                    ExceptionMessageHandler.ShowError(exception);
                }
            }
        }

        public ICompany GetSelectedCompany()
        {
            return View.SelectedCompany;
        }
        public void Update()
        {
            View.Companies = Repository.GetCompanies();
        }
    }
}
