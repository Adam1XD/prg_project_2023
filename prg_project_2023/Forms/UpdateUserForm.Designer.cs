namespace prg_project_2023.Forms
{
    partial class UpdateUserForm
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
            label4 = new Label();
            txtId = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnCancel = new Button();
            btnUpdateUser = new Button();
            label5 = new Label();
            txtRole = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 47);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 70;
            label4.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(84, 44);
            txtId.Name = "txtId";
            txtId.Size = new Size(130, 23);
            txtId.TabIndex = 69;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 76);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 67;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 105);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 68;
            label3.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(58, 9);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 66;
            label1.Text = "Update User";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(84, 73);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(130, 23);
            txtUsername.TabIndex = 62;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(84, 102);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(130, 23);
            txtPassword.TabIndex = 63;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(154, 160);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(60, 23);
            btnCancel.TabIndex = 65;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdateUser
            // 
            btnUpdateUser.Location = new Point(84, 160);
            btnUpdateUser.Name = "btnUpdateUser";
            btnUpdateUser.Size = new Size(60, 23);
            btnUpdateUser.TabIndex = 64;
            btnUpdateUser.Text = "Update";
            btnUpdateUser.UseVisualStyleBackColor = true;
            btnUpdateUser.Click += btnUpdateUser_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 134);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 72;
            label5.Text = "Role:";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(84, 131);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(130, 23);
            txtRole.TabIndex = 71;
            // 
            // UpdateUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(227, 194);
            Controls.Add(label5);
            Controls.Add(txtRole);
            Controls.Add(label4);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdateUser);
            Name = "UpdateUserForm";
            Text = "UpdateUserForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private TextBox txtId;
        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnCancel;
        private Button btnUpdateUser;
        private Label label5;
        private TextBox txtRole;
    }
}