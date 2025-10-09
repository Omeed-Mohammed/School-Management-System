namespace School_Management_System.Dashboard
{
    partial class frmDashboard
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.lblDateTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelChart = new System.Windows.Forms.TableLayoutPanel();
            this.chartStudents = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartAttendance = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ucStudents = new School_Management_System.Dashboard.controls.ucCard();
            this.ucTeachers = new School_Management_System.Dashboard.controls.ucCard();
            this.ucCard2 = new School_Management_System.Dashboard.controls.ucCard();
            this.ucCard3 = new School_Management_System.Dashboard.controls.ucCard();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAttendance)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblDateTime.Location = new System.Drawing.Point(25, 51);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(130, 25);
            this.lblDateTime.TabIndex = 22;
            this.lblDateTime.Text = "08.10.2025";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "Dashboard";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblDateTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 97);
            this.panel1.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 97);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1009, 703);
            this.panel2.TabIndex = 24;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelChart, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.8121F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.1879F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 239F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1009, 703);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanelChart
            // 
            this.tableLayoutPanelChart.ColumnCount = 2;
            this.tableLayoutPanelChart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.27946F));
            this.tableLayoutPanelChart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.72054F));
            this.tableLayoutPanelChart.Controls.Add(this.chartStudents, 1, 0);
            this.tableLayoutPanelChart.Controls.Add(this.chartAttendance, 0, 0);
            this.tableLayoutPanelChart.Location = new System.Drawing.Point(3, 236);
            this.tableLayoutPanelChart.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.tableLayoutPanelChart.Name = "tableLayoutPanelChart";
            this.tableLayoutPanelChart.RowCount = 1;
            this.tableLayoutPanelChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.22078F));
            this.tableLayoutPanelChart.Size = new System.Drawing.Size(957, 214);
            this.tableLayoutPanelChart.TabIndex = 6;
            // 
            // chartStudents
            // 
            chartArea1.Name = "ChartArea1";
            this.chartStudents.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartStudents.Legends.Add(legend1);
            this.chartStudents.Location = new System.Drawing.Point(492, 3);
            this.chartStudents.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.chartStudents.Name = "chartStudents";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartStudents.Series.Add(series1);
            this.chartStudents.Size = new System.Drawing.Size(361, 159);
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
            this.chartAttendance.Size = new System.Drawing.Size(411, 159);
            this.chartAttendance.TabIndex = 0;
            this.chartAttendance.Text = "chart1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(30, 466);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 192);
            this.groupBox1.TabIndex = 8;
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
            this.listView1.Size = new System.Drawing.Size(816, 173);
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ucStudents);
            this.flowLayoutPanel1.Controls.Add(this.ucTeachers);
            this.flowLayoutPanel1.Controls.Add(this.ucCard2);
            this.flowLayoutPanel1.Controls.Add(this.ucCard3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1003, 220);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // ucStudents
            // 
            this.ucStudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucStudents.Icon = ((System.Drawing.Image)(resources.GetObject("ucStudents.Icon")));
            this.ucStudents.Location = new System.Drawing.Point(30, 3);
            this.ucStudents.Margin = new System.Windows.Forms.Padding(30, 3, 3, 20);
            this.ucStudents.Name = "ucStudents";
            this.ucStudents.Size = new System.Drawing.Size(180, 150);
            this.ucStudents.TabIndex = 2;
            this.ucStudents.Title = "Students";
            this.ucStudents.Value = 0;
            // 
            // ucTeachers
            // 
            this.ucTeachers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucTeachers.Icon = ((System.Drawing.Image)(resources.GetObject("ucTeachers.Icon")));
            this.ucTeachers.Location = new System.Drawing.Point(243, 3);
            this.ucTeachers.Margin = new System.Windows.Forms.Padding(30, 3, 3, 20);
            this.ucTeachers.Name = "ucTeachers";
            this.ucTeachers.Size = new System.Drawing.Size(180, 150);
            this.ucTeachers.TabIndex = 3;
            this.ucTeachers.Title = "Students";
            this.ucTeachers.Value = 0;
            // 
            // ucCard2
            // 
            this.ucCard2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucCard2.Icon = ((System.Drawing.Image)(resources.GetObject("ucCard2.Icon")));
            this.ucCard2.Location = new System.Drawing.Point(456, 3);
            this.ucCard2.Margin = new System.Windows.Forms.Padding(30, 3, 3, 20);
            this.ucCard2.Name = "ucCard2";
            this.ucCard2.Size = new System.Drawing.Size(180, 150);
            this.ucCard2.TabIndex = 4;
            this.ucCard2.Title = "Students";
            this.ucCard2.Value = 0;
            // 
            // ucCard3
            // 
            this.ucCard3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ucCard3.Icon = ((System.Drawing.Image)(resources.GetObject("ucCard3.Icon")));
            this.ucCard3.Location = new System.Drawing.Point(669, 3);
            this.ucCard3.Margin = new System.Windows.Forms.Padding(30, 3, 3, 20);
            this.ucCard3.Name = "ucCard3";
            this.ucCard3.Size = new System.Drawing.Size(180, 150);
            this.ucCard3.TabIndex = 5;
            this.ucCard3.Title = "Students";
            this.ucCard3.Value = 0;
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 800);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDashboard";
            this.Text = "frmDashboard";
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanelChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartAttendance)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerDateTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStudents;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartAttendance;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private controls.ucCard ucStudents;
        private controls.ucCard ucTeachers;
        private controls.ucCard ucCard2;
        private controls.ucCard ucCard3;
    }
}