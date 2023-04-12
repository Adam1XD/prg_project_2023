using Microsoft.VisualBasic.Logging;
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

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new();
            login.Show();
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

        private void txtSearchEmployee_TextChanged(object sender, EventArgs e)
        {
            LoadEmployee();
        }

        private void txtSearchWorkType_TextChanged(object sender, EventArgs e)
        {
            LoadWorkType();
        }
    }
}
