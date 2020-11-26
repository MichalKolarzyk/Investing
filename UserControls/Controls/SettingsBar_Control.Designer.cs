namespace UserControls
{
    partial class SettingsBarControl
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
            this.button_Calendar = new System.Windows.Forms.Button();
            this.button_Informations = new System.Windows.Forms.Button();
            this.button_Settings = new System.Windows.Forms.Button();
            this.button_DataBase = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Calendar
            // 
            this.button_Calendar.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Calendar.FlatAppearance.BorderSize = 0;
            this.button_Calendar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Calendar.Image = global::UserControls.Properties.Resources.outline_calendar_today_white_48dp;
            this.button_Calendar.Location = new System.Drawing.Point(192, 0);
            this.button_Calendar.Name = "button_Calendar";
            this.button_Calendar.Size = new System.Drawing.Size(62, 55);
            this.button_Calendar.TabIndex = 4;
            this.button_Calendar.UseVisualStyleBackColor = true;
            this.button_Calendar.Click += new System.EventHandler(this.button_Calendar_Click);
            // 
            // button_Informations
            // 
            this.button_Informations.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Informations.FlatAppearance.BorderSize = 0;
            this.button_Informations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Informations.Image = global::UserControls.Properties.Resources.outline_info_white_48dp;
            this.button_Informations.Location = new System.Drawing.Point(254, 0);
            this.button_Informations.Name = "button_Informations";
            this.button_Informations.Size = new System.Drawing.Size(62, 55);
            this.button_Informations.TabIndex = 3;
            this.button_Informations.UseVisualStyleBackColor = true;
            this.button_Informations.Click += new System.EventHandler(this.button_Informations_Click);
            // 
            // button_Settings
            // 
            this.button_Settings.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_Settings.FlatAppearance.BorderSize = 0;
            this.button_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Settings.Image = global::UserControls.Properties.Resources.outline_settings_white_48dp;
            this.button_Settings.Location = new System.Drawing.Point(316, 0);
            this.button_Settings.Name = "button_Settings";
            this.button_Settings.Size = new System.Drawing.Size(62, 55);
            this.button_Settings.TabIndex = 2;
            this.button_Settings.UseVisualStyleBackColor = true;
            this.button_Settings.Click += new System.EventHandler(this.button_Settings_Click);
            // 
            // button_DataBase
            // 
            this.button_DataBase.Dock = System.Windows.Forms.DockStyle.Right;
            this.button_DataBase.FlatAppearance.BorderSize = 0;
            this.button_DataBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DataBase.Image = global::UserControls.Properties.Resources.outline_storage_white_48dp;
            this.button_DataBase.Location = new System.Drawing.Point(130, 0);
            this.button_DataBase.Name = "button_DataBase";
            this.button_DataBase.Size = new System.Drawing.Size(62, 55);
            this.button_DataBase.TabIndex = 6;
            this.button_DataBase.UseVisualStyleBackColor = true;
            this.button_DataBase.Click += new System.EventHandler(this.button_DataBase_Click);
            // 
            // SettingsBarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.button_DataBase);
            this.Controls.Add(this.button_Calendar);
            this.Controls.Add(this.button_Informations);
            this.Controls.Add(this.button_Settings);
            this.Name = "SettingsBarControl";
            this.Size = new System.Drawing.Size(378, 55);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_Settings;
        private System.Windows.Forms.Button button_Informations;
        private System.Windows.Forms.Button button_Calendar;
        private System.Windows.Forms.Button button_DataBase;
    }
}
