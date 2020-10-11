namespace UserControls
{
    partial class CompanyList_UserControl
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GroupBox_Companies = new BasicControls.BasicGroupBox();
            this.Panel_CompaniesList = new System.Windows.Forms.Panel();
            this.panel_Buttons = new System.Windows.Forms.Panel();
            this.customButton_RemoveCompany = new BasicControls.BasicButton();
            this.customButton_AddCompany = new BasicControls.BasicButton();
            this.panel_CompanyList = new System.Windows.Forms.Panel();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.GroupBox_Companies.SuspendLayout();
            this.panel_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // GroupBox_Companies
            // 
            this.GroupBox_Companies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.GroupBox_Companies.Controls.Add(this.Panel_CompaniesList);
            this.GroupBox_Companies.Controls.Add(this.panel_Buttons);
            this.GroupBox_Companies.Controls.Add(this.panel_CompanyList);
            this.GroupBox_Companies.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupBox_Companies.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.GroupBox_Companies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.GroupBox_Companies.Location = new System.Drawing.Point(0, 0);
            this.GroupBox_Companies.Margin = new System.Windows.Forms.Padding(0);
            this.GroupBox_Companies.Name = "GroupBox_Companies";
            this.GroupBox_Companies.Size = new System.Drawing.Size(301, 581);
            this.GroupBox_Companies.TabIndex = 0;
            this.GroupBox_Companies.TabStop = false;
            this.GroupBox_Companies.Text = "Companies";
            // 
            // Panel_CompaniesList
            // 
            this.Panel_CompaniesList.AutoScroll = true;
            this.Panel_CompaniesList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Panel_CompaniesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_CompaniesList.Location = new System.Drawing.Point(3, 22);
            this.Panel_CompaniesList.Margin = new System.Windows.Forms.Padding(0);
            this.Panel_CompaniesList.Name = "Panel_CompaniesList";
            this.Panel_CompaniesList.Size = new System.Drawing.Size(295, 512);
            this.Panel_CompaniesList.TabIndex = 7;
            // 
            // panel_Buttons
            // 
            this.panel_Buttons.Controls.Add(this.customButton_RemoveCompany);
            this.panel_Buttons.Controls.Add(this.customButton_AddCompany);
            this.panel_Buttons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Buttons.Location = new System.Drawing.Point(3, 534);
            this.panel_Buttons.Name = "panel_Buttons";
            this.panel_Buttons.Size = new System.Drawing.Size(295, 44);
            this.panel_Buttons.TabIndex = 5;
            // 
            // customButton_RemoveCompany
            // 
            this.customButton_RemoveCompany.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.customButton_RemoveCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.customButton_RemoveCompany.Dock = System.Windows.Forms.DockStyle.Right;
            this.customButton_RemoveCompany.FlatAppearance.BorderSize = 0;
            this.customButton_RemoveCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton_RemoveCompany.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.customButton_RemoveCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.customButton_RemoveCompany.Image = global::UserControls.Properties.Resources.outline_remove_white_48dp;
            this.customButton_RemoveCompany.Location = new System.Drawing.Point(185, 0);
            this.customButton_RemoveCompany.Name = "customButton_RemoveCompany";
            this.customButton_RemoveCompany.Size = new System.Drawing.Size(55, 44);
            this.customButton_RemoveCompany.TabIndex = 3;
            this.customButton_RemoveCompany.Text = " ";
            this.customButton_RemoveCompany.UseVisualStyleBackColor = false;
            this.customButton_RemoveCompany.Click += new System.EventHandler(this.customButton_RemoveCompany_Click);
            // 
            // customButton_AddCompany
            // 
            this.customButton_AddCompany.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.customButton_AddCompany.Dock = System.Windows.Forms.DockStyle.Right;
            this.customButton_AddCompany.FlatAppearance.BorderSize = 0;
            this.customButton_AddCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton_AddCompany.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.customButton_AddCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.customButton_AddCompany.Image = global::UserControls.Properties.Resources.outline_add_white_48dp;
            this.customButton_AddCompany.Location = new System.Drawing.Point(240, 0);
            this.customButton_AddCompany.Name = "customButton_AddCompany";
            this.customButton_AddCompany.Size = new System.Drawing.Size(55, 44);
            this.customButton_AddCompany.TabIndex = 1;
            this.customButton_AddCompany.Text = " ";
            this.customButton_AddCompany.UseVisualStyleBackColor = false;
            this.customButton_AddCompany.Click += new System.EventHandler(this.customButton_AddCompany_Click);
            // 
            // panel_CompanyList
            // 
            this.panel_CompanyList.AutoScroll = true;
            this.panel_CompanyList.AutoSize = true;
            this.panel_CompanyList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel_CompanyList.Location = new System.Drawing.Point(3, 22);
            this.panel_CompanyList.Name = "panel_CompanyList";
            this.panel_CompanyList.Size = new System.Drawing.Size(0, 0);
            this.panel_CompanyList.TabIndex = 4;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // CompanyList_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBox_Companies);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CompanyList_UserControl";
            this.Size = new System.Drawing.Size(301, 581);
            this.GroupBox_Companies.ResumeLayout(false);
            this.GroupBox_Companies.PerformLayout();
            this.panel_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BasicControls.BasicGroupBox GroupBox_Companies;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel_CompanyList;
        private System.Windows.Forms.Panel Panel_CompaniesList;
        private System.Windows.Forms.Panel panel_Buttons;
        private BasicControls.BasicButton customButton_RemoveCompany;
        private BasicControls.BasicButton customButton_AddCompany;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}
