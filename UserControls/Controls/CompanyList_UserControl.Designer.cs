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
            this.GroupBox_Companies = new UserControls.BasicControls.BasicGroupBox();
            this.Panel_CompaniesList = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.basicTextBox_Search = new UserControls.BasicControls.BasicComponents.BasicTextBox();
            this.iconButton1 = new UserControls.BasicControls.IconButton();
            this.panel_Buttons = new System.Windows.Forms.Panel();
            this.customButton_RemoveCompany = new UserControls.BasicControls.BasicButton();
            this.customButton_AddCompany = new UserControls.BasicControls.BasicButton();
            this.panel_CompanyList = new System.Windows.Forms.Panel();
            this.GroupBox_Companies.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox_Companies
            // 
            this.GroupBox_Companies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.GroupBox_Companies.Controls.Add(this.Panel_CompaniesList);
            this.GroupBox_Companies.Controls.Add(this.panel1);
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
            this.Panel_CompaniesList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_CompaniesList.Location = new System.Drawing.Point(3, 49);
            this.Panel_CompaniesList.Name = "Panel_CompaniesList";
            this.Panel_CompaniesList.Size = new System.Drawing.Size(295, 485);
            this.Panel_CompaniesList.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.basicTextBox_Search);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 22);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(295, 27);
            this.panel1.TabIndex = 7;
            // 
            // basicTextBox_Search
            // 
            this.basicTextBox_Search.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basicTextBox_Search.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicTextBox_Search.Location = new System.Drawing.Point(30, 0);
            this.basicTextBox_Search.Margin = new System.Windows.Forms.Padding(10);
            this.basicTextBox_Search.Name = "basicTextBox_Search";
            this.basicTextBox_Search.Size = new System.Drawing.Size(265, 26);
            this.basicTextBox_Search.TabIndex = 3;
            this.basicTextBox_Search.TextChanged += new System.EventHandler(this.basicTextBox_Search_TextChanged);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.iconButton1.Image = global::UserControls.Properties.Resources.baseline_search_white_24dp1;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(10);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(30, 27);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.UseVisualStyleBackColor = false;
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
            this.customButton_RemoveCompany.Margin = new System.Windows.Forms.Padding(10);
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
            this.customButton_AddCompany.Margin = new System.Windows.Forms.Padding(10);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BasicControls.BasicGroupBox GroupBox_Companies;
        private System.Windows.Forms.Panel panel_CompanyList;
        private System.Windows.Forms.Panel panel_Buttons;
        private BasicControls.BasicButton customButton_RemoveCompany;
        private BasicControls.BasicButton customButton_AddCompany;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Panel_CompaniesList;
        private BasicControls.BasicComponents.BasicTextBox basicTextBox_Search;
        private BasicControls.IconButton iconButton1;
    }
}
