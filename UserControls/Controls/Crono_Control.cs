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
using UserControls.BasicControls.BasicComponents;

namespace UserControls.Controls
{
    public partial class Crono_Control : BasicControl, ICronoExpressionView
    {
        public Crono_Control()
        {
            InitializeComponent();
            basicComboBox_StartDay.DataSource = DataLists.WeekDays;
            basicComboBox_EndDay.DataSource = DataLists.WeekDays;

            basicComboBox_StartHour.DataSource = DataLists.Hours;
            basicComboBox_EndHour.DataSource = DataLists.Hours;
            basicComboBox_UpdateInterval.DataSource = DataLists.UpdateInterval;
        }

        public string Seconds { get => "0"; set { } }
        public string Minutes { get => "*" ; set { } }
        public string Days { get => "?"; set { } }
        public string Hours
        {
            get
            {
                string value = 
                    $"{basicComboBox_StartHour.Text}" +
                    $"-" +
                    $"{basicComboBox_EndHour.Text}";
                return value;
            }
            set
            {
                basicComboBox_StartHour.Text = value.Split('-')[0];
                basicComboBox_EndHour.Text = value.Split('-')[1];
            }
        }
        public string Months { get => "*"; set { } }
        public string WeekDays
        {
            get
            {
                string value =
                    $"{basicComboBox_StartDay.Text}" +
                    $"-" +
                    $"{basicComboBox_EndDay.Text}";
                return value;
            }
            set
            {
                basicComboBox_StartDay.Text = value.Split('-')[0];
                basicComboBox_EndDay.Text = value.Split('-')[1];
            }
        }
    }
}
