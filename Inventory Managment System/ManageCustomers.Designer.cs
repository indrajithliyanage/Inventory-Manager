namespace Inventory_Managment_System
{
    partial class ManageCustomers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCustomers));
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HomeBTN = new System.Windows.Forms.Button();
            this.DeleteUserBTN = new System.Windows.Forms.Button();
            this.EditUserBTN = new System.Windows.Forms.Button();
            this.AddUserBTN = new System.Windows.Forms.Button();
            this.mobileNoTB = new System.Windows.Forms.TextBox();
            this.fullNameTB = new System.Windows.Forms.TextBox();
            this.userIDTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomersGV = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Courier New", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Manage Customers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.HomeBTN);
            this.panel2.Controls.Add(this.DeleteUserBTN);
            this.panel2.Controls.Add(this.EditUserBTN);
            this.panel2.Controls.Add(this.AddUserBTN);
            this.panel2.Controls.Add(this.mobileNoTB);
            this.panel2.Controls.Add(this.fullNameTB);
            this.panel2.Controls.Add(this.userIDTB);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(34, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 391);
            this.panel2.TabIndex = 12;
            // 
            // HomeBTN
            // 
            this.HomeBTN.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.HomeBTN.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBTN.Location = new System.Drawing.Point(197, 328);
            this.HomeBTN.Name = "HomeBTN";
            this.HomeBTN.Size = new System.Drawing.Size(120, 44);
            this.HomeBTN.TabIndex = 13;
            this.HomeBTN.Text = "Home";
            this.HomeBTN.UseVisualStyleBackColor = false;
            this.HomeBTN.Click += new System.EventHandler(this.HomeBTN_Click);
            // 
            // DeleteUserBTN
            // 
            this.DeleteUserBTN.BackColor = System.Drawing.Color.Red;
            this.DeleteUserBTN.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUserBTN.Location = new System.Drawing.Point(348, 251);
            this.DeleteUserBTN.Name = "DeleteUserBTN";
            this.DeleteUserBTN.Size = new System.Drawing.Size(120, 44);
            this.DeleteUserBTN.TabIndex = 12;
            this.DeleteUserBTN.Text = "Delete";
            this.DeleteUserBTN.UseVisualStyleBackColor = false;
            this.DeleteUserBTN.Click += new System.EventHandler(this.DeleteUserBTN_Click);
            // 
            // EditUserBTN
            // 
            this.EditUserBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.EditUserBTN.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditUserBTN.Location = new System.Drawing.Point(197, 251);
            this.EditUserBTN.Name = "EditUserBTN";
            this.EditUserBTN.Size = new System.Drawing.Size(120, 44);
            this.EditUserBTN.TabIndex = 11;
            this.EditUserBTN.Text = "Edit";
            this.EditUserBTN.UseVisualStyleBackColor = false;
            this.EditUserBTN.Click += new System.EventHandler(this.EditUserBTN_Click);
            // 
            // AddUserBTN
            // 
            this.AddUserBTN.BackColor = System.Drawing.Color.Lime;
            this.AddUserBTN.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserBTN.Location = new System.Drawing.Point(50, 251);
            this.AddUserBTN.Name = "AddUserBTN";
            this.AddUserBTN.Size = new System.Drawing.Size(120, 44);
            this.AddUserBTN.TabIndex = 10;
            this.AddUserBTN.Text = "Add";
            this.AddUserBTN.UseVisualStyleBackColor = false;
            this.AddUserBTN.Click += new System.EventHandler(this.AddUserBTN_Click);
            // 
            // mobileNoTB
            // 
            this.mobileNoTB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileNoTB.Location = new System.Drawing.Point(106, 192);
            this.mobileNoTB.Name = "mobileNoTB";
            this.mobileNoTB.Size = new System.Drawing.Size(297, 30);
            this.mobileNoTB.TabIndex = 9;
            this.mobileNoTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fullNameTB
            // 
            this.fullNameTB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameTB.Location = new System.Drawing.Point(106, 111);
            this.fullNameTB.Name = "fullNameTB";
            this.fullNameTB.Size = new System.Drawing.Size(297, 30);
            this.fullNameTB.TabIndex = 6;
            this.fullNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // userIDTB
            // 
            this.userIDTB.Enabled = false;
            this.userIDTB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIDTB.Location = new System.Drawing.Point(106, 41);
            this.userIDTB.Name = "userIDTB";
            this.userIDTB.Size = new System.Drawing.Size(297, 30);
            this.userIDTB.TabIndex = 4;
            this.userIDTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userIDTB.TextChanged += new System.EventHandler(this.userNameTB_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(102, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mobile Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(102, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Full Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(102, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Customer ID";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.CustomersGV.Location = new System.Drawing.Point(600, 58);
            this.CustomersGV.Name = "CustomersGV";
            this.CustomersGV.ReadOnly = true;
            this.CustomersGV.RowHeadersVisible = false;
            this.CustomersGV.RowHeadersWidth = 51;
            this.CustomersGV.RowTemplate.Height = 24;
            this.CustomersGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomersGV.Size = new System.Drawing.Size(352, 391);
            this.CustomersGV.TabIndex = 13;
            this.CustomersGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomersGV_CellClick);
            // 
            // ManageCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 470);
            this.Controls.Add(this.CustomersGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ManageCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCustomers";
            this.Load += new System.EventHandler(this.ManageCustomers_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button HomeBTN;
        private System.Windows.Forms.Button DeleteUserBTN;
        private System.Windows.Forms.Button EditUserBTN;
        private System.Windows.Forms.Button AddUserBTN;
        private System.Windows.Forms.TextBox mobileNoTB;
        private System.Windows.Forms.TextBox fullNameTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView CustomersGV;
        private System.Windows.Forms.TextBox userIDTB;
        private System.Windows.Forms.Label label3;
    }
}