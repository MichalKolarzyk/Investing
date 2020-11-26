﻿using Repositories.Interfaces;
using Repositories.Sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControls.View;


namespace UserControls.Presenter
{
    public class DataBasePresenter
    {
        private IDataBaseView view;
        private IDataBaseManager dataBaseManager;

        public DataBasePresenter(IDataBaseView view)
        {
            this.view = view;
            view.OnDataBaseCreate += createDatabase;
            view.OnDataBaseClean += cleanDatabase;
            
        }

        private void createDatabase(object sender, EventArgs eventArgs)
        {

        }

        private void cleanDatabase(object sender, EventArgs eventArgs)
        {
            string connectionString = Properties.Settings.Default.ConnectionString;
            dataBaseManager = new SqlDataBaseManager(connectionString);
            dataBaseManager.Clear();
        }

        private void deleteDatabase(object sender, EventArgs eventArgs)
        {

        }

    }
}