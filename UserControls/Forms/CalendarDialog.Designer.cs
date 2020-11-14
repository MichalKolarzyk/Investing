namespace UserControls.Forms
{
    partial class CalendarDialog
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
            this.crono_Control1 = new UserControls.Controls.Crono_Control();
            this.SuspendLayout();
            // 
            // crono_Control1
            // 
            this.crono_Control1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.crono_Control1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crono_Control1.Location = new System.Drawing.Point(0, 0);
            this.crono_Control1.Name = "crono_Control1";
            this.crono_Control1.Size = new System.Drawing.Size(800, 450);
            this.crono_Control1.TabIndex = 0;
            // 
            // CalendarDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.crono_Control1);
            this.Name = "CalendarDialog";
            this.Text = "CalendarDialog";
            this.ResumeLayout(false);

        }

        #endregion

        private Controls.Crono_Control crono_Control1;
    }
}