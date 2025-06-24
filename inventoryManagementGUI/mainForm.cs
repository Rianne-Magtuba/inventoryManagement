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
            setupSupplierTable();
            productTable.CellClick += productTable_CellClick;
            //supplierTable.CellClick += supplierTable_CellClick;
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

        private void setupSupplierTable()
        {
            // Initialize ProductTable columns
            supplierTable.AutoGenerateColumns = false;

            // Product ID Column
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "ID";
            col1.Name = "supplierId";
            col1.DataPropertyName = "supplierId";
            col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Product Name Column
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Name";
            col2.Name = "supplierName";
            col2.DataPropertyName = "supplierName";
            col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Category Column
            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Email";
            col3.Name = "supplierEmail";
            col3.DataPropertyName = "supplierEmail";
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
            supplierTable.Columns.AddRange(new DataGridViewColumn[] { col1, col2, col3, editCol, moreCol });


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

            // Assuming icon columns are at index 3 and 4 (adjust as needed)
            if (productTable.Columns[e.ColumnIndex].Name == "Edit")
            {
                //string productId = productTable.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                //MessageBox.Show($"Edit clicked for Product ID: {productId}");

                headerLbl.Text = "Products/ edit information ";
                tabControl1.SelectedTab = editProducts;
                loadCategories();

            }
            else if (productTable.Columns[e.ColumnIndex].Name == "More")
            {
                string productId = productTable.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();

         



                MessageBox.Show($"More clicked for Product ID: {productId}");
                // TODO: open dropdown, menu, or context logic here
            }
        }

        private void supplierTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks on header row or out-of-range indexes
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            string supplierId = "";
            // Assuming  icon columns are at index 3 and 4 (adjust as needed)
            if (supplierTable.Columns[e.ColumnIndex].Name == "Edit")
            {
                supplierId = supplierTable.Rows[e.RowIndex].Cells["supplierId"].Value.ToString();
                MessageBox.Show($"Edit clicked for Product ID: {supplierId}");
                tabControl1.SelectedTab = editSupplier;
                setupSupplierEditPanel(supplierId);


            }
            else if (supplierTable.Columns[e.ColumnIndex].Name == "More")
            {
                supplierId = supplierTable.Rows[e.RowIndex].Cells["supplierId"].Value.ToString();

                var cellRect = supplierTable.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                var cellScreenLocation = supplierTable.PointToScreen(new Point(cellRect.X, cellRect.Y + cellRect.Height));

                tabControl1.SelectedTab = supplierInfo;
                setupSupllierInfoPanel(supplierId);

            }
        }

        private void setupSupplierEditPanel(string selectedSupplierId)
        {
            List<Supplier> suppliers = inventoryProcess.getSupplier(selectedSupplierId);
            editSupplierId.Text = suppliers[0].Id;
            editSupplierEmail.Text = suppliers[0].EmailAdd;
            editSupplierName.Text = suppliers[0].Name;
            editSupplierNum.Text = suppliers[0].ContactNum;
            editSupplierAddress.Text = suppliers[0].Address;

        }
        private void setupSupllierInfoPanel(string selectedSupllierId)
        {
            List<Supplier> suppliers = inventoryProcess.getSupplier(selectedSupllierId);
            List<string> supplierProducts = inventoryProcess.getSupplierProducts(selectedSupllierId);
            info_supplierProductsCmb.DataSource = supplierProducts;

            info_supplierName.textBox.Text = suppliers[0].Name;
            info_supplierEmail.textBox.Text = suppliers[0].EmailAdd;
            info_supplierAdd.textBox.Text = suppliers[0].Address;
            info_supplierNum.textBox.Text = suppliers[0].ContactNum;
            info_supplierId.textBox.Text = suppliers[0].Id;

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

                if (filteredData.Count == 0)
                {
                    noProductPrompt.Visible = true;
                    return;
                }

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
        private void ReloadSupplierGrid(List<Supplier> updatedSupplier)
        {
            try
            {

                var filteredData = updatedSupplier.Select(s => new
                {
                    supplierId = s.Id,
                    supplierName = s.Name,
                    supplierEmail = s.EmailAdd
                }).ToList();

                supplierTable.DataSource = null;
                supplierTable.DataSource = filteredData;
                StyleDataGridView(supplierTable);
                supplierTable.ClearSelection();
                supplierTable.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reloading product grid: " + ex.Message);
            }
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
        public void setupEditProductPanel()
        {

        }
        public void setupAddProductPanel()
        {
            List<string> defaultt = new List<string>();
            defaultt.Add("No Item Found");
            addProductSupplierCmb.DataSource = inventoryProcess.getSupplierNames();
            addProductCategoryCmb.DataSource = inventoryProcess.GetCategoryNames();
            if (addProductCategoryCmb.Items.Count == 0)
            {
                addProductCategoryCmb.DataSource = defaultt;
            }
            if (addProductSupplierCmb.Items.Count == 0)
            {
                addProductSupplierCmb.DataSource = defaultt;
            }


        }
        private void loadCategories()
        {
            cmbCategory.DataSource = inventoryProcess.GetCategoryNames();

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
            Category AddCategory = new Category(this);
            AddCategory.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = supplierInfo;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void supplierMoreBtn_Click(object sender, EventArgs e)
        {
            var locationOnScreen = supplierMoreBtn.PointToScreen(new Point(0, supplierMoreBtn.Height));


            supplierMoreStrip.Show(locationOnScreen);
        }

        private void cyberTextBox11_Load(object sender, EventArgs e)
        {

        }

        private void viewProdBtn_Click(object sender, EventArgs e)
        {
            headerLbl.Text = "Products";
            tabControl1.SelectedTab = viewProducts;

            List<Product> updatedProduct = inventoryProcess.getProducts();
            ReloadProductGrid(updatedProduct);
        }

        private void supplierNavbtn_Click(object sender, EventArgs e)
        {
            headerLbl.Text = "Suppliers";
            tabControl1.SelectedTab = supplierPanel;

            List<Supplier> updatedSupplier = inventoryProcess.getSuppliers();
            ReloadSupplierGrid(updatedSupplier);
        }

        private void cyberTextBox13_Load(object sender, EventArgs e)
        {

        }

        private void saveEditSupplierBtn_Click(object sender, EventArgs e)
        {
            string id = editSupplierId.Text;

            string name = editSupplierName.Text;
            string email = editSupplierEmail.Text;
            string contactNum = editSupplierNum.Text;
            string address = editSupplierAddress.Text;

            inventoryProcess.updateSupplier(id, name, email, contactNum, address);
            MessageBox.Show("Supplier updated successfully!");
        }

        private void orderProductCatBtn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addProductNavBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = addProduct;
            setupAddProductPanel();
        }

        private void addProdCatViewMore_Click(object sender, EventArgs e)
        {
            var locationOnScreen = addProdCatViewMore.PointToScreen(new Point(0, categoryMoreBtn.Height));

            categoryMore.Show(locationOnScreen);
        }

        private void addProdSupViewMore_Click(object sender, EventArgs e)
        {
            var locationOnScreen = addProdSupViewMore.PointToScreen(new Point(0, addProdSupViewMore.Height));


            supplierMoreStrip.Show(locationOnScreen);
        }

      

        private void addProductBtn_Click_1(object sender, EventArgs e)
        {
            string name = addProductNameField.Text.Trim();
            string id = addProductIdField.Text.Trim();
            string category = addProductCategoryCmb.Text.Trim();
            string supplierName = addProductSupplierCmb.Text.Trim();
            string preConPrice = addProductPrice.Text.Trim();
            double price = 0;
            if (preConPrice == "")
            {
                price = 0;
            }
            else
            {
                price = Convert.ToDouble(preConPrice);
            }
                int qty = 0;

            if (name == "" && id == ""  && price == 0 ||  category == "No Item Found" && supplierName == "No Item Found")
            {
                MessageBox.Show("Please fill all fields correctly.");
                return;
            }
            string supplierId =  inventoryProcess.getSupplierId(supplierName);
            inventoryProcess.addProduct(id, name, qty, supplierId, price, category);
            MessageBox.Show("Product added successfully!");
        }
    }
}
