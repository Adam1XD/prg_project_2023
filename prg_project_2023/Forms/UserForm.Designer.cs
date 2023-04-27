namespace prg_project_2023
{
    partial class UserForm
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
            btnLogout = new Button();
            listViewEmployee = new ListView();
            Id = new ColumnHeader();
            FirstName = new ColumnHeader();
            Surname = new ColumnHeader();
            BirthDate = new ColumnHeader();
            Email = new ColumnHeader();
            Phone = new ColumnHeader();
            txtSearchEmployee = new TextBox();
            label2 = new Label();
            listViewWorkType = new ListView();
            IdWorkType = new ColumnHeader();
            NameWorkType = new ColumnHeader();
            DescriptionWorkType = new ColumnHeader();
            txtSearchWorkType = new TextBox();
            label3 = new Label();
            btnDeleteWorkType = new Button();
            btnCreateWorkType = new Button();
            btnUpdateWorkType = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 62);
            label1.Name = "label1";
            label1.Size = new Size(105, 15);
            label1.TabIndex = 0;
            label1.Text = "Search Employees:";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1016, 462);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // listViewEmployee
            // 
            listViewEmployee.Columns.AddRange(new ColumnHeader[] { Id, FirstName, Surname, BirthDate, Email, Phone });
            listViewEmployee.FullRowSelect = true;
            listViewEmployee.GridLines = true;
            listViewEmployee.Location = new Point(12, 88);
            listViewEmployee.Name = "listViewEmployee";
            listViewEmployee.Size = new Size(557, 368);
            listViewEmployee.TabIndex = 2;
            listViewEmployee.UseCompatibleStateImageBehavior = false;
            listViewEmployee.View = View.Details;
            // 
            // Id
            // 
            Id.Text = "Id";
            Id.Width = 50;
            // 
            // FirstName
            // 
            FirstName.Text = "First Name";
            FirstName.Width = 100;
            // 
            // Surname
            // 
            Surname.Text = "Surname";
            Surname.Width = 100;
            // 
            // BirthDate
            // 
            BirthDate.Text = "Birth Date";
            BirthDate.Width = 100;
            // 
            // Email
            // 
            Email.Text = "E-mail";
            Email.Width = 100;
            // 
            // Phone
            // 
            Phone.Text = "Phone";
            Phone.Width = 100;
            // 
            // txtSearchEmployee
            // 
            txtSearchEmployee.Location = new Point(123, 59);
            txtSearchEmployee.Name = "txtSearchEmployee";
            txtSearchEmployee.Size = new Size(154, 23);
            txtSearchEmployee.TabIndex = 3;
            txtSearchEmployee.TextChanged += txtSearchEmployee_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 10);
            label2.Name = "label2";
            label2.Size = new Size(56, 30);
            label2.TabIndex = 4;
            label2.Text = "User";
            // 
            // listViewWorkType
            // 
            listViewWorkType.Columns.AddRange(new ColumnHeader[] { IdWorkType, NameWorkType, DescriptionWorkType });
            listViewWorkType.FullRowSelect = true;
            listViewWorkType.GridLines = true;
            listViewWorkType.Location = new Point(575, 88);
            listViewWorkType.Name = "listViewWorkType";
            listViewWorkType.Size = new Size(516, 368);
            listViewWorkType.TabIndex = 18;
            listViewWorkType.UseCompatibleStateImageBehavior = false;
            listViewWorkType.View = View.Details;
            // 
            // IdWorkType
            // 
            IdWorkType.Text = "Id";
            IdWorkType.Width = 75;
            // 
            // NameWorkType
            // 
            NameWorkType.Text = "Name";
            NameWorkType.Width = 150;
            // 
            // DescriptionWorkType
            // 
            DescriptionWorkType.Text = "Description";
            DescriptionWorkType.Width = 280;
            // 
            // txtSearchWorkType
            // 
            txtSearchWorkType.Location = new Point(694, 60);
            txtSearchWorkType.Name = "txtSearchWorkType";
            txtSearchWorkType.Size = new Size(154, 23);
            txtSearchWorkType.TabIndex = 17;
            txtSearchWorkType.TextChanged += txtSearchWorkType_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(575, 63);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 16;
            label3.Text = "Search in WorkType:";
            // 
            // btnDeleteWorkType
            // 
            btnDeleteWorkType.Location = new Point(935, 60);
            btnDeleteWorkType.Name = "btnDeleteWorkType";
            btnDeleteWorkType.Size = new Size(75, 23);
            btnDeleteWorkType.TabIndex = 20;
            btnDeleteWorkType.Text = "Delete";
            btnDeleteWorkType.UseVisualStyleBackColor = true;
            btnDeleteWorkType.Click += btnDeleteWorkType_Click;
            // 
            // btnCreateWorkType
            // 
            btnCreateWorkType.Location = new Point(854, 60);
            btnCreateWorkType.Name = "btnCreateWorkType";
            btnCreateWorkType.Size = new Size(75, 23);
            btnCreateWorkType.TabIndex = 19;
            btnCreateWorkType.Text = "Create";
            btnCreateWorkType.UseVisualStyleBackColor = true;
            btnCreateWorkType.Click += btnCreateWorkType_Click;
            // 
            // btnUpdateWorkType
            // 
            btnUpdateWorkType.Location = new Point(1016, 59);
            btnUpdateWorkType.Name = "btnUpdateWorkType";
            btnUpdateWorkType.Size = new Size(75, 23);
            btnUpdateWorkType.TabIndex = 21;
            btnUpdateWorkType.Text = "Update";
            btnUpdateWorkType.UseVisualStyleBackColor = true;
            btnUpdateWorkType.Click += btnUpdateWorkType_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 497);
            Controls.Add(btnUpdateWorkType);
            Controls.Add(btnDeleteWorkType);
            Controls.Add(btnCreateWorkType);
            Controls.Add(listViewWorkType);
            Controls.Add(txtSearchWorkType);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtSearchEmployee);
            Controls.Add(listViewEmployee);
            Controls.Add(btnLogout);
            Controls.Add(label1);
            Name = "UserForm";
            Text = "UserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnLogout;
        private ListView listViewEmployee;
        private ColumnHeader Id;
        private ColumnHeader FirstName;
        private ColumnHeader Surname;
        private ColumnHeader BirthDate;
        private ColumnHeader Email;
        private ColumnHeader Phone;
        private TextBox txtSearchEmployee;
        private Label label2;
        private ListView listViewWorkType;
        private ColumnHeader IdWorkType;
        private ColumnHeader NameWorkType;
        private ColumnHeader DescriptionWorkType;
        private TextBox txtSearchWorkType;
        private Label label3;
        private Button btnDeleteWorkType;
        private Button btnCreateWorkType;
        private Button btnUpdateWorkType;
    }
}