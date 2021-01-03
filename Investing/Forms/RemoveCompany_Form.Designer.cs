namespace Investing.Forms
{
    partial class RemoveCompany_Form
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
            this.textBox_CompanyID = new Investing.BasicControls.BasicComponents.BasicTextBox();
            this.basicLabel1 = new Investing.BasicControls.BasicLabel();
            this.SuspendLayout();
            // 
            // textBox_CompanyID
            // 
            this.textBox_CompanyID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox_CompanyID.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.textBox_CompanyID.Location = new System.Drawing.Point(100, 5);
            this.textBox_CompanyID.Margin = new System.Windows.Forms.Padding(10);
            this.textBox_CompanyID.Name = "textBox_CompanyID";
            this.textBox_CompanyID.Size = new System.Drawing.Size(180, 26);
            this.textBox_CompanyID.TabIndex = 5;
            // 
            // basicLabel1
            // 
            this.basicLabel1.AutoSize = true;
            this.basicLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.basicLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicLabel1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicLabel1.Location = new System.Drawing.Point(8, 8);
            this.basicLabel1.Margin = new System.Windows.Forms.Padding(10);
            this.basicLabel1.Name = "basicLabel1";
            this.basicLabel1.Size = new System.Drawing.Size(85, 19);
            this.basicLabel1.TabIndex = 6;
            this.basicLabel1.Text = "Company Id";
            // 
            // RemoveCompany_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 134);
            this.Controls.Add(this.basicLabel1);
            this.Controls.Add(this.textBox_CompanyID);
            this.Name = "RemoveCompany_Form";
            this.Text = "Remove Company";
            this.Controls.SetChildIndex(this.textBox_CompanyID, 0);
            this.Controls.SetChildIndex(this.basicLabel1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BasicControls.BasicComponents.BasicTextBox textBox_CompanyID;
        private BasicControls.BasicLabel basicLabel1;
    }
}