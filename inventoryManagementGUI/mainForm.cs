using BusinessLogic;
using InventoryCommon;
using Microsoft.IdentityModel.Tokens;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace inventoryManagementGUI
{
    public partial class mainForm : Form
    {

        public mainForm(string userName)
        {
            InitializeComponent();

            setupDashboardTable();
            setupDashBoardPage();

            setupProductTable();

            setupSupplierTable();
            setupOrderTable();
            setupStocksTable();
            userLbl.Text = userName;


        }

        string selectedProductId = "";
        string selectedSupplierId = "";
        string selectedStock = "";

        List<Product> products = new List<Product>();
        List<Orders> orders = new List<Orders>();


        // Dashboard page methods
        private void setupDashboardTable()
        {

            arrivingProductTable.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();

            col1.Name = "ProductName";
            col1.DataPropertyName = "ProductName";
            col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();

            col2.Name = "ProductQty";
            col2.DataPropertyName = "ProductQty";
            col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;




            arrivingProductTable.Columns.AddRange(new DataGridViewColumn[] { col1, col2 });

            StyleDataGridView(arrivingProductTable);
            arrivingProductTable.DefaultCellStyle.BackColor = Color.White;
            arrivingProductTable.ForeColor = Color.Black;
            arrivingProductTable.DefaultCellStyle.SelectionBackColor = Color.White;
            arrivingProductTable.GridColor = Color.Black;

        }
        private void setupDashBoardPage()
        {
            List<Orders> updatedOrders = inventoryProcess.getOrders();
            List<Product> updatedProducts = inventoryProcess.getProducts();
            headerLbl.Text = "Dashboard";
            tabControl1.SelectedTab = Dashboard;

            lowStockLblOverView.Text = inventoryProcess.getLowStockProduct(updatedProducts).ToString();
            NoOfProdLblOverView.Text = updatedProducts.Count.ToString();
            totalStocksLbl.Text = inventoryProcess.getTotalStockProduct(updatedProducts).ToString();
            OutOfStockLbl.Text = inventoryProcess.getOutOfStockProduct(updatedProducts).ToString();
            ReloadDashBoardGrid(updatedOrders);




        }


        private void ReloadDashBoardGrid(List<Orders> updatedOrders)
        {

            try
            {

                var filteredData = updatedOrders.Select(o => new

                {

                    ProductQty = o.qty,
                    ProductName = inventoryProcess.getProductNameByOrderId(o.Id),


                }).ToList();

                if (filteredData.Count == 0)
                {
                    arrivingSoonPrompt.Visible = true;
                    return;
                }
                arrivingSoonPrompt.Visible = false;
                arrivingProductTable.DataSource = null;
                arrivingProductTable.DataSource = filteredData;

                StyleDataGridView(arrivingProductTable);

                arrivingProductTable.DefaultCellStyle.BackColor = Color.White;
                arrivingProductTable.ForeColor = Color.Black;
                arrivingProductTable.DefaultCellStyle.SelectionBackColor = Color.White;
                arrivingProductTable.GridColor = Color.Black;

                arrivingProductTable.ClearSelection();
                arrivingProductTable.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reloading product grid: " + ex.Message);
            }
        }




        //dashboard page action methods
        private void dashBoardNavBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = Dashboard;
            setupDashBoardPage();
        }


        // Product page methods


        private void setupProductTable()
        {

            productTable.AutoGenerateColumns = false;


            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();

            col1.Name = "ProductID";
            col1.DataPropertyName = "ProductID";
            col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();

            col2.Name = "ProductName";
            col2.DataPropertyName = "ProductName";
            col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();

            col3.Name = "ProductCategory";
            col3.DataPropertyName = "ProductCategory";
            col3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewImageColumn editCol = new DataGridViewImageColumn();
            editCol.Image = Resources.editIcon;
            editCol.Name = "Edit";

            editCol.Width = 40;
            editCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            DataGridViewImageColumn moreCol = new DataGridViewImageColumn();
            moreCol.Image = Resources.moreIcon;
            moreCol.Name = "More";

            moreCol.Width = 40;
            moreCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;


            productTable.Columns.AddRange(new DataGridViewColumn[] { col1, col2, col3, editCol, moreCol });

            StyleDataGridView(productTable);


        }
        private void setupProductPage()
        {
            products = inventoryProcess.getProducts();
            headerLbl.Text = "Products";
            tabControl1.SelectedTab = viewProducts;
            List<Product> updatedProduct = products;
            ReloadProductGrid(updatedProduct);
            loadProdPageCategory();
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
                noProductPrompt.Visible = false;
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
        private void loadProdPageCategory()
        {
            List<string> categories = inventoryProcess.GetCategoryNames();
            productPageCatCmb.Items.Clear();
            productPageCatCmb.Items.Add("All");
            for (int i = 0; i < categories.Count; i++)
            {

                productPageCatCmb.Items.Add(categories[i]);
            }
            productPageCatCmb.SelectedIndex = 0;
        }
        private void setupViewProductInfoPanel(string selectedProduct)
        {
            headerLbl.Text = "Products/ View information ";
            ProductMorePageHdr.Text = "Product Information";
            editProductBtn.Visible = true;
            returnToProductView.Visible = false;
            editProductSaveBtn.Visible = false;

            loadCategoriesNSsupplier();
            moreProductNameField.ReadOnly = true;
            moreProductPriceField.ReadOnly = true;
            MoreProductQty.ReadOnly = true;
            List<Product> products = inventoryProcess.getProductById(selectedProduct);
            moreProductNameField.Text = products[0].Name;
            moreProductPriceField.Text = products[0].Price.ToString();
            MoreProductQty.Text = products[0].Quantity.ToString();
            cmbCategory.Text = products[0].category;
            cmbSuppliers.Text = inventoryProcess.getSupplierName(products[0].supplierId);
            ProdDateModified.Text = products[0].dateModified.ToString();
            selectedProductId = selectedProduct;

        }




        private void setupEditProductPanel(string selectedProduct)
        {
            headerLbl.Text = "Products/ Edit information ";
            ProductMorePageHdr.Text = "Edit Product Information";
            editProductBtn.Visible = false;
            returnToProductView.Visible = true;
            editProductSaveBtn.Visible = true;
            loadCategoriesNSsupplier();

            moreProductNameField.ReadOnly = false;
            moreProductPriceField.ReadOnly = false;
            MoreProductQty.ReadOnly = true;
            List<Product> products = inventoryProcess.getProductById(selectedProduct);
            moreProductNameField.Text = products[0].Name;
            moreProductPriceField.Text = products[0].Price.ToString();
            MoreProductQty.Text = products[0].Quantity.ToString();
            cmbCategory.Text = products[0].category;
            cmbSuppliers.Text = inventoryProcess.getSupplierName(products[0].supplierId);
            ProdDateModified.Text = products[0].dateModified.ToString();

            selectedProductId = selectedProduct;

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

        //product page action methods


        private void viewProdBtn_Click(object sender, EventArgs e)
        {
            setupProductPage();
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
        private void productTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks on header row or out-of-range indexes
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Assuming icon columns are at index 3 and 4 (adjust as needed)
            if (productTable.Columns[e.ColumnIndex].Name == "Edit")
            {
                string selectedProdId = productTable.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                //MessageBox.Show($"Edit clicked for Product ID: {productId}");


                tabControl1.SelectedTab = productMorePage;
                setupEditProductPanel(selectedProdId);

            }
            else if (productTable.Columns[e.ColumnIndex].Name == "More")
            {
                string selectedProdId = productTable.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();


                tabControl1.SelectedTab = productMorePage;
                setupViewProductInfoPanel(selectedProdId);



                // TODO: open dropdown, menu, or context logic here
            }
        }

        private void productPageCatCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<Product> categorized = categorizeAndSearchProductTable(products);
            if (categorized.Count == 0)
            {
                noProductPrompt.Visible = true;
                productTable.DataSource = null;
                productTable.Refresh();
            }
            else
            {
                noProductPrompt.Visible = false;
                ReloadProductGrid(categorized);
            }


        }

        private void searchProductField_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchProductField.Text))
            {
                searchProductField.Text = " ";
            }
            if (searchProductField.Text.StartsWith(" ") || searchProductField.Text.Trim() == "Search Product Name")
            {
                productTable.DataSource = null;
                productTable.Refresh();
                List<Product> filteredProducts = inventoryProcess.getProductByCategoryAndName(productPageCatCmb.Text.Trim(), searchProductField.Text, products);
                ReloadProductGrid(filteredProducts);


            }
            else
            {

                List<Product> filteredProducts = inventoryProcess.getProductByCategoryAndName(productPageCatCmb.Text.Trim(), searchProductField.Text, products);

                if (filteredProducts.Count == 0)
                {
                    noProductPrompt.Visible = true;
                    productTable.DataSource = null;
                    productTable.Refresh();
                }
                else
                {
                    noProductPrompt.Visible = false;
                    ReloadProductGrid(filteredProducts);
                }
            }
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

            if (name == "" && id == "" && price == 0 || category == "No Item Found" && supplierName == "No Item Found")
            {
                MessageBox.Show("Please fill all fields correctly.");
                return;
            }
            if (inventoryProcess.productNameExist(name))
            {
                MessageBox.Show("Product with this name already exists.");
                return;
            }
            string supplierId = inventoryProcess.getSupplierId(supplierName);
            inventoryProcess.addProduct(id, name, qty, supplierId, price, category);
            MessageBox.Show("Product added successfully! Returning to Product Page");
            setupProductPage();
            returnToPreviousTab();


        }


        private void returnToProductView_Click(object sender, EventArgs e)
        {
            string selectedProdId = selectedProductId;

            setupViewProductInfoPanel(selectedProdId);
        }

        private void editProductBtn_Click(object sender, EventArgs e)
        {
            string selectedProdId = selectedProductId;

            setupEditProductPanel(selectedProdId);
        }

        private void editProductSaveBtn_Click(object sender, EventArgs e)
        {

            string newProductName = moreProductNameField.Text;
            Double productPrice = Convert.ToDouble(moreProductPriceField.Text);
            string productId = selectedProductId;
            int productQty = Convert.ToInt32(MoreProductQty.Text);
            string category = cmbCategory.Text;
            string supplierId = inventoryProcess.getSupplierId(cmbSuppliers.Text);


            inventoryProcess.updateProduct(newProductName, productId, productQty, productPrice, supplierId, category);
            MessageBox.Show("Product updated successfully! Returning to Product Page");

            returnToPreviousTab();
            setupProductPage();



        }

        private List<Product> categorizeAndSearchProductTable(List<Product> product)
        {

            if (productPageCatCmb.Text.Trim() == "All")
            {
                return product;
            }
            else
            {
                return inventoryProcess.getProductByCategoryAndName(productPageCatCmb.Text.Trim(), searchProductField.Text, products);
            }

        }



        private void prodQtyAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ORDER PRODUCTS");
        }

        private void prodQtyMinus_Click(object sender, EventArgs e)
        {
            MessageBox.Show("INVOICE?");
        }




        // Supplier page methods
        private void setupSupplierPage()
        {
            headerLbl.Text = "Suppliers";
            tabControl1.SelectedTab = supplierPanel;
            List<Supplier> updatedSupplier = inventoryProcess.getSuppliers();
            ReloadSupplierGrid(updatedSupplier);
        }
        private void setupSupplierTable()
        {
            supplierTable.AutoGenerateColumns = false;


            DataGridViewTextBoxColumn supTableCol1 = new DataGridViewTextBoxColumn();

            supTableCol1.Name = "supplierId";
            supTableCol1.DataPropertyName = "supplierId";
            supTableCol1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            supTableCol1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            DataGridViewTextBoxColumn supTableCol2 = new DataGridViewTextBoxColumn();

            supTableCol2.Name = "supplierName";
            supTableCol2.DataPropertyName = "supplierName";
            supTableCol2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            supTableCol2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn supTableCol3 = new DataGridViewTextBoxColumn();

            supTableCol3.Name = "supplierEmail";
            supTableCol3.DataPropertyName = "supplierEmail";
            supTableCol3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            supTableCol3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            DataGridViewImageColumn supEditCol = new DataGridViewImageColumn();
            supEditCol.Image = Resources.editIcon;
            supEditCol.Name = "Edit";

            supEditCol.Width = 40;
            supEditCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;


            DataGridViewImageColumn supMoreCol = new DataGridViewImageColumn();
            supMoreCol.Image = Resources.moreIcon;
            supMoreCol.Name = "More";

            supMoreCol.Width = 40;
            supMoreCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;


            supplierTable.Columns.AddRange(new DataGridViewColumn[] { supTableCol1, supTableCol2, supTableCol3, supEditCol, supMoreCol });
            StyleDataGridView(supplierTable);

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

                if (filteredData.Count == 0)
                {
                    supplierHdrPrompt.Visible = true;
                    return;
                }
                supplierHdrPrompt.Visible = false;
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

        private void setupSupplierEditPanel(string selectedSupplierId)
        {

            headerLbl.Text = "Supplier/ Edit information";
            supllierMoreHdr.Text = "Edit Supplier Information";
            moreSupIdField.ReadOnly = true;
            moreSupNameField.ReadOnly = false;
            moreSupNumField.ReadOnly = false;
            moreSupAddressField.ReadOnly = false;
            moreSupEmailField.ReadOnly = false;


            editSupplierBtn.Visible = false;
            saveSupChangesBtn.Visible = true;
            stopEditingSupBtn.Visible = true;


            List<Supplier> suppliers = inventoryProcess.getSupplier(selectedSupplierId);



            moreSupIdField.Text = suppliers[0].Id;
            moreSupNameField.Text = suppliers[0].Name;
            moreSupEmailField.Text = suppliers[0].EmailAdd;
            moreSupAddressField.Text = suppliers[0].Address;
            moreSupNumField.Text = suppliers[0].ContactNum;

            info_supplierProductsCmb.Visible = false;
            moreSupProductLbl.Visible = false;
            moreSupProdBg.Visible = false;


        }
        private void setupSupllierInfoPanel(string selectedSupllierId)
        {
            headerLbl.Text = "Supplier/ View information";
            supllierMoreHdr.Text = "Supplier Information";
            moreSupIdField.ReadOnly = true;
            moreSupNameField.ReadOnly = true;
            moreSupNumField.ReadOnly = true;
            moreSupAddressField.ReadOnly = true;
            moreSupEmailField.ReadOnly = true;


            editSupplierBtn.Visible = true;
            saveSupChangesBtn.Visible = false;
            stopEditingSupBtn.Visible = false;


            info_supplierProductsCmb.Visible = true;
            moreSupProductLbl.Visible = true;
            moreSupProdBg.Visible = true;

            List<Supplier> suppliers = inventoryProcess.getSupplier(selectedSupllierId);
            List<string> supplierProducts = inventoryProcess.getSupplierProducts(selectedSupllierId);


            moreSupIdField.Text = suppliers[0].Id;
            moreSupNameField.Text = suppliers[0].Name;
            moreSupEmailField.Text = suppliers[0].EmailAdd;
            moreSupAddressField.Text = suppliers[0].Address;
            moreSupNumField.Text = suppliers[0].ContactNum;
            info_supplierProductsCmb.DataSource = supplierProducts;



        }

        //suppleir page action methods

        private void supplierNavbtn_Click(object sender, EventArgs e)
        {
            setupSupplierPage();
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


                tabControl1.SelectedTab = supplierMorePanel;
                setupSupplierEditPanel(supplierId);
                selectedSupplierId = supplierId;

            }
            else if (supplierTable.Columns[e.ColumnIndex].Name == "More")
            {
                supplierId = supplierTable.Rows[e.RowIndex].Cells["supplierId"].Value.ToString();

                var cellRect = supplierTable.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                var cellScreenLocation = supplierTable.PointToScreen(new Point(cellRect.X, cellRect.Y + cellRect.Height));

                tabControl1.SelectedTab = supplierMorePanel;
                setupSupllierInfoPanel(supplierId);
                selectedSupplierId = supplierId;

            }
        }


        private void addSupplierBtn_Click(object sender, EventArgs e)
        {
            string id = addSupplierId.Text;

            string name = addSupplierName.Text;
            string email = addSupplierEmail.Text;
            string contactNum = addSupplierNum.Text;
            string address = addSupplierAddress.Text;

            inventoryProcess.addSupplier(id, name, email, contactNum, address);
            MessageBox.Show("Supplier Added successfully!");
        }

        private void addSupplierNavBtn_Click(object sender, EventArgs e)
        {
            headerLbl.Text = "Supplier/ Add Supplier";
            tabControl1.SelectedTab = addSupplier;
        }

        private void editSupplierBtn_Click(object sender, EventArgs e)
        {
            setupSupplierEditPanel(selectedSupplierId);
        }
        private void stopEditingSupBtn_Click(object sender, EventArgs e)
        {
            setupSupllierInfoPanel(selectedSupplierId);
        }
        private void saveSupChangesBtn_Click(object sender, EventArgs e)
        {
            string supId = moreSupIdField.Text;
            string supName = moreSupNameField.Text;
            string supNum = moreSupNumField.Text;
            string supAdd = moreSupAddressField.Text;
            string supEmail = moreSupEmailField.Text;

            if (supId == "" || supName == "" || supNum == "" || supAdd == "" || supEmail == "")
            {
                MessageBox.Show("Please fill all fields correctly.");
                return;
            }

            if (inventoryProcess.supplierExist(supId))
            {
                MessageBox.Show("Supplier with this name already exists.");
                return;
            }

            inventoryProcess.updateSupplier(supId, supName, supNum, supAdd, supEmail);
            MessageBox.Show("Supplier updated successfully! Returning to Supplier Page");
            returnToPreviousTab();
            ReloadSupplierGrid(inventoryProcess.getSuppliers());

        }

        private void searchSupplierField_KeyUp(object sender, KeyEventArgs e)
        {
            if (searchSupplierField.Text == "" || searchSupplierField.Text == "Search Supplier Name")
            {
                List<Supplier> supplier = inventoryProcess.getSuppliers();

                ReloadSupplierGrid(supplier);
                supplierTable.Refresh();
            }
            else
            {
                List<Supplier> filteredSuppliers = inventoryProcess.getSupplierByName(searchSupplierField.Text.Trim());
                if (filteredSuppliers.Count == 0)
                {
                    supplierHdrPrompt.Visible = true;
                    supplierTable.DataSource = null;
                    supplierTable.Refresh();
                }
                else
                {
                    ReloadSupplierGrid(filteredSuppliers);
                }
            }
        }

        //Order page methods

        public void setupOrderPage()
        {
            headerLbl.Text = "Orders";
            tabControl1.SelectedTab = Orders;
            List<Orders> orders = inventoryProcess.getOrders();
            this.orders = orders;
            ReloadOrderGrid(orders);

        }

        public void setupOrderProductPage()
        {
            if (loadOrderProductSupplierCmb() == false)
            {
                return;
            }
            if (loadOrderProductValues() == false)
            {
                return;
            }



        }
        public bool loadOrderProductSupplierCmb()
        {
            orderProductsuppCmb.DataSource = null;
            orderProductsuppCmb.DataSource = inventoryProcess.getSupplierNames();
            if (orderProductsuppCmb.Items.Count == 0)
            {
                orderProductsuppCmb.DataSource = new List<string> { "No Supplier Found" };
                return false;
            }
            return true;
        }
        public bool loadOrderProductNameCmb()
        {
            string selectedSupplierId = inventoryProcess.getSupplierId(orderProductsuppCmb.Text);
            orderProductNamecmb.DataSource = inventoryProcess.getSupplierProducts(selectedSupplierId);
            if (orderProductNamecmb.Items.Count == 0)
            {
                orderProductNamecmb.DataSource = new List<string> { "No Product Found" };
                return false;

            }

            return true;

        }
        public bool loadOrderProductValues()
        {


            List<Product> product = inventoryProcess.getProductByName(orderProductNamecmb.Text);
            if (product.Count == 0)
            {
                return false;
            }
            DateTime currentDate = DateTime.Now;

            Random rng = new Random();

            int daysToAdd = rng.Next(1, 8);
            DateTime arrivalDate = currentDate.AddDays(daysToAdd);

            orderProductIDField.Text = product[0].Id;
            orderProductPriceField.Text = product[0].Price.ToString();
            orderProductCatField.Text = product[0].category;
            estimatedArrivalLbl.Text = arrivalDate.ToString("dd/MM/yyyy");
            return true;

        }
        private void setupOrderInformationPanel(Orders order)
        {
            viewOrderStatusLbl.Text = order.status;
            ViewEstArrivalLbl.Text = order.estimatedDate.ToString("yyyy-MM-dd");
            ViewdateOrderedLbl.Text = order.orderDate.ToString("yyyy-MM-dd");
            viewProductSupOrderLbl.Text = inventoryProcess.getSupplierName(order.supplierId);
            viewProductNameOrderLbl.Text = inventoryProcess.getProductNameByOrderId(order.Id);
            viewProdQtyOrderLbl.Text = order.qty.ToString();
            viewOrderIdLbl.Text = order.Id.ToString();




        }
        private void setupOrderTable()
        {

            ordersTable.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn supTableCol1 = new DataGridViewTextBoxColumn();

            supTableCol1.Name = "Product Name";
            supTableCol1.DataPropertyName = "ProductName";
            supTableCol1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            supTableCol1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            DataGridViewTextBoxColumn supTableCol2 = new DataGridViewTextBoxColumn();

            supTableCol2.Name = "est delivery";
            supTableCol2.DataPropertyName = "estDelivery";
            supTableCol2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            supTableCol2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            DataGridViewTextBoxColumn supTableCol3 = new DataGridViewTextBoxColumn();

            supTableCol3.Name = "status";
            supTableCol3.DataPropertyName = "orderStatus";
            supTableCol3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            supTableCol3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            DataGridViewTextBoxColumn supTableCol4 = new DataGridViewTextBoxColumn();

            supTableCol4.Name = "qty";
            supTableCol4.DataPropertyName = "orderQty";
            supTableCol4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            supTableCol4.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn idColumn = new DataGridViewTextBoxColumn();
            idColumn.Name = "orderId";                      // Internal column name
            idColumn.DataPropertyName = "orderId";              // Must match your anonymous type in ReloadOrderGrid
            idColumn.Visible = false;

            // More Icon Column
            DataGridViewImageColumn supMoreCol = new DataGridViewImageColumn();
            supMoreCol.Image = Resources.moreIcon;
            supMoreCol.Name = "More";

            supMoreCol.Width = 40;
            supMoreCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            // Add columns
            ordersTable.Columns.AddRange(new DataGridViewColumn[] { supTableCol1, supTableCol2, supTableCol3, supTableCol4, supMoreCol, idColumn });
            StyleDataGridView(ordersTable);

        }

        private void ReloadOrderGrid(List<Orders> updatedOrders)
        {


            try
            {


                var filteredData = updatedOrders.Select(o => new

                {
                    orderId = o.Id,
                    orderQty = o.qty,
                    ProductName = inventoryProcess.getProductNameByOrderId(o.Id),
                    estDelivery = o.estimatedDate.ToString("dd/MM/yyyy"),
                    orderStatus = o.status,


                }).ToList();

                if (filteredData.Count == 0)
                {
                    noOrdersPrompt.Visible = true;
                    return;
                }
                noOrdersPrompt.Visible = false;
                ordersTable.DataSource = null;
                ordersTable.DataSource = filteredData;

                StyleDataGridView(ordersTable);
                ordersTable.ClearSelection();
                ordersTable.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reloading product grid: " + ex.Message);
            }
        }
        private void FilterOrders()
        {
            string productName = orderPanelSearchField.Text?.Trim() ?? "";
            string selectedStatusText = selectedStatus.Text?.Trim() ?? "All";

            // Normalize input
            if (string.IsNullOrWhiteSpace(productName) || productName == "Search Product Name")
            {
                productName = "";
            }

            List<Orders> allOrders = orders;

            // Use your combined filter method
            List<Orders> filteredOrders = inventoryProcess.getOrderByProductIdAndStatus(productName, selectedStatusText, allOrders);

            if (filteredOrders.Count == 0)
            {
                noOrdersPrompt.Visible = true;
                ordersTable.DataSource = null;
                ordersTable.Refresh();
                return;
            }

            noOrdersPrompt.Visible = false;
            ReloadOrderGrid(filteredOrders);
        }

        //Order Page action methods
        private void OrderTabNavBtn_Click(object sender, EventArgs e)
        {

            setupOrderPage();

        }

        private void orderProdNavBtn_Click(object sender, EventArgs e)
        {
            headerLbl.Text = "Order Products";
            tabControl1.SelectedTab = orderProduct;
            setupOrderProductPage();
        }
        private void orderProductBtn_Click(object sender, EventArgs e)
        {
            string prodId = orderProductIDField.Text;
            string supplierId = inventoryProcess.getSupplierId(orderProductsuppCmb.Text);
            int qty = Convert.ToInt32(orderProductQtyField.Text);
            DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
            string status = "Ordered";

            DateOnly estDate = DateOnly.Parse(estimatedArrivalLbl.Text);
            if (qty == 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }
            inventoryProcess.addOrder(currentDate, supplierId, prodId, qty, status, estDate);
            MessageBox.Show("Order placed successfully! returning to Order Page");
            returnToPreviousTab();
            setupOrderPage();

        }

        private void orderProductsuppCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadOrderProductNameCmb();
        }

        private void orderProductNamecmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadOrderProductValues();
        }


        private void orderProductQtyField_KeyUp(object sender, KeyEventArgs e)
        {
            orderProductQtyField.Text = orderProductQtyField.Text.Trim();

            if (orderProductQtyField.Text == " " || orderProductQtyField.Text.IsNullOrEmpty())
            {
                orderProductQtyField.Text = "0";

            }
            int qty = Convert.ToInt32(orderProductQtyField.Text);



            orderTotalLbl.Text = (qty * Convert.ToDouble(orderProductPriceField.Text)).ToString();

        }

        private void selectedStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterOrders();
        }

        private void orderTables_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ignore clicks on header row or out-of-range indexes
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;
            int orderId = 0;

            if (ordersTable.Columns[e.ColumnIndex].Name == "More")
            {
                orderId = Convert.ToInt16(ordersTable.Rows[e.RowIndex].Cells["orderId"].Value);

                var cellRect = ordersTable.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                var cellScreenLocation = ordersTable.PointToScreen(new Point(cellRect.X, cellRect.Y + cellRect.Height));

                headerLbl.Text = "Orders/ View information";
                Orders orders = inventoryProcess.getOrder(orderId);
                tabControl1.SelectedTab = OrderInformation;
                setupOrderInformationPanel(orders);





            }
        }

        private void recieveOrderBtn_Click(object sender, EventArgs e)
        {

            string status = viewOrderStatusLbl.Text;
            DateOnly arrivalDate = DateOnly.Parse(ViewEstArrivalLbl.Text);
            DateOnly dateNow = DateOnly.FromDateTime(DateTime.Now);
            int qty = Convert.ToInt32(viewProdQtyOrderLbl.Text);

            //ViewdateOrderedLbl.Text;
            //viewProductSupOrderLbl.Text;
            string productName = viewProductNameOrderLbl.Text;
            List<Product> product = inventoryProcess.getProductByName(productName);


            product[0].Quantity = qty;

            if (status == "Ordered")
            {
                int orderId = Convert.ToInt16(viewOrderIdLbl.Text);
                MessageBox.Show("Order Receive succesfully please view your stocks");
                inventoryProcess.updateProduct(product[0].Name, product[0].Id, product[0].Quantity, product[0].Price, product[0].supplierId, product[0].category);
                inventoryProcess.updateOrder(orderId, "Received");
                ReloadOrderGrid(inventoryProcess.getOrders());
                returnToPreviousTab();
            }
            else
            {
                MessageBox.Show("Cannot receive item yet");
            }




        }
        private void delOrderBtn_Click(object sender, EventArgs e)
        {
            string status = viewOrderStatusLbl.Text;
            int orderId = Convert.ToInt16(viewOrderIdLbl.Text);

            DialogResult result = MessageBox.Show(
    "Are you sure you want to delete this order?",
    "Confirm Action",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question
);

            if (result == DialogResult.No)
            {
                return;
            }

            if (status == "Ordered")
            {
                MessageBox.Show("Cannot delete order that has been received");
                return;
            }

            inventoryProcess.removeOrder(orderId);
            MessageBox.Show("Order deleted successfully");
            returnToPreviousTab();
            setupOrderPage();


        }
        private void orderPanelSearchField_KeyUp(object sender, KeyEventArgs e)
        {
            FilterOrders();


        }




        //View stocks method
        private void setupStocksTable()
        {

            stocksTable.AutoGenerateColumns = false;


            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();

            col1.Name = "ProductID";
            col1.DataPropertyName = "ProductID";
            col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();

            col2.Name = "ProductName";
            col2.DataPropertyName = "ProductName";
            col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col2.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;


            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();

            col3.Name = "ProductQty";
            col3.DataPropertyName = "ProductQty";
            col3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col3.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            DataGridViewTextBoxColumn col4 = new DataGridViewTextBoxColumn();

            col4.Name = "DateModified";
            col4.DataPropertyName = "DateModified";
            col4.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            col4.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



            DataGridViewImageColumn moreCol = new DataGridViewImageColumn();
            moreCol.Image = Resources.moreIcon;
            moreCol.Name = "More";

            moreCol.Width = 40;
            moreCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;

            DataGridViewImageColumn warningCol = new DataGridViewImageColumn();

            warningCol.Name = "Warning";

            warningCol.Width = 40;
            warningCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;


            stocksTable.Columns.AddRange(new DataGridViewColumn[] { col1, col2, col3, col4, moreCol, warningCol });

            StyleDataGridView(stocksTable);


        }

        private void ReloadStocksGrid(List<Product> updatedProduct)
        {

            try
            {


                var filteredData = updatedProduct.Select(p => new
                {
                    ProductID = p.Id,
                    ProductName = p.Name,
                    ProductCategory = p.category,
                    ProductQty = p.Quantity,
                    DateModified = p.dateModified.ToString("dd/MM/yyyy")

                }).ToList();

                if (filteredData.Count == 0)
                {
                    stocksTablePrompt.Visible = true;
                    return;
                }



                stocksTablePrompt.Visible = false;
                stocksTable.DataSource = null;
                stocksTable.DataSource = filteredData;

                for (int i = 0; i < stocksTable.Rows.Count; i++)
                {
                    var row = stocksTable.Rows[i];


                    var qtyValue = row.Cells["ProductQty"].Value?.ToString();
                    int qty = Convert.ToInt16(qtyValue);


                    if (qty == 0)
                    {
                        row.Cells["Warning"].Value = Resources.warningIcon;
                    }
                    else
                    {

                        row.Cells["Warning"].Value = Resources.newBlankIcon;

                    }
                }
                StyleDataGridView(stocksTable);
                stocksTable.ClearSelection();
                stocksTable.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reloading product grid: " + ex.Message);
            }
        }
        private void setupStocksPage()
        {
            products = inventoryProcess.getProducts();
            headerLbl.Text = "Stocks";
            tabControl1.SelectedTab = viewStocks;
            List<Product> updatedProduct = products;
            ReloadStocksGrid(updatedProduct);

        }
        private void setupInvoicePanel(string selectedId)
        {
            List<Product> product = inventoryProcess.getProductById(selectedId);

            invoiceProdName.Text = product[0].Name;
            InvoiceDateMod.Text = product[0].dateModified.ToString("dd/MM/yyyy");
            invoiceProdPrice.Text = product[0].Price.ToString();
            InvoiceSalesQty.Text = "0";
            invoiceProdQuantity.Text = product[0].Quantity.ToString();
            InvoiceSup.Text = inventoryProcess.getSupplierName(product[0].supplierId);
            InvoiceProdCat.Text = product[0].category;
            InvoiceTotalSalesQty.Text = "";


        }



        //view stockss action method

        private void viewStocksBtn_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = viewStocks;
            setupStocksPage();
        }




        private void stocksTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Assuming icon columns are at index 3 and 4 (adjust as needed)
            if (stocksTable.Columns[e.ColumnIndex].Name == "More")
            {
                string selectedProdId = stocksTable.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                //MessageBox.Show($"Edit clicked for Product ID: {productId}");


                tabControl1.SelectedTab = invoicePanel;
                setupInvoicePanel(selectedProdId);

            }
            else if (stocksTable.Columns[e.ColumnIndex].Name == "Warning")
            {
                string selectedProdId = stocksTable.Rows[e.RowIndex].Cells["ProductID"].Value.ToString();
                Rectangle cellRect = stocksTable.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
                Point locationOnScreen = stocksTable.PointToScreen(new Point(cellRect.X, cellRect.Y));

                outOfStockStrip.Show(locationOnScreen);

                selectedStock = selectedProdId;
            }
        }


        private void addStocks_Click(object sender, EventArgs e)
        {
            setupOrderProductPage();
            tabControl1.SelectedTab = orderProduct;
        }
        private void CreateInvoiceBtn_Click(object sender, EventArgs e)
        {
            double totalSales = Convert.ToDouble(InvoiceTotalSalesQty.Text);

            if (totalSales == 0 || string.IsNullOrEmpty(InvoiceSalesQty.Text) || InvoiceSalesQty.Text == "0")
            {
                MessageBox.Show("Please enter a valid sales quantity.");
                return;
            }

            int salesQty = Convert.ToInt32(InvoiceSalesQty.Text);
            int productQty = Convert.ToInt32(invoiceProdQuantity.Text);
            if (salesQty > productQty)
            {
                MessageBox.Show("Sales quantity cannot be greater than product quantity.");
                InvoiceSalesQty.Text = "0";
                InvoiceTotalSalesQty.Text = "0";
                return;
            }


            int newQuantity = productQty - salesQty;
            string productName = invoiceProdName.Text.Trim();
            List<Product> product = inventoryProcess.getProductByName(productName);
            product[0].Quantity = newQuantity;

            DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);


            inventoryProcess.updateProduct(product[0].Name, product[0].Id, product[0].Quantity, product[0].Price, product[0].supplierId, product[0].category);
            // I CAN MODIFY LATER TO IF I ADD A SALES TABLE
            MessageBox.Show("Invoice created successfully! Returning to Stocks Page");
            returnToPreviousTab();
            setupStocksPage();


        }

        private void InvoiceSalesQty_KeyUp(object sender, KeyEventArgs e)
        {
            if (InvoiceSalesQty.Text == "" || InvoiceSalesQty.Text == "0" || string.IsNullOrEmpty(InvoiceSalesQty.Text))
            {
                InvoiceTotalSalesQty.Text = "0";
                return;
            }

            int salesQty = Convert.ToInt32(InvoiceSalesQty.Text);
            int productQty = Convert.ToInt32(invoiceProdQuantity.Text);
            if (salesQty > productQty)
            {
                MessageBox.Show("Sales quantity cannot be greater than product quantity.");
                InvoiceSalesQty.Text = "0";
                InvoiceTotalSalesQty.Text = "0";
                return;
            }

            double productPrice = Convert.ToDouble(invoiceProdPrice.Text);

            InvoiceTotalSalesQty.Text = (salesQty * productPrice).ToString("F2");





        }

        //General MEthods
        private void returnToPreviousTab()
        {
            int tab = tabControl1.SelectedIndex;
            int movement = 1;
            if (tab == 0)
            {
                return;
            }
            if (tabControl1.SelectedTab == addProduct || tabControl1.SelectedTab == orderProduct || tabControl1.SelectedTab == addSupplier)
            {
                movement = 2;
            }

            headerLbl.Text = tabControl1.SelectedTab.Text;
            tabControl1.SelectedIndex = tab - movement;



        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            returnToPreviousTab();
        }
        private void categoryMoreBtn_Click(object sender, EventArgs e)
        {
            var locationOnScreen = categoryMoreBtn.PointToScreen(new Point(0, categoryMoreBtn.Height));

            categoryMore.Show(locationOnScreen);
        }
        private void supplierMoreBtn_Click(object sender, EventArgs e)
        {
            var locationOnScreen = supplierMoreBtn.PointToScreen(new Point(0, supplierMoreBtn.Height));


            supplierMoreStrip.Show(locationOnScreen);
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Category AddCategory = new Category(this);
            AddCategory.Show();
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

            grid.DefaultCellStyle.Font = new Font("Arial", 10F);
            grid.DefaultCellStyle.Padding = new Padding(0, 8, 0, 8);
            grid.AllowUserToResizeColumns = false;
            grid.AllowUserToResizeRows = false;
            grid.GridColor = Color.LightGray;
        }
        public void loadCategoriesNSsupplier()
        {
            cmbCategory.DataSource = inventoryProcess.GetCategoryNames();
            cmbSuppliers.DataSource = inventoryProcess.getSupplierNames();

        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = supplierMorePanel;
        }

        private void profileBtn_Click(object sender, EventArgs e)
        {
            var locationOnScreen = profileBtn.PointToScreen(new Point(0, profileBtn.Height));
            accountStrip.Show(locationOnScreen);
        }

        private void regAccount_Click(object sender, EventArgs e)
        {
            registrationForm regForm = new registrationForm();
            regForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
    "Are you sure you want to Exit the application?",
    "Confirm Action",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question
);

            if (result == DialogResult.No)
            {
                return;
            }
            this.Close();
        }
    }


}
