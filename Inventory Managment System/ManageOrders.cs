using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory_Managment_System
{
    public partial class ManageOrders : Form
    {
        private readonly SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\indra\OneDrive\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        private decimal totalPrice = 0.0M;

        public ManageOrders()
        {
            InitializeComponent();
        }

        private async void ManageOrders_Load(object sender, EventArgs e)
        {
            await PopulateGrid();
        }

        private async Task PopulateGrid()
        {
            try
            {
                connection.Open();
                string gridViewQuery1 = "SELECT * FROM CustomerTBL";
                SqlDataAdapter dataAdapter1 = new SqlDataAdapter(gridViewQuery1, connection);
                var dataSet1 = new DataSet();
                await Task.Run(() => dataAdapter1.Fill(dataSet1));
                CustomersGV.DataSource = dataSet1.Tables[0];
                string gridViewQuery2 = "SELECT * FROM ProductTBL";
                SqlDataAdapter dataAdapter2 = new SqlDataAdapter(gridViewQuery2, connection);
                var dataSet2 = new DataSet();
                await Task.Run(() => dataAdapter2.Fill(dataSet2));
                ProductsGV.DataSource = dataSet2.Tables[0];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error Occured!");
            }
        }

        private void CustomersGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CustomersGV.SelectedRows.Count != 0)
            {
                customerIDTB.Text = CustomersGV.SelectedRows[0].Cells[0].Value.ToString();
            }
        }

        private void ProductsGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private async void addOrderBTN_Click(object sender, EventArgs e)
        {
            if (ProductsGV.SelectedRows.Count > 0)
            {
                if (quantityNUD.Text != "0" && quantityNUD.Text != "")
                {
                    int productID = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[0].Value.ToString());
                    int quantity = Convert.ToInt32(quantityNUD.Value);
                    int availableQuantity = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[2].Value.ToString());
                    if (quantity > availableQuantity)
                    {
                        MessageBox.Show("Not Enough Quantity in the Inventory to Create an Order!");
                    }
                    else
                    {
                        var isAvaiable = ordersGV.Columns.Contains("Product");

                        if (!isAvaiable)
                        {
                            ordersGV.DataSource = null;
                            ordersGV.Rows.Clear();
                            ordersGV.Columns.Add("ProductID", "Product ID");
                            ordersGV.Columns.Add("Product", "Product");
                            ordersGV.Columns.Add("Quantity", "Quantity");
                            ordersGV.Columns.Add("UnitPrice", "Unit Price");
                            ordersGV.Columns.Add("TotalPrice", "Total Price");
                        }

                        int newRow = ordersGV.Rows.Add();
                        decimal unitPrice = Convert.ToDecimal(ProductsGV.SelectedRows[0].Cells[3].Value.ToString());
                        ordersGV.Rows[newRow].Cells[0].Value = ProductsGV.SelectedRows[0].Cells[0].Value;
                        ordersGV.Rows[newRow].Cells[1].Value = ProductsGV.SelectedRows[0].Cells[1].Value;
                        ordersGV.Rows[newRow].Cells[2].Value = quantity;
                        ordersGV.Rows[newRow].Cells[3].Value = unitPrice;
                        ordersGV.Rows[newRow].Cells[4].Value = quantity * unitPrice;
                        totalPrice += quantity * unitPrice;
                        grandTotalLBL.Text = totalPrice.ToString();
                        int stocks = availableQuantity - quantity;
                        if (stocks >= 0)
                        {
                            await UpdateStocks(productID, stocks);
                        }
                        quantityNUD.Value = 0;
                    }
                }
                else
                {
                    MessageBox.Show("Add a Quantity!");
                }
            }
            else
            {
                MessageBox.Show("Select a Product First!");
            }
        }

        private async Task UpdateStocks(int productID, int quantity)
        {
            try
            {
                SqlCommand command = new SqlCommand(String.Format("UPDATE ProductTBL SET Quantity = {0} WHERE ProductID = {1}", quantity, productID), connection);
                await ExecuteCommand(command);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error Occured!");
            }
        }

        private async Task<int> ExecuteCommand(SqlCommand command)
        {
            connection.Open();
            int rowsChanged = command.ExecuteNonQuery();
            connection.Close();
            await PopulateGrid();
            return rowsChanged;
        }

        private async void insertOrderBTN_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand();
            int customerID = Convert.ToInt32(customerIDTB.Text.ToString());
            string customerName = "";
            DataGridViewRow customerRow = CustomersGV.Rows.Cast<DataGridViewRow>().Where(r => r.Cells[0].Value.ToString().Equals(customerID.ToString())).FirstOrDefault();
            if (customerRow != null)
            {
                customerName = customerRow.Cells[1].Value.ToString();
            }
            command.CommandText = "INSERT INTO OrderTBL (CustomerID, CustomerName,OrderDate,TotalAmount) VALUES";
            if (ordersGV.Rows.Count > 1)
            {
                foreach (DataGridViewRow row in ordersGV.Rows)
                {
                    command.CommandText += String.Format(" ('{0}','{1}','{2}',{3}),", customerID, customerName, dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), row.Cells[3].Value.ToString().Replace(",", ""));
                }
                command.CommandText = command.CommandText.Remove(command.CommandText.Length - 1, 1);
            }
            else
            {
                foreach (DataGridViewRow row in ordersGV.Rows)
                {
                    command.CommandText += String.Format(" ('{0}','{1}','{2}',{3});", customerID, customerName, dateTimePicker1.Value.Date.ToString("yyyy-MM-dd"), row.Cells[3].Value.ToString().Replace(",", ""));
                }
            }
            command.Connection = connection;
            int rowsChanged = await ExecuteCommand(command);
            if (rowsChanged > 0)
            {
                MessageBox.Show("Orders Added Succesfully!");
                ordersGV.Rows.Clear();
                customerIDTB.Text = "";
                grandTotalLBL.Text = "0.00";
                quantityNUD.Value = 0;
            }
        }

        private async void viewOrderBTN_Click(object sender, EventArgs e)
        {
            string gridViewQuery = string.Empty;

            if (orderIDTB.Text != "" && customerIDTB.Text == "")
            {
                gridViewQuery = "SELECT * FROM OrderTBL WHERE OrderID=" + orderIDTB.Text + ";";
            }
            else if (customerIDTB.Text != "" && orderIDTB.Text == "")
            {
                gridViewQuery = "SELECT * FROM OrderTBL WHERE CustomerID=" + customerIDTB.Text + ";";
            }
            else if (orderIDTB.Text != "" && customerIDTB.Text != "")
            {
                gridViewQuery = "SELECT * FROM OrderTBL WHERE OrderID=" + customerIDTB.Text + " AND CustomerID=" + orderIDTB.Text + ";";
            }
            else
            {
                gridViewQuery = "SELECT * FROM OrderTBL;";
            }
            try
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(gridViewQuery, connection);
                var dataSet = new DataSet();
                bool isExisiting = ordersGV.Columns.Contains("Product");
                if (isExisiting)
                {
                    ordersGV.Columns.Remove("ProductID");
                    ordersGV.Columns.Remove("Product");
                    ordersGV.Columns.Remove("Quantity");
                    ordersGV.Columns.Remove("UnitPrice");
                    ordersGV.Columns.Remove("TotalPrice");
                }
                await Task.Run(() => dataAdapter.Fill(dataSet));
                ordersGV.DataSource = dataSet.Tables[0];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error Occured!");
            }
        }

        private async void deleteProductBTN_Click(object sender, EventArgs e)
        {
            bool isExisiting = ordersGV.Columns.Contains("Product");
            if (isExisiting)
            {
                int rowsChanged = 0;
                foreach (DataGridViewRow row in ordersGV.Rows)
                {
                    string productID = row.Cells[0].Value.ToString();
                    string quantity = row.Cells[2].Value.ToString();
                    SqlCommand command = new SqlCommand();
                    command.CommandText = String.Format("UPDATE ProductTBL SET Quantity = Quantity + {0} WHERE ProductID = {1}", quantity, productID);
                    command.Connection = connection;
                    rowsChanged = await ExecuteCommand(command);
                }
                if (rowsChanged > 0)
                {
                    MessageBox.Show("Orders Updated Succesfully!");
                    ordersGV.Rows.Clear();
                    grandTotalLBL.Text = "0.00";
                }
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            bool isExisiting = ordersGV.Columns.Contains("OrderID");
            if (isExisiting && ordersGV.Rows.Count > 0)
            {
                int mainLineX = 10;
                int mainLineY = 20;
                foreach (DataGridViewRow row in ordersGV.Rows)
                {
                    e.Graphics.DrawString("Order ID:" + row.Cells[0].Value.ToString(), new Font("Century", 18, FontStyle.Bold), Brushes.Red, new Point(mainLineX, mainLineY));
                    int subLineX = mainLineX;
                    int subLineY = mainLineY + 50;
                    e.Graphics.DrawString("Customer ID: "+row.Cells[1].Value.ToString(), new Font("Century", 14, FontStyle.Bold), Brushes.Green, new Point(subLineX, subLineY));
                    int sub2Line = subLineY+ 50;
                    e.Graphics.DrawString("Name: "+row.Cells[2].Value.ToString(), new Font("Century", 14, FontStyle.Bold), Brushes.Blue, new Point(subLineX, sub2Line));
                    e.Graphics.DrawString("Order Date: " + row.Cells[3].Value.ToString(), new Font("Century", 14, FontStyle.Bold), Brushes.Blue, new Point(subLineX += 200, sub2Line));
                    e.Graphics.DrawString("Amount: " + row.Cells[4].Value.ToString(), new Font("Century", 14, FontStyle.Bold), Brushes.Blue, new Point(subLineX += 380, sub2Line));
                    mainLineY += 150;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1; 
            printPreviewDialog1.ShowDialog();
        }

        private void HomeBTN_Click(object sender, EventArgs e)
        {
            this.Hide();
            Home home = new Home();
            home.Show();
        }
    }
}