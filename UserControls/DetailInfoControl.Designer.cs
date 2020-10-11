namespace UserControls
{
    partial class DetailInfoControl
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
            this.basicLabel_CompanyName = new UserControls.BasicControls.BasicLabel();
            this.basicLabel_CompanyID = new UserControls.BasicControls.BasicLabel();
            this.SuspendLayout();
            // 
            // basicLabel1
            // 
            this.basicLabel1.AutoSize = true;
            this.basicLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.basicLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicLabel1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicLabel1.Location = new System.Drawing.Point(3, 38);
            this.basicLabel1.Name = "basicLabel1";
            this.basicLabel1.Size = new System.Drawing.Size(91, 19);
            this.basicLabel1.TabIndex = 0;
            this.basicLabel1.Text = "Company ID:";
            // 
            // basicLabel2
            // 
            this.basicLabel2.AutoSize = true;
            this.basicLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.basicLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicLabel2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicLabel2.Location = new System.Drawing.Point(3, 19);
            this.basicLabel2.Name = "basicLabel2";
            this.basicLabel2.Size = new System.Drawing.Size(49, 19);
            this.basicLabel2.TabIndex = 1;
            this.basicLabel2.Text = "Name:";
            // 
            // basicLabel_CompanyName
            // 
            this.basicLabel_CompanyName.AutoSize = true;
            this.basicLabel_CompanyName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.basicLabel_CompanyName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicLabel_CompanyName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicLabel_CompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicLabel_CompanyName.Location = new System.Drawing.Point(154, 18);
            this.basicLabel_CompanyName.Name = "basicLabel_CompanyName";
            this.basicLabel_CompanyName.Size = new System.Drawing.Size(109, 19);
            this.basicLabel_CompanyName.TabIndex = 2;
            this.basicLabel_CompanyName.Text = "Company Name";
            // 
            // basicLabel_CompanyID
            // 
            this.basicLabel_CompanyID.AutoSize = true;
            this.basicLabel_CompanyID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.basicLabel_CompanyID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicLabel_CompanyID.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicLabel_CompanyID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicLabel_CompanyID.Location = new System.Drawing.Point(154, 38);
            this.basicLabel_CompanyID.Name = "basicLabel_CompanyID";
            this.basicLabel_CompanyID.Size = new System.Drawing.Size(88, 19);
            this.basicLabel_CompanyID.TabIndex = 3;
            this.basicLabel_CompanyID.Text = "Company ID";
            // 
            // DetailInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.basicLabel_CompanyID);
            this.Controls.Add(this.basicLabel_CompanyName);
            this.Controls.Add(this.basicLabel2);
            this.Controls.Add(this.basicLabel1);
            this.Name = "DetailInfoControl";
            this.Size = new System.Drawing.Size(707, 634);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BasicControls.BasicLabel basicLabel1;
        private BasicControls.BasicLabel basicLabel2;
        private BasicControls.BasicLabel basicLabel_CompanyName;
        private BasicControls.BasicLabel basicLabel_CompanyID;
    }
}
