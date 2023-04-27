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
    public partial class UpdateWorkTypeForm : Form
    {
        SqlRepo sqlRepo;
        public UpdateWorkTypeForm()
        {
            InitializeComponent();
            sqlRepo = new SqlRepo();
        }

        private void btnUpdateWorkType_Click(object sender, EventArgs e)
        {
            if(txtId.Text != string.Empty ||  txtName.Text != string.Empty || txtDescription.Text != string.Empty)
            {
                this.Hide();
                sqlRepo.UpdateWorkType(txtId.Text, txtName.Text, txtDescription.Text);
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Fill every window", "Update Failed.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Text = "";
                txtName.Text = "";
                txtDescription.Text = "";
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
