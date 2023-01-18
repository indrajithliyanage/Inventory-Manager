namespace Inventory_Managment_System
{
    partial class ManageProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageProducts));
            this.label1 = new System.Windows.Forms.Label();
            this.ProductsGV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productPriceNUD = new System.Windows.Forms.NumericUpDown();
            this.productQuantityNUD = new System.Windows.Forms.NumericUpDown();
            this.productCategoryCB = new System.Windows.Forms.ComboBox();
            this.HomeBTN = new System.Windows.Forms.Button();
            this.deleteProductBTN = new System.Windows.Forms.Button();
            this.editProductBTN = new System.Windows.Forms.Button();
            this.addProductBTN = new System.Windows.Forms.Button();
            this.productDescriptionTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.productNameTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchCB = new System.Windows.Forms.ComboBox();
            this.resetBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPriceNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantityNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Courier New", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(454, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 31);
            this.label1.TabIndex = 15;
            this.label1.Text = "Manage Products";
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
            this.ProductsGV.Location = new System.Drawing.Point(602, 120);
            this.ProductsGV.Name = "ProductsGV";
            this.ProductsGV.ReadOnly = true;
            this.ProductsGV.RowHeadersVisible = false;
            this.ProductsGV.RowHeadersWidth = 51;
            this.ProductsGV.RowTemplate.Height = 24;
            this.ProductsGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsGV.Size = new System.Drawing.Size(491, 338);
            this.ProductsGV.TabIndex = 17;
            this.ProductsGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGV_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.productPriceNUD);
            this.panel2.Controls.Add(this.productQuantityNUD);
            this.panel2.Controls.Add(this.productCategoryCB);
            this.panel2.Controls.Add(this.HomeBTN);
            this.panel2.Controls.Add(this.deleteProductBTN);
            this.panel2.Controls.Add(this.editProductBTN);
            this.panel2.Controls.Add(this.addProductBTN);
            this.panel2.Controls.Add(this.productDescriptionTB);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.productNameTB);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 391);
            this.panel2.TabIndex = 16;
            // 
            // productPriceNUD
            // 
            this.productPriceNUD.DecimalPlaces = 2;
            this.productPriceNUD.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceNUD.Location = new System.Drawing.Point(60, 198);
            this.productPriceNUD.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.productPriceNUD.Name = "productPriceNUD";
            this.productPriceNUD.Size = new System.Drawing.Size(297, 30);
            this.productPriceNUD.TabIndex = 16;
            this.productPriceNUD.ThousandsSeparator = true;
            // 
            // productQuantityNUD
            // 
            this.productQuantityNUD.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productQuantityNUD.Location = new System.Drawing.Point(60, 123);
            this.productQuantityNUD.Name = "productQuantityNUD";
            this.productQuantityNUD.Size = new System.Drawing.Size(297, 30);
            this.productQuantityNUD.TabIndex = 15;
            this.productQuantityNUD.ThousandsSeparator = true;
            // 
            // productCategoryCB
            // 
            this.productCategoryCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.productCategoryCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productCategoryCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productCategoryCB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productCategoryCB.Location = new System.Drawing.Point(60, 336);
            this.productCategoryCB.Name = "productCategoryCB";
            this.productCategoryCB.Size = new System.Drawing.Size(297, 30);
            this.productCategoryCB.TabIndex = 18;
            this.productCategoryCB.DropDown += new System.EventHandler(this.productCategoryCB_DropDown);
            this.productCategoryCB.DropDownClosed += new System.EventHandler(this.productCategoryCB_DropDownClosed);
            // 
            // HomeBTN
            // 
            this.HomeBTN.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.HomeBTN.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBTN.Location = new System.Drawing.Point(379, 328);
            this.HomeBTN.Name = "HomeBTN";
            this.HomeBTN.Size = new System.Drawing.Size(120, 44);
            this.HomeBTN.TabIndex = 13;
            this.HomeBTN.Text = "Home";
            this.HomeBTN.UseVisualStyleBackColor = false;
            this.HomeBTN.Click += new System.EventHandler(this.HomeBTN_Click);
            // 
            // deleteProductBTN
            // 
            this.deleteProductBTN.BackColor = System.Drawing.Color.Red;
            this.deleteProductBTN.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteProductBTN.Location = new System.Drawing.Point(379, 239);
            this.deleteProductBTN.Name = "deleteProductBTN";
            this.deleteProductBTN.Size = new System.Drawing.Size(120, 44);
            this.deleteProductBTN.TabIndex = 12;
            this.deleteProductBTN.Text = "Delete";
            this.deleteProductBTN.UseVisualStyleBackColor = false;
            this.deleteProductBTN.Click += new System.EventHandler(this.deleteProductBTN_Click);
            // 
            // editProductBTN
            // 
            this.editProductBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.editProductBTN.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProductBTN.Location = new System.Drawing.Point(379, 173);
            this.editProductBTN.Name = "editProductBTN";
            this.editProductBTN.Size = new System.Drawing.Size(120, 44);
            this.editProductBTN.TabIndex = 11;
            this.editProductBTN.Text = "Edit";
            this.editProductBTN.UseVisualStyleBackColor = false;
            this.editProductBTN.Click += new System.EventHandler(this.editProductBTN_Click);
            // 
            // addProductBTN
            // 
            this.addProductBTN.BackColor = System.Drawing.Color.Lime;
            this.addProductBTN.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductBTN.Location = new System.Drawing.Point(379, 109);
            this.addProductBTN.Name = "addProductBTN";
            this.addProductBTN.Size = new System.Drawing.Size(120, 44);
            this.addProductBTN.TabIndex = 10;
            this.addProductBTN.Text = "Add";
            this.addProductBTN.UseVisualStyleBackColor = false;
            this.addProductBTN.Click += new System.EventHandler(this.AddUserBTN_Click);
            // 
            // productDescriptionTB
            // 
            this.productDescriptionTB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productDescriptionTB.Location = new System.Drawing.Point(60, 275);
            this.productDescriptionTB.Name = "productDescriptionTB";
            this.productDescriptionTB.Size = new System.Drawing.Size(297, 30);
            this.productDescriptionTB.TabIndex = 17;
            this.productDescriptionTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(56, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "Description";
            // 
            // productNameTB
            // 
            this.productNameTB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameTB.Location = new System.Drawing.Point(60, 53);
            this.productNameTB.Name = "productNameTB";
            this.productNameTB.Size = new System.Drawing.Size(297, 30);
            this.productNameTB.TabIndex = 14;
            this.productNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(56, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Product Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(56, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Product Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(56, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Product Name";
            // 
            // searchCB
            // 
            this.searchCB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchCB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchCB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCB.Location = new System.Drawing.Point(677, 67);
            this.searchCB.Name = "searchCB";
            this.searchCB.Size = new System.Drawing.Size(297, 30);
            this.searchCB.TabIndex = 19;
            this.searchCB.DropDown += new System.EventHandler(this.searchCB_DropDown);
            this.searchCB.SelectionChangeCommitted += new System.EventHandler(this.searchCB_SelectionChangeCommitted);
            this.searchCB.DropDownClosed += new System.EventHandler(this.searchCB_DropDownClosed);
            // 
            // resetBTN
            // 
            this.resetBTN.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.resetBTN.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetBTN.Location = new System.Drawing.Point(982, 67);
            this.resetBTN.Name = "resetBTN";
            this.resetBTN.Size = new System.Drawing.Size(111, 30);
            this.resetBTN.TabIndex = 19;
            this.resetBTN.Text = "Reset";
            this.resetBTN.UseVisualStyleBackColor = false;
            this.resetBTN.Click += new System.EventHandler(this.resetBTN_Click);
            // 
            // ManageProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1114, 470);
            this.Controls.Add(this.resetBTN);
            this.Controls.Add(this.searchCB);
            this.Controls.Add(this.ProductsGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "ManageProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageProducts";
            this.Load += new System.EventHandler(this.ManageProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productPriceNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productQuantityNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView ProductsGV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox productCategoryCB;
        private System.Windows.Forms.Button HomeBTN;
        private System.Windows.Forms.Button deleteProductBTN;
        private System.Windows.Forms.Button editProductBTN;
        private System.Windows.Forms.Button addProductBTN;
        private System.Windows.Forms.TextBox productDescriptionTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox productNameTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown productQuantityNUD;
        private System.Windows.Forms.NumericUpDown productPriceNUD;
        private System.Windows.Forms.ComboBox searchCB;
        private System.Windows.Forms.Button resetBTN;
    }
}