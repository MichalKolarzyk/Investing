using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserControls.View;
using UserControls.Repository;


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
            dataBaseManager = new SqlDataBaseManager(view.ConnectionString);
            dataBaseManager.Clear();
        }

        private void deleteDatabase(object sender, EventArgs eventArgs)
        {

        }

    }
}
