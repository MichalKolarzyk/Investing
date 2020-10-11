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
using System.Runtime.CompilerServices;

namespace UserControls
{
    public partial class AddCompanyDialog : UserControl, IDynamicDialog<ICompany>
    {
        public AddCompanyDialog()
        {
            InitializeComponent();
        }

        public ICompany GetObject()
        {
            return new Company(TextBox_CompanyId.Text);
        }
    }
}
