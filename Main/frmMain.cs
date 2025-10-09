using School_Management_System.Dashboard;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Main
{
    
    public partial class frmMain : Form
    {
        private frmDashboard _dashboard;
        public frmMain()
        {
            InitializeComponent();
        }

        private void ShowForm(Form frm)
        {
            panelMain.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(frm);
            frm.Show();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if(_dashboard == null || _dashboard.IsDisposed)
                _dashboard = new frmDashboard();


            ShowForm(_dashboard);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            btnDashboard_Click(sender, e);
        }
    }
}
