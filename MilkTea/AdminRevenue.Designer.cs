namespace MilkTea
{
    partial class AdminRevenue
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
            lbBranchName = new Label();
            dgvAminRevenueOrder = new DataGridView();
            label6 = new Label();
            label7 = new Label();
            dgvAminRevenueOrderDetail = new DataGridView();
            label9 = new Label();
            label10 = new Label();
            label13 = new Label();
            label15 = new Label();
            label16 = new Label();
            label20 = new Label();
            txtTotalOfOrders = new TextBox();
            txtBranchRevenue = new TextBox();
            label23 = new Label();
            txtTotal = new TextBox();
            dtDateCreated = new DateTimePicker();
            txtProductName = new TextBox();
            txtQuantity = new TextBox();
            txtTotalPrice = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            txttotalQuantities = new TextBox();
            txtTotalPrices = new TextBox();
            txtSearch = new TextBox();
            dtFrom = new DateTimePicker();
            dtTo = new DateTimePicker();
            btnSearch = new Button();
            btnFilterByDate = new Button();
            btnAllList = new Button();
            btnFirstPage = new Button();
            btnPreviousPage = new Button();
            btnNextPage = new Button();
            btnLastPage = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label8 = new Label();
            panel4 = new Panel();
            label4 = new Label();
            panel5 = new Panel();
            lbRevenue = new Label();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAminRevenueOrder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvAminRevenueOrderDetail).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // lbBranchName
            // 
            lbBranchName.AutoSize = true;
            lbBranchName.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbBranchName.ForeColor = Color.DarkRed;
            lbBranchName.Location = new Point(763, 33);
            lbBranchName.Name = "lbBranchName";
            lbBranchName.Size = new Size(57, 41);
            lbBranchName.TabIndex = 0;
            lbBranchName.Text = "BR";
            // 
            // dgvAminRevenueOrder
            // 
            dgvAminRevenueOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAminRevenueOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAminRevenueOrder.Location = new Point(12, 109);
            dgvAminRevenueOrder.Name = "dgvAminRevenueOrder";
            dgvAminRevenueOrder.RowHeadersWidth = 51;
            dgvAminRevenueOrder.RowTemplate.Height = 29;
            dgvAminRevenueOrder.Size = new Size(808, 275);
            dgvAminRevenueOrder.TabIndex = 5;
            dgvAminRevenueOrder.CellClick += dgvAminRevenueOrder_CellClick;
            dgvAminRevenueOrder.ColumnHeaderMouseClick += dgvAminRevenueOrder_ColumnHeaderMouseClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(12, 84);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 6;
            label6.Text = "Orders";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(826, 84);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 7;
            label7.Text = "Order Detail";
            // 
            // dgvAminRevenueOrderDetail
            // 
            dgvAminRevenueOrderDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAminRevenueOrderDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAminRevenueOrderDetail.Location = new Point(826, 109);
            dgvAminRevenueOrderDetail.Name = "dgvAminRevenueOrderDetail";
            dgvAminRevenueOrderDetail.RowHeadersWidth = 51;
            dgvAminRevenueOrderDetail.RowTemplate.Height = 29;
            dgvAminRevenueOrderDetail.Size = new Size(796, 275);
            dgvAminRevenueOrderDetail.TabIndex = 8;
            dgvAminRevenueOrderDetail.CellClick += dgvAminRevenueOrderDetail_CellClick;
            dgvAminRevenueOrderDetail.ColumnHeaderMouseClick += dgvAminRevenueOrderDetail_ColumnHeaderMouseClick;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(5, 47);
            label9.Name = "label9";
            label9.Size = new Size(66, 20);
            label9.TabIndex = 10;
            label9.Text = "Total Per";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 82);
            label10.Name = "label10";
            label10.Size = new Size(83, 20);
            label10.TabIndex = 11;
            label10.Text = "Order Date";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(5, 38);
            label13.Name = "label13";
            label13.Size = new Size(104, 20);
            label13.TabIndex = 14;
            label13.Text = "Product Name";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(5, 68);
            label15.Name = "label15";
            label15.Size = new Size(65, 20);
            label15.TabIndex = 16;
            label15.Text = "Quantity";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(5, 103);
            label16.Name = "label16";
            label16.Size = new Size(41, 20);
            label16.TabIndex = 17;
            label16.Text = "Price";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = SystemColors.Info;
            label20.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label20.ForeColor = SystemColors.ActiveCaptionText;
            label20.Location = new Point(159, 7);
            label20.Name = "label20";
            label20.Size = new Size(174, 25);
            label20.TabIndex = 21;
            label20.Text = "BRANCH REVENUE";
            // 
            // txtTotalOfOrders
            // 
            txtTotalOfOrders.Location = new Point(6, 34);
            txtTotalOfOrders.Name = "txtTotalOfOrders";
            txtTotalOfOrders.Size = new Size(130, 27);
            txtTotalOfOrders.TabIndex = 25;
            // 
            // txtBranchRevenue
            // 
            txtBranchRevenue.Location = new Point(159, 34);
            txtBranchRevenue.Name = "txtBranchRevenue";
            txtBranchRevenue.Size = new Size(174, 27);
            txtBranchRevenue.TabIndex = 26;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.BackColor = SystemColors.Info;
            label23.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label23.Location = new Point(6, 7);
            label23.Name = "label23";
            label23.Size = new Size(130, 23);
            label23.TabIndex = 27;
            label23.Text = "Total of Orders";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(109, 41);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 30;
            // 
            // dtDateCreated
            // 
            dtDateCreated.CalendarMonthBackground = SystemColors.Control;
            dtDateCreated.CustomFormat = "dd/MM/yyyy";
            dtDateCreated.Format = DateTimePickerFormat.Custom;
            dtDateCreated.Location = new Point(109, 77);
            dtDateCreated.Name = "dtDateCreated";
            dtDateCreated.Size = new Size(250, 27);
            dtDateCreated.TabIndex = 33;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(142, 32);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(125, 27);
            txtProductName.TabIndex = 35;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(142, 65);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(125, 27);
            txtQuantity.TabIndex = 37;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(142, 99);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(125, 27);
            txtTotalPrice.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(5, 13);
            label2.Name = "label2";
            label2.Size = new Size(138, 20);
            label2.TabIndex = 39;
            label2.Text = "Order Information";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 156);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 40;
            label3.Text = "Total of Quantities";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 194);
            label5.Name = "label5";
            label5.Size = new Size(102, 20);
            label5.TabIndex = 41;
            label5.Text = "Total of Prices";
            // 
            // txttotalQuantities
            // 
            txttotalQuantities.Location = new Point(142, 153);
            txttotalQuantities.Name = "txttotalQuantities";
            txttotalQuantities.Size = new Size(125, 27);
            txttotalQuantities.TabIndex = 42;
            // 
            // txtTotalPrices
            // 
            txtTotalPrices.Location = new Point(142, 187);
            txtTotalPrices.Name = "txtTotalPrices";
            txtTotalPrices.Size = new Size(125, 27);
            txtTotalPrices.TabIndex = 43;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(826, 425);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter product name...";
            txtSearch.Size = new Size(147, 27);
            txtSearch.TabIndex = 45;
            // 
            // dtFrom
            // 
            dtFrom.CustomFormat = "dd/MM/yyyy";
            dtFrom.Format = DateTimePickerFormat.Custom;
            dtFrom.Location = new Point(6, 38);
            dtFrom.Name = "dtFrom";
            dtFrom.Size = new Size(250, 27);
            dtFrom.TabIndex = 49;
            // 
            // dtTo
            // 
            dtTo.CustomFormat = "dd/MM/yyyy";
            dtTo.Format = DateTimePickerFormat.Custom;
            dtTo.Location = new Point(6, 70);
            dtTo.Name = "dtTo";
            dtTo.Size = new Size(250, 27);
            dtTo.TabIndex = 50;
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(826, 390);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 51;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnFilterByDate
            // 
            btnFilterByDate.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilterByDate.Location = new Point(6, 103);
            btnFilterByDate.Name = "btnFilterByDate";
            btnFilterByDate.Size = new Size(97, 29);
            btnFilterByDate.TabIndex = 52;
            btnFilterByDate.Text = "Filter";
            btnFilterByDate.UseVisualStyleBackColor = true;
            btnFilterByDate.Click += btnFilterByDate_Click;
            // 
            // btnAllList
            // 
            btnAllList.BackColor = SystemColors.GradientInactiveCaption;
            btnAllList.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAllList.Location = new Point(403, 3);
            btnAllList.Name = "btnAllList";
            btnAllList.Size = new Size(94, 29);
            btnAllList.TabIndex = 53;
            btnAllList.Text = "All List";
            btnAllList.UseVisualStyleBackColor = false;
            btnAllList.Click += btnAllList_Click;
            // 
            // btnFirstPage
            // 
            btnFirstPage.BackColor = SystemColors.ControlLightLight;
            btnFirstPage.Location = new Point(3, 3);
            btnFirstPage.Name = "btnFirstPage";
            btnFirstPage.Size = new Size(94, 29);
            btnFirstPage.TabIndex = 54;
            btnFirstPage.Text = "First Page";
            btnFirstPage.UseVisualStyleBackColor = false;
            btnFirstPage.Click += btnFirstPage_Click;
            // 
            // btnPreviousPage
            // 
            btnPreviousPage.BackColor = SystemColors.Info;
            btnPreviousPage.Location = new Point(103, 3);
            btnPreviousPage.Name = "btnPreviousPage";
            btnPreviousPage.Size = new Size(94, 29);
            btnPreviousPage.TabIndex = 55;
            btnPreviousPage.Text = "Previous Page";
            btnPreviousPage.UseVisualStyleBackColor = false;
            btnPreviousPage.Click += btnPreviousPage_Click;
            // 
            // btnNextPage
            // 
            btnNextPage.BackColor = SystemColors.Info;
            btnNextPage.Location = new Point(203, 3);
            btnNextPage.Name = "btnNextPage";
            btnNextPage.Size = new Size(94, 29);
            btnNextPage.TabIndex = 56;
            btnNextPage.Text = "Next Page";
            btnNextPage.UseVisualStyleBackColor = false;
            btnNextPage.Click += btnNextPage_Click;
            // 
            // btnLastPage
            // 
            btnLastPage.BackColor = SystemColors.ButtonHighlight;
            btnLastPage.Location = new Point(303, 3);
            btnLastPage.Name = "btnLastPage";
            btnLastPage.Size = new Size(94, 29);
            btnLastPage.TabIndex = 57;
            btnLastPage.Text = "Last Page";
            btnLastPage.UseVisualStyleBackColor = false;
            btnLastPage.Click += btnLastPage_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnFirstPage);
            panel1.Controls.Add(btnLastPage);
            panel1.Controls.Add(btnPreviousPage);
            panel1.Controls.Add(btnAllList);
            panel1.Controls.Add(btnNextPage);
            panel1.Location = new Point(46, 390);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 38);
            panel1.TabIndex = 58;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtBranchRevenue);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(txtTotalOfOrders);
            panel2.Controls.Add(label23);
            panel2.Location = new Point(1286, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(336, 65);
            panel2.TabIndex = 59;
            // 
            // panel3
            // 
            panel3.Controls.Add(label8);
            panel3.Controls.Add(dtFrom);
            panel3.Controls.Add(dtTo);
            panel3.Controls.Add(btnFilterByDate);
            panel3.Location = new Point(383, 461);
            panel3.Name = "panel3";
            panel3.Size = new Size(259, 137);
            panel3.TabIndex = 60;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(6, 4);
            label8.Name = "label8";
            label8.Size = new Size(147, 20);
            label8.TabIndex = 53;
            label8.Text = "Filter Order by Date";
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(txtProductName);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(txtQuantity);
            panel4.Controls.Add(label16);
            panel4.Controls.Add(txtTotalPrice);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(txtTotalPrices);
            panel4.Controls.Add(txttotalQuantities);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(1003, 390);
            panel4.Name = "panel4";
            panel4.Size = new Size(278, 231);
            panel4.TabIndex = 61;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(5, 7);
            label4.Name = "label4";
            label4.Size = new Size(187, 20);
            label4.TabIndex = 44;
            label4.Text = "Order Detail Information ";
            // 
            // panel5
            // 
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(txtTotal);
            panel5.Controls.Add(dtDateCreated);
            panel5.Location = new Point(12, 455);
            panel5.Name = "panel5";
            panel5.Size = new Size(365, 121);
            panel5.TabIndex = 62;
            // 
            // lbRevenue
            // 
            lbRevenue.AutoSize = true;
            lbRevenue.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbRevenue.ForeColor = SystemColors.ActiveCaptionText;
            lbRevenue.Location = new Point(746, -2);
            lbRevenue.Name = "lbRevenue";
            lbRevenue.Size = new Size(104, 41);
            lbRevenue.TabIndex = 63;
            lbRevenue.Text = "label1";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 38);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(131, 29);
            btnSave.TabIndex = 64;
            btnSave.Text = "Save To Excel";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AdminRevenue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1644, 806);
            Controls.Add(btnSave);
            Controls.Add(lbRevenue);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(dgvAminRevenueOrderDetail);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(dgvAminRevenueOrder);
            Controls.Add(lbBranchName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminRevenue";
            Text = "AdminStatic";
            Load += AdminRevenue_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAminRevenueOrder).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvAminRevenueOrderDetail).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbBranchName;
        private DataGridView dgvAminRevenueOrder;
        private Label label6;
        private Label label7;
        private DataGridView dgvAminRevenueOrderDetail;
        private Label label9;
        private Label label10;
        private Label label13;
        private Label label15;
        private Label label16;
        private Label label20;
        private TextBox txtTotalOfOrders;
        private TextBox txtBranchRevenue;
        private Label label23;
        private TextBox txtTotal;
        private DateTimePicker dtDateCreated;
        private TextBox txtProductName;
        private TextBox txtQuantity;
        private TextBox txtTotalPrice;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txttotalQuantities;
        private TextBox txtTotalPrices;
        private TextBox txtSearch;
        private DateTimePicker dtFrom;
        private DateTimePicker dtTo;
        private Button btnSearch;
        private Button btnFilterByDate;
        private Button btnAllList;
        private Button btnFirstPage;
        private Button btnPreviousPage;
        private Button btnNextPage;
        private Button btnLastPage;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label4;
        private Panel panel5;
        private Label label8;
        private Label lbRevenue;
        private Button btnSave;
    }
}