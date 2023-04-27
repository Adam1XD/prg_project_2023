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
            btnDeleteWorkType = new Button();
            btnCreateWorkType = new Button();
            listViewWorkType = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            txtSearchWorkType = new TextBox();
            label3 = new Label();
            listViewUsers = new ListView();
            UserId = new ColumnHeader();
            UserName = new ColumnHeader();
            UserRole = new ColumnHeader();
            listViewEmployees = new ListView();
            EmployeeId = new ColumnHeader();
            EmployeeFirstName = new ColumnHeader();
            EmployeeSurname = new ColumnHeader();
            EmployeeBirthDate = new ColumnHeader();
            EmployeeEmail = new ColumnHeader();
            EmployeePhone = new ColumnHeader();
            btnLogout = new Button();
            btnDeleteEmployee = new Button();
            btnCreateEmployee = new Button();
            txtSearchUser = new TextBox();
            txtSearchEmployee = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            btnUpdateWorkType = new Button();
            btnUpdateEmployees = new Button();
            btnUpdateUser = new Button();
            SuspendLayout();
            // 
            // btnDeleteWorkType
            // 
            btnDeleteWorkType.Location = new Point(1325, 48);
            btnDeleteWorkType.Name = "btnDeleteWorkType";
            btnDeleteWorkType.Size = new Size(75, 23);
            btnDeleteWorkType.TabIndex = 31;
            btnDeleteWorkType.Text = "Delete";
            btnDeleteWorkType.UseVisualStyleBackColor = true;
            btnDeleteWorkType.Click += btnDeleteWorkType_Click;
            // 
            // btnCreateWorkType
            // 
            btnCreateWorkType.Location = new Point(1244, 49);
            btnCreateWorkType.Name = "btnCreateWorkType";
            btnCreateWorkType.Size = new Size(75, 23);
            btnCreateWorkType.TabIndex = 30;
            btnCreateWorkType.Text = "Create";
            btnCreateWorkType.UseVisualStyleBackColor = true;
            btnCreateWorkType.Click += btnCreateWorkType_Click;
            // 
            // listViewWorkType
            // 
            listViewWorkType.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewWorkType.FullRowSelect = true;
            listViewWorkType.GridLines = true;
            listViewWorkType.Location = new Point(966, 78);
            listViewWorkType.Name = "listViewWorkType";
            listViewWorkType.Size = new Size(515, 368);
            listViewWorkType.TabIndex = 29;
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
            columnHeader3.Width = 280;
            // 
            // txtSearchWorkType
            // 
            txtSearchWorkType.Location = new Point(1085, 49);
            txtSearchWorkType.Name = "txtSearchWorkType";
            txtSearchWorkType.Size = new Size(153, 23);
            txtSearchWorkType.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(966, 52);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 27;
            label3.Text = "Search in WorkType:";
            // 
            // listViewUsers
            // 
            listViewUsers.Columns.AddRange(new ColumnHeader[] { UserId, UserName, UserRole });
            listViewUsers.FullRowSelect = true;
            listViewUsers.GridLines = true;
            listViewUsers.Location = new Point(12, 78);
            listViewUsers.Name = "listViewUsers";
            listViewUsers.Size = new Size(386, 368);
            listViewUsers.TabIndex = 26;
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
            // listViewEmployees
            // 
            listViewEmployees.Columns.AddRange(new ColumnHeader[] { EmployeeId, EmployeeFirstName, EmployeeSurname, EmployeeBirthDate, EmployeeEmail, EmployeePhone });
            listViewEmployees.FullRowSelect = true;
            listViewEmployees.GridLines = true;
            listViewEmployees.Location = new Point(404, 78);
            listViewEmployees.Name = "listViewEmployees";
            listViewEmployees.Size = new Size(556, 368);
            listViewEmployees.TabIndex = 25;
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
            // btnLogout
            // 
            btnLogout.Location = new Point(1406, 452);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 24;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.Location = new Point(744, 49);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(75, 23);
            btnDeleteEmployee.TabIndex = 23;
            btnDeleteEmployee.Text = "Delete";
            btnDeleteEmployee.UseVisualStyleBackColor = true;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // btnCreateEmployee
            // 
            btnCreateEmployee.Location = new Point(663, 49);
            btnCreateEmployee.Name = "btnCreateEmployee";
            btnCreateEmployee.Size = new Size(75, 23);
            btnCreateEmployee.TabIndex = 22;
            btnCreateEmployee.Text = "Create";
            btnCreateEmployee.UseVisualStyleBackColor = true;
            btnCreateEmployee.Click += btnCreateEmployee_Click;
            // 
            // txtSearchUser
            // 
            txtSearchUser.Location = new Point(107, 49);
            txtSearchUser.Name = "txtSearchUser";
            txtSearchUser.Size = new Size(129, 23);
            txtSearchUser.TabIndex = 21;
            // 
            // txtSearchEmployee
            // 
            txtSearchEmployee.Location = new Point(528, 49);
            txtSearchEmployee.Name = "txtSearchEmployee";
            txtSearchEmployee.Size = new Size(129, 23);
            txtSearchEmployee.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(404, 52);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 19;
            label2.Text = "Search in Employees:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 52);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 18;
            label1.Text = "Search in Users:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(12, 9);
            label4.Name = "label4";
            label4.Size = new Size(79, 30);
            label4.TabIndex = 32;
            label4.Text = "Admin";
            // 
            // btnUpdateWorkType
            // 
            btnUpdateWorkType.Location = new Point(1406, 48);
            btnUpdateWorkType.Name = "btnUpdateWorkType";
            btnUpdateWorkType.Size = new Size(75, 23);
            btnUpdateWorkType.TabIndex = 33;
            btnUpdateWorkType.Text = "Update";
            btnUpdateWorkType.UseVisualStyleBackColor = true;
            btnUpdateWorkType.Click += btnUpdateWorkType_Click;
            // 
            // btnUpdateEmployees
            // 
            btnUpdateEmployees.Location = new Point(825, 49);
            btnUpdateEmployees.Name = "btnUpdateEmployees";
            btnUpdateEmployees.Size = new Size(75, 23);
            btnUpdateEmployees.TabIndex = 34;
            btnUpdateEmployees.Text = "Update";
            btnUpdateEmployees.UseVisualStyleBackColor = true;
            btnUpdateEmployees.Click += btnUpdateEmployees_Click;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Location = new Point(242, 49);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(75, 23);
            btnUpdateUser.TabIndex = 35;
            btnUpdateUser.Text = "Update";
            btnUpdateUser.UseVisualStyleBackColor = true;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1492, 484);
            Controls.Add(btnUpdateUser);
            Controls.Add(btnUpdateEmployees);
            Controls.Add(btnUpdateWorkType);
            Controls.Add(label4);
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

        private Button btnDeleteWorkType;
        private Button btnCreateWorkType;
        private ListView listViewWorkType;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox txtSearchWorkType;
        private Label label3;
        private ListView listViewUsers;
        private ColumnHeader UserId;
        private ColumnHeader UserName;
        private ColumnHeader UserRole;
        private ListView listViewEmployees;
        private ColumnHeader EmployeeId;
        private ColumnHeader EmployeeFirstName;
        private ColumnHeader EmployeeSurname;
        private ColumnHeader EmployeeBirthDate;
        private ColumnHeader EmployeeEmail;
        private ColumnHeader EmployeePhone;
        private Button btnLogout;
        private Button btnDeleteEmployee;
        private Button btnCreateEmployee;
        private TextBox txtSearchUser;
        private TextBox txtSearchEmployee;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button btnUpdateWorkType;
        private Button btnUpdateEmployees;
        private Button btnUpdateUser;
    }
}