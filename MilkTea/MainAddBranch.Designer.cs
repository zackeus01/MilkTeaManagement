namespace MilkTea
{
    partial class MainAddBranch
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtBranchName = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtManagerId = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(278, 21);
            label1.Name = "label1";
            label1.Size = new Size(246, 41);
            label1.TabIndex = 0;
            label1.Text = "Add New Branch";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(125, 119);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 1;
            label2.Text = "Branch Name (*)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(125, 160);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Phone (*)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(125, 215);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 3;
            label4.Text = "Address (*)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(125, 266);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 4;
            label5.Text = "Manager ID (*)";
            // 
            // txtBranchName
            // 
            txtBranchName.Location = new Point(304, 116);
            txtBranchName.Name = "txtBranchName";
            txtBranchName.Size = new Size(202, 27);
            txtBranchName.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(304, 160);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(202, 27);
            txtPhone.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(304, 208);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(202, 27);
            txtAddress.TabIndex = 7;
            // 
            // txtManagerId
            // 
            txtManagerId.Location = new Point(304, 259);
            txtManagerId.Name = "txtManagerId";
            txtManagerId.Size = new Size(202, 27);
            txtManagerId.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(304, 335);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(412, 335);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // MainAddBranch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtManagerId);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtBranchName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MainAddBranch";
            Text = "MainAddBranch";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtBranchName;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtManagerId;
        private Button btnSave;
        private Button btnCancel;
    }
}