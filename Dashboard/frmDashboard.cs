using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace School_Management_System.Dashboard
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            lblDateTime.Text = DateTime.Now.ToString();
        }

        

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {
            timerDateTime.Interval = 1000; // تحديث كل ثانية
            timerDateTime.Tick += Timer1_Tick;
            timerDateTime.Start();


            chartAttendance1();
            chartStudents1();
            LoadData();


        }

 
        private void chartAttendance1()
        {
            chartAttendance.Series.Clear();
            chartAttendance.Series.Add("Attendance");
            chartAttendance.Series["Attendance"].ChartType = SeriesChartType.Column;
            chartAttendance.Series["Attendance"].Points.AddXY("Jan", 95);
            chartAttendance.Series["Attendance"].Points.AddXY("Feb", 88);
            chartAttendance.Series["Attendance"].Points.AddXY("Mar", 92);
            LayoutChartAttendance();
        }

        private void chartStudents1()
        {
            chartStudents.Series.Clear();
            chartStudents.Series.Add("New Students");
            chartStudents.Series["New Students"].ChartType = SeriesChartType.Line;
            chartStudents.Series["New Students"].Points.AddXY("Jan", 10);
            chartStudents.Series["New Students"].Points.AddXY("Feb", 15);
            chartStudents.Series["New Students"].Points.AddXY("Mar", 20);
            LayoutChartStudents();
        }

        private void LayoutChartAttendance()
        {
            // تحسين مظهر الرسم البياني Attendance
            chartAttendance.ChartAreas[0].BackColor = Color.Transparent;
            chartAttendance.BackColor = Color.Transparent;
            chartAttendance.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
            chartAttendance.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.LightGray;
            chartAttendance.ChartAreas[0].AxisX.LabelStyle.ForeColor = Color.DimGray;
            chartAttendance.ChartAreas[0].AxisY.LabelStyle.ForeColor = Color.DimGray;

            // جعل الأعمدة بلون عصري
            chartAttendance.Series["Attendance"].Color = Color.FromArgb(52, 152, 219); // أزرق جميل
            chartAttendance.Series["Attendance"].BorderWidth = 3;

            // إضافة عنوان للرسم البياني
            chartAttendance.Titles.Clear();
            chartAttendance.Titles.Add("Attendance Rate");
            chartAttendance.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
            chartAttendance.Titles[0].ForeColor = Color.FromArgb(44, 62, 80);

            // إظهار القيم (النسبة المئوية) فوق الأعمدة
            chartAttendance.Series["Attendance"].IsValueShownAsLabel = true;
            chartAttendance.Series["Attendance"].LabelForeColor = Color.FromArgb(44, 62, 80);
            chartAttendance.Series["Attendance"].Font = new Font("Segoe UI", 9, FontStyle.Bold);
        }

        private void LayoutChartStudents()
        {
            chartStudents.ChartAreas[0].BackColor = Color.Transparent;
            chartStudents.BackColor = Color.Transparent;
            chartStudents.Series["New Students"].Color = Color.FromArgb(46, 204, 113);
            chartStudents.Series["New Students"].BorderWidth = 3;
            chartStudents.Titles.Add("New Students Growth");
            chartStudents.Titles[0].Font = new Font("Segoe UI", 12, FontStyle.Bold);
            chartStudents.Titles[0].ForeColor = Color.FromArgb(44, 62, 80);
        }


        private void LoadData()
        {
            ucStudents.Title = "Students";
            ucStudents.Value = GetStudentsCount();
            ucStudents.Icon = Properties.Resources.student128;

            ucTeachers.Title = "Teachers";
            ucTeachers.Value = GetTeachersCount();
            ucTeachers.Icon = Properties.Resources.training;

            ucCard2.Title = "Employees";
            ucCard2.Value = GetEmployeesCount();
            ucCard2.Icon = Properties.Resources.employee;
        }

        private int GetStudentsCount() => 123;
        private int GetTeachersCount() => 18;
        private int GetEmployeesCount() => 12;

    }
}
