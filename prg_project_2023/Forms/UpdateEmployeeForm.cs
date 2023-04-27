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
    public partial class UpdateEmployeeForm : Form
    {
        SqlRepo sqlRepo;
        public UpdateEmployeeForm()
        {
            InitializeComponent();
            sqlRepo = new SqlRepo();
        }
        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            if (txtId.Text != string.Empty || txtFirstName.Text != string.Empty || txtLastName.Text != string.Empty || txtEmail.Text != string.Empty || txtPhone.Text != string.Empty)
            {
                this.Hide();
                sqlRepo.UpdateEmployee(txtId.Text, txtFirstName.Text, txtLastName.Text, datePicker.Value, txtEmail.Text, txtPhone.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Fill every window", "Update Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Text = "";
                txtFirstName.Text = "";
                txtLastName.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";
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
