using System;
using System.Windows.Forms;

namespace Inventory_Managment_System
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void showPasswordCB_CheckedChanged(object sender, EventArgs e)
        {
            if (showPasswordCB.Checked == true)
            {
                passwordTB.UseSystemPasswordChar = false;
            }
            else
            {
                passwordTB.UseSystemPasswordChar = true;
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            userNameTB.Text = string.Empty;
            passwordTB.Text = string.Empty;
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (userNameTB.Text == "admin" && passwordTB.Text == "pass")
            {
                this.Hide();
                Home home = new Home();
                home.Show();
            }
        }
    }
}