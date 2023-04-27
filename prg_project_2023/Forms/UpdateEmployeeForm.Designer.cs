namespace prg_project_2023.Forms
{
    partial class UpdateEmployeeForm
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
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            btnCancel = new Button();
            btnUpdateEmployee = new Button();
            datePicker = new DateTimePicker();
            txtPhone = new TextBox();
            label4 = new Label();
            txtId = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 76);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 51;
            label2.Text = "First Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 105);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 52;
            label3.Text = "Last Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 163);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 53;
            label5.Text = "E-mail:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 137);
            label7.Name = "label7";
            label7.Size = new Size(62, 15);
            label7.TabIndex = 55;
            label7.Text = "Birth Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(29, 192);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 54;
            label6.Text = "Phone:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(38, 9);
            label1.Name = "label1";
            label1.Size = new Size(146, 21);
            label1.TabIndex = 50;
            label1.Text = "Update Employee";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(76, 73);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(130, 23);
            txtFirstName.TabIndex = 43;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(76, 102);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(130, 23);
            txtLastName.TabIndex = 44;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(76, 160);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(130, 23);
            txtEmail.TabIndex = 45;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(146, 218);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(60, 23);
            btnCancel.TabIndex = 49;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdateEmployee
            // 
            btnUpdateEmployee.Location = new Point(80, 218);
            btnUpdateEmployee.Name = "btnUpdateEmployee";
            btnUpdateEmployee.Size = new Size(60, 23);
            btnUpdateEmployee.TabIndex = 48;
            btnUpdateEmployee.Text = "Update";
            btnUpdateEmployee.UseVisualStyleBackColor = true;
            btnUpdateEmployee.Click += btnUpdateEmployee_Click;
            // 
            // datePicker
            // 
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(76, 131);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(130, 23);
            datePicker.TabIndex = 47;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(76, 189);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(130, 23);
            txtPhone.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 47);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 57;
            label4.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(76, 44);
            txtId.Name = "txtId";
            txtId.Size = new Size(130, 23);
            txtId.TabIndex = 56;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(38, 9);
            label8.Name = "label8";
            label8.Size = new Size(146, 21);
            label8.TabIndex = 50;
            label8.Text = "Update Employee";
            // 
            // UpdateEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 255);
            Controls.Add(label4);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtEmail);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdateEmployee);
            Controls.Add(datePicker);
            Controls.Add(txtPhone);
            Name = "UpdateEmployeeForm";
            Text = "UpdateEmployeeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label5;
        private Label label7;
        private Label label6;
        private Label label1;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private Button btnCancel;
        private Button btnUpdateEmployee;
        private DateTimePicker datePicker;
        private TextBox txtPhone;
        private Label label4;
        private TextBox txtId;
        private Label label8;
    }
}