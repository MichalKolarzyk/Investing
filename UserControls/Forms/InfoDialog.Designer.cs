namespace UserControls.Forms
{
    partial class InfoDialog
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
            this.basicLabel1 = new UserControls.BasicControls.BasicLabel();
            this.basicLabel2 = new UserControls.BasicControls.BasicLabel();
            this.ok_Control1 = new UserControls.Controls.Ok_Control();
            this.SuspendLayout();
            // 
            // basicLabel1
            // 
            this.basicLabel1.AutoSize = true;
            this.basicLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.basicLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicLabel1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicLabel1.Location = new System.Drawing.Point(12, 9);
            this.basicLabel1.Name = "basicLabel1";
            this.basicLabel1.Size = new System.Drawing.Size(106, 19);
            this.basicLabel1.TabIndex = 0;
            this.basicLabel1.Text = "About Program:";
            // 
            // basicLabel2
            // 
            this.basicLabel2.AutoSize = true;
            this.basicLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.basicLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicLabel2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicLabel2.Location = new System.Drawing.Point(12, 50);
            this.basicLabel2.Name = "basicLabel2";
            this.basicLabel2.Size = new System.Drawing.Size(21, 19);
            this.basicLabel2.TabIndex = 1;
            this.basicLabel2.Text = "...";
            // 
            // ok_Control1
            // 
            this.ok_Control1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.ok_Control1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ok_Control1.Location = new System.Drawing.Point(0, 299);
            this.ok_Control1.Name = "ok_Control1";
            this.ok_Control1.Size = new System.Drawing.Size(800, 151);
            this.ok_Control1.TabIndex = 2;
            // 
            // InfoDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ok_Control1);
            this.Controls.Add(this.basicLabel2);
            this.Controls.Add(this.basicLabel1);
            this.Name = "InfoDialog";
            this.Text = "InfoDialog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BasicControls.BasicLabel basicLabel1;
        private BasicControls.BasicLabel basicLabel2;
        private Controls.Ok_Control ok_Control1;
    }
}