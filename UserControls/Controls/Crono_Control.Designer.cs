namespace UserControls.Controls
{
    partial class Crono_Control
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.basicComboBox_StartDay = new UserControls.BasicControls.BasicComboBox();
            this.basicLabel1 = new UserControls.BasicControls.BasicLabel();
            this.basicLabel2 = new UserControls.BasicControls.BasicLabel();
            this.basicComboBox_EndDay = new UserControls.BasicControls.BasicComboBox();
            this.basicLabel4 = new UserControls.BasicControls.BasicLabel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // basicComboBox_StartDay
            // 
            this.basicComboBox_StartDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.basicComboBox_StartDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.basicComboBox_StartDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicComboBox_StartDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicComboBox_StartDay.FormattingEnabled = true;
            this.basicComboBox_StartDay.Location = new System.Drawing.Point(109, 101);
            this.basicComboBox_StartDay.Name = "basicComboBox_StartDay";
            this.basicComboBox_StartDay.Size = new System.Drawing.Size(121, 21);
            this.basicComboBox_StartDay.TabIndex = 0;
            // 
            // basicLabel1
            // 
            this.basicLabel1.AutoSize = true;
            this.basicLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.basicLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicLabel1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicLabel1.Location = new System.Drawing.Point(3, 103);
            this.basicLabel1.Name = "basicLabel1";
            this.basicLabel1.Size = new System.Drawing.Size(67, 19);
            this.basicLabel1.TabIndex = 1;
            this.basicLabel1.Text = "Start Day";
            // 
            // basicLabel2
            // 
            this.basicLabel2.AutoSize = true;
            this.basicLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.basicLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicLabel2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicLabel2.Location = new System.Drawing.Point(8, 135);
            this.basicLabel2.Name = "basicLabel2";
            this.basicLabel2.Size = new System.Drawing.Size(62, 19);
            this.basicLabel2.TabIndex = 2;
            this.basicLabel2.Text = "End Day";
            // 
            // basicComboBox_EndDay
            // 
            this.basicComboBox_EndDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.basicComboBox_EndDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.basicComboBox_EndDay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicComboBox_EndDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicComboBox_EndDay.FormattingEnabled = true;
            this.basicComboBox_EndDay.Location = new System.Drawing.Point(109, 136);
            this.basicComboBox_EndDay.Name = "basicComboBox_EndDay";
            this.basicComboBox_EndDay.Size = new System.Drawing.Size(121, 21);
            this.basicComboBox_EndDay.TabIndex = 3;
            // 
            // basicLabel4
            // 
            this.basicLabel4.AutoSize = true;
            this.basicLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.basicLabel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicLabel4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicLabel4.Location = new System.Drawing.Point(8, 9);
            this.basicLabel4.Name = "basicLabel4";
            this.basicLabel4.Size = new System.Drawing.Size(95, 19);
            this.basicLabel4.TabIndex = 5;
            this.basicLabel4.Text = "Update Prices";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(109, 9);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 6;
            // 
            // Crono_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.basicLabel4);
            this.Controls.Add(this.basicComboBox_EndDay);
            this.Controls.Add(this.basicLabel2);
            this.Controls.Add(this.basicLabel1);
            this.Controls.Add(this.basicComboBox_StartDay);
            this.Name = "Crono_Control";
            this.Size = new System.Drawing.Size(707, 394);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BasicControls.BasicComboBox basicComboBox_StartDay;
        private BasicControls.BasicLabel basicLabel1;
        private BasicControls.BasicLabel basicLabel2;
        private BasicControls.BasicComboBox basicComboBox_EndDay;
        private BasicControls.BasicLabel basicLabel4;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}
