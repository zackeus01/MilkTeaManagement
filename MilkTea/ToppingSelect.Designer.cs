namespace MilkTea
{
    partial class ToppingSelect
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
            picImage = new PictureBox();
            btnAdd = new Button();
            lblName = new Label();
            lblTotalPrice = new Label();
            label1 = new Label();
            numQuantity = new NumericUpDown();
            dgvToppings = new DataGridView();
            Select = new DataGridViewCheckBoxColumn();
            Id = new DataGridViewTextBoxColumn();
            ToppingName = new DataGridViewTextBoxColumn();
            ToppingPrice = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)picImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvToppings).BeginInit();
            SuspendLayout();
            // 
            // picImage
            // 
            picImage.Location = new Point(12, 12);
            picImage.Name = "picImage";
            picImage.Size = new Size(160, 160);
            picImage.SizeMode = PictureBoxSizeMode.Zoom;
            picImage.TabIndex = 0;
            picImage.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(553, 480);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblName
            // 
            lblName.Font = new Font("Montserrat SemiBold", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            lblName.Location = new Point(200, 12);
            lblName.Name = "lblName";
            lblName.Size = new Size(422, 60);
            lblName.TabIndex = 3;
            lblName.Text = "Initial Text";
            // 
            // lblTotalPrice
            // 
            lblTotalPrice.BackColor = Color.Transparent;
            lblTotalPrice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalPrice.ForeColor = Color.DarkGoldenrod;
            lblTotalPrice.Location = new Point(200, 72);
            lblTotalPrice.Name = "lblTotalPrice";
            lblTotalPrice.Size = new Size(422, 27);
            lblTotalPrice.TabIndex = 4;
            lblTotalPrice.Text = "Price";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(200, 117);
            label1.Name = "label1";
            label1.Size = new Size(80, 27);
            label1.TabIndex = 5;
            label1.Text = "Quantity: ";
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(286, 117);
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(60, 23);
            numQuantity.TabIndex = 6;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.ValueChanged += numQuantity_ValueChanged;
            // 
            // dgvToppings
            // 
            dgvToppings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvToppings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvToppings.Columns.AddRange(new DataGridViewColumn[] { Select, Id, ToppingName, ToppingPrice });
            dgvToppings.Location = new Point(12, 188);
            dgvToppings.Name = "dgvToppings";
            dgvToppings.RowTemplate.Height = 25;
            dgvToppings.Size = new Size(616, 279);
            dgvToppings.TabIndex = 7;
            // 
            // Select
            // 
            Select.FillWeight = 40F;
            Select.HeaderText = "Select";
            Select.Name = "Select";
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.FillWeight = 40F;
            Id.HeaderText = "ID";
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // ToppingName
            // 
            ToppingName.DataPropertyName = "Name";
            ToppingName.FillWeight = 99.49239F;
            ToppingName.HeaderText = "Name";
            ToppingName.Name = "ToppingName";
            ToppingName.ReadOnly = true;
            // 
            // ToppingPrice
            // 
            ToppingPrice.DataPropertyName = "Price";
            ToppingPrice.FillWeight = 99.49239F;
            ToppingPrice.HeaderText = "Price";
            ToppingPrice.Name = "ToppingPrice";
            ToppingPrice.ReadOnly = true;
            // 
            // frmToppingSelect
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 515);
            Controls.Add(dgvToppings);
            Controls.Add(numQuantity);
            Controls.Add(label1);
            Controls.Add(lblTotalPrice);
            Controls.Add(lblName);
            Controls.Add(btnAdd);
            Controls.Add(picImage);
            Name = "frmToppingSelect";
            Text = "ToppingSelect";
            Load += frmToppingSelect_Load;
            ((System.ComponentModel.ISupportInitialize)picImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvToppings).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picImage;
        private Button btnAdd;
        private Label lblName;
        private Label lblTotalPrice;
        private Label label1;
        private NumericUpDown numQuantity;
        private DataGridView dgvToppings;
        private DataGridViewCheckBoxColumn Select;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn ToppingName;
        private DataGridViewTextBoxColumn ToppingPrice;
    }
}