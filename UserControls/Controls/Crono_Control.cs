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
using UserControls.BasicControls.BasicComponents;

namespace UserControls.Controls
{
    public partial class Crono_Control : BasicControl
    {
        public Crono_Control()
        {
            InitializeComponent();
            basicComboBox_StartDay.DataSource = DataLists.WeekDays;
            basicComboBox_EndDay.DataSource = DataLists.WeekDays;
        }
    }
}
