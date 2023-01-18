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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Inventory_Managment_System
{
    public partial class ManageProducts : Form
    {
        private readonly SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\indra\OneDrive\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        public ManageProducts()
        {
            InitializeComponent();
        }

        private async Task PopulateGrid()
        {
            try
            {
                connection.Open();
                string gridViewQuery = "SELECT * FROM ProductTBL";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(gridViewQuery, connection);
                var dataSet = new DataSet();
                await Task.Run(() => dataAdapter.Fill(dataSet));
                ProductsGV.DataSource = dataSet.Tables[0];
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
            productNameTB.Text = "";
            productQuantityNUD.Value = 0;
            if (rowsChanged > 0)
            {
                if (type == "insert")
                {
                    MessageBox.Show("Product Added Succesfully!");
                }
                else if (type == "update")
                {
                    MessageBox.Show("Product Updated Succesfully!");
                }
            }
        }

        private async Task FillCategory()
        {
            try
            {
                connection.Open();
                string command = "SELECT * FROM CategoryTBL";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command, connection);
                var dataSet = new DataSet();
                await Task.Run(() => dataAdapter.Fill(dataSet));
                foreach (DataRow singleDS in dataSet.Tables[0].Rows)
                {
                    productCategoryCB.Items.Add(singleDS["CategoryName"].ToString());
                    searchCB.Items.Add(singleDS["CategoryName"]).ToString();
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error Occured!");
            }
        }

        private async void ManageProducts_Load(object sender, EventArgs e)
        {
            await PopulateGrid();
            if (!productCategoryCB.Items.Contains("Product Category"))
            {
                productCategoryCB.ForeColor = Color.Red;
                productCategoryCB.Items.Add("Product Category");
            }
            if (!searchCB.Items.Contains("Filter Products"))
            {
                searchCB.ForeColor = Color.Red;
                searchCB.Items.Add("Filter Products");
            }
            productCategoryCB.Text = "Product Category";
            searchCB.Text = "Filter Products";
            await FillCategory();
        }

        private void productCategoryCB_DropDown(object sender, EventArgs e)
        {
                productCategoryCB.ForeColor = Color.Black;            
        }

        private void productCategoryCB_DropDownClosed(object sender, EventArgs e)
        {
            if(productCategoryCB.SelectedIndex == 0)
            {
                productCategoryCB.ForeColor = Color.Red;
            }
        }

        private void AddUserBTN_Click(object sender, EventArgs e)
        {
            if (productNameTB.Text != "" && productQuantityNUD.Text != "" && productPriceNUD.Text != "" && productDescriptionTB.Text != "" && productCategoryCB.SelectedIndex != 0)
            {
                SqlCommand command = new SqlCommand(String.Format("INSERT INTO ProductTBL (ProductName,Quantity,Price,Description,Category) VALUES ('{0}',{1},{2},'{3}','{4}');", productNameTB.Text, productQuantityNUD.Text, productPriceNUD.Text.Replace(",", ""), productDescriptionTB.Text, productCategoryCB.SelectedItem), connection);
                try
                {
                    ExecuteCommand(command, "insert");
                    ResetForm();
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

        private void editProductBTN_Click(object sender, EventArgs e)
        {
            if (productNameTB.Text == "" && productQuantityNUD.Text == "" && productPriceNUD.Text == "" && productDescriptionTB.Text == "" && productCategoryCB.SelectedIndex == 0)
            {
                MessageBox.Show("Select a Record to Update");
            }
            else
            {
                try
                {
                    int productID = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[0].Value);
                    SqlCommand command = new SqlCommand(String.Format("UPDATE ProductTBL SET ProductName = '{0}', Quantity = {1}, Price = {2}, Description = '{3}', Category = '{4}' WHERE ProductID = {5}", productNameTB.Text, productQuantityNUD.Text, productPriceNUD.Text.Replace(",", ""), productDescriptionTB.Text, productCategoryCB.SelectedItem,productID), connection);
                    ExecuteCommand(command, "update");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected Error Occured!");
                }
            }
        }

        private void ProductsGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductsGV.SelectedRows.Count != 0)
            {
                productNameTB.Text = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
                productQuantityNUD.Value = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[2].Value.ToString());
                productPriceNUD.Value = Convert.ToDecimal(ProductsGV.SelectedRows[0].Cells[3].Value.ToString());
                productDescriptionTB.Text = ProductsGV.SelectedRows[0].Cells[4].Value.ToString();
                productCategoryCB.SelectedItem = ProductsGV.SelectedRows[0].Cells[5].Value.ToString();
            }
        }

        private async void deleteProductBTN_Click(object sender, EventArgs e)
        {
            if (productNameTB.Text != "")
            {
                try
                {
                    connection.Open();
                    string productID = productNameTB.Text = ProductsGV.SelectedRows[0].Cells[0].Value.ToString();
                    string deleteUserQuery = "DELETE FROM ProductTBL WHERE ProductID = '" + productID + "'";
                    SqlCommand command = new SqlCommand(deleteUserQuery, connection);
                    int rows = command.ExecuteNonQuery();
                    connection.Close();
                    await PopulateGrid();
                    if (rows > 0)
                    {
                        ResetForm();
                        MessageBox.Show("Product Deleted!");
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
                MessageBox.Show("Select a Record to Delete!");
            }
        }

        private void ResetForm()
        {
            productNameTB.Text = "";
            productQuantityNUD.ResetText();
            productPriceNUD.Value = 0;
            productDescriptionTB.Text = "";
            productCategoryCB.SelectedIndex = 0;
        }

        private void searchCB_DropDown(object sender, EventArgs e)
        {
            searchCB.ForeColor = Color.Black;
        }

        private void searchCB_DropDownClosed(object sender, EventArgs e)
        {
            if (searchCB.SelectedIndex == 0)
            {
                searchCB.ForeColor = Color.Red;
            }
        }

        private async void searchCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string category = searchCB.SelectedItem.ToString();
            if (category != "Filter Products")
            {
                try
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                    connection.Open();
                    string gridViewQuery = "SELECT * FROM ProductTBL WHERE Category = '" + category + "'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(gridViewQuery, connection);
                    var dataSet = new DataSet();
                    await Task.Run(() => dataAdapter.Fill(dataSet));
                    ProductsGV.DataSource = dataSet.Tables[0];
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected Error Occured!");
                }
            }
            else
            {
                await PopulateGrid();
            }
        }

        private async void resetBTN_Click(object sender, EventArgs e)
        {
            if(searchCB.SelectedIndex != 0)
            {
                searchCB.SelectedIndex = 0;
                await PopulateGrid();
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
