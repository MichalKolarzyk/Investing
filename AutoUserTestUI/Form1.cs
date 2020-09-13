using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoUser;

namespace AutoUserTestUI
{
    public partial class Form1 : Form
    {
        public string LabelText { get; set; }
        public Form1()
        {
            InitializeComponent();
            Scheduler scheduler = new Scheduler();
            Action action = () => Invoke( new Action(update));
            scheduler.Add(new ApplicationJob("* * 13-22 ? * SUN-SAT", action));
            Task task = scheduler.Start();
            Task.WaitAll(task);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void update() 
        {
            label1.Text = DateTime.Now.ToString();
        }
    }
}
