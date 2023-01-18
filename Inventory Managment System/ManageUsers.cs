using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Managment_System
{
    public partial class ManageUsers : Form
    {
        private readonly SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\indra\OneDrive\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        public ManageUsers()
        {
            InitializeComponent();
        }

        private async Task PopulateGrid()
        {
            try
            {
                connection.Open();
                string gridViewQuery = "SELECT UserID,UserName,FullName,Password,Phone FROM UserTBL";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(gridViewQuery, connection);
                var dataSet = new DataSet();
                await Task.Run(() => dataAdapter.Fill(dataSet));
                UsersGV.DataSource = dataSet.Tables[0];
                UsersGV.Columns["UserID"].Visible = false;
                UsersGV.Columns["Password"].Visible = false;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error Occured!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (userNameTB.Text != "" && fullNameTB.Text != "" && passwordTB.Text != "" && confirmPasswordTB.Text != "" && mobileNoTB.Text != "")
            {
                if (passwordTB.Text == confirmPasswordTB.Text)
                {
                    SqlCommand command = new SqlCommand(String.Format("INSERT INTO UserTBL (UserName,FullName,Password,Phone) VALUES ('{0}','{1}','{2}','{3}');", userNameTB.Text, fullNameTB.Text, passwordTB.Text, mobileNoTB.Text), connection);
                    try
                    {
                        ExecuteCommand(command, "insert");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unexpected Error Occured!");
                    }
                }
                else
                {
                    {
                        MessageBox.Show("Passwords don't match... Please Check!");
                    }
                }
            }
            else
            {
                MessageBox.Show("All fields need to be filled...");
            }
        }

        private async void ManageUsers_Load(object sender, EventArgs e)
        {
            await PopulateGrid();
        }

        private async void DeleteUserBTN_Click(object sender, EventArgs e)
        {
            if (mobileNoTB.Text != "")
            {
                try
                {
                    connection.Open();
                    string deleteUserQuery = "DELETE FROM UserTBL WHERE Phone = '" + mobileNoTB.Text + "'";
                    SqlCommand command = new SqlCommand(deleteUserQuery, connection);
                    int rows = command.ExecuteNonQuery();
                    connection.Close();
                    await PopulateGrid();
                    if (rows > 0)
                    {
                        userNameTB.Text = "";
                        fullNameTB.Text = "";
                        mobileNoTB.Text = "";
                                MessageBox.Show("User Deleted!");
                    }
                    else
                    {
                        MessageBox.Show("No Records Deleted... Please Check Again!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected Error Occured!");
                }
            }
            else
            {
                MessageBox.Show("Enter the Mobile Number to Delete!");
            }
        }

        private void UsersGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (UsersGV.SelectedRows.Count != 0)
            {
                userNameTB.Text = UsersGV.SelectedRows[0].Cells[1].Value.ToString();
                fullNameTB.Text = UsersGV.SelectedRows[0].Cells[2].Value.ToString();
                passwordTB.Text = UsersGV.SelectedRows[0].Cells[3].Value.ToString();
                confirmPasswordTB.Text = UsersGV.SelectedRows[0].Cells[3].Value.ToString();
                mobileNoTB.Text = UsersGV.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void EditUserBTN_Click(object sender, EventArgs e)
        {
            if(userNameTB.Text == "" && fullNameTB.Text == "" && passwordTB.Text == "" && confirmPasswordTB.Text == "" && mobileNoTB.Text == "")
            {
                MessageBox.Show("Select a Record to Update");
            }
            else
            {
                if (passwordTB.Text == confirmPasswordTB.Text)
                {
                    try
                    {
                        int userID = Convert.ToInt32(UsersGV.SelectedRows[0].Cells[0].Value);
                        SqlCommand command = new SqlCommand(String.Format("UPDATE UserTBL SET UserName = '{0}', FullName = '{1}', Password = '{2}', Phone = '{3}' WHERE UserID = {4}", userNameTB.Text, fullNameTB.Text, passwordTB.Text, mobileNoTB.Text, userID), connection);
                        ExecuteCommand(command, "update");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unexpected Error Occured!");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords don't match... Please Check!");
                }
            }
        }

        private async void ExecuteCommand(SqlCommand command,string type)
        {
            connection.Open();
            int rowsChanged = command.ExecuteNonQuery();
            connection.Close();
            await PopulateGrid();
            userNameTB.Text = "";
            fullNameTB.Text = "";
            passwordTB.Text = "";
            confirmPasswordTB.Text = "";
            mobileNoTB.Text = "";
            if(rowsChanged > 0)
            {
                if (type == "insert")
                {
                    MessageBox.Show("User Added Succesfully!");
                }
                else if (type == "update")
                {
                    MessageBox.Show("User Updated Succesfully!");
                }
            }
        }
    }
}