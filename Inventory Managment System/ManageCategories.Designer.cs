namespace Inventory_Managment_System
{
    partial class ManageCategories
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageCategories));
            this.CategoriesGV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HomeBTN = new System.Windows.Forms.Button();
            this.DeleteUserBTN = new System.Windows.Forms.Button();
            this.EditUserBTN = new System.Windows.Forms.Button();
            this.AddUserBTN = new System.Windows.Forms.Button();
            this.categoryNameTB = new System.Windows.Forms.TextBox();
            this.categoryIDTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGV)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CategoriesGV
            // 
            this.CategoriesGV.AllowUserToAddRows = false;
            this.CategoriesGV.AllowUserToDeleteRows = false;
            this.CategoriesGV.AllowUserToResizeColumns = false;
            this.CategoriesGV.AllowUserToResizeRows = false;
            this.CategoriesGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CategoriesGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.CategoriesGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriesGV.Location = new System.Drawing.Point(598, 64);
            this.CategoriesGV.Name = "CategoriesGV";
            this.CategoriesGV.ReadOnly = true;
            this.CategoriesGV.RowHeadersVisible = false;
            this.CategoriesGV.RowHeadersWidth = 51;
            this.CategoriesGV.RowTemplate.Height = 24;
            this.CategoriesGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CategoriesGV.Size = new System.Drawing.Size(352, 391);
            this.CategoriesGV.TabIndex = 16;
            this.CategoriesGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CategoriesGV_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.HomeBTN);
            this.panel2.Controls.Add(this.DeleteUserBTN);
            this.panel2.Controls.Add(this.EditUserBTN);
            this.panel2.Controls.Add(this.AddUserBTN);
            this.panel2.Controls.Add(this.categoryNameTB);
            this.panel2.Controls.Add(this.categoryIDTB);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(32, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(518, 332);
            this.panel2.TabIndex = 15;
            // 
            // HomeBTN
            // 
            this.HomeBTN.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.HomeBTN.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeBTN.Location = new System.Drawing.Point(197, 276);
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
            this.DeleteUserBTN.Location = new System.Drawing.Point(348, 199);
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
            this.EditUserBTN.Location = new System.Drawing.Point(197, 199);
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
            this.AddUserBTN.Location = new System.Drawing.Point(50, 199);
            this.AddUserBTN.Name = "AddUserBTN";
            this.AddUserBTN.Size = new System.Drawing.Size(120, 44);
            this.AddUserBTN.TabIndex = 10;
            this.AddUserBTN.Text = "Add";
            this.AddUserBTN.UseVisualStyleBackColor = false;
            this.AddUserBTN.Click += new System.EventHandler(this.AddUserBTN_Click);
            // 
            // categoryNameTB
            // 
            this.categoryNameTB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryNameTB.Location = new System.Drawing.Point(106, 111);
            this.categoryNameTB.Name = "categoryNameTB";
            this.categoryNameTB.Size = new System.Drawing.Size(297, 30);
            this.categoryNameTB.TabIndex = 6;
            this.categoryNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // categoryIDTB
            // 
            this.categoryIDTB.Enabled = false;
            this.categoryIDTB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryIDTB.Location = new System.Drawing.Point(106, 41);
            this.categoryIDTB.Name = "categoryIDTB";
            this.categoryIDTB.Size = new System.Drawing.Size(297, 30);
            this.categoryIDTB.TabIndex = 4;
            this.categoryIDTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(102, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Category Name";
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
            this.label3.Text = "Category ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Courier New", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "Manage Categories";
            // 
            // ManageCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(982, 470);
            this.Controls.Add(this.CategoriesGV);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ManageCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCategories";
            this.Load += new System.EventHandler(this.ManageCategories_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriesGV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CategoriesGV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button HomeBTN;
        private System.Windows.Forms.Button DeleteUserBTN;
        private System.Windows.Forms.Button EditUserBTN;
        private System.Windows.Forms.Button AddUserBTN;
        private System.Windows.Forms.TextBox categoryNameTB;
        private System.Windows.Forms.TextBox categoryIDTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}