using prg_project_2023.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prg_project_2023.Forms
{
    public partial class UpdateUserForm : Form
    {
        SqlRepo sqlRepo;
        public UpdateUserForm()
        {
            InitializeComponent();
            sqlRepo = new SqlRepo();
        }
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty || txtUsername.Text != string.Empty || txtPassword.Text != string.Empty || txtRole.Text != string.Empty)
            {
                this.Hide();
                sqlRepo.UpdateUser(txtId.Text, txtUsername.Text, txtPassword.Text, txtRole.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Fill every window", "Update Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Text = "";
                txtUsername.Text = "";
                txtPassword.Text = "";
                txtRole.Text = "";
                txtId.Focus();
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
