namespace prg_project_2023
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txtSearchEmployee = new TextBox();
            txtSearchUser = new TextBox();
            btnCreateEmployee = new Button();
            btnDeleteEmployee = new Button();
            btnLogout = new Button();
            listViewEmployees = new ListView();
            EmployeeId = new ColumnHeader();
            EmployeeFirstName = new ColumnHeader();
            EmployeeSurname = new ColumnHeader();
            EmployeeBirthDate = new ColumnHeader();
            EmployeeEmail = new ColumnHeader();
            EmployeePhone = new ColumnHeader();
            listViewUsers = new ListView();
            UserId = new ColumnHeader();
            UserName = new ColumnHeader();
            UserRole = new ColumnHeader();
            listViewWorkType = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            txtSearchWorkType = new TextBox();
            label3 = new Label();
            btnCreateWorkType = new Button();
            btnDeleteWorkType = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Search in Users:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(423, 9);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 1;
            label2.Text = "Search in Employees:";
            // 
            // txtSearchEmployee
            // 
            txtSearchEmployee.Location = new Point(547, 6);
            txtSearchEmployee.Name = "txtSearchEmployee";
            txtSearchEmployee.Size = new Size(100, 23);
            txtSearchEmployee.TabIndex = 2;
            txtSearchEmployee.TextChanged += txtSearchEmployee_TextChanged;
            // 
            // txtSearchUser
            // 
            txtSearchUser.Location = new Point(107, 6);
            txtSearchUser.Name = "txtSearchUser";
            txtSearchUser.Size = new Size(129, 23);
            txtSearchUser.TabIndex = 3;
            txtSearchUser.TextChanged += txtSearchUser_TextChanged;
            // 
            // btnCreateEmployee
            // 
            btnCreateEmployee.Location = new Point(653, 6);
            btnCreateEmployee.Name = "btnCreateEmployee";
            btnCreateEmployee.Size = new Size(75, 23);
            btnCreateEmployee.TabIndex = 4;
            btnCreateEmployee.Text = "Create";
            btnCreateEmployee.UseVisualStyleBackColor = true;
            btnCreateEmployee.Click += btnCreateEmployee_Click;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Location = new Point(734, 6);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(75, 23);
            btnDeleteEmployee.TabIndex = 5;
            btnDeleteEmployee.Text = "Delete";
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1360, 409);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // listViewEmployees
            // 
            listViewEmployees.Columns.AddRange(new ColumnHeader[] { EmployeeId, EmployeeFirstName, EmployeeSurname, EmployeeBirthDate, EmployeeEmail, EmployeePhone });
            listViewEmployees.FullRowSelect = true;
            listViewEmployees.GridLines = true;
            listViewEmployees.Location = new Point(423, 35);
            listViewEmployees.Name = "listViewEmployees";
            listViewEmployees.Size = new Size(556, 368);
            listViewEmployees.TabIndex = 11;
            listViewEmployees.UseCompatibleStateImageBehavior = false;
            listViewEmployees.View = View.Details;
            // 
            // EmployeeId
            // 
            EmployeeId.Text = "Id";
            EmployeeId.Width = 50;
            // 
            // EmployeeFirstName
            // 
            EmployeeFirstName.Text = "First Name";
            EmployeeFirstName.Width = 100;
            // 
            // EmployeeSurname
            // 
            EmployeeSurname.Text = "Surname";
            EmployeeSurname.Width = 100;
            // 
            // EmployeeBirthDate
            // 
            EmployeeBirthDate.Text = "Birth Date";
            EmployeeBirthDate.Width = 100;
            // 
            // EmployeeEmail
            // 
            EmployeeEmail.Text = "E-mail";
            EmployeeEmail.Width = 100;
            // 
            // EmployeePhone
            // 
            EmployeePhone.Text = "Phone";
            EmployeePhone.Width = 100;
            // 
            // listViewUsers
            // 
            listViewUsers.Columns.AddRange(new ColumnHeader[] { UserId, UserName, UserRole });
            listViewUsers.FullRowSelect = true;
            listViewUsers.GridLines = true;
            listViewUsers.Location = new Point(12, 35);
            listViewUsers.Name = "listViewUsers";
            listViewUsers.Size = new Size(386, 368);
            listViewUsers.TabIndex = 12;
            listViewUsers.UseCompatibleStateImageBehavior = false;
            listViewUsers.View = View.Details;
            // 
            // UserId
            // 
            UserId.Text = "Id";
            UserId.Width = 75;
            // 
            // UserName
            // 
            UserName.Text = "Name";
            UserName.Width = 150;
            // 
            // UserRole
            // 
            UserRole.Text = "Role";
            UserRole.Width = 150;
            // 
            // listViewWorkType
            // 
            listViewWorkType.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewWorkType.FullRowSelect = true;
            listViewWorkType.GridLines = true;
            listViewWorkType.Location = new Point(999, 35);
            listViewWorkType.Name = "listViewWorkType";
            listViewWorkType.Size = new Size(436, 368);
            listViewWorkType.TabIndex = 15;
            listViewWorkType.UseCompatibleStateImageBehavior = false;
            listViewWorkType.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Id";
            columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Name";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Description";
            columnHeader3.Width = 200;
            // 
            // txtSearchWorkType
            // 
            txtSearchWorkType.Location = new Point(1118, 6);
            txtSearchWorkType.Name = "txtSearchWorkType";
            txtSearchWorkType.Size = new Size(129, 23);
            txtSearchWorkType.TabIndex = 14;
            txtSearchWorkType.TextChanged += txtSearchWorkType_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(999, 9);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 13;
            label3.Text = "Search in WorkType:";
            // 
            // btnCreateWorkType
            // 
            btnCreateWorkType.Location = new Point(1253, 6);
            btnCreateWorkType.Name = "btnCreateWorkType";
            btnCreateWorkType.Size = new Size(75, 23);
            btnCreateWorkType.TabIndex = 16;
            btnCreateWorkType.Text = "Create";
            btnCreateWorkType.UseVisualStyleBackColor = true;
            btnCreateWorkType.Click += btnCreateWorkType_Click;
            // 
            // btnDeleteWorkType
            // 
            btnDeleteWorkType.Location = new Point(1334, 5);
            btnDeleteWorkType.Name = "btnDeleteWorkType";
            btnDeleteWorkType.Size = new Size(75, 23);
            btnDeleteWorkType.TabIndex = 17;
            btnDeleteWorkType.Text = "Delete";
            btnDeleteWorkType.UseVisualStyleBackColor = true;
            btnDeleteWorkType.Click += btnDeleteWorkType_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1447, 439);
            Controls.Add(btnDeleteWorkType);
            Controls.Add(btnCreateWorkType);
            Controls.Add(listViewWorkType);
            Controls.Add(txtSearchWorkType);
            Controls.Add(label3);
            Controls.Add(listViewUsers);
            Controls.Add(listViewEmployees);
            Controls.Add(btnLogout);
            Controls.Add(btnDeleteEmployee);
            Controls.Add(btnCreateEmployee);
            Controls.Add(txtSearchUser);
            Controls.Add(txtSearchEmployee);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminForm";
            Text = "AdminForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSearchEmployee;
        private TextBox txtSearchUser;
        private Button btnCreateEmployee;
        private Button btnDeleteEmployee;
        private Button btnLogout;
        private ListView listViewEmployees;
        private ColumnHeader EmployeeId;
        private ColumnHeader EmployeeFirstName;
        private ColumnHeader EmployeeSurname;
        private ColumnHeader EmployeeBirthDate;
        private ColumnHeader EmployeeEmail;
        private ColumnHeader EmployeePhone;
        private ListView listViewUsers;
        private ColumnHeader UserId;
        private ColumnHeader UserName;
        private ColumnHeader UserRole;
        private ListView listViewWorkType;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox txtSearchWorkType;
        private Label label3;
        private Button btnCreateWorkType;
        private Button btnDeleteWorkType;
    }
}