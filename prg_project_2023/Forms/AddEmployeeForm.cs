using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prg_project_2023.Classes;

namespace prg_project_2023
{
    public partial class AddEmployeeForm : Form
    {
        SqlRepo sqlRepo;
        public AddEmployeeForm()
        {
            InitializeComponent();
            sqlRepo = new();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtEmail.Text != "" && txtPhone.Text != "")
            {
                sqlRepo.AddEmployee(txtFirstName.Text, txtLastName.Text, datePicker.Value.ToString("dd.MM.yyyy"), txtEmail.Text, txtPhone.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Fill every window.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
