namespace prg_project_2023
{
    partial class AddEmployeeForm
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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            btnCancel = new Button();
            btnAddEmployee = new Button();
            datePicker = new DateTimePicker();
            txtPhone = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(54, 9);
            label1.Name = "label1";
            label1.Size = new Size(121, 21);
            label1.TabIndex = 37;
            label1.Text = "Add Employee";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(82, 37);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(130, 23);
            txtFirstName.TabIndex = 28;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(82, 66);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(130, 23);
            txtLastName.TabIndex = 29;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(82, 124);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(130, 23);
            txtEmail.TabIndex = 30;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(152, 182);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(60, 23);
            btnCancel.TabIndex = 34;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.Location = new Point(86, 182);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(60, 23);
            btnAddEmployee.TabIndex = 33;
            btnAddEmployee.Text = "Add";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // datePicker
            // 
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(82, 95);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(130, 23);
            datePicker.TabIndex = 32;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(82, 153);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(130, 23);
            txtPhone.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 40);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 38;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 69);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 39;
            label3.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 127);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 40;
            label5.Text = "E-mail";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(17, 101);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 42;
            label7.Text = "Birth Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 156);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 41;
            label6.Text = "Phone";
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 219);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtEmail);
            Controls.Add(btnCancel);
            Controls.Add(btnAddEmployee);
            Controls.Add(datePicker);
            Controls.Add(txtPhone);
            Name = "AddEmployeeForm";
            Text = "AddEmployeeFrom";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private Button btnCancel;
        private Button btnAddEmployee;
        private DateTimePicker datePicker;
        private TextBox txtPhone;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label7;
        private Label label6;
    }
}