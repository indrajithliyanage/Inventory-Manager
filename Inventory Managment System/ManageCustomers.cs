using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Managment_System
{
    public partial class ManageCustomers : Form
    {
        private readonly SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\indra\OneDrive\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        public ManageCustomers()
        {
            InitializeComponent();
        }

        private async Task PopulateGrid()
        {
            try
            {
                connection.Open();
                string gridViewQuery = "SELECT * FROM CustomerTBL";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(gridViewQuery, connection);
                var dataSet = new DataSet();
                await Task.Run(() => dataAdapter.Fill(dataSet));
                CustomersGV.DataSource = dataSet.Tables[0];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error Occured!");
            }
        }

        private async void ExecuteCommand(SqlCommand command, string type)
        {
            connection.Open();
            int rowsChanged = command.ExecuteNonQuery();
            connection.Close();
            await PopulateGrid();
            userIDTB.Text = "";
            fullNameTB.Text = "";
            mobileNoTB.Text = "";
            if (rowsChanged > 0)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void userNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private async void ManageCustomers_Load(object sender, EventArgs e)
        {
            await PopulateGrid();
        }

        private void AddUserBTN_Click(object sender, EventArgs e)
        {
            if (fullNameTB.Text != "" && mobileNoTB.Text != "" && userIDTB.Text == "")
            {
                SqlCommand command = new SqlCommand(String.Format("INSERT INTO CustomerTBL (CustomerName,CustomerPhone) VALUES ('{0}','{1}');", fullNameTB.Text, mobileNoTB.Text), connection);
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
                MessageBox.Show("All fields need to be filled...");
            }
        }

        private void CustomersGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CustomersGV.SelectedRows.Count != 0)
            {
                userIDTB.Text = CustomersGV.SelectedRows[0].Cells[0].Value.ToString();
                fullNameTB.Text = CustomersGV.SelectedRows[0].Cells[1].Value.ToString();
                mobileNoTB.Text = CustomersGV.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        private void EditUserBTN_Click(object sender, EventArgs e)
        {
            if (userIDTB.Text == "" && mobileNoTB.Text == "")
            {
                MessageBox.Show("Select a Record to Update");
            }
            else
            {
                try
                {
                    int userID = Convert.ToInt32(userIDTB.Text);
                    SqlCommand command = new SqlCommand(String.Format("UPDATE CustomerTBL SET CustomerName = '{0}', CustomerPhone = '{1}' WHERE CustomerID = {2}", fullNameTB.Text, mobileNoTB.Text, userID), connection);
                    ExecuteCommand(command, "update");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected Error Occured!");
                }
            }
        }

        private async void DeleteUserBTN_Click(object sender, EventArgs e)
        {
            if (userIDTB.Text != "")
            {
                try
                {
                    connection.Open();
                    string deleteUserQuery = "DELETE FROM CustomerTBL WHERE CustomerID = " + userIDTB.Text + "";
                    SqlCommand command = new SqlCommand(deleteUserQuery, connection);
                    int rows = command.ExecuteNonQuery();
                    connection.Close();
                    await PopulateGrid();
                    if (rows > 0)
                    {
                        userIDTB.Text = "";
                        fullNameTB.Text = "";
                        mobileNoTB.Text = "";
                        MessageBox.Show("Customer Deleted!");
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
                MessageBox.Show("Select a Customer to Delete!");
            }
        }

        private void HomeBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}
