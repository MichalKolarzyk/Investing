using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControls.BasicControls
{
    public partial class BasicToggle : UserControl
    {
        private bool state;
        public EventHandler OnStateChange;
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public bool State
        {
            get { return state; }
            set
            {
                state = value;
                SetImage();
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public string ToogleText {
            get { return basicLabel1.Text; }
            set { basicLabel1.Text = value; } 
        }

        Image imageOff;
        Image imageOn;

        public BasicToggle()
        {
            InitializeComponent();
            BackColor = Color.Transparent;
            imageOff = Properties.Resources.baseline_toggle_off_white_48dp;
            imageOn = Properties.Resources.baseline_toggle_on_white_48dp;
            MinimumSize = new Size(100, 48);
            SetImage();
        }

        private void Panel1_Click(object sender, EventArgs e)
        {
            State = !State;
            SetImage();
            OnStateChange?.Invoke(sender, e);
        }
        private void SetImage()
        {
            if (State == true)
            {
                panel1.BackgroundImage = imageOn;
            }
            else
            {
                panel1.BackgroundImage = imageOff;
            }
        }
    }
}
