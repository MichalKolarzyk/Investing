namespace Investing
{
    partial class DetailInfo_Control
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.basicChart_Prices = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.basicLabel_CurrentPrice = new Investing.BasicControls.BasicLabel();
            this.basicLabel3 = new Investing.BasicControls.BasicLabel();
            this.basicLabel_CompanyID = new Investing.BasicControls.BasicLabel();
            this.basicLabel_CompanyName = new Investing.BasicControls.BasicLabel();
            this.basicLabel2 = new Investing.BasicControls.BasicLabel();
            this.basicLabel1 = new Investing.BasicControls.BasicLabel();
            ((System.ComponentModel.ISupportInitialize)(this.basicChart_Prices)).BeginInit();
            this.SuspendLayout();
            // 
            // basicChart_Prices
            // 
            this.basicChart_Prices.BackColor = System.Drawing.Color.Transparent;
            this.basicChart_Prices.BackSecondaryColor = System.Drawing.Color.White;
            this.basicChart_Prices.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.basicChart_Prices.BorderSkin.PageColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.basicChart_Prices.ChartAreas.Add(chartArea1);
            this.basicChart_Prices.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.basicChart_Prices.Location = new System.Drawing.Point(0, 225);
            this.basicChart_Prices.Name = "basicChart_Prices";
            series1.BackSecondaryColor = System.Drawing.Color.Black;
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.DodgerBlue;
            series1.EmptyPointStyle.LabelForeColor = System.Drawing.Color.White;
            series1.LabelBackColor = System.Drawing.Color.White;
            series1.LabelBorderColor = System.Drawing.Color.White;
            series1.MarkerBorderWidth = 4;
            series1.MarkerColor = System.Drawing.Color.Blue;
            series1.MarkerSize = 20;
            series1.Name = "Series1";
            series1.ShadowColor = System.Drawing.Color.Black;
            series1.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White;
            this.basicChart_Prices.Series.Add(series1);
            this.basicChart_Prices.Size = new System.Drawing.Size(707, 409);
            this.basicChart_Prices.TabIndex = 6;
            this.basicChart_Prices.Text = "chart1";
            // 
            // basicLabel_CurrentPrice
            // 
            this.basicLabel_CurrentPrice.AutoSize = true;
            this.basicLabel_CurrentPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.basicLabel_CurrentPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicLabel_CurrentPrice.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicLabel_CurrentPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicLabel_CurrentPrice.Location = new System.Drawing.Point(143, 96);
            this.basicLabel_CurrentPrice.Margin = new System.Windows.Forms.Padding(10);
            this.basicLabel_CurrentPrice.Name = "basicLabel_CurrentPrice";
            this.basicLabel_CurrentPrice.Size = new System.Drawing.Size(90, 19);
            this.basicLabel_CurrentPrice.TabIndex = 5;
            this.basicLabel_CurrentPrice.Text = "Current Price";
            // 
            // basicLabel3
            // 
            this.basicLabel3.AutoSize = true;
            this.basicLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.basicLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicLabel3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicLabel3.Location = new System.Drawing.Point(12, 96);
            this.basicLabel3.Margin = new System.Windows.Forms.Padding(10);
            this.basicLabel3.Name = "basicLabel3";
            this.basicLabel3.Size = new System.Drawing.Size(90, 19);
            this.basicLabel3.TabIndex = 4;
            this.basicLabel3.Text = "Current Price";
            // 
            // basicLabel_CompanyID
            // 
            this.basicLabel_CompanyID.AutoSize = true;
            this.basicLabel_CompanyID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.basicLabel_CompanyID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicLabel_CompanyID.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicLabel_CompanyID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicLabel_CompanyID.Location = new System.Drawing.Point(143, 57);
            this.basicLabel_CompanyID.Margin = new System.Windows.Forms.Padding(10);
            this.basicLabel_CompanyID.Name = "basicLabel_CompanyID";
            this.basicLabel_CompanyID.Size = new System.Drawing.Size(88, 19);
            this.basicLabel_CompanyID.TabIndex = 3;
            this.basicLabel_CompanyID.Text = "Company ID";
            // 
            // basicLabel_CompanyName
            // 
            this.basicLabel_CompanyName.AutoSize = true;
            this.basicLabel_CompanyName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.basicLabel_CompanyName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicLabel_CompanyName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicLabel_CompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicLabel_CompanyName.Location = new System.Drawing.Point(143, 18);
            this.basicLabel_CompanyName.Margin = new System.Windows.Forms.Padding(10);
            this.basicLabel_CompanyName.Name = "basicLabel_CompanyName";
            this.basicLabel_CompanyName.Size = new System.Drawing.Size(109, 19);
            this.basicLabel_CompanyName.TabIndex = 2;
            this.basicLabel_CompanyName.Text = "Company Name";
            // 
            // basicLabel2
            // 
            this.basicLabel2.AutoSize = true;
            this.basicLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.basicLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicLabel2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicLabel2.Location = new System.Drawing.Point(10, 18);
            this.basicLabel2.Margin = new System.Windows.Forms.Padding(10);
            this.basicLabel2.Name = "basicLabel2";
            this.basicLabel2.Size = new System.Drawing.Size(49, 19);
            this.basicLabel2.TabIndex = 1;
            this.basicLabel2.Text = "Name:";
            // 
            // basicLabel1
            // 
            this.basicLabel1.AutoSize = true;
            this.basicLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.basicLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.basicLabel1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.basicLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.basicLabel1.Location = new System.Drawing.Point(11, 57);
            this.basicLabel1.Margin = new System.Windows.Forms.Padding(10);
            this.basicLabel1.Name = "basicLabel1";
            this.basicLabel1.Size = new System.Drawing.Size(91, 19);
            this.basicLabel1.TabIndex = 0;
            this.basicLabel1.Text = "Company ID:";
            // 
            // DetailInfo_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.Controls.Add(this.basicChart_Prices);
            this.Controls.Add(this.basicLabel_CurrentPrice);
            this.Controls.Add(this.basicLabel3);
            this.Controls.Add(this.basicLabel_CompanyID);
            this.Controls.Add(this.basicLabel_CompanyName);
            this.Controls.Add(this.basicLabel2);
            this.Controls.Add(this.basicLabel1);
            this.Name = "DetailInfo_Control";
            this.Size = new System.Drawing.Size(707, 634);
            ((System.ComponentModel.ISupportInitialize)(this.basicChart_Prices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BasicControls.BasicLabel basicLabel1;
        private BasicControls.BasicLabel basicLabel2;
        private BasicControls.BasicLabel basicLabel_CompanyName;
        private BasicControls.BasicLabel basicLabel_CompanyID;
        private BasicControls.BasicLabel basicLabel3;
        private BasicControls.BasicLabel basicLabel_CurrentPrice;
        private System.Windows.Forms.DataVisualization.Charting.Chart basicChart_Prices;
    }
}
