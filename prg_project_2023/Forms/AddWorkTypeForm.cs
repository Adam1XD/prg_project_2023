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
    public partial class AddWorkTypeForm : Form
    {
        SqlRepo sqlRepo;
        public AddWorkTypeForm()
        {
            InitializeComponent();
            sqlRepo = new();
        }

        private void btnAddWorkType_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtDescription.Text != "")
            {
                sqlRepo.AddWorkType(txtName.Text, txtDescription.Text);
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
