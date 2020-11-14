namespace UserControls.Controls
{
    partial class OkCancel_Control
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
            this.basicButton_Cancel = new UserControls.BasicControls.BasicButton();
            this.basicButton_Ok = new UserControls.BasicControls.BasicButton();
            this.SuspendLayout();
            // 
            // basicButton_Cancel
            // 
            this.basicButton_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.basicButton_Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.basicButton_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicButton_Cancel.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicButton_Cancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicButton_Cancel.Location = new System.Drawing.Point(10, 48);
            this.basicButton_Cancel.Margin = new System.Windows.Forms.Padding(10);
            this.basicButton_Cancel.Name = "basicButton_Cancel";
            this.basicButton_Cancel.Size = new System.Drawing.Size(130, 30);
            this.basicButton_Cancel.TabIndex = 0;
            this.basicButton_Cancel.Text = "Cancel";
            this.basicButton_Cancel.UseVisualStyleBackColor = false;
            this.basicButton_Cancel.Click += new System.EventHandler(this.basicButton_Cancel_Click);
            // 
            // basicButton_Ok
            // 
            this.basicButton_Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.basicButton_Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.basicButton_Ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicButton_Ok.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicButton_Ok.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicButton_Ok.Location = new System.Drawing.Point(509, 48);
            this.basicButton_Ok.Margin = new System.Windows.Forms.Padding(10);
            this.basicButton_Ok.Name = "basicButton_Ok";
            this.basicButton_Ok.Size = new System.Drawing.Size(130, 30);
            this.basicButton_Ok.TabIndex = 1;
            this.basicButton_Ok.Text = "Ok";
            this.basicButton_Ok.UseVisualStyleBackColor = false;
            this.basicButton_Ok.Click += new System.EventHandler(this.basicButton_Ok_Click);
            // 
            // OkCancel_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.basicButton_Ok);
            this.Controls.Add(this.basicButton_Cancel);
            this.Name = "OkCancel_Control";
            this.Size = new System.Drawing.Size(649, 88);
            this.ResumeLayout(false);

        }

        #endregion

        private BasicControls.BasicButton basicButton_Cancel;
        private BasicControls.BasicButton basicButton_Ok;
    }
}
