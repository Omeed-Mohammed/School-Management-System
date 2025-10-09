namespace School_Management_System.Register_Login
{
    partial class frmNewSchool
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new School_Management_System.ToolsControls.RJButton();
            this.btnBackToLogin = new School_Management_System.ToolsControls.RJButton();
            this.btnCreateAccount = new School_Management_System.ToolsControls.RJButton();
            this.txtConfirmPassword = new School_Management_System.ToolsControls.CustomTextBox();
            this.txtPassword = new School_Management_System.ToolsControls.CustomTextBox();
            this.txtCity = new School_Management_System.ToolsControls.CustomTextBox();
            this.customComboBox1 = new School_Management_System.ToolsControls.CustomComboBox();
            this.txtPhoneNumber = new School_Management_System.ToolsControls.CustomTextBox();
            this.txtLastname = new School_Management_System.ToolsControls.CustomTextBox();
            this.txtFirstname = new School_Management_System.ToolsControls.CustomTextBox();
            this.txtEmail = new School_Management_System.ToolsControls.CustomTextBox();
            this.txtSchoolName = new School_Management_System.ToolsControls.CustomTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(424, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "School Type :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(307, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Create New School Account";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(317, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "You will be the admin of this school";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.SteelBlue;
            this.btnExit.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnExit.BorderRadius = 25;
            this.btnExit.BorderSize = 1;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = global::School_Management_System.Properties.Resources.Exit;
            this.btnExit.Location = new System.Drawing.Point(788, 12);
            this.btnExit.Name = "btnExit";
            this.btnExit.NormalBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnExit.PressedBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnExit.Size = new System.Drawing.Size(35, 35);
            this.btnExit.TabIndex = 22;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBackToLogin
            // 
            this.btnBackToLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBackToLogin.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnBackToLogin.BorderRadius = 5;
            this.btnBackToLogin.BorderSize = 2;
            this.btnBackToLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBackToLogin.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnBackToLogin.FlatAppearance.BorderSize = 0;
            this.btnBackToLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToLogin.ForeColor = System.Drawing.Color.White;
            this.btnBackToLogin.Image = global::School_Management_System.Properties.Resources.back_to;
            this.btnBackToLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackToLogin.Location = new System.Drawing.Point(125, 594);
            this.btnBackToLogin.Name = "btnBackToLogin";
            this.btnBackToLogin.NormalBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnBackToLogin.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnBackToLogin.PressedBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnBackToLogin.Size = new System.Drawing.Size(240, 52);
            this.btnBackToLogin.TabIndex = 19;
            this.btnBackToLogin.Text = "Back to Login";
            this.btnBackToLogin.UseVisualStyleBackColor = false;
            this.btnBackToLogin.Click += new System.EventHandler(this.btnBackToLogin_Click);
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCreateAccount.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.btnCreateAccount.BorderRadius = 5;
            this.btnCreateAccount.BorderSize = 2;
            this.btnCreateAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateAccount.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnCreateAccount.FlatAppearance.BorderSize = 0;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.Image = global::School_Management_System.Properties.Resources.Create1;
            this.btnCreateAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateAccount.Location = new System.Drawing.Point(475, 594);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.NormalBackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCreateAccount.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCreateAccount.PressedBackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCreateAccount.Size = new System.Drawing.Size(240, 52);
            this.btnCreateAccount.TabIndex = 18;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.SteelBlue;
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.White;
            this.txtConfirmPassword.BorderFocusColor = System.Drawing.Color.White;
            this.txtConfirmPassword.BorderRadius = 5;
            this.txtConfirmPassword.BorderSize = 4;
            this.txtConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtConfirmPassword.Location = new System.Drawing.Point(475, 498);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtConfirmPassword.Multiline = false;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.txtConfirmPassword.PasswordChar = false;
            this.txtConfirmPassword.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtConfirmPassword.PlaceholderText = "Confirm Password";
            this.txtConfirmPassword.Size = new System.Drawing.Size(240, 39);
            this.txtConfirmPassword.TabIndex = 17;
            this.txtConfirmPassword.Texts = "";
            this.txtConfirmPassword.UnderlinedStyle = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.SteelBlue;
            this.txtPassword.BorderColor = System.Drawing.Color.White;
            this.txtPassword.BorderFocusColor = System.Drawing.Color.White;
            this.txtPassword.BorderRadius = 5;
            this.txtPassword.BorderSize = 4;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtPassword.Location = new System.Drawing.Point(125, 498);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.txtPassword.PasswordChar = false;
            this.txtPassword.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.Size = new System.Drawing.Size(240, 39);
            this.txtPassword.TabIndex = 16;
            this.txtPassword.Texts = "";
            this.txtPassword.UnderlinedStyle = true;
            // 
            // txtCity
            // 
            this.txtCity.BackColor = System.Drawing.Color.SteelBlue;
            this.txtCity.BorderColor = System.Drawing.Color.White;
            this.txtCity.BorderFocusColor = System.Drawing.Color.White;
            this.txtCity.BorderRadius = 5;
            this.txtCity.BorderSize = 4;
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtCity.Location = new System.Drawing.Point(125, 320);
            this.txtCity.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCity.Multiline = false;
            this.txtCity.Name = "txtCity";
            this.txtCity.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.txtCity.PasswordChar = false;
            this.txtCity.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtCity.PlaceholderText = "City";
            this.txtCity.Size = new System.Drawing.Size(240, 39);
            this.txtCity.TabIndex = 15;
            this.txtCity.Texts = "";
            this.txtCity.UnderlinedStyle = true;
            // 
            // customComboBox1
            // 
            this.customComboBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customComboBox1.BorderColor = System.Drawing.Color.White;
            this.customComboBox1.BorderSize = 2;
            this.customComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.customComboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.customComboBox1.ForeColor = System.Drawing.Color.DimGray;
            this.customComboBox1.IconColor = System.Drawing.Color.SteelBlue;
            this.customComboBox1.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.customComboBox1.ListTextColor = System.Drawing.Color.DimGray;
            this.customComboBox1.Location = new System.Drawing.Point(546, 167);
            this.customComboBox1.MinimumSize = new System.Drawing.Size(200, 30);
            this.customComboBox1.Name = "customComboBox1";
            this.customComboBox1.Padding = new System.Windows.Forms.Padding(2);
            this.customComboBox1.Size = new System.Drawing.Size(200, 30);
            this.customComboBox1.TabIndex = 13;
            this.customComboBox1.Texts = "";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.Color.SteelBlue;
            this.txtPhoneNumber.BorderColor = System.Drawing.Color.White;
            this.txtPhoneNumber.BorderFocusColor = System.Drawing.Color.White;
            this.txtPhoneNumber.BorderRadius = 5;
            this.txtPhoneNumber.BorderSize = 4;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtPhoneNumber.Location = new System.Drawing.Point(475, 408);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPhoneNumber.Multiline = false;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.txtPhoneNumber.PasswordChar = false;
            this.txtPhoneNumber.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtPhoneNumber.PlaceholderText = "Phone Number";
            this.txtPhoneNumber.Size = new System.Drawing.Size(240, 39);
            this.txtPhoneNumber.TabIndex = 12;
            this.txtPhoneNumber.Texts = "";
            this.txtPhoneNumber.UnderlinedStyle = true;
            // 
            // txtLastname
            // 
            this.txtLastname.BackColor = System.Drawing.Color.SteelBlue;
            this.txtLastname.BorderColor = System.Drawing.Color.White;
            this.txtLastname.BorderFocusColor = System.Drawing.Color.White;
            this.txtLastname.BorderRadius = 5;
            this.txtLastname.BorderSize = 4;
            this.txtLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastname.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtLastname.Location = new System.Drawing.Point(475, 233);
            this.txtLastname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtLastname.Multiline = false;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.txtLastname.PasswordChar = false;
            this.txtLastname.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtLastname.PlaceholderText = "Last Name";
            this.txtLastname.Size = new System.Drawing.Size(240, 39);
            this.txtLastname.TabIndex = 9;
            this.txtLastname.Texts = "";
            this.txtLastname.UnderlinedStyle = true;
            // 
            // txtFirstname
            // 
            this.txtFirstname.BackColor = System.Drawing.Color.SteelBlue;
            this.txtFirstname.BorderColor = System.Drawing.Color.White;
            this.txtFirstname.BorderFocusColor = System.Drawing.Color.White;
            this.txtFirstname.BorderRadius = 5;
            this.txtFirstname.BorderSize = 4;
            this.txtFirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstname.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtFirstname.Location = new System.Drawing.Point(125, 233);
            this.txtFirstname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtFirstname.Multiline = false;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.txtFirstname.PasswordChar = false;
            this.txtFirstname.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtFirstname.PlaceholderText = "First Name";
            this.txtFirstname.Size = new System.Drawing.Size(240, 39);
            this.txtFirstname.TabIndex = 8;
            this.txtFirstname.Texts = "";
            this.txtFirstname.UnderlinedStyle = true;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.SteelBlue;
            this.txtEmail.BorderColor = System.Drawing.Color.White;
            this.txtEmail.BorderFocusColor = System.Drawing.Color.White;
            this.txtEmail.BorderRadius = 5;
            this.txtEmail.BorderSize = 4;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.Location = new System.Drawing.Point(125, 408);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtEmail.Multiline = false;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.txtEmail.PasswordChar = false;
            this.txtEmail.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(240, 39);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Texts = "";
            this.txtEmail.UnderlinedStyle = true;
            // 
            // txtSchoolName
            // 
            this.txtSchoolName.BackColor = System.Drawing.Color.SteelBlue;
            this.txtSchoolName.BorderColor = System.Drawing.Color.White;
            this.txtSchoolName.BorderFocusColor = System.Drawing.Color.White;
            this.txtSchoolName.BorderRadius = 5;
            this.txtSchoolName.BorderSize = 4;
            this.txtSchoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSchoolName.ForeColor = System.Drawing.Color.Gainsboro;
            this.txtSchoolName.Location = new System.Drawing.Point(125, 153);
            this.txtSchoolName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtSchoolName.Multiline = false;
            this.txtSchoolName.Name = "txtSchoolName";
            this.txtSchoolName.Padding = new System.Windows.Forms.Padding(12, 9, 12, 9);
            this.txtSchoolName.PasswordChar = false;
            this.txtSchoolName.PlaceholderColor = System.Drawing.Color.Gainsboro;
            this.txtSchoolName.PlaceholderText = "School Name";
            this.txtSchoolName.Size = new System.Drawing.Size(240, 39);
            this.txtSchoolName.TabIndex = 6;
            this.txtSchoolName.Texts = "";
            this.txtSchoolName.UnderlinedStyle = true;
            // 
            // frmNewSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(840, 700);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBackToLogin);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customComboBox1);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSchoolName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewSchool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolsControls.CustomTextBox txtSchoolName;
        private ToolsControls.CustomTextBox txtEmail;
        private ToolsControls.CustomTextBox txtFirstname;
        private ToolsControls.CustomTextBox txtLastname;
        private ToolsControls.CustomTextBox txtPhoneNumber;
        private ToolsControls.CustomComboBox customComboBox1;
        private System.Windows.Forms.Label label2;
        private ToolsControls.CustomTextBox txtCity;
        private ToolsControls.CustomTextBox txtConfirmPassword;
        private ToolsControls.CustomTextBox txtPassword;
        private ToolsControls.RJButton btnCreateAccount;
        private ToolsControls.RJButton btnBackToLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private ToolsControls.RJButton btnExit;
    }
}