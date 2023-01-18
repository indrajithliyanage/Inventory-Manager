namespace Inventory_Managment_System
{
    partial class ManageOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageOrders));
            this.label1 = new System.Windows.Forms.Label();
            this.CustomersGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductsGV = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.insertOrderBTN = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.customerIDTB = new System.Windows.Forms.TextBox();
            this.viewOrderBTN = new System.Windows.Forms.Button();
            this.deleteProductBTN = new System.Windows.Forms.Button();
            this.orderIDTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.HomeBTN = new System.Windows.Forms.Button();
            this.addOrderBTN = new System.Windows.Forms.Button();
            this.ordersGV = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.quantityNUD = new System.Windows.Forms.NumericUpDown();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.grandTotalLBL = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNUD)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Courier New", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(449, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Manage Orders";
            // 
            // CustomersGV
            // 
            this.CustomersGV.AllowUserToAddRows = false;
            this.CustomersGV.AllowUserToDeleteRows = false;
            this.CustomersGV.AllowUserToResizeColumns = false;
            this.CustomersGV.AllowUserToResizeRows = false;
            this.CustomersGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomersGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CustomersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersGV.Location = new System.Drawing.Point(12, 120);
            this.CustomersGV.Name = "CustomersGV";
            this.CustomersGV.ReadOnly = true;
            this.CustomersGV.RowHeadersVisible = false;
            this.CustomersGV.RowHeadersWidth = 51;
            this.CustomersGV.RowTemplate.Height = 24;
            this.CustomersGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomersGV.Size = new System.Drawing.Size(491, 174);
            this.CustomersGV.TabIndex = 18;
            this.CustomersGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersGV_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Font = new System.Drawing.Font("Courier New", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(145, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 31);
            this.label2.TabIndex = 19;
            this.label2.Text = "Customer List";
            // 
            // ProductsGV
            // 
            this.ProductsGV.AllowUserToAddRows = false;
            this.ProductsGV.AllowUserToDeleteRows = false;
            this.ProductsGV.AllowUserToResizeColumns = false;
            this.ProductsGV.AllowUserToResizeRows = false;
            this.ProductsGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductsGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ProductsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGV.Location = new System.Drawing.Point(584, 120);
            this.ProductsGV.Name = "ProductsGV";
            this.ProductsGV.ReadOnly = true;
            this.ProductsGV.RowHeadersVisible = false;
            this.ProductsGV.RowHeadersWidth = 51;
            this.ProductsGV.RowTemplate.Height = 24;
            this.ProductsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsGV.Size = new System.Drawing.Size(491, 174);
            this.ProductsGV.TabIndex = 20;
            this.ProductsGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGV_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Font = new System.Drawing.Font("Courier New", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(729, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 31);
            this.label3.TabIndex = 21;
            this.label3.Text = "Product List";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.insertOrderBTN);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.customerIDTB);
            this.panel2.Controls.Add(this.viewOrderBTN);
            this.panel2.Controls.Add(this.deleteProductBTN);
            this.panel2.Controls.Add(this.orderIDTB);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(215, 300);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 219);
            this.panel2.TabIndex = 22;
            // 
            // insertOrderBTN
            // 
            this.insertOrderBTN.BackColor = System.Drawing.Color.BlueViolet;
            this.insertOrderBTN.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertOrderBTN.Location = new System.Drawing.Point(56, 105);
            this.insertOrderBTN.Name = "insertOrderBTN";
            this.insertOrderBTN.Size = new System.Drawing.Size(120, 63);
            this.insertOrderBTN.TabIndex = 19;
            this.insertOrderBTN.Text = "Insert Order";
            this.insertOrderBTN.UseVisualStyleBackColor = false;
            this.insertOrderBTN.Click += new System.EventHandler(this.insertOrderBTN_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "\"yyyy-MM-dd\"";
            this.dateTimePicker1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(404, 119);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 30);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // customerIDTB
            // 
            this.customerIDTB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerIDTB.Location = new System.Drawing.Point(331, 49);
            this.customerIDTB.Name = "customerIDTB";
            this.customerIDTB.Size = new System.Drawing.Size(297, 30);
            this.customerIDTB.TabIndex = 15;
            this.customerIDTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // viewOrderBTN
            // 
            this.viewOrderBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.viewOrderBTN.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewOrderBTN.Location = new System.Drawing.Point(196, 105);
            this.viewOrderBTN.Name = "viewOrderBTN";
            this.viewOrderBTN.Size = new System.Drawing.Size(120, 63);
            this.viewOrderBTN.TabIndex = 11;
            this.viewOrderBTN.Text = "View Order";
            this.viewOrderBTN.UseVisualStyleBackColor = false;
            this.viewOrderBTN.Click += new System.EventHandler(this.viewOrderBTN_Click);
            // 
            // deleteProductBTN
            // 
            this.deleteProductBTN.BackColor = System.Drawing.Color.Red;
            this.deleteProductBTN.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProductBTN.Location = new System.Drawing.Point(508, 172);
            this.deleteProductBTN.Name = "deleteProductBTN";
            this.deleteProductBTN.Size = new System.Drawing.Size(120, 44);
            this.deleteProductBTN.TabIndex = 12;
            this.deleteProductBTN.Text = "Delete";
            this.deleteProductBTN.UseVisualStyleBackColor = false;
            this.deleteProductBTN.Click += new System.EventHandler(this.deleteProductBTN_Click);
            // 
            // orderIDTB
            // 
            this.orderIDTB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderIDTB.Location = new System.Drawing.Point(19, 49);
            this.orderIDTB.Name = "orderIDTB";
            this.orderIDTB.Size = new System.Drawing.Size(297, 30);
            this.orderIDTB.TabIndex = 14;
            this.orderIDTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(498, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Order Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(486, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Customer ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(210, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "Order ID";
            // 
            // HomeBTN
            // 
            this.HomeBTN.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.HomeBTN.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBTN.Location = new System.Drawing.Point(908, 383);
            this.HomeBTN.Name = "HomeBTN";
            this.HomeBTN.Size = new System.Drawing.Size(120, 44);
            this.HomeBTN.TabIndex = 13;
            this.HomeBTN.Text = "Home";
            this.HomeBTN.UseVisualStyleBackColor = false;
            this.HomeBTN.Click += new System.EventHandler(this.HomeBTN_Click);
            // 
            // addOrderBTN
            // 
            this.addOrderBTN.BackColor = System.Drawing.Color.Lime;
            this.addOrderBTN.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrderBTN.Location = new System.Drawing.Point(28, 112);
            this.addOrderBTN.Name = "addOrderBTN";
            this.addOrderBTN.Size = new System.Drawing.Size(120, 44);
            this.addOrderBTN.TabIndex = 10;
            this.addOrderBTN.Text = "Add";
            this.addOrderBTN.UseVisualStyleBackColor = false;
            this.addOrderBTN.Click += new System.EventHandler(this.addOrderBTN_Click);
            // 
            // ordersGV
            // 
            this.ordersGV.AllowUserToAddRows = false;
            this.ordersGV.AllowUserToDeleteRows = false;
            this.ordersGV.AllowUserToResizeColumns = false;
            this.ordersGV.AllowUserToResizeRows = false;
            this.ordersGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ordersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGV.Location = new System.Drawing.Point(12, 525);
            this.ordersGV.Name = "ordersGV";
            this.ordersGV.RowHeadersWidth = 51;
            this.ordersGV.RowTemplate.Height = 24;
            this.ordersGV.Size = new System.Drawing.Size(850, 184);
            this.ordersGV.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(34, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 22);
            this.label7.TabIndex = 18;
            this.label7.Text = "Quantity";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.quantityNUD);
            this.panel1.Controls.Add(this.addOrderBTN);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(27, 324);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 169);
            this.panel1.TabIndex = 24;
            // 
            // quantityNUD
            // 
            this.quantityNUD.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityNUD.Location = new System.Drawing.Point(28, 70);
            this.quantityNUD.Name = "quantityNUD";
            this.quantityNUD.Size = new System.Drawing.Size(120, 30);
            this.quantityNUD.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.grandTotalLBL);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(908, 612);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 97);
            this.panel3.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(14, 60);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label9.Size = new System.Drawing.Size(46, 23);
            this.label9.TabIndex = 28;
            this.label9.Text = "Rs.";
            // 
            // grandTotalLBL
            // 
            this.grandTotalLBL.AutoSize = true;
            this.grandTotalLBL.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.grandTotalLBL.Font = new System.Drawing.Font("Courier New", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandTotalLBL.Location = new System.Drawing.Point(66, 60);
            this.grandTotalLBL.Name = "grandTotalLBL";
            this.grandTotalLBL.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grandTotalLBL.Size = new System.Drawing.Size(58, 23);
            this.grandTotalLBL.TabIndex = 27;
            this.grandTotalLBL.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(10, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "Grand Total";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(926, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 44);
            this.button1.TabIndex = 27;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // ManageOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1091, 721);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ordersGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.HomeBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductsGV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomersGV);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ManageOrders";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageOrders";
            this.Load += new System.EventHandler(this.ManageOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantityNUD)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CustomersGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView ProductsGV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox customerIDTB;
        private System.Windows.Forms.Button HomeBTN;
        private System.Windows.Forms.Button deleteProductBTN;
        private System.Windows.Forms.Button viewOrderBTN;
        private System.Windows.Forms.Button addOrderBTN;
        private System.Windows.Forms.TextBox orderIDTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView ordersGV;
        private System.Windows.Forms.Button insertOrderBTN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown quantityNUD;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label grandTotalLBL;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}