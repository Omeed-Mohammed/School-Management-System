using School_Management_System.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Management_System.Register_Login
{
    public partial class frmLogin : Form
    {

        public string UserName = "omeed";
        public string Password = "12345";
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Focus();
        }

        

       

        private void lblRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmNewSchool frm = new frmNewSchool();
            frm.ShowDialog();
            this.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
           Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string password = txtPassword.Text;
            if (user == UserName)
            {
                if (password == Password)
                {
                    this.Hide();
                    frmMain frm = new frmMain();
                    frm.ShowDialog();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Password is Wrong");
                }
            }
            else 
            {
                MessageBox.Show("User Name is Wrong");
            }

        }

        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
                txtPassword.UseSystemPasswordChar = true;
            
            if(!checkBoxShowPass.Checked)
                txtPassword.UseSystemPasswordChar = false;
        }
    }
}
