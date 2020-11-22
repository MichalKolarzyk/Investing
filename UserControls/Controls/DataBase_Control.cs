using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserControls.BasicControls;
using UserControls.View;

namespace UserControls.Controls
{
    public partial class DataBase_Control : BasicControl, IDataBaseView
    {
        public DataBase_Control()
        {
            InitializeComponent();
        }

        public EventHandler OnDataBaseCreate { get; set; }
        public EventHandler OnDataBaseDelete { get; set; }
        public EventHandler OnDataBaseClean { get; set; }

        private void basicButton_CreateDatabase_Click(object sender, EventArgs e)
        {
            OnDataBaseCreate?.Invoke(this, EventArgs.Empty);
        }

        private void basicButton_DeleteDatabase_Click(object sender, EventArgs e)
        {
            OnDataBaseDelete?.Invoke(this, EventArgs.Empty);
        }

        private void basicButton_CleanDatabase_Click(object sender, EventArgs e)
        {
            OnDataBaseClean?.Invoke(this, EventArgs.Empty);
        }
    }
}
