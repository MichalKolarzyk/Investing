namespace Investing
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.detailInfoControl1 = new UserControls.DetailInfo_Control();
            this.addCompanyControl1 = new UserControls.CompanyList_UserControl();
            this.settingsControl1 = new UserControls.SettingsBarControl();
            this.closeMinimize_Control1 = new UserControls.Controls.CloseMinimize_Control();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.addCompanyControl1);
            this.panel1.Controls.Add(this.settingsControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 652);
            this.panel1.TabIndex = 0;
            // 
            // detailInfoControl1
            // 
            this.detailInfoControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.detailInfoControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.detailInfoControl1.Location = new System.Drawing.Point(322, 0);
            this.detailInfoControl1.Name = "detailInfoControl1";
            this.detailInfoControl1.Size = new System.Drawing.Size(612, 652);
            this.detailInfoControl1.TabIndex = 1;
            this.detailInfoControl1.Visible = false;
            // 
            // addCompanyControl1
            // 
            this.addCompanyControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addCompanyControl1.Location = new System.Drawing.Point(0, 53);
            this.addCompanyControl1.Margin = new System.Windows.Forms.Padding(0);
            this.addCompanyControl1.Name = "addCompanyControl1";
            this.addCompanyControl1.Size = new System.Drawing.Size(322, 599);
            this.addCompanyControl1.TabIndex = 1;
            // 
            // settingsControl1
            // 
            this.settingsControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.settingsControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsControl1.Location = new System.Drawing.Point(0, 0);
            this.settingsControl1.Name = "settingsControl1";
            this.settingsControl1.Size = new System.Drawing.Size(322, 53);
            this.settingsControl1.TabIndex = 0;
            // 
            // closeMinimize_Control1
            // 
            this.closeMinimize_Control1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeMinimize_Control1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.closeMinimize_Control1.Location = new System.Drawing.Point(805, 0);
            this.closeMinimize_Control1.Name = "closeMinimize_Control1";
            this.closeMinimize_Control1.Size = new System.Drawing.Size(129, 53);
            this.closeMinimize_Control1.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(934, 652);
            this.Controls.Add(this.closeMinimize_Control1);
            this.Controls.Add(this.detailInfoControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private UserControls.DetailInfo_Control detailInfoControl1;
        private UserControls.CompanyList_UserControl addCompanyControl1;
        private UserControls.SettingsBarControl settingsControl1;
        private UserControls.Controls.CloseMinimize_Control closeMinimize_Control1;
    }
}