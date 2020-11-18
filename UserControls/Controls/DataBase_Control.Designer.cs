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
            this.basicTextBox_ConnectionString = new UserControls.BasicControls.BasicComponents.BasicTextBox();
            this.basicLabel1 = new UserControls.BasicControls.BasicLabel();
            this.basicButton_CleanDatabase = new UserControls.BasicControls.BasicButton();
            this.basicButton_CreateDatabase = new UserControls.BasicControls.BasicButton();
            this.basicButton_DeleteDatabase = new UserControls.BasicControls.BasicButton();
            this.basicLabel2 = new UserControls.BasicControls.BasicLabel();
            this.basicTextBox_Password = new UserControls.BasicControls.BasicComponents.BasicTextBox();
            this.SuspendLayout();
            // 
            // basicTextBox_ConnectionString
            // 
            this.basicTextBox_ConnectionString.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicTextBox_ConnectionString.Location = new System.Drawing.Point(147, 10);
            this.basicTextBox_ConnectionString.Margin = new System.Windows.Forms.Padding(10);
            this.basicTextBox_ConnectionString.Name = "basicTextBox_ConnectionString";
            this.basicTextBox_ConnectionString.Size = new System.Drawing.Size(562, 26);
            this.basicTextBox_ConnectionString.TabIndex = 0;
            // 
            // basicLabel1
            // 
            this.basicLabel1.AutoSize = true;
            this.basicLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.basicLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicLabel1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicLabel1.Location = new System.Drawing.Point(10, 13);
            this.basicLabel1.Margin = new System.Windows.Forms.Padding(10);
            this.basicLabel1.Name = "basicLabel1";
            this.basicLabel1.Size = new System.Drawing.Size(117, 19);
            this.basicLabel1.TabIndex = 1;
            this.basicLabel1.Text = "Connection String";
            // 
            // basicButton_CleanDatabase
            // 
            this.basicButton_CleanDatabase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.basicButton_CleanDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicButton_CleanDatabase.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicButton_CleanDatabase.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicButton_CleanDatabase.Location = new System.Drawing.Point(10, 265);
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
            this.basicButton_CreateDatabase.Location = new System.Drawing.Point(10, 165);
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
            this.basicButton_DeleteDatabase.Location = new System.Drawing.Point(10, 215);
            this.basicButton_DeleteDatabase.Margin = new System.Windows.Forms.Padding(10);
            this.basicButton_DeleteDatabase.Name = "basicButton_DeleteDatabase";
            this.basicButton_DeleteDatabase.Size = new System.Drawing.Size(130, 30);
            this.basicButton_DeleteDatabase.TabIndex = 4;
            this.basicButton_DeleteDatabase.Text = "Delete Database";
            this.basicButton_DeleteDatabase.UseVisualStyleBackColor = false;
            this.basicButton_DeleteDatabase.Click += new System.EventHandler(this.basicButton_DeleteDatabase_Click);
            // 
            // basicLabel2
            // 
            this.basicLabel2.AutoSize = true;
            this.basicLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.basicLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicLabel2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicLabel2.Location = new System.Drawing.Point(10, 59);
            this.basicLabel2.Margin = new System.Windows.Forms.Padding(10);
            this.basicLabel2.Name = "basicLabel2";
            this.basicLabel2.Size = new System.Drawing.Size(69, 19);
            this.basicLabel2.TabIndex = 5;
            this.basicLabel2.Text = "Password";
            // 
            // basicTextBox_Password
            // 
            this.basicTextBox_Password.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicTextBox_Password.Location = new System.Drawing.Point(147, 56);
            this.basicTextBox_Password.Margin = new System.Windows.Forms.Padding(10);
            this.basicTextBox_Password.Name = "basicTextBox_Password";
            this.basicTextBox_Password.PasswordChar = '*';
            this.basicTextBox_Password.Size = new System.Drawing.Size(136, 26);
            this.basicTextBox_Password.TabIndex = 6;
            // 
            // DataBase_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.basicTextBox_Password);
            this.Controls.Add(this.basicLabel2);
            this.Controls.Add(this.basicButton_DeleteDatabase);
            this.Controls.Add(this.basicButton_CreateDatabase);
            this.Controls.Add(this.basicButton_CleanDatabase);
            this.Controls.Add(this.basicLabel1);
            this.Controls.Add(this.basicTextBox_ConnectionString);
            this.Name = "DataBase_Control";
            this.Size = new System.Drawing.Size(736, 305);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BasicControls.BasicComponents.BasicTextBox basicTextBox_ConnectionString;
        private BasicControls.BasicLabel basicLabel1;
        private BasicControls.BasicButton basicButton_CleanDatabase;
        private BasicControls.BasicButton basicButton_CreateDatabase;
        private BasicControls.BasicButton basicButton_DeleteDatabase;
        private BasicControls.BasicLabel basicLabel2;
        private BasicControls.BasicComponents.BasicTextBox basicTextBox_Password;
    }
}
