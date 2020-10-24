namespace UserControls.Forms
{
    partial class AddCompany_Form
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new UserControls.BasicControls.BasicLabel();
            this.textBox_CompanyID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Id";
            // 
            // textBox_CompanyID
            // 
            this.textBox_CompanyID.Location = new System.Drawing.Point(100, 9);
            this.textBox_CompanyID.Name = "textBox_CompanyID";
            this.textBox_CompanyID.Size = new System.Drawing.Size(139, 20);
            this.textBox_CompanyID.TabIndex = 1;
            // 
            // AddCompany_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 134);
            this.Controls.Add(this.textBox_CompanyID);
            this.Controls.Add(this.label1);
            this.Name = "AddCompany_Form";
            this.Text = "Add Company";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBox_CompanyID, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BasicControls.BasicLabel label1;
        private System.Windows.Forms.TextBox textBox_CompanyID;
    }
}