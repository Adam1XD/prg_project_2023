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
    public partial class LoginForm : Form
    {
        private readonly SqlRepo sqlRepo = new SqlRepo();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = sqlRepo.Login(txtUsename.Text, txtPassword.Text);

            if (user != null)
            {
                if (user.Role == "Admin")
                {
                    AdminForm adminFrm = new AdminForm(user);
                    adminFrm.Show();
                    return;
                }
                else
                {
                    new UserForm().Show();
                }
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password. Please Try Again.", "Login Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsename.Text = "";
                txtPassword.Text = "";
                txtUsename.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsename.Text = "";
            txtPassword.Text = "";
            txtUsename.Focus();
        }

        private void checkbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxShowPass.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }
    }
}
