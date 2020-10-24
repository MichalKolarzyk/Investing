﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls;
using UserControls.Presenter;
using UserControls.View;

namespace Investing
{
    public partial class MainForm : Form
    {
        CompanyPresenter detailPresenter;
        CompanyListPresenter companyListPresenter;
        public MainForm()
        {
            InitializeComponent();
            detailPresenter = new CompanyPresenter(detailInfoControl1);

            companyListPresenter = new CompanyListPresenter(addCompanyControl1);
            companyListPresenter.OnUpdate += SqlManager.OnCompanyListPresenterInit_Event;
            companyListPresenter.Update();
            
            companyListPresenter.OnSelectedCompany += changeViewOndetailPresenter_Event;

        }

        private void changeViewOndetailPresenter_Event(object sender, EventArgs e)
        {
            detailPresenter.SetCompany(companyListPresenter.GetSelectedCompany());
        }

        private void settingsControl1_Load(object sender, EventArgs e)
        {

        }
    }
}