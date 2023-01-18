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
    public partial class ManageCategories : Form
    {
        private readonly SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\indra\OneDrive\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        public ManageCategories()
        {
            InitializeComponent();
        }

        private async Task PopulateGrid()
        {
            try
            {
                connection.Open();
                string gridViewQuery = "SELECT * FROM CategoryTBL";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(gridViewQuery, connection);
                var dataSet = new DataSet();
                await Task.Run(() => dataAdapter.Fill(dataSet));
                CategoriesGV.DataSource = dataSet.Tables[0];
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
            categoryIDTB.Text = "";
            categoryNameTB.Text = "";
            if (rowsChanged > 0)
            {
                if (type == "insert")
                {
                    MessageBox.Show("Category Added Succesfully!");
                }
                else if (type == "update")
                {
                    MessageBox.Show("Category Updated Succesfully!");
                }
            }
        }

        private async void ManageCategories_Load(object sender, EventArgs e)
        {
            await PopulateGrid();
        }

        private void AddUserBTN_Click(object sender, EventArgs e)
        {
            if(categoryNameTB.Text != "")
            {
                try
                {
                    SqlCommand command = new SqlCommand(String.Format("INSERT INTO CategoryTBL VALUES ('{0}');", categoryNameTB.Text), connection);
                    ExecuteCommand(command, "insert");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected Error Occured!");
                }
            }
            else
            {
                MessageBox.Show("Category name need to be filled...");
            }
        }

        private void EditUserBTN_Click(object sender, EventArgs e)
        {
            if(categoryNameTB.Text != "")
            {
                try
                {
                    int categoryID = Convert.ToInt32(categoryIDTB.Text);
                    SqlCommand command = new SqlCommand(String.Format("UPDATE CategoryTBL SET CategoryName = '{0}' WHERE CategoryID = {1}", categoryNameTB.Text, categoryID), connection);
                    ExecuteCommand(command, "update");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected Error Occured!");

                }
            }
            else
            {
                MessageBox.Show("Select a Record to Update");
            }
        }

        private void CategoriesGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CategoriesGV.SelectedRows.Count != 0)
            {
                categoryIDTB.Text = CategoriesGV.SelectedRows[0].Cells[0].Value.ToString();
                categoryNameTB.Text = CategoriesGV.SelectedRows[0].Cells[1].Value.ToString();
            }
        }

        private async void DeleteUserBTN_Click(object sender, EventArgs e)
        {
            if(categoryNameTB.Text != "")
            {
                try
                {
                    connection.Open();
                    string deleteUserQuery = "DELETE FROM CategoryTBL WHERE CategoryID = " + categoryIDTB.Text + "";
                    SqlCommand command = new SqlCommand(deleteUserQuery, connection);
                    int rows = command.ExecuteNonQuery();
                    connection.Close();
                    await PopulateGrid();
                    if (rows > 0)
                    {
                        categoryIDTB.Text = "";
                        categoryNameTB.Text = "";
                        MessageBox.Show("Category Deleted!");
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
                MessageBox.Show("Select a Category to Delete!");
            }
        }

        private void HomeBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home= new Home();
            home.Show();
        }
    }
}
