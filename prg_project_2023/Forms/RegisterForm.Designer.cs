namespace prg_project_2023
{
    partial class RegisterForm
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
            txtUsename = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            txtConPassword = new TextBox();
            checkbxShowPass = new CheckBox();
            btnRegister = new Button();
            btnClear = new Button();
            lblToLogin = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(26, 29);
            label1.Name = "label1";
            label1.Size = new Size(90, 30);
            label1.TabIndex = 0;
            label1.Text = "Register";
            // 
            // txtUsename
            // 
            txtUsename.Location = new Point(26, 116);
            txtUsename.Multiline = true;
            txtUsename.Name = "txtUsename";
            txtUsename.Size = new Size(216, 28);
            txtUsename.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 98);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 3;
            label2.Text = "Usename";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 163);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(26, 181);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '•';
            txtPassword.Size = new Size(216, 28);
            txtPassword.TabIndex = 4;
            // 
            // txtConPassword
            // 
            txtConPassword.Location = new Point(26, 253);
            txtConPassword.Multiline = true;
            txtConPassword.Name = "txtConPassword";
            txtConPassword.PasswordChar = '•';
            txtConPassword.Size = new Size(216, 28);
            txtConPassword.TabIndex = 6;
            // 
            // checkbxShowPass
            // 
            checkbxShowPass.AutoSize = true;
            checkbxShowPass.Location = new Point(137, 287);
            checkbxShowPass.Name = "checkbxShowPass";
            checkbxShowPass.Size = new Size(108, 19);
            checkbxShowPass.TabIndex = 8;
            checkbxShowPass.Text = "Show Password";
            checkbxShowPass.UseVisualStyleBackColor = true;
            checkbxShowPass.CheckedChanged += checkbxShowPass_CheckedChanged;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(26, 327);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(216, 35);
            btnRegister.TabIndex = 9;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(26, 368);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(216, 35);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // lblToLogin
            // 
            lblToLogin.AutoSize = true;
            lblToLogin.ForeColor = SystemColors.MenuHighlight;
            lblToLogin.Location = new Point(163, 406);
            lblToLogin.Name = "lblToLogin";
            lblToLogin.Size = new Size(79, 15);
            lblToLogin.TabIndex = 11;
            lblToLogin.Text = "Back to Login";
            lblToLogin.Click += lblToLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 235);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 12;
            label4.Text = "Confirm Password";
            // 
            // RegisterForm
            // 
            AcceptButton = btnRegister;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(269, 505);
            Controls.Add(label4);
            Controls.Add(lblToLogin);
            Controls.Add(btnClear);
            Controls.Add(btnRegister);
            Controls.Add(checkbxShowPass);
            Controls.Add(txtConPassword);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtUsename);
            Controls.Add(label1);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsename;
        private Label label2;
        private Label label3;
        private TextBox txtPassword;
        private TextBox txtConPassword;
        private CheckBox checkbxShowPass;
        private Button btnRegister;
        private Button btnClear;
        private Label lblToLogin;
        private Label label4;
    }
}