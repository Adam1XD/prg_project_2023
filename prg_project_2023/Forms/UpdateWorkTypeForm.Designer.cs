namespace prg_project_2023.Forms
{
    partial class UpdateWorkTypeForm
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
            label1 = new Label();
            txtName = new TextBox();
            txtDescription = new TextBox();
            btnCancel = new Button();
            btnUpdateWorkType = new Button();
            label4 = new Label();
            txtId = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 76);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 58;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1, 105);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 59;
            label3.Text = "Description:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(36, 9);
            label1.Name = "label1";
            label1.Size = new Size(147, 21);
            label1.TabIndex = 57;
            label1.Text = "Update WorkType";
            // 
            // txtName
            // 
            txtName.Location = new Point(77, 73);
            txtName.Name = "txtName";
            txtName.Size = new Size(130, 23);
            txtName.TabIndex = 53;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(77, 102);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(130, 23);
            txtDescription.TabIndex = 54;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(147, 131);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(60, 23);
            btnCancel.TabIndex = 56;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnUpdateWorkType
            // 
            btnUpdateWorkType.Location = new Point(77, 131);
            btnUpdateWorkType.Name = "btnUpdateWorkType";
            btnUpdateWorkType.Size = new Size(60, 23);
            btnUpdateWorkType.TabIndex = 55;
            btnUpdateWorkType.Text = "Update";
            btnUpdateWorkType.UseVisualStyleBackColor = true;
            btnUpdateWorkType.Click += btnUpdateWorkType_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 47);
            label4.Name = "label4";
            label4.Size = new Size(20, 15);
            label4.TabIndex = 61;
            label4.Text = "Id:";
            // 
            // txtId
            // 
            txtId.Location = new Point(77, 44);
            txtId.Name = "txtId";
            txtId.Size = new Size(130, 23);
            txtId.TabIndex = 60;
            // 
            // UpdateWorkTypeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(218, 166);
            Controls.Add(label4);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(txtDescription);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdateWorkType);
            Name = "UpdateWorkTypeForm";
            Text = "UpdateWorkTypeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox txtName;
        private TextBox txtDescription;
        private Button btnCancel;
        private Button btnUpdateWorkType;
        private Label label4;
        private TextBox txtId;
    }
}