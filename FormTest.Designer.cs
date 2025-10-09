namespace School_Management_System
{
    partial class FormTest
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelChart = new System.Windows.Forms.TableLayoutPanel();
            this.chartStudents = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAttendance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ucCard5 = new School_Management_System.Dashboard.controls.ucCard();
            this.ucCard6 = new School_Management_System.Dashboard.controls.ucCard();
            this.ucCard7 = new School_Management_System.Dashboard.controls.ucCard();
            this.ucCard8 = new School_Management_System.Dashboard.controls.ucCard();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAttendance)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelChart, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 143F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1032, 698);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanelChart
            // 
            this.tableLayoutPanelChart.ColumnCount = 2;
            this.tableLayoutPanelChart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.27946F));
            this.tableLayoutPanelChart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.72054F));
            this.tableLayoutPanelChart.Controls.Add(this.chartStudents, 1, 0);
            this.tableLayoutPanelChart.Controls.Add(this.chartAttendance, 0, 0);
            this.tableLayoutPanelChart.Location = new System.Drawing.Point(3, 363);
            this.tableLayoutPanelChart.Name = "tableLayoutPanelChart";
            this.tableLayoutPanelChart.RowCount = 2;
            this.tableLayoutPanelChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.22078F));
            this.tableLayoutPanelChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelChart.Size = new System.Drawing.Size(1026, 182);
            this.tableLayoutPanelChart.TabIndex = 6;
            // 
            // chartStudents
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStudents.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStudents.Legends.Add(legend1);
            this.chartStudents.Location = new System.Drawing.Point(525, 3);
            this.chartStudents.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.chartStudents.Name = "chartStudents";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartStudents.Series.Add(series1);
            this.chartStudents.Size = new System.Drawing.Size(361, 147);
            this.chartStudents.TabIndex = 1;
            this.chartStudents.Text = "chart2";
            // 
            // chartAttendance
            // 
            chartArea2.Name = "ChartArea1";
            this.chartAttendance.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartAttendance.Legends.Add(legend2);
            this.chartAttendance.Location = new System.Drawing.Point(30, 3);
            this.chartAttendance.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.chartAttendance.Name = "chartAttendance";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartAttendance.Series.Add(series2);
            this.chartAttendance.Size = new System.Drawing.Size(411, 147);
            this.chartAttendance.TabIndex = 0;
            this.chartAttendance.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(30, 557);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(978, 129);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recent Activities";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(972, 110);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date / Time";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "User";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Action";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.41406F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.58594F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 247F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 274F));
            this.tableLayoutPanel3.Controls.Add(this.ucCard5, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.ucCard6, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.ucCard7, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ucCard8, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.71314F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.28686F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1026, 226);
            this.tableLayoutPanel3.TabIndex = 10;
            // 
            // ucCard5
            // 
            this.ucCard5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucCard5.Location = new System.Drawing.Point(781, 3);
            this.ucCard5.Margin = new System.Windows.Forms.Padding(30, 3, 3, 20);
            this.ucCard5.Name = "ucCard5";
            this.ucCard5.Size = new System.Drawing.Size(180, 150);
            this.ucCard5.TabIndex = 4;
            // 
            // ucCard6
            // 
            this.ucCard6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucCard6.Location = new System.Drawing.Point(534, 3);
            this.ucCard6.Margin = new System.Windows.Forms.Padding(30, 3, 3, 20);
            this.ucCard6.Name = "ucCard6";
            this.ucCard6.Size = new System.Drawing.Size(180, 150);
            this.ucCard6.TabIndex = 3;
            // 
            // ucCard7
            // 
            this.ucCard7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucCard7.Location = new System.Drawing.Point(279, 3);
            this.ucCard7.Margin = new System.Windows.Forms.Padding(30, 3, 3, 20);
            this.ucCard7.Name = "ucCard7";
            this.ucCard7.Size = new System.Drawing.Size(180, 150);
            this.ucCard7.TabIndex = 2;
            // 
            // ucCard8
            // 
            this.ucCard8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucCard8.Location = new System.Drawing.Point(30, 3);
            this.ucCard8.Margin = new System.Windows.Forms.Padding(30, 3, 3, 20);
            this.ucCard8.Name = "ucCard8";
            this.ucCard8.Size = new System.Drawing.Size(180, 150);
            this.ucCard8.TabIndex = 1;
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 698);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormTest";
            this.Text = "FormTest";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanelChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAttendance)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStudents;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAttendance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Dashboard.controls.ucCard ucCard5;
        private Dashboard.controls.ucCard ucCard6;
        private Dashboard.controls.ucCard ucCard7;
        private Dashboard.controls.ucCard ucCard8;
    }
}