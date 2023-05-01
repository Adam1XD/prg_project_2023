using Microsoft.VisualBasic.Logging;
using prg_project_2023.Classes;
using prg_project_2023.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prg_project_2023
{
    public partial class UserForm : Form
    {
        private List<Employee> employees;
        SqlRepo sqlRepo;
        private List<WorkType> worktypes;
        public UserForm()
        {
            InitializeComponent();
            sqlRepo = new SqlRepo();
            LoadEmployee();
            LoadWorkType();
        }
        public void LoadWorkType()
        {
            worktypes = sqlRepo.GetWorkType(txtSearchWorkType.Text);
            listViewWorkType.Items.Clear();

            foreach (var worktype in worktypes)
            {
                listViewWorkType.Items.Add(worktype.ToListViewItem());
            }
        }
        public void LoadEmployee()
        {
            employees = sqlRepo.GetEmployees(txtSearchEmployee.Text);
            listViewEmployee.Items.Clear();

            foreach (var employee in employees)
            {
                listViewEmployee.Items.Add(employee.ToListViewItem());
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new();
            login.Show();
        }
        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            LoadEmployee();
        }
        private void txtSearchWorkType_TextChanged(object sender, EventArgs e)
        {
            LoadWorkType();
        }
        private void btnCreateWorkType_Click(object sender, EventArgs e)
        {
            AddWorkTypeForm addWorkType = new();
            var result = addWorkType.ShowDialog();
            if (result == DialogResult.OK)
                LoadWorkType();
        }
        private void btnDeleteWorkType_Click(object sender, EventArgs e)
        {
            if (listViewWorkType.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select row to delete.", "Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDeleteWorkType.Focus();
                return;
            }
            var row = listViewWorkType.SelectedItems[0];
            var id = row.SubItems[0].Text;
            sqlRepo.DeleteWorkType(Convert.ToInt32(id));
            listViewWorkType.SelectedItems[0].Remove();

            LoadWorkType();
        }
        private void btnUpdateWorkType_Click(object sender, EventArgs e)
        {
            UpdateWorkTypeForm updateWorkType = new UpdateWorkTypeForm();
            var result = updateWorkType.ShowDialog();
            if (result == DialogResult.OK)
                LoadWorkType();
        }
    }
}
