namespace MilkTea
{
    partial class EmployeeMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeMenu));
            panel1 = new Panel();
            btnLogOut = new Button();
            panel2 = new Panel();
            btnSaveOrder = new Button();
            panel3 = new Panel();
            lblTotalBill = new Label();
            label1 = new Label();
            label2 = new Label();
            pnlOrder = new Panel();
            button1 = new Button();
            button8 = new Button();
            button7 = new Button();
            orderTopping2 = new Controls.OrderTopping();
            orderTopping1 = new Controls.OrderTopping();
            orderItem2 = new Controls.OrderItem();
            orderItem1 = new Controls.OrderItem();
            button6 = new Button();
            btnPrintBill = new Button();
            pnlMenu = new Panel();
            menuItem6 = new Controls.MenuItem();
            menuItem5 = new Controls.MenuItem();
            menuItem4 = new Controls.MenuItem();
            button5 = new Button();
            menuItem3 = new Controls.MenuItem();
            button4 = new Button();
            button3 = new Button();
            menuItem2 = new Controls.MenuItem();
            menuItem1 = new Controls.MenuItem();
            pnlCategory = new Panel();
            button2 = new Button();
            btnAll = new Button();
            printPreviewDialogBill = new PrintPreviewDialog();
            printDocumentBill = new System.Drawing.Printing.PrintDocument();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            pnlOrder.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlCategory.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LemonChiffon;
            panel1.Controls.Add(btnLogOut);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1904, 76);
            panel1.TabIndex = 0;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.IndianRed;
            btnLogOut.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogOut.ForeColor = SystemColors.ControlLightLight;
            btnLogOut.Location = new Point(1738, 12);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(154, 39);
            btnLogOut.TabIndex = 9;
            btnLogOut.Text = "LOG OUT";
            btnLogOut.UseVisualStyleBackColor = false;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnSaveOrder);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pnlOrder);
            panel2.Controls.Add(btnPrintBill);
            panel2.Location = new Point(0, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(699, 965);
            panel2.TabIndex = 1;
            // 
            // btnSaveOrder
            // 
            btnSaveOrder.BackColor = Color.IndianRed;
            btnSaveOrder.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSaveOrder.ForeColor = SystemColors.ControlLightLight;
            btnSaveOrder.Location = new Point(354, 878);
            btnSaveOrder.Name = "btnSaveOrder";
            btnSaveOrder.Size = new Size(154, 39);
            btnSaveOrder.TabIndex = 8;
            btnSaveOrder.Text = "SAVE ORDER";
            btnSaveOrder.UseVisualStyleBackColor = false;
            btnSaveOrder.Click += btnSaveOrder_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblTotalBill);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(26, 827);
            panel3.Name = "panel3";
            panel3.Size = new Size(656, 30);
            panel3.TabIndex = 7;
            // 
            // lblTotalBill
            // 
            lblTotalBill.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotalBill.ForeColor = SystemColors.ActiveCaptionText;
            lblTotalBill.Location = new Point(103, 5);
            lblTotalBill.Name = "lblTotalBill";
            lblTotalBill.Size = new Size(300, 25);
            lblTotalBill.TabIndex = 4;
            lblTotalBill.Text = "Total Bill: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkSlateGray;
            label1.Location = new Point(0, 5);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 3;
            label1.Text = "Total Bill: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DarkSlateGray;
            label2.Location = new Point(276, 16);
            label2.Name = "label2";
            label2.Size = new Size(138, 33);
            label2.TabIndex = 6;
            label2.Text = "Order List";
            // 
            // pnlOrder
            // 
            pnlOrder.AutoScroll = true;
            pnlOrder.Controls.Add(button1);
            pnlOrder.Controls.Add(button8);
            pnlOrder.Controls.Add(button7);
            pnlOrder.Controls.Add(orderTopping2);
            pnlOrder.Controls.Add(orderTopping1);
            pnlOrder.Controls.Add(orderItem2);
            pnlOrder.Controls.Add(orderItem1);
            pnlOrder.Controls.Add(button6);
            pnlOrder.Location = new Point(26, 64);
            pnlOrder.Name = "pnlOrder";
            pnlOrder.Size = new Size(656, 734);
            pnlOrder.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(611, 181);
            button1.Name = "button1";
            button1.Size = new Size(36, 27);
            button1.TabIndex = 14;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.IndianRed;
            button8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.ControlLightLight;
            button8.Location = new Point(611, 123);
            button8.Name = "button8";
            button8.Size = new Size(36, 27);
            button8.TabIndex = 13;
            button8.Text = "X";
            button8.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.IndianRed;
            button7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ControlLightLight;
            button7.Location = new Point(611, 66);
            button7.Name = "button7";
            button7.Size = new Size(36, 27);
            button7.TabIndex = 12;
            button7.Text = "X";
            button7.UseVisualStyleBackColor = false;
            // 
            // orderTopping2
            // 
            orderTopping2.BackColor = Color.Gainsboro;
            orderTopping2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            orderTopping2.Location = new Point(3, 166);
            orderTopping2.Name = "orderTopping2";
            orderTopping2.ProductId = 0;
            orderTopping2.PropName = null;
            orderTopping2.PropPrice = 0D;
            orderTopping2.PropQuantity = 0;
            orderTopping2.Size = new Size(602, 46);
            orderTopping2.TabIndex = 11;
            orderTopping2.ToppingFor = 0;
            // 
            // orderTopping1
            // 
            orderTopping1.BackColor = Color.Gainsboro;
            orderTopping1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            orderTopping1.Location = new Point(3, 114);
            orderTopping1.Name = "orderTopping1";
            orderTopping1.ProductId = 0;
            orderTopping1.PropName = null;
            orderTopping1.PropPrice = 0D;
            orderTopping1.PropQuantity = 0;
            orderTopping1.Size = new Size(602, 46);
            orderTopping1.TabIndex = 9;
            orderTopping1.ToppingFor = 0;
            // 
            // orderItem2
            // 
            orderItem2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            orderItem2.Location = new Point(3, 59);
            orderItem2.Margin = new Padding(3, 4, 3, 4);
            orderItem2.Name = "orderItem2";
            orderItem2.ProductId = 0;
            orderItem2.PropName = null;
            orderItem2.PropOrderNumber = 0;
            orderItem2.PropQuantity = 1;
            orderItem2.PropUnitPrice = 0D;
            orderItem2.Size = new Size(602, 48);
            orderItem2.TabIndex = 8;
            // 
            // orderItem1
            // 
            orderItem1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            orderItem1.Location = new Point(3, 3);
            orderItem1.Margin = new Padding(3, 4, 3, 4);
            orderItem1.Name = "orderItem1";
            orderItem1.ProductId = 0;
            orderItem1.PropName = null;
            orderItem1.PropOrderNumber = 0;
            orderItem1.PropQuantity = 1;
            orderItem1.PropUnitPrice = 0D;
            orderItem1.Size = new Size(602, 48);
            orderItem1.TabIndex = 7;
            // 
            // button6
            // 
            button6.BackColor = Color.IndianRed;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(611, 8);
            button6.Name = "button6";
            button6.Size = new Size(36, 27);
            button6.TabIndex = 4;
            button6.Text = "X";
            button6.UseVisualStyleBackColor = false;
            // 
            // btnPrintBill
            // 
            btnPrintBill.BackColor = Color.SlateGray;
            btnPrintBill.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrintBill.ForeColor = SystemColors.ControlLightLight;
            btnPrintBill.Location = new Point(514, 878);
            btnPrintBill.Name = "btnPrintBill";
            btnPrintBill.Size = new Size(154, 39);
            btnPrintBill.TabIndex = 3;
            btnPrintBill.Text = "PRINT BILL";
            btnPrintBill.UseVisualStyleBackColor = false;
            btnPrintBill.Click += btnPrintBill_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.AutoScroll = true;
            pnlMenu.BackColor = SystemColors.Control;
            pnlMenu.Controls.Add(menuItem6);
            pnlMenu.Controls.Add(menuItem5);
            pnlMenu.Controls.Add(menuItem4);
            pnlMenu.Controls.Add(button5);
            pnlMenu.Controls.Add(menuItem3);
            pnlMenu.Controls.Add(button4);
            pnlMenu.Controls.Add(button3);
            pnlMenu.Controls.Add(menuItem2);
            pnlMenu.Controls.Add(menuItem1);
            pnlMenu.Location = new Point(957, 76);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(947, 857);
            pnlMenu.TabIndex = 2;
            // 
            // menuItem6
            // 
            menuItem6.BackColor = SystemColors.ControlLightLight;
            menuItem6.Location = new Point(730, 3);
            menuItem6.Name = "menuItem6";
            menuItem6.ProductId = 0;
            menuItem6.PropImage = null;
            menuItem6.PropName = null;
            menuItem6.PropPrice = 0D;
            menuItem6.Size = new Size(175, 267);
            menuItem6.TabIndex = 17;
            // 
            // menuItem5
            // 
            menuItem5.BackColor = SystemColors.ControlLightLight;
            menuItem5.Location = new Point(549, 3);
            menuItem5.Name = "menuItem5";
            menuItem5.ProductId = 0;
            menuItem5.PropImage = null;
            menuItem5.PropName = null;
            menuItem5.PropPrice = 0D;
            menuItem5.Size = new Size(175, 267);
            menuItem5.TabIndex = 16;
            // 
            // menuItem4
            // 
            menuItem4.BackColor = SystemColors.ControlLightLight;
            menuItem4.Location = new Point(368, 3);
            menuItem4.Name = "menuItem4";
            menuItem4.ProductId = 0;
            menuItem4.PropImage = null;
            menuItem4.PropName = null;
            menuItem4.PropPrice = 0D;
            menuItem4.Size = new Size(175, 267);
            menuItem4.TabIndex = 15;
            // 
            // button5
            // 
            button5.BackColor = Color.IndianRed;
            button5.ForeColor = SystemColors.ControlLightLight;
            button5.Location = new Point(114, 278);
            button5.Name = "button5";
            button5.Size = new Size(67, 28);
            button5.TabIndex = 14;
            button5.Text = "Add";
            button5.UseVisualStyleBackColor = false;
            // 
            // menuItem3
            // 
            menuItem3.BackColor = SystemColors.ControlLightLight;
            menuItem3.Location = new Point(6, 276);
            menuItem3.Name = "menuItem3";
            menuItem3.ProductId = 0;
            menuItem3.PropImage = null;
            menuItem3.PropName = null;
            menuItem3.PropPrice = 0D;
            menuItem3.Size = new Size(175, 267);
            menuItem3.TabIndex = 13;
            // 
            // button4
            // 
            button4.BackColor = Color.IndianRed;
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(295, 5);
            button4.Name = "button4";
            button4.Size = new Size(67, 28);
            button4.TabIndex = 12;
            button4.Text = "Add";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.IndianRed;
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(114, 5);
            button3.Name = "button3";
            button3.Size = new Size(67, 28);
            button3.TabIndex = 11;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = false;
            // 
            // menuItem2
            // 
            menuItem2.BackColor = SystemColors.ControlLightLight;
            menuItem2.Location = new Point(187, 3);
            menuItem2.Name = "menuItem2";
            menuItem2.ProductId = 0;
            menuItem2.PropImage = null;
            menuItem2.PropName = null;
            menuItem2.PropPrice = 0D;
            menuItem2.Size = new Size(175, 267);
            menuItem2.TabIndex = 10;
            // 
            // menuItem1
            // 
            menuItem1.BackColor = SystemColors.ControlLightLight;
            menuItem1.Location = new Point(6, 3);
            menuItem1.Name = "menuItem1";
            menuItem1.ProductId = 0;
            menuItem1.PropImage = null;
            menuItem1.PropName = null;
            menuItem1.PropPrice = 0D;
            menuItem1.Size = new Size(175, 267);
            menuItem1.TabIndex = 9;
            // 
            // pnlCategory
            // 
            pnlCategory.AutoScroll = true;
            pnlCategory.Controls.Add(button2);
            pnlCategory.Controls.Add(btnAll);
            pnlCategory.Location = new Point(699, 76);
            pnlCategory.Name = "pnlCategory";
            pnlCategory.Size = new Size(258, 965);
            pnlCategory.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = Color.Khaki;
            button2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(82, 105);
            button2.Name = "button2";
            button2.Size = new Size(173, 83);
            button2.TabIndex = 1;
            button2.Text = "All";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnAll
            // 
            btnAll.BackColor = Color.Khaki;
            btnAll.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAll.Location = new Point(82, 16);
            btnAll.Name = "btnAll";
            btnAll.Size = new Size(173, 83);
            btnAll.TabIndex = 0;
            btnAll.Text = "All";
            btnAll.UseVisualStyleBackColor = false;
            // 
            // printPreviewDialogBill
            // 
            printPreviewDialogBill.AutoScrollMargin = new Size(0, 0);
            printPreviewDialogBill.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialogBill.ClientSize = new Size(400, 300);
            printPreviewDialogBill.Enabled = true;
            printPreviewDialogBill.Icon = (Icon)resources.GetObject("printPreviewDialogBill.Icon");
            printPreviewDialogBill.Name = "printPreviewDialogBill";
            printPreviewDialogBill.Visible = false;
            // 
            // printDocumentBill
            // 
            printDocumentBill.PrintPage += printDocumentBill_PrintPage;
            // 
            // EmployeeMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(pnlCategory);
            Controls.Add(pnlMenu);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "EmployeeMenu";
            Text = "Menu Order";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            pnlOrder.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            pnlCategory.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel pnlMenu;
        private Panel pnlCategory;
        private Button btnAll;
        private Button btnPrintBill;
        private Panel pnlOrder;
        private Label label2;
        private Button button6;
        private PrintPreviewDialog printPreviewDialogBill;
        private System.Drawing.Printing.PrintDocument printDocumentBill;
        private Panel panel3;
        private Label lblTotalBill;
        private Label label1;
        private Controls.OrderItem orderItem1;
        private Controls.OrderItem orderItem2;
        private Controls.OrderTopping orderTopping2;
        private Button button1;
        private Button button8;
        private Button button7;
        private Controls.OrderTopping orderTopping1;
        private Controls.MenuItem menuItem6;
        private Controls.MenuItem menuItem5;
        private Controls.MenuItem menuItem4;
        private Button button5;
        private Controls.MenuItem menuItem3;
        private Button button4;
        private Button button3;
        private Controls.MenuItem menuItem2;
        private Controls.MenuItem menuItem1;
        private Button button2;
        private Button btnSaveOrder;
        private Button btnLogOut;
    }
}