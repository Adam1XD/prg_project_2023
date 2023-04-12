namespace prg_project_2023.Forms
{
    partial class AddWorkTypeForm
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
            btnAddWorkType = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 40);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 51;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 69);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 52;
            label3.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(52, 9);
            label1.Name = "label1";
            label1.Size = new Size(122, 21);
            label1.TabIndex = 50;
            label1.Text = "Add WorkType";
            // 
            // txtName
            // 
            txtName.Location = new Point(80, 37);
            txtName.Name = "txtName";
            txtName.Size = new Size(130, 23);
            txtName.TabIndex = 43;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(80, 66);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(130, 23);
            txtDescription.TabIndex = 44;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(150, 95);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(60, 23);
            btnCancel.TabIndex = 49;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnAddWorkType
            // 
            btnAddWorkType.Location = new Point(80, 95);
            btnAddWorkType.Name = "btnAddWorkType";
            btnAddWorkType.Size = new Size(60, 23);
            btnAddWorkType.TabIndex = 48;
            btnAddWorkType.Text = "Add";
            btnAddWorkType.UseVisualStyleBackColor = true;
            btnAddWorkType.Click += btnAddWorkType_Click;
            // 
            // AddWorkTypeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 128);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(txtDescription);
            Controls.Add(btnCancel);
            Controls.Add(btnAddWorkType);
            Name = "AddWorkTypeForm";
            Text = "AddWorkTypeForm";
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
        private Button btnAddWorkType;
    }
}