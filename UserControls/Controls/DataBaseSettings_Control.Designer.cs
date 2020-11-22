namespace UserControls.Controls
{
    partial class DataBaseSettings_Control
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
            this.basicLabel1 = new UserControls.BasicControls.BasicLabel();
            this.basicLabel2 = new UserControls.BasicControls.BasicLabel();
            this.basicTextBox_ConnestionStrin = new UserControls.BasicControls.BasicComponents.BasicTextBox();
            this.basicTextBox_Password = new UserControls.BasicControls.BasicComponents.BasicTextBox();
            this.basicGroupBox1 = new UserControls.BasicControls.BasicGroupBox();
            this.basicGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // basicLabel1
            // 
            this.basicLabel1.AutoSize = true;
            this.basicLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.basicLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicLabel1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicLabel1.Location = new System.Drawing.Point(13, 68);
            this.basicLabel1.Margin = new System.Windows.Forms.Padding(10);
            this.basicLabel1.Name = "basicLabel1";
            this.basicLabel1.Size = new System.Drawing.Size(69, 19);
            this.basicLabel1.TabIndex = 0;
            this.basicLabel1.Text = "Password";
            // 
            // basicLabel2
            // 
            this.basicLabel2.AutoSize = true;
            this.basicLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.basicLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicLabel2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicLabel2.Location = new System.Drawing.Point(10, 29);
            this.basicLabel2.Margin = new System.Windows.Forms.Padding(10);
            this.basicLabel2.Name = "basicLabel2";
            this.basicLabel2.Size = new System.Drawing.Size(117, 19);
            this.basicLabel2.TabIndex = 1;
            this.basicLabel2.Text = "Connection String";
            // 
            // basicTextBox_ConnestionStrin
            // 
            this.basicTextBox_ConnestionStrin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.basicTextBox_ConnestionStrin.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicTextBox_ConnestionStrin.Location = new System.Drawing.Point(132, 26);
            this.basicTextBox_ConnestionStrin.Margin = new System.Windows.Forms.Padding(10);
            this.basicTextBox_ConnestionStrin.Name = "basicTextBox_ConnestionStrin";
            this.basicTextBox_ConnestionStrin.Size = new System.Drawing.Size(384, 26);
            this.basicTextBox_ConnestionStrin.TabIndex = 2;
            // 
            // basicTextBox_Password
            // 
            this.basicTextBox_Password.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicTextBox_Password.Location = new System.Drawing.Point(132, 65);
            this.basicTextBox_Password.Margin = new System.Windows.Forms.Padding(10);
            this.basicTextBox_Password.Name = "basicTextBox_Password";
            this.basicTextBox_Password.PasswordChar = '*';
            this.basicTextBox_Password.Size = new System.Drawing.Size(128, 26);
            this.basicTextBox_Password.TabIndex = 3;
            // 
            // basicGroupBox1
            // 
            this.basicGroupBox1.Controls.Add(this.basicTextBox_ConnestionStrin);
            this.basicGroupBox1.Controls.Add(this.basicLabel2);
            this.basicGroupBox1.Controls.Add(this.basicTextBox_Password);
            this.basicGroupBox1.Controls.Add(this.basicLabel1);
            this.basicGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basicGroupBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.basicGroupBox1.Name = "basicGroupBox1";
            this.basicGroupBox1.Size = new System.Drawing.Size(541, 180);
            this.basicGroupBox1.TabIndex = 4;
            this.basicGroupBox1.TabStop = false;
            this.basicGroupBox1.Text = "Data Base";
            // 
            // DataBaseSettings_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.basicGroupBox1);
            this.Name = "DataBaseSettings_Control";
            this.Size = new System.Drawing.Size(541, 180);
            this.basicGroupBox1.ResumeLayout(false);
            this.basicGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BasicControls.BasicLabel basicLabel1;
        private BasicControls.BasicLabel basicLabel2;
        private BasicControls.BasicComponents.BasicTextBox basicTextBox_ConnestionStrin;
        private BasicControls.BasicComponents.BasicTextBox basicTextBox_Password;
        private BasicControls.BasicGroupBox basicGroupBox1;
    }
}
