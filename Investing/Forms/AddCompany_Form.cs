using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BasicModels;
using Investing.BasicControls;
using Repositories.Interfaces;
using Repositories.Yahoo;

namespace Investing.Forms
{
    public partial class AddCompany_Form : Dialog_OkCancel
    {
        ICompanyOutSource CompanyOutSource { get; set; }
        public AddCompany_Form()
        {
            InitializeComponent();
            CompanyOutSource = new CompanyYahooRepository();
        }

        public ICompany GetCompany()
        {
            return Task.Run(() => CompanyOutSource.GetCompany(textBox_CompanyID.Text)).Result;
        }
    }
}
