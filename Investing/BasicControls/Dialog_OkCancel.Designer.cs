namespace Investing.BasicControls
{
    partial class Dialog_OkCancel
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
            this.basicButton_Ok = new Investing.BasicControls.BasicButton();
            this.basicButton_Cancel = new Investing.BasicControls.BasicButton();
            this.SuspendLayout();
            // 
            // basicButton_Ok
            // 
            this.basicButton_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.basicButton_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.basicButton_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicButton_Ok.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicButton_Ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicButton_Ok.Location = new System.Drawing.Point(204, 92);
            this.basicButton_Ok.Name = "basicButton_Ok";
            this.basicButton_Ok.Size = new System.Drawing.Size(83, 30);
            this.basicButton_Ok.TabIndex = 0;
            this.basicButton_Ok.Text = "Ok";
            this.basicButton_Ok.UseVisualStyleBackColor = false;
            this.basicButton_Ok.Click += new System.EventHandler(this.basicButton_Ok_Click);
            // 
            // basicButton_Cancel
            // 
            this.basicButton_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.basicButton_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.basicButton_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicButton_Cancel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicButton_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicButton_Cancel.Location = new System.Drawing.Point(12, 92);
            this.basicButton_Cancel.Name = "basicButton_Cancel";
            this.basicButton_Cancel.Size = new System.Drawing.Size(89, 30);
            this.basicButton_Cancel.TabIndex = 1;
            this.basicButton_Cancel.Text = "Cancel";
            this.basicButton_Cancel.UseVisualStyleBackColor = false;
            this.basicButton_Cancel.Click += new System.EventHandler(this.basicButton_Cancel_Click);
            // 
            // Dialog_OkCancel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 134);
            this.Controls.Add(this.basicButton_Cancel);
            this.Controls.Add(this.basicButton_Ok);
            this.Name = "Dialog_OkCancel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dialog_OkCancel";
            this.ResumeLayout(false);

        }

        #endregion

        private BasicButton basicButton_Ok;
        private BasicButton basicButton_Cancel;
    }
}