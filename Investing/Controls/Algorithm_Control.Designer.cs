namespace Investing.Controls
{
    partial class Algorithm_Control
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
            this.basicToggle1 = new Investing.BasicControls.BasicToggle();
            this.basicButton1 = new Investing.BasicControls.BasicButton();
            this.SuspendLayout();
            // 
            // basicToggle1
            // 
            this.basicToggle1.BackColor = System.Drawing.Color.Transparent;
            this.basicToggle1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.basicToggle1.Dock = System.Windows.Forms.DockStyle.Left;
            this.basicToggle1.Location = new System.Drawing.Point(0, 0);
            this.basicToggle1.MinimumSize = new System.Drawing.Size(100, 48);
            this.basicToggle1.Name = "basicToggle1";
            this.basicToggle1.Size = new System.Drawing.Size(164, 54);
            this.basicToggle1.State = false;
            this.basicToggle1.TabIndex = 0;
            this.basicToggle1.ToogleText = "basicLabel1";
            // 
            // basicButton1
            // 
            this.basicButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.basicButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.basicButton1.FlatAppearance.BorderSize = 0;
            this.basicButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicButton1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicButton1.Image = global::Investing.Properties.Resources.baseline_live_help_white_48dp;
            this.basicButton1.Location = new System.Drawing.Point(164, 0);
            this.basicButton1.Margin = new System.Windows.Forms.Padding(10);
            this.basicButton1.Name = "basicButton1";
            this.basicButton1.Size = new System.Drawing.Size(100, 54);
            this.basicButton1.TabIndex = 1;
            this.basicButton1.UseVisualStyleBackColor = false;
            // 
            // Algorithm_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.basicButton1);
            this.Controls.Add(this.basicToggle1);
            this.Name = "Algorithm_Control";
            this.Size = new System.Drawing.Size(264, 54);
            this.ResumeLayout(false);

        }

        #endregion

        private BasicControls.BasicToggle basicToggle1;
        private BasicControls.BasicButton basicButton1;
    }
}
