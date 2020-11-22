namespace UserControls.Controls
{
    partial class DataBase_Control
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
            this.basicButton_CleanDatabase = new UserControls.BasicControls.BasicButton();
            this.basicButton_CreateDatabase = new UserControls.BasicControls.BasicButton();
            this.basicButton_DeleteDatabase = new UserControls.BasicControls.BasicButton();
            this.SuspendLayout();
            // 
            // basicButton_CleanDatabase
            // 
            this.basicButton_CleanDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.basicButton_CleanDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicButton_CleanDatabase.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicButton_CleanDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicButton_CleanDatabase.Location = new System.Drawing.Point(10, 110);
            this.basicButton_CleanDatabase.Margin = new System.Windows.Forms.Padding(10);
            this.basicButton_CleanDatabase.Name = "basicButton_CleanDatabase";
            this.basicButton_CleanDatabase.Size = new System.Drawing.Size(130, 30);
            this.basicButton_CleanDatabase.TabIndex = 2;
            this.basicButton_CleanDatabase.Text = "Clear Data";
            this.basicButton_CleanDatabase.UseVisualStyleBackColor = false;
            this.basicButton_CleanDatabase.Click += new System.EventHandler(this.basicButton_CleanDatabase_Click);
            // 
            // basicButton_CreateDatabase
            // 
            this.basicButton_CreateDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.basicButton_CreateDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicButton_CreateDatabase.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicButton_CreateDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicButton_CreateDatabase.Location = new System.Drawing.Point(10, 10);
            this.basicButton_CreateDatabase.Margin = new System.Windows.Forms.Padding(10);
            this.basicButton_CreateDatabase.Name = "basicButton_CreateDatabase";
            this.basicButton_CreateDatabase.Size = new System.Drawing.Size(130, 30);
            this.basicButton_CreateDatabase.TabIndex = 3;
            this.basicButton_CreateDatabase.Text = "Create Database";
            this.basicButton_CreateDatabase.UseVisualStyleBackColor = false;
            this.basicButton_CreateDatabase.Click += new System.EventHandler(this.basicButton_CreateDatabase_Click);
            // 
            // basicButton_DeleteDatabase
            // 
            this.basicButton_DeleteDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.basicButton_DeleteDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicButton_DeleteDatabase.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicButton_DeleteDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicButton_DeleteDatabase.Location = new System.Drawing.Point(10, 60);
            this.basicButton_DeleteDatabase.Margin = new System.Windows.Forms.Padding(10);
            this.basicButton_DeleteDatabase.Name = "basicButton_DeleteDatabase";
            this.basicButton_DeleteDatabase.Size = new System.Drawing.Size(130, 30);
            this.basicButton_DeleteDatabase.TabIndex = 4;
            this.basicButton_DeleteDatabase.Text = "Delete Database";
            this.basicButton_DeleteDatabase.UseVisualStyleBackColor = false;
            this.basicButton_DeleteDatabase.Click += new System.EventHandler(this.basicButton_DeleteDatabase_Click);
            // 
            // DataBase_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.basicButton_DeleteDatabase);
            this.Controls.Add(this.basicButton_CreateDatabase);
            this.Controls.Add(this.basicButton_CleanDatabase);
            this.Name = "DataBase_Control";
            this.Size = new System.Drawing.Size(736, 305);
            this.ResumeLayout(false);

        }

        #endregion
        private BasicControls.BasicButton basicButton_CleanDatabase;
        private BasicControls.BasicButton basicButton_CreateDatabase;
        private BasicControls.BasicButton basicButton_DeleteDatabase;
    }
}
