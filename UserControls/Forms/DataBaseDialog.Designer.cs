namespace UserControls.Forms
{
    partial class DataBaseDialog
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
            this.okCancel_Control1 = new UserControls.Controls.OkCancel_Control();
            this.SuspendLayout();
            // 
            // okCancel_Control1
            // 
            this.okCancel_Control1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.okCancel_Control1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.okCancel_Control1.Location = new System.Drawing.Point(0, 362);
            this.okCancel_Control1.Name = "okCancel_Control1";
            this.okCancel_Control1.Size = new System.Drawing.Size(800, 88);
            this.okCancel_Control1.TabIndex = 0;
            // 
            // DataBaseDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.okCancel_Control1);
            this.Name = "DataBaseDialog";
            this.Text = "DataBaseDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.OkCancel_Control okCancel_Control1;
    }
}