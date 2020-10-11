using BasicForms;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.View;

namespace UserControls
{
    public class Company_Control : CustomButton, ICompanyView
    {
        public Company Company {
            get
            {
                Company company = new Company();
                company.ID = Text;
                return company;
            }
            set
            {
                Text = value.ID;
            }
        }
    }
}
