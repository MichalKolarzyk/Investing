﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.BasicControls;
using UserControls.View;
using BasicModels;

namespace UserControls.Forms
{
    public partial class RemoveCompany_Form : Dialog_OkCancel
    {
        public RemoveCompany_Form()
        {
            InitializeComponent();
        }

        public Company GetCompany()
        {
            Company company = new Company
            {
                ID = textBox_CompanyID.Text
            };
            return company;
        }
    }
}
