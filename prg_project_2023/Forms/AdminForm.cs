﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prg_project_2023.Classes;
using prg_project_2023.Forms;

namespace prg_project_2023
{
    public partial class AdminForm : Form
    {
        SqlRepo sqlRepo;
        private User user;
        private List<User> users;
        private List<Employee> employees;
        private List<WorkType> worktypes;

        public AdminForm(User user)
        {
            InitializeComponent();
            sqlRepo = new();
            LoadUser();
            LoadEmployee();
            LoadWorkType();
        }
        public void LoadUser()
        {
            users = sqlRepo.GetUsers(txtSearchUser.Text);
            listViewUsers.Items.Clear();

            foreach (var user in users)
            {
                listViewUsers.Items.Add(user.ToListViewItem());
            }
        }
        public void LoadEmployee()
        {
            employees = sqlRepo.GetEmployees(txtSearchEmployee.Text);
            listViewEmployees.Items.Clear();

            foreach (var employee in employees)
            {
                listViewEmployees.Items.Add(employee.ToListViewItem());
            }
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
        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployee = new();
            var result = addEmployee.ShowDialog();
            if (result == DialogResult.OK)
                LoadEmployee();
        }
        private void btnCreateWorkType_Click(object sender, EventArgs e)
        {
            AddWorkTypeForm addWorkType = new();
            var result = addWorkType.ShowDialog();
            if (result == DialogResult.OK)
                LoadWorkType();
        }
        private void btnUpdateWorkType_Click(object sender, EventArgs e)
        {
            UpdateWorkTypeForm updateWorkType = new UpdateWorkTypeForm();
            var result = updateWorkType.ShowDialog();
            if (result == DialogResult.OK)
                LoadWorkType();
        }
        private void btnUpdateEmployees_Click(object sender, EventArgs e)
        {
            UpdateEmployeeForm updateEmployee = new UpdateEmployeeForm();
            var result = updateEmployee.ShowDialog();
            if (result == DialogResult.OK)
                LoadEmployee();
        }
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            UpdateUserForm userEmployee = new UpdateUserForm();
            var result = userEmployee.ShowDialog();
            if (result == DialogResult.OK)
                LoadUser();
        }
        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (listViewEmployees.SelectedItems.Count == 0)
            {
                MessageBox.Show("Select row to delete.", "Delete failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnDeleteEmployee.Focus();
                return;
            }
            var row = listViewEmployees.SelectedItems[0];
            var id = row.SubItems[0].Text;
            sqlRepo.DeleteEmployee(Convert.ToInt32(id));
            listViewEmployees.SelectedItems[0].Remove();
            LoadEmployee();
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
        private void txtSearchWorkType_TextChanged(object sender, EventArgs e)
        {
            LoadWorkType();
        }
        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            LoadEmployee();
        }
        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new();
            login.Show();
        }
    }
}
