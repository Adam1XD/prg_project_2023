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
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            txtSearchWorkType = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(277, 15);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Search:";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(1142, 415);
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
            listViewEmployee.Location = new Point(12, 41);
            listViewEmployee.Name = "listViewEmployee";
            listViewEmployee.Size = new Size(776, 368);
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
            txtSearchEmployee.Location = new Point(328, 12);
            txtSearchEmployee.Name = "txtSearchEmployee";
            txtSearchEmployee.Size = new Size(100, 23);
            txtSearchEmployee.TabIndex = 3;
            txtSearchEmployee.TextChanged += txtSearchEmployee_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 10);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 4;
            label2.Text = "Employees Data";
            // 
            // listViewWorkType
            // 
            listViewWorkType.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listViewWorkType.FullRowSelect = true;
            listViewWorkType.GridLines = true;
            listViewWorkType.Location = new Point(807, 41);
            listViewWorkType.Name = "listViewWorkType";
            listViewWorkType.Size = new Size(410, 368);
            listViewWorkType.TabIndex = 18;
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
            txtSearchWorkType.Location = new Point(926, 12);
            txtSearchWorkType.Name = "txtSearchWorkType";
            txtSearchWorkType.Size = new Size(129, 23);
            txtSearchWorkType.TabIndex = 17;
            txtSearchWorkType.TextChanged += txtSearchWorkType_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(807, 15);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 16;
            label3.Text = "Search in WorkType:";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 445);
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
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox txtSearchWorkType;
        private Label label3;
    }
}