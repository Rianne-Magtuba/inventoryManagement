using BusinessLogic;
using InventoryCommon;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventoryManagementGUI
{
    public partial class mainForm : Form
    {

        public mainForm()
        {
            InitializeComponent();
            setupProductTable();
            productTable.CellClick += productTable_CellClick;
        }


        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            headerLbl.Text = "Order  Product";
            tabControl1.SelectedTab = orderProduct;
        }

        private void tab2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void setupProductTable()
        {
            // Initialize ProductTable columns
            productTable.AutoGenerateColumns = false;

            // Product ID Column
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "ID";
            col1.Name = "ProductID";
            col1.DataPropertyName = "ProductID";
            col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Product Name Column
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Name";
            col2.Name = "ProductName";
            col2.DataPropertyName = "ProductName";
            col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Category Column
            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Category";
            col3.Name = "ProductCategory";
            col3.DataPropertyName = "ProductCategory";
            col3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Edit Icon Column
            DataGridViewImageColumn editCol = new DataGridViewImageColumn();
            editCol.Image = Resources.editIcon;
            editCol.Name = "Edit";
            editCol.HeaderText = "";
            editCol.Width = 40;
            editCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            // More Icon Column
            DataGridViewImageColumn moreCol = new DataGridViewImageColumn();
            moreCol.Image = Resources.moreIcon;
            moreCol.Name = "More";
            moreCol.HeaderText = "";
            moreCol.Width = 40;
            moreCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            // Add columns
            productTable.Columns.AddRange(new DataGridViewColumn[] { col1, col2, col3, editCol, moreCol });

            // Apply style
            StyleDataGridView(productTable);

        }
        private void addProductBtn_Click(object sender, EventArgs e)
        {
            //string productId = ProdIdField.Text;
            //string productName = ProdNameField.Text;
            //int productQuantity = Convert.ToInt32(ProdQtyField.Text);
            //string productSupplier = ProdSuppField.Text;
            //double productPrice = Convert.ToDouble(ProdPriceField.Text);
            //string prodCategory = ProdCatField.Text;

            //inventoryProcess.addProduct(productId, productName, productQuantity, productSupplier, productPrice, prodCategory);
            //MessageBox.Show("Product added successfully!");
            //ProdIdField.Clear();
            //ProdNameField.Clear();
            //ProdQtyField.Clear();
            //ProdSuppField.Clear();
            //ProdPriceField.Clear();
            //ProdCatField.Clear();

        }
        private void productTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks on header row or out-of-range indexes
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Assuming your icon columns are at index 3 and 4 (adjust as needed)
            if (productTable.Columns[e.ColumnIndex].Name == "Edit")
            {
                string productId = productTable.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                MessageBox.Show($"Edit clicked for Product ID: {productId}");

                headerLbl.Text = "Products/ edit information ";
                tabControl1.SelectedTab = editProducts;
                loadCategories();
                // TODO: open your edit form or logic here
            }
            else if (productTable.Columns[e.ColumnIndex].Name == "More")
            {
                string productId = productTable.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();

                var cellRect = productTable.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                var cellScreenLocation = productTable.PointToScreen(new Point(cellRect.X, cellRect.Y + cellRect.Height));
                supplierMoreStrip.Show(cellScreenLocation);


               
                MessageBox.Show($"More clicked for Product ID: {productId}");
                // TODO: open dropdown, menu, or context logic here
            }
        }

        private void StyleDataGridView(DataGridView grid)
        {
            grid.ColumnHeadersVisible = false;
            grid.RowHeadersVisible = false;
            grid.BorderStyle = BorderStyle.None;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            grid.DefaultCellStyle.BackColor = Color.FromArgb(236, 236, 236);
            grid.DefaultCellStyle.SelectionBackColor = Color.LightGray;
            grid.DefaultCellStyle.SelectionForeColor = Color.Black;

            grid.DefaultCellStyle.Font = new Font("Segoe UI", 10F);
            grid.DefaultCellStyle.Padding = new Padding(0, 8, 0, 8);
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;
            grid.GridColor = Color.LightGray;
        }

        private void ReloadProductGrid(List<Product> updatedProduct)
        {
            try
            {

                var filteredData = updatedProduct.Select(p => new
                {
                    ProductID = p.Id,
                    ProductName = p.Name,
                    ProductCategory = p.category
                }).ToList();

                productTable.DataSource = null;
                productTable.DataSource = filteredData;
                StyleDataGridView(productTable);
                productTable.ClearSelection();
                productTable.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reloading product grid: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            headerLbl.Text = "Products";
            tabControl1.SelectedTab = viewProducts;

            List<Product> updatedProduct = inventoryProcess.getProducts();
            ReloadProductGrid(updatedProduct);

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void searchField_KeyUp(object sender, KeyEventArgs e)
        {
            //List<Product> searchedProduct = inventoryProcess.searchProduct(searchField.Text);
            //ReloadProductGrid(searchedProduct);
        }

        private void removeProdButton_Click(object sender, EventArgs e)
        {


        }

        private void removeProdButton_Click_1(object sender, EventArgs e)
        {

            int rowIndex = productTable.CurrentCell.RowIndex;
            int columnIndex = productTable.CurrentCell.ColumnIndex;

            var selectedId = productTable.Rows[rowIndex].Cells[0].Value;


            if (inventoryProcess.removeProduct(selectedId.ToString()) == true)
            {
                MessageBox.Show("Product Removed Succesfully");
                List<Product> updatedProduct = inventoryProcess.getProducts();
                ReloadProductGrid(updatedProduct);
            }
            else
            {
                MessageBox.Show("Product Deletion Failed");

            }




        }

        private void loadCategories()
        {
            List<Product> product = inventoryProcess.getProducts();
            List<string> categories = product.Select(p => p.category).Distinct().ToList();
            cmbCategory.DataSource = categories;

        }
        private void searchField_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void viewProducts_Click(object sender, EventArgs e)
        {

        }

        private void categoryMoreBtn_Click(object sender, EventArgs e)
        {
            var locationOnScreen = categoryMoreBtn.PointToScreen(new Point(0, categoryMoreBtn.Height));


            categoryMore.Show(locationOnScreen);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SHOW CATEGORY");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SHOW Supplier");
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void supplierMoreBtn_Click(object sender, EventArgs e)
        {
            var locationOnScreen = supplierMoreBtn.PointToScreen(new Point(0, supplierMoreBtn.Height));


            supplierMoreStrip.Show(locationOnScreen);
        }
    }
}
