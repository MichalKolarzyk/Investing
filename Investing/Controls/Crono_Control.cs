﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Investing.View;
using Investing.BasicControls;
using Investing.BasicControls.BasicComponents;

namespace Investing.Controls
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
        public string StartHour
        {
            get { return basicComboBox_StartHour.Text; }
            set{ basicComboBox_StartHour.Text = value; }
        }
        public string EndHour
        {
            get { return basicComboBox_EndHour.Text; }
            set { basicComboBox_EndHour.Text = value; }
        }
        public string Months { get => "*"; set { } }
        public string StartDay
        {
            get { return basicComboBox_StartDay.Text; }
            set { basicComboBox_StartDay.Text = value; }
        }
        public string EndDay
        {
            get { return basicComboBox_EndDay.Text; }
            set { basicComboBox_EndDay.Text = value; }
        }
        public string Preview { 
            get{ return basicLabel_Preview.Text; }
            set { basicLabel_Preview.Text = value; }
        }
    }
}
