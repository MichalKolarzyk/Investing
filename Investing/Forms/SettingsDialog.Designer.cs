namespace Investing.Forms
{
    partial class SettingsDialog
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
            this.okCancel_Control1 = new Investing.Controls.OkCancel_Control();
            this.dataBaseSettings_Control1 = new Investing.Controls.DataBaseSettings_Control();
            this.SuspendLayout();
            // 
            // okCancel_Control1
            // 
            this.okCancel_Control1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.okCancel_Control1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okCancel_Control1.Location = new System.Drawing.Point(0, 369);
            this.okCancel_Control1.Name = "okCancel_Control1";
            this.okCancel_Control1.Size = new System.Drawing.Size(800, 81);
            this.okCancel_Control1.TabIndex = 0;
            // 
            // dataBaseSettings_Control1
            // 
            this.dataBaseSettings_Control1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dataBaseSettings_Control1.ConnectionString = "";
            this.dataBaseSettings_Control1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataBaseSettings_Control1.Location = new System.Drawing.Point(0, 0);
            this.dataBaseSettings_Control1.Name = "dataBaseSettings_Control1";
            this.dataBaseSettings_Control1.Password = "";
            this.dataBaseSettings_Control1.Size = new System.Drawing.Size(800, 114);
            this.dataBaseSettings_Control1.TabIndex = 1;
            // 
            // SettingsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataBaseSettings_Control1);
            this.Controls.Add(this.okCancel_Control1);
            this.Name = "SettingsDialog";
            this.Text = "SettingsDialog";
            this.Controls.SetChildIndex(this.okCancel_Control1, 0);
            this.Controls.SetChildIndex(this.dataBaseSettings_Control1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.OkCancel_Control okCancel_Control1;
        private Controls.DataBaseSettings_Control dataBaseSettings_Control1;
    }
}