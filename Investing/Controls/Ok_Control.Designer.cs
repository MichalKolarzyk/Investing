namespace Investing.Controls
{
    partial class Ok_Control
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
            this.basicButton1 = new Investing.BasicControls.BasicButton();
            this.SuspendLayout();
            // 
            // basicButton1
            // 
            this.basicButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.basicButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.basicButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicButton1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicButton1.Location = new System.Drawing.Point(346, 111);
            this.basicButton1.Margin = new System.Windows.Forms.Padding(10);
            this.basicButton1.Name = "basicButton1";
            this.basicButton1.Size = new System.Drawing.Size(130, 30);
            this.basicButton1.TabIndex = 0;
            this.basicButton1.Text = "Ok";
            this.basicButton1.UseVisualStyleBackColor = false;
            this.basicButton1.Click += new System.EventHandler(this.basicButton1_Click);
            // 
            // Ok_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.basicButton1);
            this.Name = "Ok_Control";
            this.Size = new System.Drawing.Size(486, 151);
            this.ResumeLayout(false);

        }

        #endregion

        private BasicControls.BasicButton basicButton1;
    }
}
