namespace UserControls
{
    partial class AddCompanyControl
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
            this.customGroupBox1 = new BasicForms.CustomGroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.customButton1 = new BasicForms.CustomButton();
            this.customLabel1 = new BasicForms.CustomLabel();
            this.customGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // customGroupBox1
            // 
            this.customGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.customGroupBox1.Controls.Add(this.textBox1);
            this.customGroupBox1.Controls.Add(this.customButton1);
            this.customGroupBox1.Controls.Add(this.customLabel1);
            this.customGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customGroupBox1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.customGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.customGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.customGroupBox1.Name = "customGroupBox1";
            this.customGroupBox1.Size = new System.Drawing.Size(312, 177);
            this.customGroupBox1.TabIndex = 0;
            this.customGroupBox1.TabStop = false;
            this.customGroupBox1.Text = "customGroupBox1";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(121, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(159, 26);
            this.textBox1.TabIndex = 2;
            // 
            // customButton1
            // 
            this.customButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.customButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.customButton1.Location = new System.Drawing.Point(150, 141);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(130, 30);
            this.customButton1.TabIndex = 1;
            this.customButton1.Text = "customButton1";
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // customLabel1
            // 
            this.customLabel1.AutoSize = true;
            this.customLabel1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.customLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.customLabel1.Location = new System.Drawing.Point(6, 60);
            this.customLabel1.Name = "customLabel1";
            this.customLabel1.Size = new System.Drawing.Size(94, 19);
            this.customLabel1.TabIndex = 0;
            this.customLabel1.Text = "customLabel1";
            // 
            // AddCompanyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customGroupBox1);
            this.Name = "AddCompanyControl";
            this.Size = new System.Drawing.Size(312, 177);
            this.customGroupBox1.ResumeLayout(false);
            this.customGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private BasicForms.CustomGroupBox customGroupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private BasicForms.CustomButton customButton1;
        private BasicForms.CustomLabel customLabel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
