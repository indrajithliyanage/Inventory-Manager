namespace Inventory_Managment_System
{
    partial class ManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsers));
            this.panel2 = new System.Windows.Forms.Panel();
            this.HomeBTN = new System.Windows.Forms.Button();
            this.DeleteUserBTN = new System.Windows.Forms.Button();
            this.EditUserBTN = new System.Windows.Forms.Button();
            this.AddUserBTN = new System.Windows.Forms.Button();
            this.mobileNoTB = new System.Windows.Forms.TextBox();
            this.confirmPasswordTB = new System.Windows.Forms.TextBox();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.fullNameTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.UsersGV = new System.Windows.Forms.DataGridView();
            this.userNameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.HomeBTN);
            this.panel2.Controls.Add(this.DeleteUserBTN);
            this.panel2.Controls.Add(this.EditUserBTN);
            this.panel2.Controls.Add(this.AddUserBTN);
            this.panel2.Controls.Add(this.mobileNoTB);
            this.panel2.Controls.Add(this.confirmPasswordTB);
            this.panel2.Controls.Add(this.passwordTB);
            this.panel2.Controls.Add(this.fullNameTB);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.userNameTB);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 391);
            this.panel2.TabIndex = 1;
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
            this.HomeBTN.Click += new System.EventHandler(this.button4_Click);
            // 
            // DeleteUserBTN
            // 
            this.DeleteUserBTN.BackColor = System.Drawing.Color.Red;
            this.DeleteUserBTN.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteUserBTN.Location = new System.Drawing.Point(379, 239);
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
            this.EditUserBTN.Location = new System.Drawing.Point(379, 173);
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
            this.AddUserBTN.Location = new System.Drawing.Point(379, 109);
            this.AddUserBTN.Name = "AddUserBTN";
            this.AddUserBTN.Size = new System.Drawing.Size(120, 44);
            this.AddUserBTN.TabIndex = 10;
            this.AddUserBTN.Text = "Add";
            this.AddUserBTN.UseVisualStyleBackColor = false;
            this.AddUserBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // mobileNoTB
            // 
            this.mobileNoTB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobileNoTB.Location = new System.Drawing.Point(60, 342);
            this.mobileNoTB.Name = "mobileNoTB";
            this.mobileNoTB.Size = new System.Drawing.Size(297, 30);
            this.mobileNoTB.TabIndex = 9;
            this.mobileNoTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // confirmPasswordTB
            // 
            this.confirmPasswordTB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordTB.Location = new System.Drawing.Point(60, 275);
            this.confirmPasswordTB.Name = "confirmPasswordTB";
            this.confirmPasswordTB.Size = new System.Drawing.Size(297, 30);
            this.confirmPasswordTB.TabIndex = 8;
            this.confirmPasswordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.confirmPasswordTB.UseSystemPasswordChar = true;
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.Location = new System.Drawing.Point(60, 198);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(297, 30);
            this.passwordTB.TabIndex = 7;
            this.passwordTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTB.UseSystemPasswordChar = true;
            // 
            // fullNameTB
            // 
            this.fullNameTB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameTB.Location = new System.Drawing.Point(60, 123);
            this.fullNameTB.Name = "fullNameTB";
            this.fullNameTB.Size = new System.Drawing.Size(297, 30);
            this.fullNameTB.TabIndex = 6;
            this.fullNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(56, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 22);
            this.label7.TabIndex = 5;
            this.label7.Text = "Confirm Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(56, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 22);
            this.label6.TabIndex = 3;
            this.label6.Text = "Mobile Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(56, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(56, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Full Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Courier New", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(380, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 31);
            this.label1.TabIndex = 10;
            this.label1.Text = "Manage Users";
            // 
            // UsersGV
            // 
            this.UsersGV.AllowUserToAddRows = false;
            this.UsersGV.AllowUserToDeleteRows = false;
            this.UsersGV.AllowUserToResizeColumns = false;
            this.UsersGV.AllowUserToResizeRows = false;
            this.UsersGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.UsersGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersGV.Location = new System.Drawing.Point(602, 67);
            this.UsersGV.Name = "UsersGV";
            this.UsersGV.ReadOnly = true;
            this.UsersGV.RowHeadersVisible = false;
            this.UsersGV.RowHeadersWidth = 51;
            this.UsersGV.RowTemplate.Height = 24;
            this.UsersGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersGV.Size = new System.Drawing.Size(352, 391);
            this.UsersGV.TabIndex = 11;
            this.UsersGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersGV_CellClick);
            // 
            // userNameTB
            // 
            this.userNameTB.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTB.Location = new System.Drawing.Point(60, 53);
            this.userNameTB.Name = "userNameTB";
            this.userNameTB.Size = new System.Drawing.Size(297, 30);
            this.userNameTB.TabIndex = 4;
            this.userNameTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(56, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "UserName";
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 470);
            this.Controls.Add(this.UsersGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Courier New", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ManageUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsersGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox mobileNoTB;
        private System.Windows.Forms.TextBox confirmPasswordTB;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.TextBox fullNameTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddUserBTN;
        private System.Windows.Forms.Button HomeBTN;
        private System.Windows.Forms.Button DeleteUserBTN;
        private System.Windows.Forms.Button EditUserBTN;
        private System.Windows.Forms.DataGridView UsersGV;
        private System.Windows.Forms.TextBox userNameTB;
        private System.Windows.Forms.Label label3;
    }
}