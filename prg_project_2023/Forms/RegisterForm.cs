using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prg_project_2023.Classes;

namespace prg_project_2023
{
    public partial class RegisterForm : Form
    {
        private readonly SqlRepo sqlRepo;

        public RegisterForm()
        {
            InitializeComponent();
            sqlRepo = new SqlRepo();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtUsename.Text == "" || txtPassword.Text == "" || txtConPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == txtConPassword.Text)
            {
                sqlRepo.RegisterUser(txtUsename.Text, txtPassword.Text);

                txtUsename.Text = "";
                txtPassword.Text = "";
                txtConPassword.Text = "";

                MessageBox.Show("Your account has been SUCCESSFULLY CREATED.", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new LoginForm().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Password does not match, Please Re-enter.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = "";
                txtConPassword.Text = "";
                txtPassword.Focus();
            }
        }

        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
                txtConPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtConPassword.PasswordChar = '•';
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsename.Text = "";
            txtPassword.Text = "";
            txtConPassword.Text = "";
            txtUsename.Focus();
        }

        private void lblToLogin_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
}
