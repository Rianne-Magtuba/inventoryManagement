using BusinessLogic;
using InventoryCommon;
using System.Windows.Forms;

namespace inventoryManagementGUI
{
    partial class mainForm 
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
        /// 

        static inventoryProcess inventoryProcess = new inventoryProcess();
        List<Product> productList  = inventoryProcess.getProducts();

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button4 = new Button();
            supplierNavbtn = new Button();
            viewStocksBtn = new Button();
            OrderTabNavBtn = new Button();
            label8 = new Label();
            viewProdBtn = new Button();
            dashBoardNavBtn = new Button();
            tabControl1 = new TabControl();
            Dashboard = new TabPage();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            OutOfStockLbl = new Label();
            totalStocksLbl = new Label();
            label74 = new Label();
            label73 = new Label();
            NoOfProdLblOverView = new Label();
            lowStockLblOverView = new Label();
            label72 = new Label();
            label71 = new Label();
            arrivingSoonPrompt = new Label();
            arrivingProductTable = new DataGridView();
            label70 = new Label();
            label69 = new Label();
            productOverviewMenuBtn = new PictureBox();
            stocksOverviewMenuBtn = new PictureBox();
            arrivingSoonMenu = new PictureBox();
            label68 = new Label();
            label67 = new Label();
            label65 = new Label();
            cyberTextBox47 = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox46 = new ReaLTaiizor.Controls.CyberTextBox();
            label11 = new Label();
            cyberTextBox45 = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox44 = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox43 = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox42 = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox41 = new ReaLTaiizor.Controls.CyberTextBox();
            viewProducts = new TabPage();
            textBox3 = new TextBox();
            productPageCatCmb = new ReaLTaiizor.Controls.DungeonComboBox();
            cyberTextBox27 = new ReaLTaiizor.Controls.CyberTextBox();
            pictureBox1 = new PictureBox();
            noProductPrompt = new Label();
            addProductNavBtn = new ReaLTaiizor.Controls.CyberButton();
            searchProductField = new TextBox();
            cyberTextBox24 = new ReaLTaiizor.Controls.CyberTextBox();
            label10 = new Label();
            label9 = new Label();
            label1 = new Label();
            cyberTextBox25 = new ReaLTaiizor.Controls.CyberTextBox();
            productTable = new DataGridView();
            productMorePage = new TabPage();
            returnToProductView = new ReaLTaiizor.Controls.CyberButton();
            editProductBtn = new ReaLTaiizor.Controls.CyberButton();
            supplierMoreBtn = new Button();
            categoryMoreBtn = new Button();
            editProductSaveBtn = new ReaLTaiizor.Controls.CyberButton();
            ProdDateModified = new Label();
            label18 = new Label();
            prodQtyMinus = new ReaLTaiizor.Controls.CyberButton();
            prodQtyAdd = new ReaLTaiizor.Controls.CyberButton();
            MoreProductQty = new TextBox();
            label16 = new Label();
            cyberTextBox4 = new ReaLTaiizor.Controls.CyberTextBox();
            label15 = new Label();
            moreProductPriceField = new TextBox();
            cyberTextBox2 = new ReaLTaiizor.Controls.CyberTextBox();
            moreProductNameField = new TextBox();
            cmbSuppliers = new ReaLTaiizor.Controls.DungeonComboBox();
            cmbCategory = new ReaLTaiizor.Controls.DungeonComboBox();
            cyberTextBox3 = new ReaLTaiizor.Controls.CyberTextBox();
            label14 = new Label();
            lbltextt = new ReaLTaiizor.Controls.CyberTextBox();
            label13 = new Label();
            cyberTextBox1 = new ReaLTaiizor.Controls.CyberTextBox();
            label12 = new Label();
            ProductMorePageHdr = new Label();
            textBox2 = new TextBox();
            addProduct = new TabPage();
            label37 = new Label();
            textBox12 = new TextBox();
            addProdSupViewMore = new Button();
            addProdCatViewMore = new Button();
            addProductBtn = new ReaLTaiizor.Controls.CyberButton();
            label36 = new Label();
            addProductIdField = new TextBox();
            addProductSupplierCmb = new ReaLTaiizor.Controls.DungeonComboBox();
            addProductCategoryCmb = new ReaLTaiizor.Controls.DungeonComboBox();
            label38 = new Label();
            label39 = new Label();
            label40 = new Label();
            addProductPrice = new TextBox();
            cyberTextBox19 = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox20 = new ReaLTaiizor.Controls.CyberTextBox();
            addProductNameField = new TextBox();
            cyberTextBox21 = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox22 = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox23 = new ReaLTaiizor.Controls.CyberTextBox();
            label41 = new Label();
            Orders = new TabPage();
            textBox1 = new TextBox();
            selectedStatus = new ReaLTaiizor.Controls.DungeonComboBox();
            cyberTextBox40 = new ReaLTaiizor.Controls.CyberTextBox();
            label42 = new Label();
            noOrdersPrompt = new Label();
            pictureBox4 = new PictureBox();
            orderProdNavBtn = new ReaLTaiizor.Controls.CyberButton();
            orderPanelSearchField = new TextBox();
            label17 = new Label();
            label34 = new Label();
            label35 = new Label();
            cyberTextBox18 = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox26 = new ReaLTaiizor.Controls.CyberTextBox();
            ordersTable = new DataGridView();
            OrderInformation = new TabPage();
            delOrderBtn = new ReaLTaiizor.Controls.CyberButton();
            recieveOrderBtn = new ReaLTaiizor.Controls.CyberButton();
            viewOrderStatusLbl = new Label();
            label52 = new Label();
            ViewEstArrivalLbl = new Label();
            label51 = new Label();
            label50 = new Label();
            label49 = new Label();
            label48 = new Label();
            label47 = new Label();
            viewProdQtyOrderLbl = new TextBox();
            cyberTextBox31 = new ReaLTaiizor.Controls.CyberTextBox();
            viewOrderIdLbl = new TextBox();
            cyberTextBox30 = new ReaLTaiizor.Controls.CyberTextBox();
            viewProductSupOrderLbl = new TextBox();
            cyberTextBox29 = new ReaLTaiizor.Controls.CyberTextBox();
            label46 = new Label();
            textBox5 = new TextBox();
            ViewdateOrderedLbl = new Label();
            label45 = new Label();
            viewProductNameOrderLbl = new TextBox();
            cyberTextBox28 = new ReaLTaiizor.Controls.CyberTextBox();
            orderProduct = new TabPage();
            estimatedArrivalLbl = new Label();
            label44 = new Label();
            orderTotalLbl = new Label();
            label43 = new Label();
            orderProductCatField = new TextBox();
            orderProductIDField = new TextBox();
            orderProductNamecmb = new ReaLTaiizor.Controls.DungeonComboBox();
            label19 = new Label();
            orderProductBtn = new ReaLTaiizor.Controls.CyberButton();
            orderProductQtyField = new TextBox();
            label5 = new Label();
            orderProductsuppCmb = new ReaLTaiizor.Controls.DungeonComboBox();
            label6 = new Label();
            label7 = new Label();
            label2 = new Label();
            orderProductPriceField = new TextBox();
            cyberTextBox5 = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox8 = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox6 = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox9 = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox7 = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox10 = new ReaLTaiizor.Controls.CyberTextBox();
            label3 = new Label();
            label4 = new Label();
            textBox7 = new TextBox();
            viewStocks = new TabPage();
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            label56 = new Label();
            label55 = new Label();
            label54 = new Label();
            label53 = new Label();
            stocksSearchField = new TextBox();
            pictureBox5 = new PictureBox();
            stocksTablePrompt = new Label();
            cyberTextBox32 = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox33 = new ReaLTaiizor.Controls.CyberTextBox();
            stocksTable = new DataGridView();
            invoicePanel = new TabPage();
            InvoiceSup = new TextBox();
            InvoiceProdCat = new TextBox();
            invoiceProdQuantity = new TextBox();
            invoiceOrderProdBtn = new ReaLTaiizor.Controls.CyberButton();
            InvoiceTotalSalesQty = new Label();
            label66 = new Label();
            InvoiceSalesQty = new TextBox();
            label64 = new Label();
            cyberTextBox39 = new ReaLTaiizor.Controls.CyberTextBox();
            CreateInvoiceBtn = new ReaLTaiizor.Controls.CyberButton();
            InvoiceDateMod = new Label();
            label57 = new Label();
            invoiceProdQty = new TextBox();
            label58 = new Label();
            cyberTextBox34 = new ReaLTaiizor.Controls.CyberTextBox();
            label59 = new Label();
            invoiceProdPrice = new TextBox();
            cyberTextBox35 = new ReaLTaiizor.Controls.CyberTextBox();
            invoiceProdName = new TextBox();
            cyberTextBox36 = new ReaLTaiizor.Controls.CyberTextBox();
            label60 = new Label();
            cyberTextBox37 = new ReaLTaiizor.Controls.CyberTextBox();
            label61 = new Label();
            cyberTextBox38 = new ReaLTaiizor.Controls.CyberTextBox();
            label62 = new Label();
            label63 = new Label();
            textBox10 = new TextBox();
            supplierPanel = new TabPage();
            supplierHdrPrompt = new Label();
            pictureBox2 = new PictureBox();
            addSupplierNavBtn = new ReaLTaiizor.Controls.CyberButton();
            searchSupplierField = new TextBox();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            cyberTextBox12 = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox11 = new ReaLTaiizor.Controls.CyberTextBox();
            supplierTable = new DataGridView();
            supplierMorePanel = new TabPage();
            saveSupChangesBtn = new ReaLTaiizor.Controls.CyberButton();
            stopEditingSupBtn = new ReaLTaiizor.Controls.CyberButton();
            editSupplierBtn = new ReaLTaiizor.Controls.CyberButton();
            moreSupIdField = new TextBox();
            moreSupAddressField = new TextBox();
            moreSupEmailField = new TextBox();
            moreSupNumField = new TextBox();
            moreSupNameField = new TextBox();
            moreSupProductLbl = new Label();
            info_supplierProductsCmb = new ReaLTaiizor.Controls.DungeonComboBox();
            info_supplierAdd = new ReaLTaiizor.Controls.CyberTextBox();
            moreSupProdBg = new ReaLTaiizor.Controls.CyberTextBox();
            label29 = new Label();
            info_supplierEmail = new ReaLTaiizor.Controls.CyberTextBox();
            label30 = new Label();
            info_supplierNum = new ReaLTaiizor.Controls.CyberTextBox();
            label31 = new Label();
            label32 = new Label();
            info_supplierId = new ReaLTaiizor.Controls.CyberTextBox();
            info_supplierName = new ReaLTaiizor.Controls.CyberTextBox();
            label33 = new Label();
            supllierMoreHdr = new Label();
            textBox6 = new TextBox();
            addSupplier = new TabPage();
            addSupplierBtn = new ReaLTaiizor.Controls.CyberButton();
            addSupplierAddress = new TextBox();
            cyberTextBox17 = new ReaLTaiizor.Controls.CyberTextBox();
            label28 = new Label();
            addSupplierEmail = new TextBox();
            cyberTextBox16 = new ReaLTaiizor.Controls.CyberTextBox();
            label27 = new Label();
            addSupplierNum = new TextBox();
            cyberTextBox15 = new ReaLTaiizor.Controls.CyberTextBox();
            label26 = new Label();
            label23 = new Label();
            addSupplierId = new TextBox();
            cyberTextBox13 = new ReaLTaiizor.Controls.CyberTextBox();
            addSupplierName = new TextBox();
            cyberTextBox14 = new ReaLTaiizor.Controls.CyberTextBox();
            label24 = new Label();
            label25 = new Label();
            textBox8 = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            userLbl = new Label();
            headerLbl = new Label();
            categoryMore = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            supplierMoreStrip = new ContextMenuStrip(components);
            toolStripMenuItem2 = new ToolStripMenuItem();
            returnBtn = new Button();
            outOfStockStrip = new ContextMenuStrip(components);
            addStocks = new ToolStripMenuItem();
            profileBtn = new Button();
            accountStrip = new ContextMenuStrip(components);
            regAccount = new ToolStripMenuItem();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            Dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arrivingProductTable).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productOverviewMenuBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stocksOverviewMenuBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)arrivingSoonMenu).BeginInit();
            viewProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productTable).BeginInit();
            productMorePage.SuspendLayout();
            addProduct.SuspendLayout();
            Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ordersTable).BeginInit();
            OrderInformation.SuspendLayout();
            orderProduct.SuspendLayout();
            viewStocks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stocksTable).BeginInit();
            invoicePanel.SuspendLayout();
            supplierPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)supplierTable).BeginInit();
            supplierMorePanel.SuspendLayout();
            addSupplier.SuspendLayout();
            categoryMore.SuspendLayout();
            supplierMoreStrip.SuspendLayout();
            outOfStockStrip.SuspendLayout();
            accountStrip.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 30);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(supplierNavbtn);
            panel1.Controls.Add(viewStocksBtn);
            panel1.Controls.Add(OrderTabNavBtn);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(viewProdBtn);
            panel1.Controls.Add(dashBoardNavBtn);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(374, 1139);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial", 10F);
            button4.ForeColor = Color.White;
            button4.Location = new Point(2, 770);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(368, 86);
            button4.TabIndex = 9;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // supplierNavbtn
            // 
            supplierNavbtn.FlatAppearance.BorderSize = 0;
            supplierNavbtn.FlatStyle = FlatStyle.Flat;
            supplierNavbtn.Font = new Font("Arial", 10F);
            supplierNavbtn.ForeColor = Color.White;
            supplierNavbtn.Image = Resources.supplierIcon;
            supplierNavbtn.ImageAlign = ContentAlignment.MiddleLeft;
            supplierNavbtn.Location = new Point(4, 561);
            supplierNavbtn.Margin = new Padding(4);
            supplierNavbtn.Name = "supplierNavbtn";
            supplierNavbtn.Padding = new Padding(42, 0, 20, 0);
            supplierNavbtn.Size = new Size(368, 86);
            supplierNavbtn.TabIndex = 8;
            supplierNavbtn.Text = "Suppliers";
            supplierNavbtn.UseVisualStyleBackColor = true;
            supplierNavbtn.Click += supplierNavbtn_Click;
            // 
            // viewStocksBtn
            // 
            viewStocksBtn.FlatAppearance.BorderSize = 0;
            viewStocksBtn.FlatStyle = FlatStyle.Flat;
            viewStocksBtn.Font = new Font("Arial", 10F);
            viewStocksBtn.ForeColor = Color.White;
            viewStocksBtn.Image = Resources.stocksIcon;
            viewStocksBtn.ImageAlign = ContentAlignment.MiddleLeft;
            viewStocksBtn.Location = new Point(-2, 467);
            viewStocksBtn.Margin = new Padding(4);
            viewStocksBtn.Name = "viewStocksBtn";
            viewStocksBtn.Padding = new Padding(42, 0, 0, 0);
            viewStocksBtn.Size = new Size(368, 86);
            viewStocksBtn.TabIndex = 7;
            viewStocksBtn.Text = "View Stocks";
            viewStocksBtn.UseVisualStyleBackColor = true;
            viewStocksBtn.Click += viewStocksBtn_Click;
            // 
            // OrderTabNavBtn
            // 
            OrderTabNavBtn.FlatAppearance.BorderSize = 0;
            OrderTabNavBtn.FlatStyle = FlatStyle.Flat;
            OrderTabNavBtn.Font = new Font("Arial", 10F);
            OrderTabNavBtn.ForeColor = Color.White;
            OrderTabNavBtn.Image = Resources.orderProducts_icon;
            OrderTabNavBtn.ImageAlign = ContentAlignment.MiddleLeft;
            OrderTabNavBtn.Location = new Point(2, 373);
            OrderTabNavBtn.Margin = new Padding(4);
            OrderTabNavBtn.Name = "OrderTabNavBtn";
            OrderTabNavBtn.Padding = new Padding(42, 0, 30, 0);
            OrderTabNavBtn.Size = new Size(368, 86);
            OrderTabNavBtn.TabIndex = 6;
            OrderTabNavBtn.Text = "Orders";
            OrderTabNavBtn.UseVisualStyleBackColor = true;
            OrderTabNavBtn.Click += OrderTabNavBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(30, 30, 30);
            label8.Font = new Font("Arial", 12F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(76, 30);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(211, 54);
            label8.TabIndex = 5;
            label8.Text = "Computer \n Inventory System ";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // viewProdBtn
            // 
            viewProdBtn.BackgroundImageLayout = ImageLayout.None;
            viewProdBtn.FlatAppearance.BorderSize = 0;
            viewProdBtn.FlatStyle = FlatStyle.Flat;
            viewProdBtn.Font = new Font("Arial", 10F);
            viewProdBtn.ForeColor = Color.White;
            viewProdBtn.Image = Resources.product_icon;
            viewProdBtn.ImageAlign = ContentAlignment.MiddleLeft;
            viewProdBtn.Location = new Point(0, 279);
            viewProdBtn.Margin = new Padding(4);
            viewProdBtn.Name = "viewProdBtn";
            viewProdBtn.Padding = new Padding(42, 0, 21, 0);
            viewProdBtn.Size = new Size(368, 86);
            viewProdBtn.TabIndex = 2;
            viewProdBtn.Text = " Products";
            viewProdBtn.UseVisualStyleBackColor = true;
            viewProdBtn.Click += viewProdBtn_Click;
            // 
            // dashBoardNavBtn
            // 
            dashBoardNavBtn.FlatAppearance.BorderSize = 0;
            dashBoardNavBtn.FlatStyle = FlatStyle.Flat;
            dashBoardNavBtn.Font = new Font("Arial", 10F);
            dashBoardNavBtn.ForeColor = Color.White;
            dashBoardNavBtn.Image = Resources.dashboard_icon;
            dashBoardNavBtn.ImageAlign = ContentAlignment.MiddleLeft;
            dashBoardNavBtn.Location = new Point(0, 176);
            dashBoardNavBtn.Margin = new Padding(4);
            dashBoardNavBtn.Name = "dashBoardNavBtn";
            dashBoardNavBtn.Padding = new Padding(42, 0, 14, 0);
            dashBoardNavBtn.Size = new Size(368, 86);
            dashBoardNavBtn.TabIndex = 1;
            dashBoardNavBtn.Text = "Dashboard";
            dashBoardNavBtn.UseVisualStyleBackColor = true;
            dashBoardNavBtn.Click += dashBoardNavBtn_Click;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(Dashboard);
            tabControl1.Controls.Add(viewProducts);
            tabControl1.Controls.Add(productMorePage);
            tabControl1.Controls.Add(addProduct);
            tabControl1.Controls.Add(Orders);
            tabControl1.Controls.Add(OrderInformation);
            tabControl1.Controls.Add(orderProduct);
            tabControl1.Controls.Add(viewStocks);
            tabControl1.Controls.Add(invoicePanel);
            tabControl1.Controls.Add(supplierPanel);
            tabControl1.Controls.Add(supplierMorePanel);
            tabControl1.Controls.Add(addSupplier);
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.Location = new Point(369, 115);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1148, 804);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 1;
            tabControl1.TabStop = false;
            // 
            // Dashboard
            // 
            Dashboard.Controls.Add(pictureBox6);
            Dashboard.Controls.Add(pictureBox7);
            Dashboard.Controls.Add(OutOfStockLbl);
            Dashboard.Controls.Add(totalStocksLbl);
            Dashboard.Controls.Add(label74);
            Dashboard.Controls.Add(label73);
            Dashboard.Controls.Add(NoOfProdLblOverView);
            Dashboard.Controls.Add(lowStockLblOverView);
            Dashboard.Controls.Add(label72);
            Dashboard.Controls.Add(label71);
            Dashboard.Controls.Add(arrivingSoonPrompt);
            Dashboard.Controls.Add(arrivingProductTable);
            Dashboard.Controls.Add(label70);
            Dashboard.Controls.Add(label69);
            Dashboard.Controls.Add(productOverviewMenuBtn);
            Dashboard.Controls.Add(stocksOverviewMenuBtn);
            Dashboard.Controls.Add(arrivingSoonMenu);
            Dashboard.Controls.Add(label68);
            Dashboard.Controls.Add(label67);
            Dashboard.Controls.Add(label65);
            Dashboard.Controls.Add(cyberTextBox47);
            Dashboard.Controls.Add(cyberTextBox46);
            Dashboard.Controls.Add(label11);
            Dashboard.Controls.Add(cyberTextBox45);
            Dashboard.Controls.Add(cyberTextBox44);
            Dashboard.Controls.Add(cyberTextBox43);
            Dashboard.Controls.Add(cyberTextBox42);
            Dashboard.Controls.Add(cyberTextBox41);
            Dashboard.Location = new Point(4, 5);
            Dashboard.Margin = new Padding(4);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(1140, 795);
            Dashboard.TabIndex = 2;
            Dashboard.Text = "tabPage3";
            Dashboard.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.White;
            pictureBox6.Image = Resources.boxIcon50;
            pictureBox6.Location = new Point(599, 195);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(47, 50);
            pictureBox6.TabIndex = 71;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.White;
            pictureBox7.Image = Resources.warningIcon50;
            pictureBox7.Location = new Point(860, 195);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(50, 50);
            pictureBox7.TabIndex = 70;
            pictureBox7.TabStop = false;
            // 
            // OutOfStockLbl
            // 
            OutOfStockLbl.AutoSize = true;
            OutOfStockLbl.BackColor = Color.White;
            OutOfStockLbl.Font = new Font("Arial", 13F, FontStyle.Bold);
            OutOfStockLbl.Location = new Point(962, 195);
            OutOfStockLbl.Margin = new Padding(4, 0, 4, 0);
            OutOfStockLbl.Name = "OutOfStockLbl";
            OutOfStockLbl.Size = new Size(41, 30);
            OutOfStockLbl.TabIndex = 68;
            OutOfStockLbl.Text = "99";
            // 
            // totalStocksLbl
            // 
            totalStocksLbl.AutoSize = true;
            totalStocksLbl.BackColor = Color.White;
            totalStocksLbl.Font = new Font("Arial", 13F, FontStyle.Bold);
            totalStocksLbl.Location = new Point(704, 195);
            totalStocksLbl.Margin = new Padding(4, 0, 4, 0);
            totalStocksLbl.Name = "totalStocksLbl";
            totalStocksLbl.Size = new Size(41, 30);
            totalStocksLbl.TabIndex = 67;
            totalStocksLbl.Text = "99";
            // 
            // label74
            // 
            label74.AutoSize = true;
            label74.BackColor = Color.White;
            label74.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label74.Location = new Point(928, 235);
            label74.Margin = new Padding(4, 0, 4, 0);
            label74.Name = "label74";
            label74.Size = new Size(109, 21);
            label74.TabIndex = 66;
            label74.Text = "Out of Stock";
            // 
            // label73
            // 
            label73.AutoSize = true;
            label73.BackColor = Color.White;
            label73.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label73.Location = new Point(666, 235);
            label73.Margin = new Padding(4, 0, 4, 0);
            label73.Name = "label73";
            label73.Size = new Size(108, 21);
            label73.TabIndex = 65;
            label73.Text = "Total Stocks";
            // 
            // NoOfProdLblOverView
            // 
            NoOfProdLblOverView.AutoSize = true;
            NoOfProdLblOverView.BackColor = Color.White;
            NoOfProdLblOverView.Font = new Font("Arial", 13F, FontStyle.Bold);
            NoOfProdLblOverView.Location = new Point(923, 591);
            NoOfProdLblOverView.Margin = new Padding(4, 0, 4, 0);
            NoOfProdLblOverView.Name = "NoOfProdLblOverView";
            NoOfProdLblOverView.Size = new Size(41, 30);
            NoOfProdLblOverView.TabIndex = 64;
            NoOfProdLblOverView.Text = "99";
            // 
            // lowStockLblOverView
            // 
            lowStockLblOverView.AutoSize = true;
            lowStockLblOverView.BackColor = Color.White;
            lowStockLblOverView.Font = new Font("Arial", 13F, FontStyle.Bold);
            lowStockLblOverView.Location = new Point(923, 522);
            lowStockLblOverView.Margin = new Padding(4, 0, 4, 0);
            lowStockLblOverView.Name = "lowStockLblOverView";
            lowStockLblOverView.Size = new Size(41, 30);
            lowStockLblOverView.TabIndex = 63;
            lowStockLblOverView.Text = "99";
            // 
            // label72
            // 
            label72.AutoSize = true;
            label72.BackColor = Color.White;
            label72.Font = new Font("Arial", 11F, FontStyle.Bold);
            label72.Location = new Point(586, 595);
            label72.Margin = new Padding(4, 0, 4, 0);
            label72.Name = "label72";
            label72.Size = new Size(172, 26);
            label72.TabIndex = 62;
            label72.Text = "No. of Products";
            // 
            // label71
            // 
            label71.AutoSize = true;
            label71.BackColor = Color.White;
            label71.Font = new Font("Arial", 11F, FontStyle.Bold);
            label71.Location = new Point(586, 522);
            label71.Margin = new Padding(4, 0, 4, 0);
            label71.Name = "label71";
            label71.Size = new Size(209, 26);
            label71.TabIndex = 61;
            label71.Text = "Low Stock Product";
            // 
            // arrivingSoonPrompt
            // 
            arrivingSoonPrompt.AutoSize = true;
            arrivingSoonPrompt.BackColor = Color.White;
            arrivingSoonPrompt.Font = new Font("Arial", 10F, FontStyle.Bold);
            arrivingSoonPrompt.Location = new Point(120, 315);
            arrivingSoonPrompt.Margin = new Padding(4, 0, 4, 0);
            arrivingSoonPrompt.Name = "arrivingSoonPrompt";
            arrivingSoonPrompt.Size = new Size(258, 24);
            arrivingSoonPrompt.TabIndex = 60;
            arrivingSoonPrompt.Text = "No products arriving soon";
            // 
            // arrivingProductTable
            // 
            arrivingProductTable.BackgroundColor = Color.White;
            arrivingProductTable.BorderStyle = BorderStyle.None;
            arrivingProductTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.LightGray;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            arrivingProductTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            arrivingProductTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            arrivingProductTable.DefaultCellStyle = dataGridViewCellStyle2;
            arrivingProductTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            arrivingProductTable.EnableHeadersVisualStyles = false;
            arrivingProductTable.GridColor = Color.White;
            arrivingProductTable.Location = new Point(90, 264);
            arrivingProductTable.Margin = new Padding(4);
            arrivingProductTable.Name = "arrivingProductTable";
            arrivingProductTable.ReadOnly = true;
            arrivingProductTable.RowHeadersVisible = false;
            arrivingProductTable.RowHeadersWidth = 120;
            arrivingProductTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            arrivingProductTable.RowTemplate.Height = 50;
            arrivingProductTable.Size = new Size(309, 455);
            arrivingProductTable.TabIndex = 59;
            // 
            // label70
            // 
            label70.AutoSize = true;
            label70.BackColor = Color.White;
            label70.Font = new Font("Arial", 10F, FontStyle.Bold);
            label70.Location = new Point(274, 211);
            label70.Margin = new Padding(4, 0, 4, 0);
            label70.Name = "label70";
            label70.Size = new Size(125, 24);
            label70.TabIndex = 58;
            label70.Text = "Product Qty";
            // 
            // label69
            // 
            label69.AutoSize = true;
            label69.BackColor = Color.White;
            label69.Font = new Font("Arial", 10F, FontStyle.Bold);
            label69.Location = new Point(90, 211);
            label69.Margin = new Padding(4, 0, 4, 0);
            label69.Name = "label69";
            label69.Size = new Size(144, 24);
            label69.TabIndex = 57;
            label69.Text = "Product Name";
            // 
            // productOverviewMenuBtn
            // 
            productOverviewMenuBtn.BackColor = Color.White;
            productOverviewMenuBtn.Image = Resources.moreIcon;
            productOverviewMenuBtn.Location = new Point(1026, 441);
            productOverviewMenuBtn.Name = "productOverviewMenuBtn";
            productOverviewMenuBtn.Size = new Size(33, 37);
            productOverviewMenuBtn.TabIndex = 56;
            productOverviewMenuBtn.TabStop = false;
            productOverviewMenuBtn.Click += viewProdBtn_Click;
            // 
            // stocksOverviewMenuBtn
            // 
            stocksOverviewMenuBtn.BackColor = Color.White;
            stocksOverviewMenuBtn.Image = Resources.moreIcon;
            stocksOverviewMenuBtn.Location = new Point(1026, 97);
            stocksOverviewMenuBtn.Name = "stocksOverviewMenuBtn";
            stocksOverviewMenuBtn.Size = new Size(33, 37);
            stocksOverviewMenuBtn.TabIndex = 55;
            stocksOverviewMenuBtn.TabStop = false;
            stocksOverviewMenuBtn.Click += viewStocksBtn_Click;
            // 
            // arrivingSoonMenu
            // 
            arrivingSoonMenu.BackColor = Color.White;
            arrivingSoonMenu.Image = Resources.moreIcon;
            arrivingSoonMenu.Location = new Point(410, 117);
            arrivingSoonMenu.Name = "arrivingSoonMenu";
            arrivingSoonMenu.Size = new Size(33, 37);
            arrivingSoonMenu.TabIndex = 54;
            arrivingSoonMenu.TabStop = false;
            arrivingSoonMenu.Click += OrderTabNavBtn_Click;
            // 
            // label68
            // 
            label68.AutoSize = true;
            label68.BackColor = Color.White;
            label68.Font = new Font("Arial", 16F, FontStyle.Bold);
            label68.Location = new Point(105, 134);
            label68.Margin = new Padding(4, 0, 4, 0);
            label68.Name = "label68";
            label68.Size = new Size(95, 37);
            label68.TabIndex = 53;
            label68.Text = "Soon";
            // 
            // label67
            // 
            label67.AutoSize = true;
            label67.BackColor = Color.White;
            label67.Font = new Font("Arial", 16F, FontStyle.Bold);
            label67.Location = new Point(72, 97);
            label67.Margin = new Padding(4, 0, 4, 0);
            label67.Name = "label67";
            label67.Size = new Size(141, 37);
            label67.TabIndex = 52;
            label67.Text = "Arriving";
            // 
            // label65
            // 
            label65.AutoSize = true;
            label65.BackColor = Color.White;
            label65.Font = new Font("Arial", 16F, FontStyle.Bold);
            label65.Location = new Point(569, 441);
            label65.Margin = new Padding(4, 0, 4, 0);
            label65.Name = "label65";
            label65.Size = new Size(287, 37);
            label65.TabIndex = 51;
            label65.Text = "Product Overview";
            // 
            // cyberTextBox47
            // 
            cyberTextBox47.Alpha = 20;
            cyberTextBox47.BackColor = Color.Transparent;
            cyberTextBox47.Background_WidthPen = 3F;
            cyberTextBox47.BackgroundPen = true;
            cyberTextBox47.ColorBackground = Color.White;
            cyberTextBox47.ColorBackground_Pen = Color.Black;
            cyberTextBox47.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox47.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox47.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox47.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox47.Enabled = false;
            cyberTextBox47.Font = new Font("Arial", 18F);
            cyberTextBox47.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox47.Lighting = false;
            cyberTextBox47.LinearGradientPen = false;
            cyberTextBox47.Location = new Point(848, 182);
            cyberTextBox47.Name = "cyberTextBox47";
            cyberTextBox47.PenWidth = 15;
            cyberTextBox47.RGB = false;
            cyberTextBox47.Rounding = true;
            cyberTextBox47.RoundingInt = 30;
            cyberTextBox47.Size = new Size(73, 74);
            cyberTextBox47.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox47.TabIndex = 50;
            cyberTextBox47.TabStop = false;
            cyberTextBox47.Tag = "Cyber";
            cyberTextBox47.TextButton = "";
            cyberTextBox47.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox47.Timer_RGB = 300;
            // 
            // cyberTextBox46
            // 
            cyberTextBox46.Alpha = 20;
            cyberTextBox46.BackColor = Color.Transparent;
            cyberTextBox46.Background_WidthPen = 3F;
            cyberTextBox46.BackgroundPen = true;
            cyberTextBox46.ColorBackground = Color.White;
            cyberTextBox46.ColorBackground_Pen = Color.Black;
            cyberTextBox46.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox46.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox46.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox46.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox46.Enabled = false;
            cyberTextBox46.Font = new Font("Arial", 18F);
            cyberTextBox46.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox46.Lighting = false;
            cyberTextBox46.LinearGradientPen = false;
            cyberTextBox46.Location = new Point(586, 182);
            cyberTextBox46.Name = "cyberTextBox46";
            cyberTextBox46.PenWidth = 15;
            cyberTextBox46.RGB = false;
            cyberTextBox46.Rounding = true;
            cyberTextBox46.RoundingInt = 30;
            cyberTextBox46.Size = new Size(73, 74);
            cyberTextBox46.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox46.TabIndex = 49;
            cyberTextBox46.TabStop = false;
            cyberTextBox46.Tag = "Cyber";
            cyberTextBox46.TextButton = "";
            cyberTextBox46.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox46.Timer_RGB = 300;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.White;
            label11.Font = new Font("Arial", 16F, FontStyle.Bold);
            label11.Location = new Point(569, 88);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(273, 37);
            label11.TabIndex = 6;
            label11.Text = "Stocks Overview";
            // 
            // cyberTextBox45
            // 
            cyberTextBox45.Alpha = 20;
            cyberTextBox45.BackColor = Color.Transparent;
            cyberTextBox45.Background_WidthPen = 3F;
            cyberTextBox45.BackgroundPen = true;
            cyberTextBox45.ColorBackground = Color.White;
            cyberTextBox45.ColorBackground_Pen = Color.Black;
            cyberTextBox45.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox45.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox45.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox45.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox45.Enabled = false;
            cyberTextBox45.Font = new Font("Arial", 32F);
            cyberTextBox45.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox45.Lighting = false;
            cyberTextBox45.LinearGradientPen = false;
            cyberTextBox45.Location = new Point(823, 155);
            cyberTextBox45.Name = "cyberTextBox45";
            cyberTextBox45.PenWidth = 15;
            cyberTextBox45.RGB = false;
            cyberTextBox45.Rounding = true;
            cyberTextBox45.RoundingInt = 30;
            cyberTextBox45.Size = new Size(236, 129);
            cyberTextBox45.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox45.TabIndex = 48;
            cyberTextBox45.TabStop = false;
            cyberTextBox45.Tag = "Cyber";
            cyberTextBox45.TextButton = "";
            cyberTextBox45.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox45.Timer_RGB = 300;
            // 
            // cyberTextBox44
            // 
            cyberTextBox44.Alpha = 20;
            cyberTextBox44.BackColor = Color.Transparent;
            cyberTextBox44.Background_WidthPen = 3F;
            cyberTextBox44.BackgroundPen = true;
            cyberTextBox44.ColorBackground = Color.White;
            cyberTextBox44.ColorBackground_Pen = Color.Black;
            cyberTextBox44.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox44.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox44.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox44.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox44.Enabled = false;
            cyberTextBox44.Font = new Font("Arial", 32F);
            cyberTextBox44.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox44.Lighting = false;
            cyberTextBox44.LinearGradientPen = false;
            cyberTextBox44.Location = new Point(557, 155);
            cyberTextBox44.Name = "cyberTextBox44";
            cyberTextBox44.PenWidth = 15;
            cyberTextBox44.RGB = false;
            cyberTextBox44.Rounding = true;
            cyberTextBox44.RoundingInt = 30;
            cyberTextBox44.Size = new Size(236, 129);
            cyberTextBox44.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox44.TabIndex = 47;
            cyberTextBox44.TabStop = false;
            cyberTextBox44.Tag = "Cyber";
            cyberTextBox44.TextButton = "";
            cyberTextBox44.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox44.Timer_RGB = 300;
            // 
            // cyberTextBox43
            // 
            cyberTextBox43.Alpha = 20;
            cyberTextBox43.BackColor = Color.Transparent;
            cyberTextBox43.Background_WidthPen = 3F;
            cyberTextBox43.BackgroundPen = true;
            cyberTextBox43.ColorBackground = Color.White;
            cyberTextBox43.ColorBackground_Pen = Color.White;
            cyberTextBox43.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox43.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox43.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox43.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox43.Enabled = false;
            cyberTextBox43.Font = new Font("Arial", 68F);
            cyberTextBox43.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox43.Lighting = false;
            cyberTextBox43.LinearGradientPen = false;
            cyberTextBox43.Location = new Point(526, 404);
            cyberTextBox43.Name = "cyberTextBox43";
            cyberTextBox43.PenWidth = 15;
            cyberTextBox43.RGB = false;
            cyberTextBox43.Rounding = true;
            cyberTextBox43.RoundingInt = 15;
            cyberTextBox43.Size = new Size(562, 275);
            cyberTextBox43.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox43.TabIndex = 46;
            cyberTextBox43.TabStop = false;
            cyberTextBox43.Tag = "Cyber";
            cyberTextBox43.TextButton = "";
            cyberTextBox43.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox43.Timer_RGB = 300;
            // 
            // cyberTextBox42
            // 
            cyberTextBox42.Alpha = 20;
            cyberTextBox42.BackColor = Color.Transparent;
            cyberTextBox42.Background_WidthPen = 3F;
            cyberTextBox42.BackgroundPen = true;
            cyberTextBox42.ColorBackground = Color.White;
            cyberTextBox42.ColorBackground_Pen = Color.White;
            cyberTextBox42.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox42.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox42.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox42.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox42.Enabled = false;
            cyberTextBox42.Font = new Font("Arial", 68F);
            cyberTextBox42.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox42.Lighting = false;
            cyberTextBox42.LinearGradientPen = false;
            cyberTextBox42.Location = new Point(526, 56);
            cyberTextBox42.Name = "cyberTextBox42";
            cyberTextBox42.PenWidth = 15;
            cyberTextBox42.RGB = false;
            cyberTextBox42.Rounding = true;
            cyberTextBox42.RoundingInt = 15;
            cyberTextBox42.Size = new Size(562, 275);
            cyberTextBox42.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox42.TabIndex = 45;
            cyberTextBox42.TabStop = false;
            cyberTextBox42.Tag = "Cyber";
            cyberTextBox42.TextButton = "";
            cyberTextBox42.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox42.Timer_RGB = 300;
            // 
            // cyberTextBox41
            // 
            cyberTextBox41.Alpha = 20;
            cyberTextBox41.BackColor = Color.Transparent;
            cyberTextBox41.Background_WidthPen = 3F;
            cyberTextBox41.BackgroundPen = true;
            cyberTextBox41.ColorBackground = Color.White;
            cyberTextBox41.ColorBackground_Pen = Color.White;
            cyberTextBox41.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox41.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox41.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox41.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox41.Enabled = false;
            cyberTextBox41.Font = new Font("Arial", 168F);
            cyberTextBox41.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox41.Lighting = false;
            cyberTextBox41.LinearGradientPen = false;
            cyberTextBox41.Location = new Point(35, 56);
            cyberTextBox41.Name = "cyberTextBox41";
            cyberTextBox41.PenWidth = 15;
            cyberTextBox41.RGB = false;
            cyberTextBox41.Rounding = true;
            cyberTextBox41.RoundingInt = 15;
            cyberTextBox41.Size = new Size(431, 672);
            cyberTextBox41.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox41.TabIndex = 44;
            cyberTextBox41.TabStop = false;
            cyberTextBox41.Tag = "Cyber";
            cyberTextBox41.TextButton = "";
            cyberTextBox41.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox41.Timer_RGB = 300;
            // 
            // viewProducts
            // 
            viewProducts.BackColor = Color.FromArgb(236, 236, 236);
            viewProducts.Controls.Add(textBox3);
            viewProducts.Controls.Add(productPageCatCmb);
            viewProducts.Controls.Add(cyberTextBox27);
            viewProducts.Controls.Add(pictureBox1);
            viewProducts.Controls.Add(noProductPrompt);
            viewProducts.Controls.Add(addProductNavBtn);
            viewProducts.Controls.Add(searchProductField);
            viewProducts.Controls.Add(cyberTextBox24);
            viewProducts.Controls.Add(label10);
            viewProducts.Controls.Add(label9);
            viewProducts.Controls.Add(label1);
            viewProducts.Controls.Add(cyberTextBox25);
            viewProducts.Controls.Add(productTable);
            viewProducts.Location = new Point(4, 5);
            viewProducts.Margin = new Padding(4);
            viewProducts.Name = "viewProducts";
            viewProducts.Padding = new Padding(4);
            viewProducts.Size = new Size(1140, 795);
            viewProducts.TabIndex = 1;
            viewProducts.Text = "Product";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(236, 236, 236);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.FromArgb(174, 174, 172);
            textBox3.Location = new Point(895, 6);
            textBox3.Margin = new Padding(4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(206, 23);
            textBox3.TabIndex = 62;
            textBox3.Text = "Select Category";
            // 
            // productPageCatCmb
            // 
            productPageCatCmb.BackColor = Color.FromArgb(236, 236, 236);
            productPageCatCmb.ColorA = Color.FromArgb(64, 64, 64);
            productPageCatCmb.ColorB = Color.FromArgb(64, 64, 64);
            productPageCatCmb.ColorC = Color.FromArgb(239, 237, 236);
            productPageCatCmb.ColorD = Color.FromArgb(239, 237, 236);
            productPageCatCmb.ColorE = Color.FromArgb(239, 237, 236);
            productPageCatCmb.ColorF = Color.FromArgb(236, 236, 236);
            productPageCatCmb.ColorG = Color.Black;
            productPageCatCmb.ColorH = Color.FromArgb(236, 236, 236);
            productPageCatCmb.ColorI = Color.FromArgb(236, 236, 236);
            productPageCatCmb.DrawMode = DrawMode.OwnerDrawFixed;
            productPageCatCmb.DropDownHeight = 100;
            productPageCatCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            productPageCatCmb.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productPageCatCmb.ForeColor = Color.FromArgb(76, 75, 78);
            productPageCatCmb.FormattingEnabled = true;
            productPageCatCmb.HoverSelectionColor = Color.Empty;
            productPageCatCmb.IntegralHeight = false;
            productPageCatCmb.ItemHeight = 20;
            productPageCatCmb.Location = new Point(907, 36);
            productPageCatCmb.Name = "productPageCatCmb";
            productPageCatCmb.Size = new Size(167, 26);
            productPageCatCmb.StartIndex = 0;
            productPageCatCmb.TabIndex = 61;
            productPageCatCmb.SelectedIndexChanged += productPageCatCmb_SelectedIndexChanged;
            // 
            // cyberTextBox27
            // 
            cyberTextBox27.Alpha = 20;
            cyberTextBox27.BackColor = Color.Transparent;
            cyberTextBox27.Background_WidthPen = 3F;
            cyberTextBox27.BackgroundPen = true;
            cyberTextBox27.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox27.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox27.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox27.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox27.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox27.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox27.Enabled = false;
            cyberTextBox27.Font = new Font("Arial", 9F);
            cyberTextBox27.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox27.Lighting = false;
            cyberTextBox27.LinearGradientPen = false;
            cyberTextBox27.Location = new Point(895, 28);
            cyberTextBox27.Name = "cyberTextBox27";
            cyberTextBox27.PenWidth = 15;
            cyberTextBox27.RGB = false;
            cyberTextBox27.Rounding = true;
            cyberTextBox27.RoundingInt = 60;
            cyberTextBox27.Size = new Size(193, 38);
            cyberTextBox27.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox27.TabIndex = 60;
            cyberTextBox27.TabStop = false;
            cyberTextBox27.Tag = "Cyber";
            cyberTextBox27.TextButton = "";
            cyberTextBox27.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox27.Timer_RGB = 300;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.searchIcon;
            pictureBox1.Location = new Point(101, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 33);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // noProductPrompt
            // 
            noProductPrompt.AutoSize = true;
            noProductPrompt.Font = new Font("Arial", 12F, FontStyle.Bold);
            noProductPrompt.Location = new Point(313, 294);
            noProductPrompt.Margin = new Padding(4, 0, 4, 0);
            noProductPrompt.Name = "noProductPrompt";
            noProductPrompt.Size = new Size(479, 29);
            noProductPrompt.TabIndex = 6;
            noProductPrompt.Text = "Products not found Please add products";
            noProductPrompt.TextAlign = ContentAlignment.MiddleCenter;
            noProductPrompt.Visible = false;
            // 
            // addProductNavBtn
            // 
            addProductNavBtn.Alpha = 20;
            addProductNavBtn.BackColor = Color.Transparent;
            addProductNavBtn.Background = true;
            addProductNavBtn.Background_WidthPen = 4F;
            addProductNavBtn.BackgroundPen = true;
            addProductNavBtn.ColorBackground = Color.FromArgb(236, 236, 236);
            addProductNavBtn.ColorBackground_1 = SystemColors.ScrollBar;
            addProductNavBtn.ColorBackground_2 = SystemColors.ActiveBorder;
            addProductNavBtn.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            addProductNavBtn.ColorLighting = Color.White;
            addProductNavBtn.ColorPen_1 = SystemColors.WindowFrame;
            addProductNavBtn.ColorPen_2 = Color.FromArgb(64, 64, 64);
            addProductNavBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            addProductNavBtn.Effect_1 = true;
            addProductNavBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            addProductNavBtn.Effect_1_Transparency = 25;
            addProductNavBtn.Effect_2 = true;
            addProductNavBtn.Effect_2_ColorBackground = Color.White;
            addProductNavBtn.Effect_2_Transparency = 20;
            addProductNavBtn.Font = new Font("Arial", 11F);
            addProductNavBtn.ForeColor = Color.Black;
            addProductNavBtn.Lighting = false;
            addProductNavBtn.LinearGradient_Background = false;
            addProductNavBtn.LinearGradientPen = false;
            addProductNavBtn.Location = new Point(827, 700);
            addProductNavBtn.Name = "addProductNavBtn";
            addProductNavBtn.PenWidth = 15;
            addProductNavBtn.Rounding = true;
            addProductNavBtn.RoundingInt = 70;
            addProductNavBtn.Size = new Size(199, 57);
            addProductNavBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            addProductNavBtn.TabIndex = 59;
            addProductNavBtn.Tag = "Cyber";
            addProductNavBtn.TextButton = "+ Add Product";
            addProductNavBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            addProductNavBtn.Timer_Effect_1 = 5;
            addProductNavBtn.Timer_RGB = 300;
            addProductNavBtn.Click += addProductNavBtn_Click;
            // 
            // searchProductField
            // 
            searchProductField.BackColor = Color.FromArgb(236, 236, 236);
            searchProductField.BorderStyle = BorderStyle.None;
            searchProductField.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchProductField.ForeColor = Color.FromArgb(174, 174, 172);
            searchProductField.Location = new Point(143, 24);
            searchProductField.Margin = new Padding(4);
            searchProductField.Name = "searchProductField";
            searchProductField.Size = new Size(565, 23);
            searchProductField.TabIndex = 6;
            searchProductField.Text = "Search Product Name";
            searchProductField.TextChanged += searchProductField_TextChanged;
            // 
            // cyberTextBox24
            // 
            cyberTextBox24.Alpha = 20;
            cyberTextBox24.BackColor = Color.Transparent;
            cyberTextBox24.Background_WidthPen = 3F;
            cyberTextBox24.BackgroundPen = true;
            cyberTextBox24.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox24.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox24.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox24.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox24.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox24.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox24.Enabled = false;
            cyberTextBox24.Font = new Font("Arial", 13F);
            cyberTextBox24.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox24.Lighting = false;
            cyberTextBox24.LinearGradientPen = false;
            cyberTextBox24.Location = new Point(82, 7);
            cyberTextBox24.Name = "cyberTextBox24";
            cyberTextBox24.PenWidth = 15;
            cyberTextBox24.RGB = false;
            cyberTextBox24.Rounding = true;
            cyberTextBox24.RoundingInt = 60;
            cyberTextBox24.Size = new Size(641, 55);
            cyberTextBox24.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox24.TabIndex = 42;
            cyberTextBox24.TabStop = false;
            cyberTextBox24.Tag = "Cyber";
            cyberTextBox24.TextButton = "";
            cyberTextBox24.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox24.Timer_RGB = 300;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(230, 230, 226);
            label10.Font = new Font("Arial", 12F);
            label10.ForeColor = Color.FromArgb(174, 174, 172);
            label10.Location = new Point(748, 115);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(200, 27);
            label10.TabIndex = 10;
            label10.Text = "Product Category";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(230, 230, 226);
            label9.Font = new Font("Arial", 12F);
            label9.ForeColor = Color.FromArgb(174, 174, 172);
            label9.Location = new Point(449, 115);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(166, 27);
            label9.TabIndex = 9;
            label9.Text = "Product Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(230, 230, 226);
            label1.Font = new Font("Arial", 12F);
            label1.ForeColor = Color.FromArgb(174, 174, 172);
            label1.Location = new Point(184, 115);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 27);
            label1.TabIndex = 8;
            label1.Text = "Product ID";
            // 
            // cyberTextBox25
            // 
            cyberTextBox25.Alpha = 20;
            cyberTextBox25.BackColor = Color.Transparent;
            cyberTextBox25.Background_WidthPen = 3F;
            cyberTextBox25.BackgroundPen = true;
            cyberTextBox25.ColorBackground = Color.FromArgb(230, 230, 226);
            cyberTextBox25.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox25.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox25.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox25.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox25.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox25.Enabled = false;
            cyberTextBox25.Font = new Font("Arial", 18F);
            cyberTextBox25.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox25.Lighting = false;
            cyberTextBox25.LinearGradientPen = false;
            cyberTextBox25.Location = new Point(82, 92);
            cyberTextBox25.Name = "cyberTextBox25";
            cyberTextBox25.PenWidth = 15;
            cyberTextBox25.RGB = false;
            cyberTextBox25.Rounding = true;
            cyberTextBox25.RoundingInt = 60;
            cyberTextBox25.Size = new Size(961, 72);
            cyberTextBox25.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox25.TabIndex = 43;
            cyberTextBox25.TabStop = false;
            cyberTextBox25.Tag = "Cyber";
            cyberTextBox25.TextButton = "";
            cyberTextBox25.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox25.Timer_RGB = 300;
            // 
            // productTable
            // 
            productTable.BackgroundColor = Color.FromArgb(236, 236, 236);
            productTable.BorderStyle = BorderStyle.None;
            productTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.LightGray;
            dataGridViewCellStyle3.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            productTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            productTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            productTable.DefaultCellStyle = dataGridViewCellStyle4;
            productTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            productTable.EnableHeadersVisualStyles = false;
            productTable.Location = new Point(82, 171);
            productTable.Margin = new Padding(4);
            productTable.Name = "productTable";
            productTable.ReadOnly = true;
            productTable.RowHeadersVisible = false;
            productTable.RowHeadersWidth = 120;
            productTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            productTable.RowTemplate.Height = 50;
            productTable.Size = new Size(961, 535);
            productTable.TabIndex = 0;
            productTable.CellClick += productTable_CellClick;
            // 
            // productMorePage
            // 
            productMorePage.BackColor = Color.FromArgb(236, 236, 236);
            productMorePage.Controls.Add(returnToProductView);
            productMorePage.Controls.Add(editProductBtn);
            productMorePage.Controls.Add(supplierMoreBtn);
            productMorePage.Controls.Add(categoryMoreBtn);
            productMorePage.Controls.Add(editProductSaveBtn);
            productMorePage.Controls.Add(ProdDateModified);
            productMorePage.Controls.Add(label18);
            productMorePage.Controls.Add(prodQtyMinus);
            productMorePage.Controls.Add(prodQtyAdd);
            productMorePage.Controls.Add(MoreProductQty);
            productMorePage.Controls.Add(label16);
            productMorePage.Controls.Add(cyberTextBox4);
            productMorePage.Controls.Add(label15);
            productMorePage.Controls.Add(moreProductPriceField);
            productMorePage.Controls.Add(cyberTextBox2);
            productMorePage.Controls.Add(moreProductNameField);
            productMorePage.Controls.Add(cmbSuppliers);
            productMorePage.Controls.Add(cmbCategory);
            productMorePage.Controls.Add(cyberTextBox3);
            productMorePage.Controls.Add(label14);
            productMorePage.Controls.Add(lbltextt);
            productMorePage.Controls.Add(label13);
            productMorePage.Controls.Add(cyberTextBox1);
            productMorePage.Controls.Add(label12);
            productMorePage.Controls.Add(ProductMorePageHdr);
            productMorePage.Controls.Add(textBox2);
            productMorePage.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            productMorePage.Location = new Point(4, 5);
            productMorePage.Margin = new Padding(4);
            productMorePage.Name = "productMorePage";
            productMorePage.Size = new Size(1140, 795);
            productMorePage.TabIndex = 3;
            productMorePage.Text = "tabPage4";
            // 
            // returnToProductView
            // 
            returnToProductView.Alpha = 20;
            returnToProductView.BackColor = Color.Transparent;
            returnToProductView.Background = true;
            returnToProductView.Background_WidthPen = 4F;
            returnToProductView.BackgroundPen = true;
            returnToProductView.ColorBackground = Color.FromArgb(236, 236, 236);
            returnToProductView.ColorBackground_1 = SystemColors.ScrollBar;
            returnToProductView.ColorBackground_2 = SystemColors.ActiveBorder;
            returnToProductView.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            returnToProductView.ColorLighting = Color.White;
            returnToProductView.ColorPen_1 = SystemColors.WindowFrame;
            returnToProductView.ColorPen_2 = Color.FromArgb(64, 64, 64);
            returnToProductView.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            returnToProductView.Effect_1 = true;
            returnToProductView.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            returnToProductView.Effect_1_Transparency = 25;
            returnToProductView.Effect_2 = true;
            returnToProductView.Effect_2_ColorBackground = Color.White;
            returnToProductView.Effect_2_Transparency = 20;
            returnToProductView.Font = new Font("Arial", 11F);
            returnToProductView.ForeColor = Color.Black;
            returnToProductView.Lighting = false;
            returnToProductView.LinearGradient_Background = false;
            returnToProductView.LinearGradientPen = false;
            returnToProductView.Location = new Point(457, 662);
            returnToProductView.Name = "returnToProductView";
            returnToProductView.PenWidth = 15;
            returnToProductView.Rounding = true;
            returnToProductView.RoundingInt = 70;
            returnToProductView.Size = new Size(265, 72);
            returnToProductView.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            returnToProductView.TabIndex = 29;
            returnToProductView.Tag = "Cyber";
            returnToProductView.TextButton = "Stop Editing";
            returnToProductView.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            returnToProductView.Timer_Effect_1 = 5;
            returnToProductView.Timer_RGB = 300;
            returnToProductView.Click += returnToProductView_Click;
            // 
            // editProductBtn
            // 
            editProductBtn.Alpha = 20;
            editProductBtn.BackColor = Color.Transparent;
            editProductBtn.Background = true;
            editProductBtn.Background_WidthPen = 4F;
            editProductBtn.BackgroundPen = true;
            editProductBtn.ColorBackground = Color.FromArgb(236, 236, 236);
            editProductBtn.ColorBackground_1 = SystemColors.ScrollBar;
            editProductBtn.ColorBackground_2 = SystemColors.ActiveBorder;
            editProductBtn.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            editProductBtn.ColorLighting = Color.White;
            editProductBtn.ColorPen_1 = SystemColors.WindowFrame;
            editProductBtn.ColorPen_2 = Color.FromArgb(64, 64, 64);
            editProductBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            editProductBtn.Effect_1 = true;
            editProductBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            editProductBtn.Effect_1_Transparency = 25;
            editProductBtn.Effect_2 = true;
            editProductBtn.Effect_2_ColorBackground = Color.White;
            editProductBtn.Effect_2_Transparency = 20;
            editProductBtn.Font = new Font("Arial", 11F);
            editProductBtn.ForeColor = Color.Black;
            editProductBtn.Lighting = false;
            editProductBtn.LinearGradient_Background = false;
            editProductBtn.LinearGradientPen = false;
            editProductBtn.Location = new Point(738, 664);
            editProductBtn.Name = "editProductBtn";
            editProductBtn.PenWidth = 15;
            editProductBtn.Rounding = true;
            editProductBtn.RoundingInt = 70;
            editProductBtn.Size = new Size(265, 72);
            editProductBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            editProductBtn.TabIndex = 28;
            editProductBtn.Tag = "Cyber";
            editProductBtn.TextButton = "Edit Products";
            editProductBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            editProductBtn.Timer_Effect_1 = 5;
            editProductBtn.Timer_RGB = 300;
            editProductBtn.Click += editProductBtn_Click;
            // 
            // supplierMoreBtn
            // 
            supplierMoreBtn.BackgroundImageLayout = ImageLayout.None;
            supplierMoreBtn.FlatAppearance.BorderSize = 0;
            supplierMoreBtn.FlatStyle = FlatStyle.Flat;
            supplierMoreBtn.Font = new Font("Arial", 10F);
            supplierMoreBtn.ForeColor = Color.White;
            supplierMoreBtn.Image = Resources.moreIcon;
            supplierMoreBtn.Location = new Point(338, 501);
            supplierMoreBtn.Margin = new Padding(4);
            supplierMoreBtn.Name = "supplierMoreBtn";
            supplierMoreBtn.Size = new Size(60, 42);
            supplierMoreBtn.TabIndex = 27;
            supplierMoreBtn.UseVisualStyleBackColor = true;
            supplierMoreBtn.Click += supplierMoreBtn_Click;
            // 
            // categoryMoreBtn
            // 
            categoryMoreBtn.BackgroundImageLayout = ImageLayout.None;
            categoryMoreBtn.FlatAppearance.BorderSize = 0;
            categoryMoreBtn.FlatStyle = FlatStyle.Flat;
            categoryMoreBtn.Font = new Font("Arial", 10F);
            categoryMoreBtn.ForeColor = Color.White;
            categoryMoreBtn.Image = Resources.moreIcon;
            categoryMoreBtn.Location = new Point(338, 333);
            categoryMoreBtn.Margin = new Padding(4);
            categoryMoreBtn.Name = "categoryMoreBtn";
            categoryMoreBtn.Size = new Size(60, 42);
            categoryMoreBtn.TabIndex = 10;
            categoryMoreBtn.UseVisualStyleBackColor = true;
            categoryMoreBtn.Click += categoryMoreBtn_Click;
            // 
            // editProductSaveBtn
            // 
            editProductSaveBtn.Alpha = 20;
            editProductSaveBtn.BackColor = Color.Transparent;
            editProductSaveBtn.Background = true;
            editProductSaveBtn.Background_WidthPen = 4F;
            editProductSaveBtn.BackgroundPen = true;
            editProductSaveBtn.ColorBackground = Color.FromArgb(236, 236, 236);
            editProductSaveBtn.ColorBackground_1 = SystemColors.ScrollBar;
            editProductSaveBtn.ColorBackground_2 = SystemColors.ActiveBorder;
            editProductSaveBtn.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            editProductSaveBtn.ColorLighting = Color.White;
            editProductSaveBtn.ColorPen_1 = SystemColors.WindowFrame;
            editProductSaveBtn.ColorPen_2 = Color.FromArgb(64, 64, 64);
            editProductSaveBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            editProductSaveBtn.Effect_1 = true;
            editProductSaveBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            editProductSaveBtn.Effect_1_Transparency = 25;
            editProductSaveBtn.Effect_2 = true;
            editProductSaveBtn.Effect_2_ColorBackground = Color.White;
            editProductSaveBtn.Effect_2_Transparency = 20;
            editProductSaveBtn.Font = new Font("Arial", 11F);
            editProductSaveBtn.ForeColor = Color.Black;
            editProductSaveBtn.Lighting = false;
            editProductSaveBtn.LinearGradient_Background = false;
            editProductSaveBtn.LinearGradientPen = false;
            editProductSaveBtn.Location = new Point(738, 662);
            editProductSaveBtn.Name = "editProductSaveBtn";
            editProductSaveBtn.PenWidth = 15;
            editProductSaveBtn.Rounding = true;
            editProductSaveBtn.RoundingInt = 70;
            editProductSaveBtn.Size = new Size(265, 72);
            editProductSaveBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            editProductSaveBtn.TabIndex = 26;
            editProductSaveBtn.Tag = "Cyber";
            editProductSaveBtn.TextButton = "Save Changes";
            editProductSaveBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            editProductSaveBtn.Timer_Effect_1 = 5;
            editProductSaveBtn.Timer_RGB = 300;
            editProductSaveBtn.Click += editProductSaveBtn_Click;
            // 
            // ProdDateModified
            // 
            ProdDateModified.AutoSize = true;
            ProdDateModified.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProdDateModified.ForeColor = Color.FromArgb(76, 75, 78);
            ProdDateModified.Location = new Point(619, 523);
            ProdDateModified.Name = "ProdDateModified";
            ProdDateModified.Size = new Size(160, 27);
            ProdDateModified.TabIndex = 25;
            ProdDateModified.Text = "xxxx-xxxx-xxxx";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(76, 75, 78);
            label18.Location = new Point(619, 465);
            label18.Name = "label18";
            label18.Size = new Size(159, 27);
            label18.TabIndex = 23;
            label18.Text = "Date Modified";
            // 
            // prodQtyMinus
            // 
            prodQtyMinus.Alpha = 20;
            prodQtyMinus.BackColor = Color.Transparent;
            prodQtyMinus.Background = true;
            prodQtyMinus.Background_WidthPen = 4F;
            prodQtyMinus.BackgroundPen = true;
            prodQtyMinus.ColorBackground = Color.FromArgb(236, 236, 236);
            prodQtyMinus.ColorBackground_1 = SystemColors.ScrollBar;
            prodQtyMinus.ColorBackground_2 = SystemColors.ActiveBorder;
            prodQtyMinus.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            prodQtyMinus.ColorLighting = Color.White;
            prodQtyMinus.ColorPen_1 = SystemColors.WindowFrame;
            prodQtyMinus.ColorPen_2 = Color.FromArgb(64, 64, 64);
            prodQtyMinus.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            prodQtyMinus.Effect_1 = true;
            prodQtyMinus.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            prodQtyMinus.Effect_1_Transparency = 25;
            prodQtyMinus.Effect_2 = true;
            prodQtyMinus.Effect_2_ColorBackground = Color.White;
            prodQtyMinus.Effect_2_Transparency = 20;
            prodQtyMinus.Font = new Font("Arial", 11F);
            prodQtyMinus.ForeColor = Color.Black;
            prodQtyMinus.Lighting = false;
            prodQtyMinus.LinearGradient_Background = false;
            prodQtyMinus.LinearGradientPen = false;
            prodQtyMinus.Location = new Point(1003, 322);
            prodQtyMinus.Name = "prodQtyMinus";
            prodQtyMinus.PenWidth = 15;
            prodQtyMinus.Rounding = true;
            prodQtyMinus.RoundingInt = 70;
            prodQtyMinus.Size = new Size(114, 62);
            prodQtyMinus.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            prodQtyMinus.TabIndex = 20;
            prodQtyMinus.Tag = "Cyber";
            prodQtyMinus.TextButton = "-Minus";
            prodQtyMinus.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            prodQtyMinus.Timer_Effect_1 = 5;
            prodQtyMinus.Timer_RGB = 300;
            prodQtyMinus.Click += prodQtyMinus_Click;
            // 
            // prodQtyAdd
            // 
            prodQtyAdd.Alpha = 20;
            prodQtyAdd.BackColor = Color.Transparent;
            prodQtyAdd.Background = true;
            prodQtyAdd.Background_WidthPen = 4F;
            prodQtyAdd.BackgroundPen = true;
            prodQtyAdd.ColorBackground = Color.FromArgb(236, 236, 236);
            prodQtyAdd.ColorBackground_1 = SystemColors.ScrollBar;
            prodQtyAdd.ColorBackground_2 = SystemColors.ActiveBorder;
            prodQtyAdd.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            prodQtyAdd.ColorLighting = Color.White;
            prodQtyAdd.ColorPen_1 = SystemColors.WindowFrame;
            prodQtyAdd.ColorPen_2 = Color.FromArgb(64, 64, 64);
            prodQtyAdd.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            prodQtyAdd.Effect_1 = true;
            prodQtyAdd.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            prodQtyAdd.Effect_1_Transparency = 25;
            prodQtyAdd.Effect_2 = true;
            prodQtyAdd.Effect_2_ColorBackground = Color.White;
            prodQtyAdd.Effect_2_Transparency = 20;
            prodQtyAdd.Font = new Font("Arial", 11F);
            prodQtyAdd.ForeColor = Color.Black;
            prodQtyAdd.Lighting = false;
            prodQtyAdd.LinearGradient_Background = false;
            prodQtyAdd.LinearGradientPen = false;
            prodQtyAdd.Location = new Point(865, 322);
            prodQtyAdd.Name = "prodQtyAdd";
            prodQtyAdd.PenWidth = 15;
            prodQtyAdd.Rounding = true;
            prodQtyAdd.RoundingInt = 70;
            prodQtyAdd.Size = new Size(114, 62);
            prodQtyAdd.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            prodQtyAdd.TabIndex = 19;
            prodQtyAdd.Tag = "Cyber";
            prodQtyAdd.TextButton = "+ Add";
            prodQtyAdd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            prodQtyAdd.Timer_Effect_1 = 5;
            prodQtyAdd.Timer_RGB = 300;
            prodQtyAdd.Click += prodQtyAdd_Click;
            // 
            // MoreProductQty
            // 
            MoreProductQty.BackColor = Color.FromArgb(236, 236, 236);
            MoreProductQty.BorderStyle = BorderStyle.None;
            MoreProductQty.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MoreProductQty.ForeColor = Color.FromArgb(76, 75, 78);
            MoreProductQty.Location = new Point(619, 342);
            MoreProductQty.Name = "MoreProductQty";
            MoreProductQty.Size = new Size(210, 28);
            MoreProductQty.TabIndex = 18;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(76, 75, 78);
            label16.Location = new Point(619, 283);
            label16.Name = "label16";
            label16.Size = new Size(194, 27);
            label16.TabIndex = 17;
            label16.Text = "Product Quantity";
            // 
            // cyberTextBox4
            // 
            cyberTextBox4.Alpha = 20;
            cyberTextBox4.BackColor = Color.Transparent;
            cyberTextBox4.Background_WidthPen = 3F;
            cyberTextBox4.BackgroundPen = true;
            cyberTextBox4.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox4.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox4.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox4.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox4.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox4.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox4.Enabled = false;
            cyberTextBox4.Font = new Font("Arial", 13F);
            cyberTextBox4.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox4.Lighting = false;
            cyberTextBox4.LinearGradientPen = false;
            cyberTextBox4.Location = new Point(604, 329);
            cyberTextBox4.Name = "cyberTextBox4";
            cyberTextBox4.PenWidth = 15;
            cyberTextBox4.RGB = false;
            cyberTextBox4.Rounding = true;
            cyberTextBox4.RoundingInt = 60;
            cyberTextBox4.Size = new Size(240, 55);
            cyberTextBox4.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox4.TabIndex = 16;
            cyberTextBox4.TabStop = false;
            cyberTextBox4.Tag = "Cyber";
            cyberTextBox4.TextButton = "";
            cyberTextBox4.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox4.Timer_RGB = 300;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(76, 75, 78);
            label15.Location = new Point(619, 115);
            label15.Name = "label15";
            label15.Size = new Size(157, 27);
            label15.TabIndex = 15;
            label15.Text = "Product Price";
            // 
            // moreProductPriceField
            // 
            moreProductPriceField.AcceptsReturn = true;
            moreProductPriceField.BackColor = Color.FromArgb(236, 236, 236);
            moreProductPriceField.BorderStyle = BorderStyle.None;
            moreProductPriceField.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            moreProductPriceField.ForeColor = Color.FromArgb(76, 75, 78);
            moreProductPriceField.Location = new Point(619, 174);
            moreProductPriceField.Name = "moreProductPriceField";
            moreProductPriceField.ReadOnly = true;
            moreProductPriceField.Size = new Size(225, 28);
            moreProductPriceField.TabIndex = 14;
            // 
            // cyberTextBox2
            // 
            cyberTextBox2.Alpha = 20;
            cyberTextBox2.BackColor = Color.Transparent;
            cyberTextBox2.Background_WidthPen = 3F;
            cyberTextBox2.BackgroundPen = true;
            cyberTextBox2.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox2.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox2.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox2.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox2.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox2.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox2.Enabled = false;
            cyberTextBox2.Font = new Font("Arial", 13F);
            cyberTextBox2.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox2.Lighting = false;
            cyberTextBox2.LinearGradientPen = false;
            cyberTextBox2.Location = new Point(604, 159);
            cyberTextBox2.Name = "cyberTextBox2";
            cyberTextBox2.PenWidth = 15;
            cyberTextBox2.RGB = false;
            cyberTextBox2.Rounding = true;
            cyberTextBox2.RoundingInt = 60;
            cyberTextBox2.Size = new Size(256, 55);
            cyberTextBox2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox2.TabIndex = 13;
            cyberTextBox2.TabStop = false;
            cyberTextBox2.Tag = "Cyber";
            cyberTextBox2.TextButton = "";
            cyberTextBox2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox2.Timer_RGB = 300;
            // 
            // moreProductNameField
            // 
            moreProductNameField.BackColor = Color.FromArgb(236, 236, 236);
            moreProductNameField.BorderStyle = BorderStyle.None;
            moreProductNameField.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            moreProductNameField.ForeColor = Color.FromArgb(76, 75, 78);
            moreProductNameField.Location = new Point(100, 174);
            moreProductNameField.Name = "moreProductNameField";
            moreProductNameField.Size = new Size(435, 28);
            moreProductNameField.TabIndex = 12;
            // 
            // cmbSuppliers
            // 
            cmbSuppliers.BackColor = Color.FromArgb(236, 236, 236);
            cmbSuppliers.ColorA = Color.FromArgb(64, 64, 64);
            cmbSuppliers.ColorB = Color.FromArgb(64, 64, 64);
            cmbSuppliers.ColorC = Color.FromArgb(239, 237, 236);
            cmbSuppliers.ColorD = Color.FromArgb(239, 237, 236);
            cmbSuppliers.ColorE = Color.FromArgb(239, 237, 236);
            cmbSuppliers.ColorF = Color.FromArgb(236, 236, 236);
            cmbSuppliers.ColorG = Color.Black;
            cmbSuppliers.ColorH = Color.FromArgb(236, 236, 236);
            cmbSuppliers.ColorI = Color.FromArgb(236, 236, 236);
            cmbSuppliers.DrawMode = DrawMode.OwnerDrawFixed;
            cmbSuppliers.DropDownHeight = 100;
            cmbSuppliers.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSuppliers.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbSuppliers.ForeColor = Color.FromArgb(76, 75, 78);
            cmbSuppliers.FormattingEnabled = true;
            cmbSuppliers.HoverSelectionColor = Color.Empty;
            cmbSuppliers.IntegralHeight = false;
            cmbSuppliers.ItemHeight = 20;
            cmbSuppliers.Location = new Point(100, 510);
            cmbSuppliers.Name = "cmbSuppliers";
            cmbSuppliers.Size = new Size(220, 26);
            cmbSuppliers.StartIndex = 0;
            cmbSuppliers.TabIndex = 10;
            // 
            // cmbCategory
            // 
            cmbCategory.BackColor = Color.FromArgb(236, 236, 236);
            cmbCategory.ColorA = Color.FromArgb(64, 64, 64);
            cmbCategory.ColorB = Color.FromArgb(64, 64, 64);
            cmbCategory.ColorC = Color.FromArgb(239, 237, 236);
            cmbCategory.ColorD = Color.FromArgb(239, 237, 236);
            cmbCategory.ColorE = Color.FromArgb(239, 237, 236);
            cmbCategory.ColorF = Color.FromArgb(236, 236, 236);
            cmbCategory.ColorG = Color.Black;
            cmbCategory.ColorH = Color.FromArgb(236, 236, 236);
            cmbCategory.ColorI = Color.FromArgb(236, 236, 236);
            cmbCategory.DrawMode = DrawMode.OwnerDrawFixed;
            cmbCategory.DropDownHeight = 100;
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbCategory.ForeColor = Color.FromArgb(76, 75, 78);
            cmbCategory.FormattingEnabled = true;
            cmbCategory.HoverSelectionColor = Color.Empty;
            cmbCategory.IntegralHeight = false;
            cmbCategory.ItemHeight = 20;
            cmbCategory.Location = new Point(100, 346);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(220, 26);
            cmbCategory.StartIndex = 0;
            cmbCategory.TabIndex = 9;
            // 
            // cyberTextBox3
            // 
            cyberTextBox3.Alpha = 20;
            cyberTextBox3.BackColor = Color.Transparent;
            cyberTextBox3.Background_WidthPen = 3F;
            cyberTextBox3.BackgroundPen = true;
            cyberTextBox3.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox3.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox3.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox3.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox3.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox3.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox3.Enabled = false;
            cyberTextBox3.Font = new Font("Arial", 13F);
            cyberTextBox3.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox3.Lighting = false;
            cyberTextBox3.LinearGradientPen = false;
            cyberTextBox3.Location = new Point(85, 495);
            cyberTextBox3.Name = "cyberTextBox3";
            cyberTextBox3.PenWidth = 15;
            cyberTextBox3.RGB = false;
            cyberTextBox3.Rounding = true;
            cyberTextBox3.RoundingInt = 60;
            cyberTextBox3.Size = new Size(246, 55);
            cyberTextBox3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox3.TabIndex = 8;
            cyberTextBox3.TabStop = false;
            cyberTextBox3.Tag = "Cyber";
            cyberTextBox3.TextButton = "";
            cyberTextBox3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox3.Timer_RGB = 300;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(76, 75, 78);
            label14.Location = new Point(85, 451);
            label14.Name = "label14";
            label14.Size = new Size(193, 27);
            label14.TabIndex = 7;
            label14.Text = "Product Supplier";
            // 
            // lbltextt
            // 
            lbltextt.Alpha = 20;
            lbltextt.BackColor = Color.Transparent;
            lbltextt.Background_WidthPen = 3F;
            lbltextt.BackgroundPen = true;
            lbltextt.ColorBackground = Color.FromArgb(236, 236, 236);
            lbltextt.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            lbltextt.ColorLighting = Color.FromArgb(174, 174, 172);
            lbltextt.ColorPen_1 = Color.FromArgb(174, 174, 172);
            lbltextt.ColorPen_2 = Color.FromArgb(174, 174, 172);
            lbltextt.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            lbltextt.Enabled = false;
            lbltextt.Font = new Font("Arial", 15F);
            lbltextt.ForeColor = Color.FromArgb(245, 245, 245);
            lbltextt.Lighting = false;
            lbltextt.LinearGradientPen = false;
            lbltextt.Location = new Point(85, 322);
            lbltextt.Name = "lbltextt";
            lbltextt.PenWidth = 15;
            lbltextt.RGB = false;
            lbltextt.Rounding = true;
            lbltextt.RoundingInt = 60;
            lbltextt.Size = new Size(246, 62);
            lbltextt.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            lbltextt.TabIndex = 5;
            lbltextt.TabStop = false;
            lbltextt.Tag = "Cyber";
            lbltextt.TextButton = "";
            lbltextt.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            lbltextt.Timer_RGB = 300;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(76, 75, 78);
            label13.Location = new Point(85, 278);
            label13.Name = "label13";
            label13.Size = new Size(200, 27);
            label13.TabIndex = 4;
            label13.Text = "Product Category";
            // 
            // cyberTextBox1
            // 
            cyberTextBox1.Alpha = 20;
            cyberTextBox1.BackColor = Color.Transparent;
            cyberTextBox1.Background_WidthPen = 3F;
            cyberTextBox1.BackgroundPen = true;
            cyberTextBox1.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox1.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox1.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox1.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox1.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox1.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox1.Enabled = false;
            cyberTextBox1.Font = new Font("Arial", 13F);
            cyberTextBox1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox1.Lighting = false;
            cyberTextBox1.LinearGradientPen = false;
            cyberTextBox1.Location = new Point(85, 159);
            cyberTextBox1.Name = "cyberTextBox1";
            cyberTextBox1.PenWidth = 15;
            cyberTextBox1.RGB = false;
            cyberTextBox1.Rounding = true;
            cyberTextBox1.RoundingInt = 60;
            cyberTextBox1.Size = new Size(474, 55);
            cyberTextBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox1.TabIndex = 3;
            cyberTextBox1.TabStop = false;
            cyberTextBox1.Tag = "Cyber";
            cyberTextBox1.TextButton = "";
            cyberTextBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox1.Timer_RGB = 300;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(76, 75, 78);
            label12.Location = new Point(85, 115);
            label12.Name = "label12";
            label12.Size = new Size(166, 27);
            label12.TabIndex = 2;
            label12.Text = "Product Name";
            // 
            // ProductMorePageHdr
            // 
            ProductMorePageHdr.AutoSize = true;
            ProductMorePageHdr.BackColor = Color.FromArgb(236, 236, 236);
            ProductMorePageHdr.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductMorePageHdr.Location = new Point(85, 32);
            ProductMorePageHdr.Name = "ProductMorePageHdr";
            ProductMorePageHdr.Size = new Size(344, 33);
            ProductMorePageHdr.TabIndex = 0;
            ProductMorePageHdr.Text = "Edit Product Information";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(222, 224, 235);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Arial Narrow", 8F, FontStyle.Bold);
            textBox2.Location = new Point(85, 58);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(323, 19);
            textBox2.TabIndex = 1;
            textBox2.TabStop = false;
            // 
            // addProduct
            // 
            addProduct.Controls.Add(label37);
            addProduct.Controls.Add(textBox12);
            addProduct.Controls.Add(addProdSupViewMore);
            addProduct.Controls.Add(addProdCatViewMore);
            addProduct.Controls.Add(addProductBtn);
            addProduct.Controls.Add(label36);
            addProduct.Controls.Add(addProductIdField);
            addProduct.Controls.Add(addProductSupplierCmb);
            addProduct.Controls.Add(addProductCategoryCmb);
            addProduct.Controls.Add(label38);
            addProduct.Controls.Add(label39);
            addProduct.Controls.Add(label40);
            addProduct.Controls.Add(addProductPrice);
            addProduct.Controls.Add(cyberTextBox19);
            addProduct.Controls.Add(cyberTextBox20);
            addProduct.Controls.Add(addProductNameField);
            addProduct.Controls.Add(cyberTextBox21);
            addProduct.Controls.Add(cyberTextBox22);
            addProduct.Controls.Add(cyberTextBox23);
            addProduct.Controls.Add(label41);
            addProduct.Location = new Point(4, 5);
            addProduct.Name = "addProduct";
            addProduct.Size = new Size(1140, 795);
            addProduct.TabIndex = 8;
            addProduct.Text = "tabPage1";
            addProduct.UseVisualStyleBackColor = true;
            // 
            // label37
            // 
            label37.AutoSize = true;
            label37.BackColor = Color.FromArgb(236, 236, 236);
            label37.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label37.Location = new Point(79, 42);
            label37.Name = "label37";
            label37.Size = new Size(181, 33);
            label37.TabIndex = 61;
            label37.Text = "Add Product";
            // 
            // textBox12
            // 
            textBox12.BackColor = Color.FromArgb(222, 224, 235);
            textBox12.BorderStyle = BorderStyle.None;
            textBox12.Font = new Font("Arial Narrow", 8F, FontStyle.Bold);
            textBox12.Location = new Point(79, 68);
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(323, 19);
            textBox12.TabIndex = 62;
            textBox12.TabStop = false;
            // 
            // addProdSupViewMore
            // 
            addProdSupViewMore.BackgroundImageLayout = ImageLayout.None;
            addProdSupViewMore.FlatAppearance.BorderSize = 0;
            addProdSupViewMore.FlatStyle = FlatStyle.Flat;
            addProdSupViewMore.Font = new Font("Arial", 10F);
            addProdSupViewMore.ForeColor = Color.White;
            addProdSupViewMore.Image = Resources.moreIcon;
            addProdSupViewMore.ImageAlign = ContentAlignment.MiddleLeft;
            addProdSupViewMore.Location = new Point(332, 515);
            addProdSupViewMore.Margin = new Padding(4);
            addProdSupViewMore.Name = "addProdSupViewMore";
            addProdSupViewMore.Size = new Size(60, 42);
            addProdSupViewMore.TabIndex = 60;
            addProdSupViewMore.TextAlign = ContentAlignment.MiddleLeft;
            addProdSupViewMore.UseVisualStyleBackColor = true;
            addProdSupViewMore.Click += addProdSupViewMore_Click;
            // 
            // addProdCatViewMore
            // 
            addProdCatViewMore.BackgroundImageLayout = ImageLayout.None;
            addProdCatViewMore.FlatAppearance.BorderSize = 0;
            addProdCatViewMore.FlatStyle = FlatStyle.Flat;
            addProdCatViewMore.Font = new Font("Arial", 10F);
            addProdCatViewMore.ForeColor = Color.White;
            addProdCatViewMore.Image = Resources.moreIcon;
            addProdCatViewMore.ImageAlign = ContentAlignment.MiddleLeft;
            addProdCatViewMore.Location = new Point(332, 347);
            addProdCatViewMore.Margin = new Padding(4);
            addProdCatViewMore.Name = "addProdCatViewMore";
            addProdCatViewMore.Size = new Size(60, 42);
            addProdCatViewMore.TabIndex = 59;
            addProdCatViewMore.TextAlign = ContentAlignment.MiddleLeft;
            addProdCatViewMore.UseVisualStyleBackColor = true;
            addProdCatViewMore.Click += addProdCatViewMore_Click;
            // 
            // addProductBtn
            // 
            addProductBtn.Alpha = 20;
            addProductBtn.BackColor = Color.Transparent;
            addProductBtn.Background = true;
            addProductBtn.Background_WidthPen = 4F;
            addProductBtn.BackgroundPen = true;
            addProductBtn.ColorBackground = Color.FromArgb(236, 236, 236);
            addProductBtn.ColorBackground_1 = SystemColors.ScrollBar;
            addProductBtn.ColorBackground_2 = SystemColors.ActiveBorder;
            addProductBtn.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            addProductBtn.ColorLighting = Color.White;
            addProductBtn.ColorPen_1 = SystemColors.WindowFrame;
            addProductBtn.ColorPen_2 = Color.FromArgb(64, 64, 64);
            addProductBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            addProductBtn.Effect_1 = true;
            addProductBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            addProductBtn.Effect_1_Transparency = 25;
            addProductBtn.Effect_2 = true;
            addProductBtn.Effect_2_ColorBackground = Color.White;
            addProductBtn.Effect_2_Transparency = 20;
            addProductBtn.Font = new Font("Arial", 11F);
            addProductBtn.ForeColor = Color.Black;
            addProductBtn.Lighting = false;
            addProductBtn.LinearGradient_Background = false;
            addProductBtn.LinearGradientPen = false;
            addProductBtn.Location = new Point(642, 650);
            addProductBtn.Name = "addProductBtn";
            addProductBtn.PenWidth = 15;
            addProductBtn.Rounding = true;
            addProductBtn.RoundingInt = 70;
            addProductBtn.Size = new Size(265, 72);
            addProductBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            addProductBtn.TabIndex = 58;
            addProductBtn.Tag = "Cyber";
            addProductBtn.TextButton = "Add Product";
            addProductBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            addProductBtn.Timer_Effect_1 = 5;
            addProductBtn.Timer_RGB = 300;
            addProductBtn.Click += addProductBtn_Click_1;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label36.ForeColor = Color.FromArgb(76, 75, 78);
            label36.Location = new Point(656, 146);
            label36.Name = "label36";
            label36.Size = new Size(126, 27);
            label36.TabIndex = 57;
            label36.Text = "Product ID";
            // 
            // addProductIdField
            // 
            addProductIdField.BackColor = Color.FromArgb(236, 236, 236);
            addProductIdField.BorderStyle = BorderStyle.None;
            addProductIdField.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProductIdField.ForeColor = Color.FromArgb(76, 75, 78);
            addProductIdField.Location = new Point(656, 205);
            addProductIdField.Name = "addProductIdField";
            addProductIdField.Size = new Size(360, 28);
            addProductIdField.TabIndex = 56;
            // 
            // addProductSupplierCmb
            // 
            addProductSupplierCmb.BackColor = Color.FromArgb(236, 236, 236);
            addProductSupplierCmb.ColorA = Color.FromArgb(64, 64, 64);
            addProductSupplierCmb.ColorB = Color.FromArgb(64, 64, 64);
            addProductSupplierCmb.ColorC = Color.FromArgb(239, 237, 236);
            addProductSupplierCmb.ColorD = Color.FromArgb(239, 237, 236);
            addProductSupplierCmb.ColorE = Color.FromArgb(239, 237, 236);
            addProductSupplierCmb.ColorF = Color.FromArgb(236, 236, 236);
            addProductSupplierCmb.ColorG = Color.Black;
            addProductSupplierCmb.ColorH = Color.FromArgb(236, 236, 236);
            addProductSupplierCmb.ColorI = Color.FromArgb(236, 236, 236);
            addProductSupplierCmb.DrawMode = DrawMode.OwnerDrawFixed;
            addProductSupplierCmb.DropDownHeight = 100;
            addProductSupplierCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            addProductSupplierCmb.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProductSupplierCmb.ForeColor = Color.FromArgb(76, 75, 78);
            addProductSupplierCmb.FormattingEnabled = true;
            addProductSupplierCmb.HoverSelectionColor = Color.Empty;
            addProductSupplierCmb.IntegralHeight = false;
            addProductSupplierCmb.ItemHeight = 20;
            addProductSupplierCmb.Location = new Point(90, 524);
            addProductSupplierCmb.Name = "addProductSupplierCmb";
            addProductSupplierCmb.Size = new Size(220, 26);
            addProductSupplierCmb.StartIndex = 0;
            addProductSupplierCmb.TabIndex = 49;
            // 
            // addProductCategoryCmb
            // 
            addProductCategoryCmb.BackColor = Color.FromArgb(236, 236, 236);
            addProductCategoryCmb.ColorA = Color.FromArgb(64, 64, 64);
            addProductCategoryCmb.ColorB = Color.FromArgb(64, 64, 64);
            addProductCategoryCmb.ColorC = Color.FromArgb(239, 237, 236);
            addProductCategoryCmb.ColorD = Color.FromArgb(239, 237, 236);
            addProductCategoryCmb.ColorE = Color.FromArgb(239, 237, 236);
            addProductCategoryCmb.ColorF = Color.FromArgb(236, 236, 236);
            addProductCategoryCmb.ColorG = Color.Black;
            addProductCategoryCmb.ColorH = Color.FromArgb(236, 236, 236);
            addProductCategoryCmb.ColorI = Color.FromArgb(236, 236, 236);
            addProductCategoryCmb.DrawMode = DrawMode.OwnerDrawFixed;
            addProductCategoryCmb.DropDownHeight = 100;
            addProductCategoryCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            addProductCategoryCmb.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProductCategoryCmb.ForeColor = Color.FromArgb(76, 75, 78);
            addProductCategoryCmb.FormattingEnabled = true;
            addProductCategoryCmb.HoverSelectionColor = Color.Empty;
            addProductCategoryCmb.IntegralHeight = false;
            addProductCategoryCmb.ItemHeight = 20;
            addProductCategoryCmb.Location = new Point(90, 357);
            addProductCategoryCmb.Name = "addProductCategoryCmb";
            addProductCategoryCmb.Size = new Size(220, 26);
            addProductCategoryCmb.StartIndex = 0;
            addProductCategoryCmb.TabIndex = 48;
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label38.ForeColor = Color.FromArgb(76, 75, 78);
            label38.Location = new Point(90, 460);
            label38.Name = "label38";
            label38.Size = new Size(193, 27);
            label38.TabIndex = 47;
            label38.Text = "Product Supplier";
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label39.ForeColor = Color.FromArgb(76, 75, 78);
            label39.Location = new Point(90, 287);
            label39.Name = "label39";
            label39.Size = new Size(200, 27);
            label39.TabIndex = 46;
            label39.Text = "Product Category";
            // 
            // label40
            // 
            label40.AutoSize = true;
            label40.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label40.ForeColor = Color.FromArgb(76, 75, 78);
            label40.Location = new Point(656, 287);
            label40.Name = "label40";
            label40.Size = new Size(157, 27);
            label40.TabIndex = 45;
            label40.Text = "Product Price";
            // 
            // addProductPrice
            // 
            addProductPrice.BackColor = Color.FromArgb(236, 236, 236);
            addProductPrice.BorderStyle = BorderStyle.None;
            addProductPrice.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProductPrice.ForeColor = Color.FromArgb(76, 75, 78);
            addProductPrice.Location = new Point(656, 357);
            addProductPrice.Name = "addProductPrice";
            addProductPrice.Size = new Size(225, 28);
            addProductPrice.TabIndex = 44;
            // 
            // cyberTextBox19
            // 
            cyberTextBox19.Alpha = 20;
            cyberTextBox19.BackColor = Color.Transparent;
            cyberTextBox19.Background_WidthPen = 3F;
            cyberTextBox19.BackgroundPen = true;
            cyberTextBox19.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox19.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox19.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox19.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox19.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox19.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox19.Enabled = false;
            cyberTextBox19.Font = new Font("Arial", 13F);
            cyberTextBox19.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox19.Lighting = false;
            cyberTextBox19.LinearGradientPen = false;
            cyberTextBox19.Location = new Point(641, 342);
            cyberTextBox19.Name = "cyberTextBox19";
            cyberTextBox19.PenWidth = 15;
            cyberTextBox19.RGB = false;
            cyberTextBox19.Rounding = true;
            cyberTextBox19.RoundingInt = 60;
            cyberTextBox19.Size = new Size(256, 55);
            cyberTextBox19.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox19.TabIndex = 43;
            cyberTextBox19.TabStop = false;
            cyberTextBox19.Tag = "Cyber";
            cyberTextBox19.TextButton = "";
            cyberTextBox19.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox19.Timer_RGB = 300;
            // 
            // cyberTextBox20
            // 
            cyberTextBox20.Alpha = 20;
            cyberTextBox20.BackColor = Color.Transparent;
            cyberTextBox20.Background_WidthPen = 3F;
            cyberTextBox20.BackgroundPen = true;
            cyberTextBox20.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox20.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox20.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox20.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox20.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox20.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox20.Enabled = false;
            cyberTextBox20.Font = new Font("Arial", 13F);
            cyberTextBox20.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox20.Lighting = false;
            cyberTextBox20.LinearGradientPen = false;
            cyberTextBox20.Location = new Point(79, 502);
            cyberTextBox20.Name = "cyberTextBox20";
            cyberTextBox20.PenWidth = 15;
            cyberTextBox20.RGB = false;
            cyberTextBox20.Rounding = true;
            cyberTextBox20.RoundingInt = 60;
            cyberTextBox20.Size = new Size(246, 55);
            cyberTextBox20.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox20.TabIndex = 53;
            cyberTextBox20.TabStop = false;
            cyberTextBox20.Tag = "Cyber";
            cyberTextBox20.TextButton = "";
            cyberTextBox20.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox20.Timer_RGB = 300;
            // 
            // addProductNameField
            // 
            addProductNameField.BackColor = Color.FromArgb(236, 236, 236);
            addProductNameField.BorderStyle = BorderStyle.None;
            addProductNameField.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addProductNameField.ForeColor = Color.FromArgb(76, 75, 78);
            addProductNameField.Location = new Point(94, 205);
            addProductNameField.Name = "addProductNameField";
            addProductNameField.Size = new Size(435, 28);
            addProductNameField.TabIndex = 42;
            // 
            // cyberTextBox21
            // 
            cyberTextBox21.Alpha = 20;
            cyberTextBox21.BackColor = Color.Transparent;
            cyberTextBox21.Background_WidthPen = 3F;
            cyberTextBox21.BackgroundPen = true;
            cyberTextBox21.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox21.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox21.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox21.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox21.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox21.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox21.Enabled = false;
            cyberTextBox21.Font = new Font("Arial", 13F);
            cyberTextBox21.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox21.Lighting = false;
            cyberTextBox21.LinearGradientPen = false;
            cyberTextBox21.Location = new Point(79, 190);
            cyberTextBox21.Name = "cyberTextBox21";
            cyberTextBox21.PenWidth = 15;
            cyberTextBox21.RGB = false;
            cyberTextBox21.Rounding = true;
            cyberTextBox21.RoundingInt = 60;
            cyberTextBox21.Size = new Size(474, 55);
            cyberTextBox21.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox21.TabIndex = 41;
            cyberTextBox21.TabStop = false;
            cyberTextBox21.Tag = "Cyber";
            cyberTextBox21.TextButton = "";
            cyberTextBox21.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox21.Timer_RGB = 300;
            // 
            // cyberTextBox22
            // 
            cyberTextBox22.Alpha = 20;
            cyberTextBox22.BackColor = Color.Transparent;
            cyberTextBox22.Background_WidthPen = 3F;
            cyberTextBox22.BackgroundPen = true;
            cyberTextBox22.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox22.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox22.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox22.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox22.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox22.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox22.Enabled = false;
            cyberTextBox22.Font = new Font("Arial", 15F);
            cyberTextBox22.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox22.Lighting = false;
            cyberTextBox22.LinearGradientPen = false;
            cyberTextBox22.Location = new Point(79, 335);
            cyberTextBox22.Name = "cyberTextBox22";
            cyberTextBox22.PenWidth = 15;
            cyberTextBox22.RGB = false;
            cyberTextBox22.Rounding = true;
            cyberTextBox22.RoundingInt = 60;
            cyberTextBox22.Size = new Size(246, 62);
            cyberTextBox22.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox22.TabIndex = 52;
            cyberTextBox22.TabStop = false;
            cyberTextBox22.Tag = "Cyber";
            cyberTextBox22.TextButton = "";
            cyberTextBox22.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox22.Timer_RGB = 300;
            // 
            // cyberTextBox23
            // 
            cyberTextBox23.Alpha = 20;
            cyberTextBox23.BackColor = Color.Transparent;
            cyberTextBox23.Background_WidthPen = 3F;
            cyberTextBox23.BackgroundPen = true;
            cyberTextBox23.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox23.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox23.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox23.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox23.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox23.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox23.Enabled = false;
            cyberTextBox23.Font = new Font("Arial", 13F);
            cyberTextBox23.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox23.Lighting = false;
            cyberTextBox23.LinearGradientPen = false;
            cyberTextBox23.Location = new Point(642, 190);
            cyberTextBox23.Name = "cyberTextBox23";
            cyberTextBox23.PenWidth = 15;
            cyberTextBox23.RGB = false;
            cyberTextBox23.Rounding = true;
            cyberTextBox23.RoundingInt = 60;
            cyberTextBox23.Size = new Size(411, 55);
            cyberTextBox23.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox23.TabIndex = 54;
            cyberTextBox23.TabStop = false;
            cyberTextBox23.Tag = "Cyber";
            cyberTextBox23.TextButton = "";
            cyberTextBox23.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox23.Timer_RGB = 300;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label41.ForeColor = Color.FromArgb(76, 75, 78);
            label41.Location = new Point(79, 146);
            label41.Name = "label41";
            label41.Size = new Size(166, 27);
            label41.TabIndex = 40;
            label41.Text = "Product Name";
            // 
            // Orders
            // 
            Orders.Controls.Add(textBox1);
            Orders.Controls.Add(selectedStatus);
            Orders.Controls.Add(cyberTextBox40);
            Orders.Controls.Add(label42);
            Orders.Controls.Add(noOrdersPrompt);
            Orders.Controls.Add(pictureBox4);
            Orders.Controls.Add(orderProdNavBtn);
            Orders.Controls.Add(orderPanelSearchField);
            Orders.Controls.Add(label17);
            Orders.Controls.Add(label34);
            Orders.Controls.Add(label35);
            Orders.Controls.Add(cyberTextBox18);
            Orders.Controls.Add(cyberTextBox26);
            Orders.Controls.Add(ordersTable);
            Orders.Location = new Point(4, 5);
            Orders.Name = "Orders";
            Orders.Size = new Size(1140, 795);
            Orders.TabIndex = 9;
            Orders.Text = "Orders";
            Orders.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(236, 236, 236);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(174, 174, 172);
            textBox1.Location = new Point(889, 17);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(206, 23);
            textBox1.TabIndex = 65;
            textBox1.Text = "Select Status";
            // 
            // selectedStatus
            // 
            selectedStatus.BackColor = Color.FromArgb(236, 236, 236);
            selectedStatus.ColorA = Color.FromArgb(64, 64, 64);
            selectedStatus.ColorB = Color.FromArgb(64, 64, 64);
            selectedStatus.ColorC = Color.FromArgb(239, 237, 236);
            selectedStatus.ColorD = Color.FromArgb(239, 237, 236);
            selectedStatus.ColorE = Color.FromArgb(239, 237, 236);
            selectedStatus.ColorF = Color.FromArgb(236, 236, 236);
            selectedStatus.ColorG = Color.Black;
            selectedStatus.ColorH = Color.FromArgb(236, 236, 236);
            selectedStatus.ColorI = Color.FromArgb(236, 236, 236);
            selectedStatus.DrawMode = DrawMode.OwnerDrawFixed;
            selectedStatus.DropDownHeight = 100;
            selectedStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            selectedStatus.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selectedStatus.ForeColor = Color.FromArgb(76, 75, 78);
            selectedStatus.FormattingEnabled = true;
            selectedStatus.HoverSelectionColor = Color.Empty;
            selectedStatus.IntegralHeight = false;
            selectedStatus.ItemHeight = 20;
            selectedStatus.Items.AddRange(new object[] { "All", "Ordered", "Received" });
            selectedStatus.Location = new Point(901, 47);
            selectedStatus.Name = "selectedStatus";
            selectedStatus.Size = new Size(167, 26);
            selectedStatus.StartIndex = 0;
            selectedStatus.TabIndex = 64;
            selectedStatus.SelectedIndexChanged += selectedStatus_SelectedIndexChanged;
            // 
            // cyberTextBox40
            // 
            cyberTextBox40.Alpha = 20;
            cyberTextBox40.BackColor = Color.Transparent;
            cyberTextBox40.Background_WidthPen = 3F;
            cyberTextBox40.BackgroundPen = true;
            cyberTextBox40.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox40.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox40.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox40.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox40.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox40.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox40.Enabled = false;
            cyberTextBox40.Font = new Font("Arial", 9F);
            cyberTextBox40.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox40.Lighting = false;
            cyberTextBox40.LinearGradientPen = false;
            cyberTextBox40.Location = new Point(889, 39);
            cyberTextBox40.Name = "cyberTextBox40";
            cyberTextBox40.PenWidth = 15;
            cyberTextBox40.RGB = false;
            cyberTextBox40.Rounding = true;
            cyberTextBox40.RoundingInt = 60;
            cyberTextBox40.Size = new Size(193, 38);
            cyberTextBox40.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox40.TabIndex = 63;
            cyberTextBox40.TabStop = false;
            cyberTextBox40.Tag = "Cyber";
            cyberTextBox40.TextButton = "";
            cyberTextBox40.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox40.Timer_RGB = 300;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.BackColor = Color.FromArgb(230, 230, 226);
            label42.Font = new Font("Arial", 12F);
            label42.ForeColor = Color.FromArgb(174, 174, 172);
            label42.Location = new Point(872, 134);
            label42.Margin = new Padding(4, 0, 4, 0);
            label42.Name = "label42";
            label42.Size = new Size(103, 27);
            label42.TabIndex = 46;
            label42.Text = "Quantity";
            // 
            // noOrdersPrompt
            // 
            noOrdersPrompt.AutoSize = true;
            noOrdersPrompt.Font = new Font("Arial", 12F, FontStyle.Bold);
            noOrdersPrompt.Location = new Point(329, 253);
            noOrdersPrompt.Margin = new Padding(4, 0, 4, 0);
            noOrdersPrompt.Name = "noOrdersPrompt";
            noOrdersPrompt.Size = new Size(469, 29);
            noOrdersPrompt.TabIndex = 45;
            noOrdersPrompt.Text = "Orders not found please order products";
            noOrdersPrompt.TextAlign = ContentAlignment.MiddleCenter;
            noOrdersPrompt.Visible = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Resources.searchIcon;
            pictureBox4.Location = new Point(87, 40);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 33);
            pictureBox4.TabIndex = 39;
            pictureBox4.TabStop = false;
            // 
            // orderProdNavBtn
            // 
            orderProdNavBtn.Alpha = 20;
            orderProdNavBtn.BackColor = Color.Transparent;
            orderProdNavBtn.Background = true;
            orderProdNavBtn.Background_WidthPen = 4F;
            orderProdNavBtn.BackgroundPen = true;
            orderProdNavBtn.ColorBackground = Color.FromArgb(236, 236, 236);
            orderProdNavBtn.ColorBackground_1 = SystemColors.ScrollBar;
            orderProdNavBtn.ColorBackground_2 = SystemColors.ActiveBorder;
            orderProdNavBtn.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            orderProdNavBtn.ColorLighting = Color.White;
            orderProdNavBtn.ColorPen_1 = SystemColors.WindowFrame;
            orderProdNavBtn.ColorPen_2 = Color.FromArgb(64, 64, 64);
            orderProdNavBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            orderProdNavBtn.Effect_1 = true;
            orderProdNavBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            orderProdNavBtn.Effect_1_Transparency = 25;
            orderProdNavBtn.Effect_2 = true;
            orderProdNavBtn.Effect_2_ColorBackground = Color.White;
            orderProdNavBtn.Effect_2_Transparency = 20;
            orderProdNavBtn.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderProdNavBtn.ForeColor = Color.Black;
            orderProdNavBtn.Lighting = false;
            orderProdNavBtn.LinearGradient_Background = false;
            orderProdNavBtn.LinearGradientPen = false;
            orderProdNavBtn.Location = new Point(901, 714);
            orderProdNavBtn.Name = "orderProdNavBtn";
            orderProdNavBtn.PenWidth = 15;
            orderProdNavBtn.Rounding = true;
            orderProdNavBtn.RoundingInt = 70;
            orderProdNavBtn.Size = new Size(172, 56);
            orderProdNavBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            orderProdNavBtn.TabIndex = 44;
            orderProdNavBtn.Tag = "Cyber";
            orderProdNavBtn.TextButton = "+ Order Product";
            orderProdNavBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            orderProdNavBtn.Timer_Effect_1 = 5;
            orderProdNavBtn.Timer_RGB = 300;
            orderProdNavBtn.Click += orderProdNavBtn_Click;
            // 
            // orderPanelSearchField
            // 
            orderPanelSearchField.BackColor = Color.FromArgb(236, 236, 236);
            orderPanelSearchField.BorderStyle = BorderStyle.None;
            orderPanelSearchField.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderPanelSearchField.ForeColor = Color.FromArgb(174, 174, 172);
            orderPanelSearchField.Location = new Point(128, 40);
            orderPanelSearchField.Name = "orderPanelSearchField";
            orderPanelSearchField.Size = new Size(670, 28);
            orderPanelSearchField.TabIndex = 43;
            orderPanelSearchField.Text = "Search Product Name";
            orderPanelSearchField.KeyUp += orderPanelSearchField_KeyUp;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.FromArgb(230, 230, 226);
            label17.Font = new Font("Arial", 12F);
            label17.ForeColor = Color.FromArgb(174, 174, 172);
            label17.Location = new Point(677, 132);
            label17.Margin = new Padding(4, 0, 4, 0);
            label17.Name = "label17";
            label17.Size = new Size(81, 27);
            label17.TabIndex = 42;
            label17.Text = "Status";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.BackColor = Color.FromArgb(230, 230, 226);
            label34.Font = new Font("Arial", 12F);
            label34.ForeColor = Color.FromArgb(174, 174, 172);
            label34.Location = new Point(365, 130);
            label34.Margin = new Padding(4, 0, 4, 0);
            label34.Name = "label34";
            label34.Size = new Size(211, 27);
            label34.TabIndex = 41;
            label34.Text = "Estimated Delivery";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.BackColor = Color.FromArgb(230, 230, 226);
            label35.Font = new Font("Arial", 12F);
            label35.ForeColor = Color.FromArgb(174, 174, 172);
            label35.Location = new Point(118, 130);
            label35.Margin = new Padding(4, 0, 4, 0);
            label35.Name = "label35";
            label35.Size = new Size(166, 27);
            label35.TabIndex = 40;
            label35.Text = "Product Name";
            // 
            // cyberTextBox18
            // 
            cyberTextBox18.Alpha = 20;
            cyberTextBox18.BackColor = Color.Transparent;
            cyberTextBox18.Background_WidthPen = 3F;
            cyberTextBox18.BackgroundPen = true;
            cyberTextBox18.ColorBackground = Color.FromArgb(230, 230, 226);
            cyberTextBox18.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox18.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox18.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox18.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox18.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox18.Enabled = false;
            cyberTextBox18.Font = new Font("Arial", 18F);
            cyberTextBox18.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox18.Lighting = false;
            cyberTextBox18.LinearGradientPen = false;
            cyberTextBox18.Location = new Point(67, 108);
            cyberTextBox18.Name = "cyberTextBox18";
            cyberTextBox18.PenWidth = 15;
            cyberTextBox18.RGB = false;
            cyberTextBox18.Rounding = true;
            cyberTextBox18.RoundingInt = 60;
            cyberTextBox18.Size = new Size(1006, 72);
            cyberTextBox18.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox18.TabIndex = 38;
            cyberTextBox18.TabStop = false;
            cyberTextBox18.Tag = "Cyber";
            cyberTextBox18.TextButton = "";
            cyberTextBox18.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox18.Timer_RGB = 300;
            // 
            // cyberTextBox26
            // 
            cyberTextBox26.Alpha = 20;
            cyberTextBox26.BackColor = Color.Transparent;
            cyberTextBox26.Background_WidthPen = 3F;
            cyberTextBox26.BackgroundPen = true;
            cyberTextBox26.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox26.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox26.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox26.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox26.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox26.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox26.Enabled = false;
            cyberTextBox26.Font = new Font("Arial", 13F);
            cyberTextBox26.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox26.Lighting = false;
            cyberTextBox26.LinearGradientPen = false;
            cyberTextBox26.Location = new Point(67, 24);
            cyberTextBox26.Name = "cyberTextBox26";
            cyberTextBox26.PenWidth = 15;
            cyberTextBox26.RGB = false;
            cyberTextBox26.Rounding = true;
            cyberTextBox26.RoundingInt = 60;
            cyberTextBox26.Size = new Size(774, 55);
            cyberTextBox26.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox26.TabIndex = 37;
            cyberTextBox26.TabStop = false;
            cyberTextBox26.Tag = "Cyber";
            cyberTextBox26.TextButton = "";
            cyberTextBox26.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox26.Timer_RGB = 300;
            // 
            // ordersTable
            // 
            ordersTable.BackgroundColor = Color.FromArgb(236, 236, 236);
            ordersTable.BorderStyle = BorderStyle.None;
            ordersTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.LightGray;
            dataGridViewCellStyle5.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            ordersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            ordersTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            ordersTable.DefaultCellStyle = dataGridViewCellStyle6;
            ordersTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            ordersTable.EnableHeadersVisualStyles = false;
            ordersTable.Location = new Point(74, 180);
            ordersTable.Margin = new Padding(4);
            ordersTable.Name = "ordersTable";
            ordersTable.ReadOnly = true;
            ordersTable.RowHeadersVisible = false;
            ordersTable.RowHeadersWidth = 120;
            ordersTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            ordersTable.RowTemplate.Height = 50;
            ordersTable.Size = new Size(999, 509);
            ordersTable.TabIndex = 36;
            ordersTable.CellClick += orderTables_CellClick;
            // 
            // OrderInformation
            // 
            OrderInformation.Controls.Add(delOrderBtn);
            OrderInformation.Controls.Add(recieveOrderBtn);
            OrderInformation.Controls.Add(viewOrderStatusLbl);
            OrderInformation.Controls.Add(label52);
            OrderInformation.Controls.Add(ViewEstArrivalLbl);
            OrderInformation.Controls.Add(label51);
            OrderInformation.Controls.Add(label50);
            OrderInformation.Controls.Add(label49);
            OrderInformation.Controls.Add(label48);
            OrderInformation.Controls.Add(label47);
            OrderInformation.Controls.Add(viewProdQtyOrderLbl);
            OrderInformation.Controls.Add(cyberTextBox31);
            OrderInformation.Controls.Add(viewOrderIdLbl);
            OrderInformation.Controls.Add(cyberTextBox30);
            OrderInformation.Controls.Add(viewProductSupOrderLbl);
            OrderInformation.Controls.Add(cyberTextBox29);
            OrderInformation.Controls.Add(label46);
            OrderInformation.Controls.Add(textBox5);
            OrderInformation.Controls.Add(ViewdateOrderedLbl);
            OrderInformation.Controls.Add(label45);
            OrderInformation.Controls.Add(viewProductNameOrderLbl);
            OrderInformation.Controls.Add(cyberTextBox28);
            OrderInformation.Location = new Point(4, 5);
            OrderInformation.Name = "OrderInformation";
            OrderInformation.Size = new Size(1140, 795);
            OrderInformation.TabIndex = 11;
            OrderInformation.Text = "OrderInformation";
            OrderInformation.UseVisualStyleBackColor = true;
            // 
            // delOrderBtn
            // 
            delOrderBtn.Alpha = 20;
            delOrderBtn.BackColor = Color.Transparent;
            delOrderBtn.Background = true;
            delOrderBtn.Background_WidthPen = 4F;
            delOrderBtn.BackgroundPen = true;
            delOrderBtn.ColorBackground = Color.FromArgb(236, 236, 236);
            delOrderBtn.ColorBackground_1 = SystemColors.ScrollBar;
            delOrderBtn.ColorBackground_2 = SystemColors.ActiveBorder;
            delOrderBtn.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            delOrderBtn.ColorLighting = Color.White;
            delOrderBtn.ColorPen_1 = SystemColors.WindowFrame;
            delOrderBtn.ColorPen_2 = Color.FromArgb(64, 64, 64);
            delOrderBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            delOrderBtn.Effect_1 = true;
            delOrderBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            delOrderBtn.Effect_1_Transparency = 25;
            delOrderBtn.Effect_2 = true;
            delOrderBtn.Effect_2_ColorBackground = Color.White;
            delOrderBtn.Effect_2_Transparency = 20;
            delOrderBtn.Font = new Font("Arial", 11F);
            delOrderBtn.ForeColor = Color.Black;
            delOrderBtn.Lighting = false;
            delOrderBtn.LinearGradient_Background = false;
            delOrderBtn.LinearGradientPen = false;
            delOrderBtn.Location = new Point(434, 650);
            delOrderBtn.Name = "delOrderBtn";
            delOrderBtn.PenWidth = 15;
            delOrderBtn.Rounding = true;
            delOrderBtn.RoundingInt = 70;
            delOrderBtn.Size = new Size(265, 72);
            delOrderBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            delOrderBtn.TabIndex = 66;
            delOrderBtn.Tag = "Cyber";
            delOrderBtn.TextButton = "Delete Order";
            delOrderBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            delOrderBtn.Timer_Effect_1 = 5;
            delOrderBtn.Timer_RGB = 300;
            delOrderBtn.Click += delOrderBtn_Click;
            // 
            // recieveOrderBtn
            // 
            recieveOrderBtn.Alpha = 20;
            recieveOrderBtn.BackColor = Color.Transparent;
            recieveOrderBtn.Background = true;
            recieveOrderBtn.Background_WidthPen = 4F;
            recieveOrderBtn.BackgroundPen = true;
            recieveOrderBtn.ColorBackground = Color.FromArgb(236, 236, 236);
            recieveOrderBtn.ColorBackground_1 = SystemColors.ScrollBar;
            recieveOrderBtn.ColorBackground_2 = SystemColors.ActiveBorder;
            recieveOrderBtn.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            recieveOrderBtn.ColorLighting = Color.White;
            recieveOrderBtn.ColorPen_1 = SystemColors.WindowFrame;
            recieveOrderBtn.ColorPen_2 = Color.FromArgb(64, 64, 64);
            recieveOrderBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            recieveOrderBtn.Effect_1 = true;
            recieveOrderBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            recieveOrderBtn.Effect_1_Transparency = 25;
            recieveOrderBtn.Effect_2 = true;
            recieveOrderBtn.Effect_2_ColorBackground = Color.White;
            recieveOrderBtn.Effect_2_Transparency = 20;
            recieveOrderBtn.Font = new Font("Arial", 11F);
            recieveOrderBtn.ForeColor = Color.Black;
            recieveOrderBtn.Lighting = false;
            recieveOrderBtn.LinearGradient_Background = false;
            recieveOrderBtn.LinearGradientPen = false;
            recieveOrderBtn.Location = new Point(761, 650);
            recieveOrderBtn.Name = "recieveOrderBtn";
            recieveOrderBtn.PenWidth = 15;
            recieveOrderBtn.Rounding = true;
            recieveOrderBtn.RoundingInt = 70;
            recieveOrderBtn.Size = new Size(265, 72);
            recieveOrderBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            recieveOrderBtn.TabIndex = 65;
            recieveOrderBtn.Tag = "Cyber";
            recieveOrderBtn.TextButton = "Receive Order";
            recieveOrderBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            recieveOrderBtn.Timer_Effect_1 = 5;
            recieveOrderBtn.Timer_RGB = 300;
            recieveOrderBtn.Click += recieveOrderBtn_Click;
            // 
            // viewOrderStatusLbl
            // 
            viewOrderStatusLbl.AutoSize = true;
            viewOrderStatusLbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewOrderStatusLbl.ForeColor = Color.FromArgb(76, 75, 78);
            viewOrderStatusLbl.Location = new Point(744, 469);
            viewOrderStatusLbl.Name = "viewOrderStatusLbl";
            viewOrderStatusLbl.Size = new Size(104, 29);
            viewOrderStatusLbl.TabIndex = 64;
            viewOrderStatusLbl.Text = "0000000";
            // 
            // label52
            // 
            label52.AutoSize = true;
            label52.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label52.ForeColor = Color.FromArgb(76, 75, 78);
            label52.Location = new Point(729, 412);
            label52.Name = "label52";
            label52.Size = new Size(150, 27);
            label52.TabIndex = 63;
            label52.Text = "Order Status";
            // 
            // ViewEstArrivalLbl
            // 
            ViewEstArrivalLbl.AutoSize = true;
            ViewEstArrivalLbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewEstArrivalLbl.ForeColor = Color.FromArgb(76, 75, 78);
            ViewEstArrivalLbl.Location = new Point(385, 469);
            ViewEstArrivalLbl.Name = "ViewEstArrivalLbl";
            ViewEstArrivalLbl.Size = new Size(104, 29);
            ViewEstArrivalLbl.TabIndex = 62;
            ViewEstArrivalLbl.Text = "0000000";
            // 
            // label51
            // 
            label51.AutoSize = true;
            label51.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label51.ForeColor = Color.FromArgb(76, 75, 78);
            label51.Location = new Point(370, 412);
            label51.Name = "label51";
            label51.Size = new Size(248, 27);
            label51.TabIndex = 61;
            label51.Text = "Estimated Arrival Date";
            // 
            // label50
            // 
            label50.AutoSize = true;
            label50.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label50.ForeColor = Color.FromArgb(76, 75, 78);
            label50.Location = new Point(647, 248);
            label50.Name = "label50";
            label50.Size = new Size(194, 27);
            label50.TabIndex = 60;
            label50.Text = "Product Quantity";
            // 
            // label49
            // 
            label49.AutoSize = true;
            label49.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label49.ForeColor = Color.FromArgb(76, 75, 78);
            label49.Location = new Point(116, 237);
            label49.Name = "label49";
            label49.Size = new Size(193, 27);
            label49.TabIndex = 59;
            label49.Text = "Product Supplier";
            // 
            // label48
            // 
            label48.AutoSize = true;
            label48.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label48.ForeColor = Color.FromArgb(76, 75, 78);
            label48.Location = new Point(647, 115);
            label48.Name = "label48";
            label48.Size = new Size(101, 27);
            label48.TabIndex = 58;
            label48.Text = "Order Id";
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label47.ForeColor = Color.FromArgb(76, 75, 78);
            label47.Location = new Point(116, 115);
            label47.Name = "label47";
            label47.Size = new Size(166, 27);
            label47.TabIndex = 57;
            label47.Text = "Product Name";
            // 
            // viewProdQtyOrderLbl
            // 
            viewProdQtyOrderLbl.BackColor = Color.FromArgb(236, 236, 236);
            viewProdQtyOrderLbl.BorderStyle = BorderStyle.None;
            viewProdQtyOrderLbl.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewProdQtyOrderLbl.ForeColor = Color.FromArgb(76, 75, 78);
            viewProdQtyOrderLbl.Location = new Point(647, 294);
            viewProdQtyOrderLbl.Name = "viewProdQtyOrderLbl";
            viewProdQtyOrderLbl.ReadOnly = true;
            viewProdQtyOrderLbl.Size = new Size(301, 28);
            viewProdQtyOrderLbl.TabIndex = 56;
            // 
            // cyberTextBox31
            // 
            cyberTextBox31.Alpha = 20;
            cyberTextBox31.BackColor = Color.Transparent;
            cyberTextBox31.Background_WidthPen = 3F;
            cyberTextBox31.BackgroundPen = true;
            cyberTextBox31.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox31.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox31.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox31.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox31.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox31.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox31.Enabled = false;
            cyberTextBox31.Font = new Font("Arial", 13F);
            cyberTextBox31.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox31.Lighting = false;
            cyberTextBox31.LinearGradientPen = false;
            cyberTextBox31.Location = new Point(636, 278);
            cyberTextBox31.Name = "cyberTextBox31";
            cyberTextBox31.PenWidth = 15;
            cyberTextBox31.RGB = false;
            cyberTextBox31.Rounding = true;
            cyberTextBox31.RoundingInt = 60;
            cyberTextBox31.Size = new Size(341, 55);
            cyberTextBox31.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox31.TabIndex = 55;
            cyberTextBox31.TabStop = false;
            cyberTextBox31.Tag = "Cyber";
            cyberTextBox31.TextButton = "";
            cyberTextBox31.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox31.Timer_RGB = 300;
            // 
            // viewOrderIdLbl
            // 
            viewOrderIdLbl.BackColor = Color.FromArgb(236, 236, 236);
            viewOrderIdLbl.BorderStyle = BorderStyle.None;
            viewOrderIdLbl.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewOrderIdLbl.ForeColor = Color.FromArgb(76, 75, 78);
            viewOrderIdLbl.Location = new Point(647, 162);
            viewOrderIdLbl.Name = "viewOrderIdLbl";
            viewOrderIdLbl.ReadOnly = true;
            viewOrderIdLbl.Size = new Size(301, 28);
            viewOrderIdLbl.TabIndex = 54;
            // 
            // cyberTextBox30
            // 
            cyberTextBox30.Alpha = 20;
            cyberTextBox30.BackColor = Color.Transparent;
            cyberTextBox30.Background_WidthPen = 3F;
            cyberTextBox30.BackgroundPen = true;
            cyberTextBox30.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox30.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox30.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox30.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox30.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox30.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox30.Enabled = false;
            cyberTextBox30.Font = new Font("Arial", 13F);
            cyberTextBox30.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox30.Lighting = false;
            cyberTextBox30.LinearGradientPen = false;
            cyberTextBox30.Location = new Point(636, 146);
            cyberTextBox30.Name = "cyberTextBox30";
            cyberTextBox30.PenWidth = 15;
            cyberTextBox30.RGB = false;
            cyberTextBox30.Rounding = true;
            cyberTextBox30.RoundingInt = 60;
            cyberTextBox30.Size = new Size(341, 55);
            cyberTextBox30.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox30.TabIndex = 53;
            cyberTextBox30.TabStop = false;
            cyberTextBox30.Tag = "Cyber";
            cyberTextBox30.TextButton = "";
            cyberTextBox30.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox30.Timer_RGB = 300;
            // 
            // viewProductSupOrderLbl
            // 
            viewProductSupOrderLbl.BackColor = Color.FromArgb(236, 236, 236);
            viewProductSupOrderLbl.BorderStyle = BorderStyle.None;
            viewProductSupOrderLbl.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewProductSupOrderLbl.ForeColor = Color.FromArgb(76, 75, 78);
            viewProductSupOrderLbl.Location = new Point(116, 283);
            viewProductSupOrderLbl.Name = "viewProductSupOrderLbl";
            viewProductSupOrderLbl.ReadOnly = true;
            viewProductSupOrderLbl.Size = new Size(346, 28);
            viewProductSupOrderLbl.TabIndex = 52;
            // 
            // cyberTextBox29
            // 
            cyberTextBox29.Alpha = 20;
            cyberTextBox29.BackColor = Color.Transparent;
            cyberTextBox29.Background_WidthPen = 3F;
            cyberTextBox29.BackgroundPen = true;
            cyberTextBox29.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox29.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox29.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox29.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox29.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox29.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox29.Enabled = false;
            cyberTextBox29.Font = new Font("Arial", 13F);
            cyberTextBox29.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox29.Lighting = false;
            cyberTextBox29.LinearGradientPen = false;
            cyberTextBox29.Location = new Point(105, 267);
            cyberTextBox29.Name = "cyberTextBox29";
            cyberTextBox29.PenWidth = 15;
            cyberTextBox29.RGB = false;
            cyberTextBox29.Rounding = true;
            cyberTextBox29.RoundingInt = 60;
            cyberTextBox29.Size = new Size(411, 55);
            cyberTextBox29.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox29.TabIndex = 51;
            cyberTextBox29.TabStop = false;
            cyberTextBox29.Tag = "Cyber";
            cyberTextBox29.TextButton = "";
            cyberTextBox29.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox29.Timer_RGB = 300;
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.BackColor = Color.FromArgb(236, 236, 236);
            label46.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label46.Location = new Point(105, 30);
            label46.Name = "label46";
            label46.Size = new Size(254, 33);
            label46.TabIndex = 49;
            label46.Text = "Order Information";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(222, 224, 235);
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Arial Narrow", 8F, FontStyle.Bold);
            textBox5.Location = new Point(105, 56);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(323, 19);
            textBox5.TabIndex = 50;
            textBox5.TabStop = false;
            // 
            // ViewdateOrderedLbl
            // 
            ViewdateOrderedLbl.AutoSize = true;
            ViewdateOrderedLbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ViewdateOrderedLbl.ForeColor = Color.FromArgb(76, 75, 78);
            ViewdateOrderedLbl.Location = new Point(141, 469);
            ViewdateOrderedLbl.Name = "ViewdateOrderedLbl";
            ViewdateOrderedLbl.Size = new Size(104, 29);
            ViewdateOrderedLbl.TabIndex = 48;
            ViewdateOrderedLbl.Text = "0000000";
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label45.ForeColor = Color.FromArgb(76, 75, 78);
            label45.Location = new Point(126, 412);
            label45.Name = "label45";
            label45.Size = new Size(152, 27);
            label45.TabIndex = 47;
            label45.Text = "Date ordered";
            // 
            // viewProductNameOrderLbl
            // 
            viewProductNameOrderLbl.BackColor = Color.FromArgb(236, 236, 236);
            viewProductNameOrderLbl.BorderStyle = BorderStyle.None;
            viewProductNameOrderLbl.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            viewProductNameOrderLbl.ForeColor = Color.FromArgb(76, 75, 78);
            viewProductNameOrderLbl.Location = new Point(116, 162);
            viewProductNameOrderLbl.Name = "viewProductNameOrderLbl";
            viewProductNameOrderLbl.ReadOnly = true;
            viewProductNameOrderLbl.Size = new Size(346, 28);
            viewProductNameOrderLbl.TabIndex = 46;
            // 
            // cyberTextBox28
            // 
            cyberTextBox28.Alpha = 20;
            cyberTextBox28.BackColor = Color.Transparent;
            cyberTextBox28.Background_WidthPen = 3F;
            cyberTextBox28.BackgroundPen = true;
            cyberTextBox28.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox28.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox28.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox28.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox28.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox28.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox28.Enabled = false;
            cyberTextBox28.Font = new Font("Arial", 13F);
            cyberTextBox28.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox28.Lighting = false;
            cyberTextBox28.LinearGradientPen = false;
            cyberTextBox28.Location = new Point(105, 146);
            cyberTextBox28.Name = "cyberTextBox28";
            cyberTextBox28.PenWidth = 15;
            cyberTextBox28.RGB = false;
            cyberTextBox28.Rounding = true;
            cyberTextBox28.RoundingInt = 60;
            cyberTextBox28.Size = new Size(411, 55);
            cyberTextBox28.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox28.TabIndex = 45;
            cyberTextBox28.TabStop = false;
            cyberTextBox28.Tag = "Cyber";
            cyberTextBox28.TextButton = "";
            cyberTextBox28.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox28.Timer_RGB = 300;
            // 
            // orderProduct
            // 
            orderProduct.Controls.Add(estimatedArrivalLbl);
            orderProduct.Controls.Add(label44);
            orderProduct.Controls.Add(orderTotalLbl);
            orderProduct.Controls.Add(label43);
            orderProduct.Controls.Add(orderProductCatField);
            orderProduct.Controls.Add(orderProductIDField);
            orderProduct.Controls.Add(orderProductNamecmb);
            orderProduct.Controls.Add(label19);
            orderProduct.Controls.Add(orderProductBtn);
            orderProduct.Controls.Add(orderProductQtyField);
            orderProduct.Controls.Add(label5);
            orderProduct.Controls.Add(orderProductsuppCmb);
            orderProduct.Controls.Add(label6);
            orderProduct.Controls.Add(label7);
            orderProduct.Controls.Add(label2);
            orderProduct.Controls.Add(orderProductPriceField);
            orderProduct.Controls.Add(cyberTextBox5);
            orderProduct.Controls.Add(cyberTextBox8);
            orderProduct.Controls.Add(cyberTextBox6);
            orderProduct.Controls.Add(cyberTextBox9);
            orderProduct.Controls.Add(cyberTextBox7);
            orderProduct.Controls.Add(cyberTextBox10);
            orderProduct.Controls.Add(label3);
            orderProduct.Controls.Add(label4);
            orderProduct.Controls.Add(textBox7);
            orderProduct.Location = new Point(4, 5);
            orderProduct.Name = "orderProduct";
            orderProduct.Size = new Size(1140, 795);
            orderProduct.TabIndex = 4;
            orderProduct.Text = "Order Product";
            orderProduct.UseVisualStyleBackColor = true;
            // 
            // estimatedArrivalLbl
            // 
            estimatedArrivalLbl.AutoSize = true;
            estimatedArrivalLbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            estimatedArrivalLbl.ForeColor = Color.FromArgb(76, 75, 78);
            estimatedArrivalLbl.Location = new Point(833, 527);
            estimatedArrivalLbl.Name = "estimatedArrivalLbl";
            estimatedArrivalLbl.Size = new Size(193, 29);
            estimatedArrivalLbl.TabIndex = 46;
            estimatedArrivalLbl.Text = "xxx-xxx-xxx-xxx";
            // 
            // label44
            // 
            label44.AutoSize = true;
            label44.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label44.ForeColor = Color.FromArgb(76, 75, 78);
            label44.Location = new Point(818, 470);
            label44.Name = "label44";
            label44.Size = new Size(198, 27);
            label44.TabIndex = 45;
            label44.Text = "Estimated Arrival ";
            // 
            // orderTotalLbl
            // 
            orderTotalLbl.AutoSize = true;
            orderTotalLbl.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderTotalLbl.ForeColor = Color.FromArgb(76, 75, 78);
            orderTotalLbl.Location = new Point(545, 527);
            orderTotalLbl.Name = "orderTotalLbl";
            orderTotalLbl.Size = new Size(104, 29);
            orderTotalLbl.TabIndex = 44;
            orderTotalLbl.Text = "0000000";
            // 
            // label43
            // 
            label43.AutoSize = true;
            label43.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label43.ForeColor = Color.FromArgb(76, 75, 78);
            label43.Location = new Point(530, 470);
            label43.Name = "label43";
            label43.Size = new Size(69, 27);
            label43.TabIndex = 43;
            label43.Text = "Total:";
            // 
            // orderProductCatField
            // 
            orderProductCatField.BackColor = Color.FromArgb(236, 236, 236);
            orderProductCatField.BorderStyle = BorderStyle.None;
            orderProductCatField.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderProductCatField.ForeColor = Color.FromArgb(76, 75, 78);
            orderProductCatField.Location = new Point(76, 529);
            orderProductCatField.Name = "orderProductCatField";
            orderProductCatField.ReadOnly = true;
            orderProductCatField.Size = new Size(225, 28);
            orderProductCatField.TabIndex = 42;
            // 
            // orderProductIDField
            // 
            orderProductIDField.BackColor = Color.FromArgb(236, 236, 236);
            orderProductIDField.BorderStyle = BorderStyle.None;
            orderProductIDField.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderProductIDField.ForeColor = Color.FromArgb(76, 75, 78);
            orderProductIDField.Location = new Point(66, 362);
            orderProductIDField.Name = "orderProductIDField";
            orderProductIDField.ReadOnly = true;
            orderProductIDField.Size = new Size(346, 28);
            orderProductIDField.TabIndex = 41;
            // 
            // orderProductNamecmb
            // 
            orderProductNamecmb.BackColor = Color.FromArgb(236, 236, 236);
            orderProductNamecmb.ColorA = Color.FromArgb(64, 64, 64);
            orderProductNamecmb.ColorB = Color.FromArgb(64, 64, 64);
            orderProductNamecmb.ColorC = Color.FromArgb(239, 237, 236);
            orderProductNamecmb.ColorD = Color.FromArgb(239, 237, 236);
            orderProductNamecmb.ColorE = Color.FromArgb(239, 237, 236);
            orderProductNamecmb.ColorF = Color.FromArgb(236, 236, 236);
            orderProductNamecmb.ColorG = Color.Black;
            orderProductNamecmb.ColorH = Color.FromArgb(236, 236, 236);
            orderProductNamecmb.ColorI = Color.FromArgb(236, 236, 236);
            orderProductNamecmb.DrawMode = DrawMode.OwnerDrawFixed;
            orderProductNamecmb.DropDownHeight = 100;
            orderProductNamecmb.DropDownStyle = ComboBoxStyle.DropDownList;
            orderProductNamecmb.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderProductNamecmb.ForeColor = Color.FromArgb(76, 75, 78);
            orderProductNamecmb.FormattingEnabled = true;
            orderProductNamecmb.HoverSelectionColor = Color.Empty;
            orderProductNamecmb.IntegralHeight = false;
            orderProductNamecmb.ItemHeight = 20;
            orderProductNamecmb.Location = new Point(591, 203);
            orderProductNamecmb.Name = "orderProductNamecmb";
            orderProductNamecmb.Size = new Size(335, 26);
            orderProductNamecmb.StartIndex = 0;
            orderProductNamecmb.TabIndex = 40;
            orderProductNamecmb.SelectedIndexChanged += orderProductNamecmb_SelectedIndexChanged;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.FromArgb(76, 75, 78);
            label19.Location = new Point(66, 292);
            label19.Name = "label19";
            label19.Size = new Size(126, 27);
            label19.TabIndex = 39;
            label19.Text = "Product ID";
            // 
            // orderProductBtn
            // 
            orderProductBtn.Alpha = 20;
            orderProductBtn.BackColor = Color.Transparent;
            orderProductBtn.Background = true;
            orderProductBtn.Background_WidthPen = 4F;
            orderProductBtn.BackgroundPen = true;
            orderProductBtn.ColorBackground = Color.FromArgb(236, 236, 236);
            orderProductBtn.ColorBackground_1 = SystemColors.ScrollBar;
            orderProductBtn.ColorBackground_2 = SystemColors.ActiveBorder;
            orderProductBtn.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            orderProductBtn.ColorLighting = Color.White;
            orderProductBtn.ColorPen_1 = SystemColors.WindowFrame;
            orderProductBtn.ColorPen_2 = Color.FromArgb(64, 64, 64);
            orderProductBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            orderProductBtn.Effect_1 = true;
            orderProductBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            orderProductBtn.Effect_1_Transparency = 25;
            orderProductBtn.Effect_2 = true;
            orderProductBtn.Effect_2_ColorBackground = Color.White;
            orderProductBtn.Effect_2_Transparency = 20;
            orderProductBtn.Font = new Font("Arial", 11F);
            orderProductBtn.ForeColor = Color.Black;
            orderProductBtn.Lighting = false;
            orderProductBtn.LinearGradient_Background = false;
            orderProductBtn.LinearGradientPen = false;
            orderProductBtn.Location = new Point(617, 693);
            orderProductBtn.Name = "orderProductBtn";
            orderProductBtn.PenWidth = 15;
            orderProductBtn.Rounding = true;
            orderProductBtn.RoundingInt = 70;
            orderProductBtn.Size = new Size(265, 72);
            orderProductBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            orderProductBtn.TabIndex = 33;
            orderProductBtn.Tag = "Cyber";
            orderProductBtn.TextButton = "Order Product";
            orderProductBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            orderProductBtn.Timer_Effect_1 = 5;
            orderProductBtn.Timer_RGB = 300;
            orderProductBtn.Click += orderProductBtn_Click;
            // 
            // orderProductQtyField
            // 
            orderProductQtyField.BackColor = Color.FromArgb(236, 236, 236);
            orderProductQtyField.BorderStyle = BorderStyle.None;
            orderProductQtyField.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderProductQtyField.ForeColor = Color.FromArgb(76, 75, 78);
            orderProductQtyField.Location = new Point(832, 368);
            orderProductQtyField.Name = "orderProductQtyField";
            orderProductQtyField.Size = new Size(210, 28);
            orderProductQtyField.TabIndex = 32;
            orderProductQtyField.KeyUp += orderProductQtyField_KeyUp;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(76, 75, 78);
            label5.Location = new Point(817, 292);
            label5.Name = "label5";
            label5.Size = new Size(194, 27);
            label5.TabIndex = 31;
            label5.Text = "Product Quantity";
            // 
            // orderProductsuppCmb
            // 
            orderProductsuppCmb.BackColor = Color.FromArgb(236, 236, 236);
            orderProductsuppCmb.ColorA = Color.FromArgb(64, 64, 64);
            orderProductsuppCmb.ColorB = Color.FromArgb(64, 64, 64);
            orderProductsuppCmb.ColorC = Color.FromArgb(239, 237, 236);
            orderProductsuppCmb.ColorD = Color.FromArgb(239, 237, 236);
            orderProductsuppCmb.ColorE = Color.FromArgb(239, 237, 236);
            orderProductsuppCmb.ColorF = Color.FromArgb(236, 236, 236);
            orderProductsuppCmb.ColorG = Color.Black;
            orderProductsuppCmb.ColorH = Color.FromArgb(236, 236, 236);
            orderProductsuppCmb.ColorI = Color.FromArgb(236, 236, 236);
            orderProductsuppCmb.DrawMode = DrawMode.OwnerDrawFixed;
            orderProductsuppCmb.DropDownHeight = 100;
            orderProductsuppCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            orderProductsuppCmb.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderProductsuppCmb.ForeColor = Color.FromArgb(76, 75, 78);
            orderProductsuppCmb.FormattingEnabled = true;
            orderProductsuppCmb.HoverSelectionColor = Color.Empty;
            orderProductsuppCmb.IntegralHeight = false;
            orderProductsuppCmb.ItemHeight = 20;
            orderProductsuppCmb.Location = new Point(66, 203);
            orderProductsuppCmb.Name = "orderProductsuppCmb";
            orderProductsuppCmb.Size = new Size(335, 26);
            orderProductsuppCmb.StartIndex = 0;
            orderProductsuppCmb.TabIndex = 30;
            orderProductsuppCmb.SelectedIndexChanged += orderProductsuppCmb_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(76, 75, 78);
            label6.Location = new Point(55, 134);
            label6.Name = "label6";
            label6.Size = new Size(193, 27);
            label6.TabIndex = 28;
            label6.Text = "Product Supplier";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(76, 75, 78);
            label7.Location = new Point(66, 470);
            label7.Name = "label7";
            label7.Size = new Size(200, 27);
            label7.TabIndex = 27;
            label7.Text = "Product Category";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(76, 75, 78);
            label2.Location = new Point(530, 292);
            label2.Name = "label2";
            label2.Size = new Size(157, 27);
            label2.TabIndex = 23;
            label2.Text = "Product Price";
            // 
            // orderProductPriceField
            // 
            orderProductPriceField.BackColor = Color.FromArgb(236, 236, 236);
            orderProductPriceField.BorderStyle = BorderStyle.None;
            orderProductPriceField.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderProductPriceField.ForeColor = Color.FromArgb(76, 75, 78);
            orderProductPriceField.Location = new Point(544, 362);
            orderProductPriceField.Name = "orderProductPriceField";
            orderProductPriceField.ReadOnly = true;
            orderProductPriceField.Size = new Size(225, 28);
            orderProductPriceField.TabIndex = 22;
            // 
            // cyberTextBox5
            // 
            cyberTextBox5.Alpha = 20;
            cyberTextBox5.BackColor = Color.Transparent;
            cyberTextBox5.Background_WidthPen = 3F;
            cyberTextBox5.BackgroundPen = true;
            cyberTextBox5.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox5.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox5.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox5.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox5.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox5.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox5.Enabled = false;
            cyberTextBox5.Font = new Font("Arial", 13F);
            cyberTextBox5.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox5.Lighting = false;
            cyberTextBox5.LinearGradientPen = false;
            cyberTextBox5.Location = new Point(529, 347);
            cyberTextBox5.Name = "cyberTextBox5";
            cyberTextBox5.PenWidth = 15;
            cyberTextBox5.RGB = false;
            cyberTextBox5.Rounding = true;
            cyberTextBox5.RoundingInt = 60;
            cyberTextBox5.Size = new Size(256, 55);
            cyberTextBox5.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox5.TabIndex = 21;
            cyberTextBox5.TabStop = false;
            cyberTextBox5.Tag = "Cyber";
            cyberTextBox5.TextButton = "";
            cyberTextBox5.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox5.Timer_RGB = 300;
            // 
            // cyberTextBox8
            // 
            cyberTextBox8.Alpha = 20;
            cyberTextBox8.BackColor = Color.Transparent;
            cyberTextBox8.Background_WidthPen = 3F;
            cyberTextBox8.BackgroundPen = true;
            cyberTextBox8.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox8.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox8.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox8.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox8.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox8.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox8.Enabled = false;
            cyberTextBox8.Font = new Font("Arial", 13F);
            cyberTextBox8.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox8.Lighting = false;
            cyberTextBox8.LinearGradientPen = false;
            cyberTextBox8.Location = new Point(55, 186);
            cyberTextBox8.Name = "cyberTextBox8";
            cyberTextBox8.PenWidth = 15;
            cyberTextBox8.RGB = false;
            cyberTextBox8.Rounding = true;
            cyberTextBox8.RoundingInt = 60;
            cyberTextBox8.Size = new Size(358, 55);
            cyberTextBox8.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox8.TabIndex = 35;
            cyberTextBox8.TabStop = false;
            cyberTextBox8.Tag = "Cyber";
            cyberTextBox8.TextButton = "";
            cyberTextBox8.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox8.Timer_RGB = 300;
            // 
            // cyberTextBox6
            // 
            cyberTextBox6.Alpha = 20;
            cyberTextBox6.BackColor = Color.Transparent;
            cyberTextBox6.Background_WidthPen = 3F;
            cyberTextBox6.BackgroundPen = true;
            cyberTextBox6.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox6.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox6.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox6.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox6.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox6.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox6.Enabled = false;
            cyberTextBox6.Font = new Font("Arial", 13F);
            cyberTextBox6.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox6.Lighting = false;
            cyberTextBox6.LinearGradientPen = false;
            cyberTextBox6.Location = new Point(526, 187);
            cyberTextBox6.Name = "cyberTextBox6";
            cyberTextBox6.PenWidth = 15;
            cyberTextBox6.RGB = false;
            cyberTextBox6.Rounding = true;
            cyberTextBox6.RoundingInt = 60;
            cyberTextBox6.Size = new Size(428, 55);
            cyberTextBox6.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox6.TabIndex = 19;
            cyberTextBox6.TabStop = false;
            cyberTextBox6.Tag = "Cyber";
            cyberTextBox6.TextButton = "";
            cyberTextBox6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox6.Timer_RGB = 300;
            // 
            // cyberTextBox9
            // 
            cyberTextBox9.Alpha = 20;
            cyberTextBox9.BackColor = Color.Transparent;
            cyberTextBox9.Background_WidthPen = 3F;
            cyberTextBox9.BackgroundPen = true;
            cyberTextBox9.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox9.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox9.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox9.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox9.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox9.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox9.Enabled = false;
            cyberTextBox9.Font = new Font("Arial", 15F);
            cyberTextBox9.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox9.Lighting = false;
            cyberTextBox9.LinearGradientPen = false;
            cyberTextBox9.Location = new Point(66, 508);
            cyberTextBox9.Name = "cyberTextBox9";
            cyberTextBox9.PenWidth = 15;
            cyberTextBox9.RGB = false;
            cyberTextBox9.Rounding = true;
            cyberTextBox9.RoundingInt = 60;
            cyberTextBox9.Size = new Size(246, 62);
            cyberTextBox9.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox9.TabIndex = 34;
            cyberTextBox9.TabStop = false;
            cyberTextBox9.Tag = "Cyber";
            cyberTextBox9.TextButton = "";
            cyberTextBox9.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox9.Timer_RGB = 300;
            // 
            // cyberTextBox7
            // 
            cyberTextBox7.Alpha = 20;
            cyberTextBox7.BackColor = Color.Transparent;
            cyberTextBox7.Background_WidthPen = 3F;
            cyberTextBox7.BackgroundPen = true;
            cyberTextBox7.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox7.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox7.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox7.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox7.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox7.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox7.Enabled = false;
            cyberTextBox7.Font = new Font("Arial", 13F);
            cyberTextBox7.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox7.Lighting = false;
            cyberTextBox7.LinearGradientPen = false;
            cyberTextBox7.Location = new Point(55, 346);
            cyberTextBox7.Name = "cyberTextBox7";
            cyberTextBox7.PenWidth = 15;
            cyberTextBox7.RGB = false;
            cyberTextBox7.Rounding = true;
            cyberTextBox7.RoundingInt = 60;
            cyberTextBox7.Size = new Size(411, 55);
            cyberTextBox7.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox7.TabIndex = 36;
            cyberTextBox7.TabStop = false;
            cyberTextBox7.Tag = "Cyber";
            cyberTextBox7.TextButton = "";
            cyberTextBox7.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox7.Timer_RGB = 300;
            // 
            // cyberTextBox10
            // 
            cyberTextBox10.Alpha = 20;
            cyberTextBox10.BackColor = Color.Transparent;
            cyberTextBox10.Background_WidthPen = 3F;
            cyberTextBox10.BackgroundPen = true;
            cyberTextBox10.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox10.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox10.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox10.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox10.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox10.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox10.Enabled = false;
            cyberTextBox10.Font = new Font("Arial", 13F);
            cyberTextBox10.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox10.Lighting = false;
            cyberTextBox10.LinearGradientPen = false;
            cyberTextBox10.Location = new Point(817, 353);
            cyberTextBox10.Name = "cyberTextBox10";
            cyberTextBox10.PenWidth = 15;
            cyberTextBox10.RGB = false;
            cyberTextBox10.Rounding = true;
            cyberTextBox10.RoundingInt = 60;
            cyberTextBox10.Size = new Size(240, 55);
            cyberTextBox10.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox10.TabIndex = 37;
            cyberTextBox10.TabStop = false;
            cyberTextBox10.Tag = "Cyber";
            cyberTextBox10.TextButton = "";
            cyberTextBox10.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox10.Timer_RGB = 300;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(76, 75, 78);
            label3.Location = new Point(526, 134);
            label3.Name = "label3";
            label3.Size = new Size(166, 27);
            label3.TabIndex = 18;
            label3.Text = "Product Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(236, 236, 236);
            label4.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(66, 47);
            label4.Name = "label4";
            label4.Size = new Size(219, 33);
            label4.TabIndex = 16;
            label4.Text = "Order Products";
            // 
            // textBox7
            // 
            textBox7.BackColor = Color.FromArgb(222, 224, 235);
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Arial Narrow", 8F, FontStyle.Bold);
            textBox7.Location = new Point(66, 73);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(323, 19);
            textBox7.TabIndex = 17;
            textBox7.TabStop = false;
            // 
            // viewStocks
            // 
            viewStocks.Controls.Add(cyberButton1);
            viewStocks.Controls.Add(label56);
            viewStocks.Controls.Add(label55);
            viewStocks.Controls.Add(label54);
            viewStocks.Controls.Add(label53);
            viewStocks.Controls.Add(stocksSearchField);
            viewStocks.Controls.Add(pictureBox5);
            viewStocks.Controls.Add(stocksTablePrompt);
            viewStocks.Controls.Add(cyberTextBox32);
            viewStocks.Controls.Add(cyberTextBox33);
            viewStocks.Controls.Add(stocksTable);
            viewStocks.Location = new Point(4, 5);
            viewStocks.Name = "viewStocks";
            viewStocks.Size = new Size(1140, 795);
            viewStocks.TabIndex = 12;
            viewStocks.Text = "Stocks";
            viewStocks.UseVisualStyleBackColor = true;
            // 
            // cyberButton1
            // 
            cyberButton1.Alpha = 20;
            cyberButton1.BackColor = Color.Transparent;
            cyberButton1.Background = true;
            cyberButton1.Background_WidthPen = 4F;
            cyberButton1.BackgroundPen = true;
            cyberButton1.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberButton1.ColorBackground_1 = SystemColors.ScrollBar;
            cyberButton1.ColorBackground_2 = SystemColors.ActiveBorder;
            cyberButton1.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberButton1.ColorLighting = Color.White;
            cyberButton1.ColorPen_1 = SystemColors.WindowFrame;
            cyberButton1.ColorPen_2 = Color.FromArgb(64, 64, 64);
            cyberButton1.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton1.Effect_1 = true;
            cyberButton1.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton1.Effect_1_Transparency = 25;
            cyberButton1.Effect_2 = true;
            cyberButton1.Effect_2_ColorBackground = Color.White;
            cyberButton1.Effect_2_Transparency = 20;
            cyberButton1.Font = new Font("Arial", 11F);
            cyberButton1.ForeColor = Color.Black;
            cyberButton1.Lighting = false;
            cyberButton1.LinearGradient_Background = false;
            cyberButton1.LinearGradientPen = false;
            cyberButton1.Location = new Point(841, 718);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 15;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 70;
            cyberButton1.Size = new Size(210, 59);
            cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton1.TabIndex = 54;
            cyberButton1.Tag = "Cyber";
            cyberButton1.TextButton = "Order Product";
            cyberButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            cyberButton1.Timer_Effect_1 = 5;
            cyberButton1.Timer_RGB = 300;
            cyberButton1.Click += OrderTabNavBtn_Click;
            // 
            // label56
            // 
            label56.AutoSize = true;
            label56.BackColor = Color.FromArgb(230, 230, 226);
            label56.Font = new Font("Arial", 12F);
            label56.ForeColor = Color.FromArgb(174, 174, 172);
            label56.Location = new Point(809, 159);
            label56.Margin = new Padding(4, 0, 4, 0);
            label56.Name = "label56";
            label56.Size = new Size(160, 27);
            label56.TabIndex = 53;
            label56.Text = "Date modified";
            // 
            // label55
            // 
            label55.AutoSize = true;
            label55.BackColor = Color.FromArgb(230, 230, 226);
            label55.Font = new Font("Arial", 12F);
            label55.ForeColor = Color.FromArgb(174, 174, 172);
            label55.Location = new Point(620, 159);
            label55.Margin = new Padding(4, 0, 4, 0);
            label55.Name = "label55";
            label55.Size = new Size(103, 27);
            label55.TabIndex = 52;
            label55.Text = "Quantity";
            // 
            // label54
            // 
            label54.AutoSize = true;
            label54.BackColor = Color.FromArgb(230, 230, 226);
            label54.Font = new Font("Arial", 12F);
            label54.ForeColor = Color.FromArgb(174, 174, 172);
            label54.Location = new Point(372, 159);
            label54.Margin = new Padding(4, 0, 4, 0);
            label54.Name = "label54";
            label54.Size = new Size(166, 27);
            label54.TabIndex = 51;
            label54.Text = "Product Name";
            // 
            // label53
            // 
            label53.AutoSize = true;
            label53.BackColor = Color.FromArgb(230, 230, 226);
            label53.Font = new Font("Arial", 12F);
            label53.ForeColor = Color.FromArgb(174, 174, 172);
            label53.Location = new Point(138, 159);
            label53.Margin = new Padding(4, 0, 4, 0);
            label53.Name = "label53";
            label53.Size = new Size(126, 27);
            label53.TabIndex = 50;
            label53.Text = "Product ID";
            // 
            // stocksSearchField
            // 
            stocksSearchField.BackColor = Color.FromArgb(236, 236, 236);
            stocksSearchField.BorderStyle = BorderStyle.None;
            stocksSearchField.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stocksSearchField.ForeColor = Color.FromArgb(174, 174, 172);
            stocksSearchField.Location = new Point(160, 65);
            stocksSearchField.Name = "stocksSearchField";
            stocksSearchField.Size = new Size(740, 28);
            stocksSearchField.TabIndex = 49;
            stocksSearchField.Text = "Search Product Name";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Resources.searchIcon;
            pictureBox5.Location = new Point(109, 65);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(35, 33);
            pictureBox5.TabIndex = 45;
            pictureBox5.TabStop = false;
            // 
            // stocksTablePrompt
            // 
            stocksTablePrompt.AutoSize = true;
            stocksTablePrompt.Font = new Font("Arial", 12F, FontStyle.Bold);
            stocksTablePrompt.Location = new Point(339, 310);
            stocksTablePrompt.Margin = new Padding(4, 0, 4, 0);
            stocksTablePrompt.Name = "stocksTablePrompt";
            stocksTablePrompt.Size = new Size(479, 29);
            stocksTablePrompt.TabIndex = 46;
            stocksTablePrompt.Text = "Products not found Please add products";
            stocksTablePrompt.TextAlign = ContentAlignment.MiddleCenter;
            stocksTablePrompt.Visible = false;
            // 
            // cyberTextBox32
            // 
            cyberTextBox32.Alpha = 20;
            cyberTextBox32.BackColor = Color.Transparent;
            cyberTextBox32.Background_WidthPen = 3F;
            cyberTextBox32.BackgroundPen = true;
            cyberTextBox32.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox32.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox32.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox32.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox32.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox32.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox32.Enabled = false;
            cyberTextBox32.Font = new Font("Arial", 13F);
            cyberTextBox32.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox32.Lighting = false;
            cyberTextBox32.LinearGradientPen = false;
            cyberTextBox32.Location = new Point(90, 48);
            cyberTextBox32.Name = "cyberTextBox32";
            cyberTextBox32.PenWidth = 15;
            cyberTextBox32.RGB = false;
            cyberTextBox32.Rounding = true;
            cyberTextBox32.RoundingInt = 60;
            cyberTextBox32.Size = new Size(879, 55);
            cyberTextBox32.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox32.TabIndex = 47;
            cyberTextBox32.TabStop = false;
            cyberTextBox32.Tag = "Cyber";
            cyberTextBox32.TextButton = "";
            cyberTextBox32.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox32.Timer_RGB = 300;
            // 
            // cyberTextBox33
            // 
            cyberTextBox33.Alpha = 20;
            cyberTextBox33.BackColor = Color.Transparent;
            cyberTextBox33.Background_WidthPen = 3F;
            cyberTextBox33.BackgroundPen = true;
            cyberTextBox33.ColorBackground = Color.FromArgb(230, 230, 226);
            cyberTextBox33.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox33.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox33.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox33.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox33.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox33.Enabled = false;
            cyberTextBox33.Font = new Font("Arial", 18F);
            cyberTextBox33.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox33.Lighting = false;
            cyberTextBox33.LinearGradientPen = false;
            cyberTextBox33.Location = new Point(90, 133);
            cyberTextBox33.Name = "cyberTextBox33";
            cyberTextBox33.PenWidth = 15;
            cyberTextBox33.RGB = false;
            cyberTextBox33.Rounding = true;
            cyberTextBox33.RoundingInt = 60;
            cyberTextBox33.Size = new Size(961, 72);
            cyberTextBox33.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox33.TabIndex = 48;
            cyberTextBox33.TabStop = false;
            cyberTextBox33.Tag = "Cyber";
            cyberTextBox33.TextButton = "";
            cyberTextBox33.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox33.Timer_RGB = 300;
            // 
            // stocksTable
            // 
            stocksTable.BackgroundColor = Color.FromArgb(236, 236, 236);
            stocksTable.BorderStyle = BorderStyle.None;
            stocksTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.LightGray;
            dataGridViewCellStyle7.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            stocksTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            stocksTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            stocksTable.DefaultCellStyle = dataGridViewCellStyle8;
            stocksTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            stocksTable.EnableHeadersVisualStyles = false;
            stocksTable.Location = new Point(90, 212);
            stocksTable.Margin = new Padding(4);
            stocksTable.Name = "stocksTable";
            stocksTable.ReadOnly = true;
            stocksTable.RowHeadersVisible = false;
            stocksTable.RowHeadersWidth = 120;
            stocksTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            stocksTable.RowTemplate.Height = 50;
            stocksTable.Size = new Size(961, 483);
            stocksTable.TabIndex = 44;
            stocksTable.CellClick += stocksTable_CellClick;
            // 
            // invoicePanel
            // 
            invoicePanel.Controls.Add(InvoiceSup);
            invoicePanel.Controls.Add(InvoiceProdCat);
            invoicePanel.Controls.Add(invoiceProdQuantity);
            invoicePanel.Controls.Add(invoiceOrderProdBtn);
            invoicePanel.Controls.Add(InvoiceTotalSalesQty);
            invoicePanel.Controls.Add(label66);
            invoicePanel.Controls.Add(InvoiceSalesQty);
            invoicePanel.Controls.Add(label64);
            invoicePanel.Controls.Add(cyberTextBox39);
            invoicePanel.Controls.Add(CreateInvoiceBtn);
            invoicePanel.Controls.Add(InvoiceDateMod);
            invoicePanel.Controls.Add(label57);
            invoicePanel.Controls.Add(invoiceProdQty);
            invoicePanel.Controls.Add(label58);
            invoicePanel.Controls.Add(cyberTextBox34);
            invoicePanel.Controls.Add(label59);
            invoicePanel.Controls.Add(invoiceProdPrice);
            invoicePanel.Controls.Add(cyberTextBox35);
            invoicePanel.Controls.Add(invoiceProdName);
            invoicePanel.Controls.Add(cyberTextBox36);
            invoicePanel.Controls.Add(label60);
            invoicePanel.Controls.Add(cyberTextBox37);
            invoicePanel.Controls.Add(label61);
            invoicePanel.Controls.Add(cyberTextBox38);
            invoicePanel.Controls.Add(label62);
            invoicePanel.Controls.Add(label63);
            invoicePanel.Controls.Add(textBox10);
            invoicePanel.Location = new Point(4, 5);
            invoicePanel.Name = "invoicePanel";
            invoicePanel.Size = new Size(1140, 795);
            invoicePanel.TabIndex = 13;
            invoicePanel.Text = "Invoice";
            invoicePanel.UseVisualStyleBackColor = true;
            // 
            // InvoiceSup
            // 
            InvoiceSup.BackColor = Color.FromArgb(236, 236, 236);
            InvoiceSup.BorderStyle = BorderStyle.None;
            InvoiceSup.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InvoiceSup.ForeColor = Color.FromArgb(76, 75, 78);
            InvoiceSup.Location = new Point(126, 523);
            InvoiceSup.Name = "InvoiceSup";
            InvoiceSup.ReadOnly = true;
            InvoiceSup.Size = new Size(210, 28);
            InvoiceSup.TabIndex = 56;
            // 
            // InvoiceProdCat
            // 
            InvoiceProdCat.BackColor = Color.FromArgb(236, 236, 236);
            InvoiceProdCat.BorderStyle = BorderStyle.None;
            InvoiceProdCat.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InvoiceProdCat.ForeColor = Color.FromArgb(76, 75, 78);
            InvoiceProdCat.Location = new Point(126, 359);
            InvoiceProdCat.Name = "InvoiceProdCat";
            InvoiceProdCat.ReadOnly = true;
            InvoiceProdCat.Size = new Size(210, 28);
            InvoiceProdCat.TabIndex = 55;
            // 
            // invoiceProdQuantity
            // 
            invoiceProdQuantity.BackColor = Color.FromArgb(236, 236, 236);
            invoiceProdQuantity.BorderStyle = BorderStyle.None;
            invoiceProdQuantity.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            invoiceProdQuantity.ForeColor = Color.FromArgb(76, 75, 78);
            invoiceProdQuantity.Location = new Point(481, 359);
            invoiceProdQuantity.Name = "invoiceProdQuantity";
            invoiceProdQuantity.ReadOnly = true;
            invoiceProdQuantity.Size = new Size(210, 28);
            invoiceProdQuantity.TabIndex = 55;
            // 
            // invoiceOrderProdBtn
            // 
            invoiceOrderProdBtn.Alpha = 20;
            invoiceOrderProdBtn.BackColor = Color.Transparent;
            invoiceOrderProdBtn.Background = true;
            invoiceOrderProdBtn.Background_WidthPen = 4F;
            invoiceOrderProdBtn.BackgroundPen = true;
            invoiceOrderProdBtn.ColorBackground = Color.FromArgb(236, 236, 236);
            invoiceOrderProdBtn.ColorBackground_1 = SystemColors.ScrollBar;
            invoiceOrderProdBtn.ColorBackground_2 = SystemColors.ActiveBorder;
            invoiceOrderProdBtn.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            invoiceOrderProdBtn.ColorLighting = Color.White;
            invoiceOrderProdBtn.ColorPen_1 = SystemColors.WindowFrame;
            invoiceOrderProdBtn.ColorPen_2 = Color.FromArgb(64, 64, 64);
            invoiceOrderProdBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            invoiceOrderProdBtn.Effect_1 = true;
            invoiceOrderProdBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            invoiceOrderProdBtn.Effect_1_Transparency = 25;
            invoiceOrderProdBtn.Effect_2 = true;
            invoiceOrderProdBtn.Effect_2_ColorBackground = Color.White;
            invoiceOrderProdBtn.Effect_2_Transparency = 20;
            invoiceOrderProdBtn.Font = new Font("Arial", 11F);
            invoiceOrderProdBtn.ForeColor = Color.Black;
            invoiceOrderProdBtn.Lighting = false;
            invoiceOrderProdBtn.LinearGradient_Background = false;
            invoiceOrderProdBtn.LinearGradientPen = false;
            invoiceOrderProdBtn.Location = new Point(441, 677);
            invoiceOrderProdBtn.Name = "invoiceOrderProdBtn";
            invoiceOrderProdBtn.PenWidth = 15;
            invoiceOrderProdBtn.Rounding = true;
            invoiceOrderProdBtn.RoundingInt = 70;
            invoiceOrderProdBtn.Size = new Size(265, 72);
            invoiceOrderProdBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            invoiceOrderProdBtn.TabIndex = 54;
            invoiceOrderProdBtn.Tag = "Cyber";
            invoiceOrderProdBtn.TextButton = "Order Product";
            invoiceOrderProdBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            invoiceOrderProdBtn.Timer_Effect_1 = 5;
            invoiceOrderProdBtn.Timer_RGB = 300;
            invoiceOrderProdBtn.Click += orderProdNavBtn_Click;
            // 
            // InvoiceTotalSalesQty
            // 
            InvoiceTotalSalesQty.AutoSize = true;
            InvoiceTotalSalesQty.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InvoiceTotalSalesQty.ForeColor = Color.FromArgb(76, 75, 78);
            InvoiceTotalSalesQty.Location = new Point(802, 522);
            InvoiceTotalSalesQty.Name = "InvoiceTotalSalesQty";
            InvoiceTotalSalesQty.Size = new Size(160, 27);
            InvoiceTotalSalesQty.TabIndex = 53;
            InvoiceTotalSalesQty.Text = "xxxx-xxxx-xxxx";
            // 
            // label66
            // 
            label66.AutoSize = true;
            label66.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label66.ForeColor = Color.FromArgb(76, 75, 78);
            label66.Location = new Point(802, 464);
            label66.Name = "label66";
            label66.Size = new Size(113, 27);
            label66.TabIndex = 52;
            label66.Text = "Total sale";
            // 
            // InvoiceSalesQty
            // 
            InvoiceSalesQty.BackColor = Color.FromArgb(236, 236, 236);
            InvoiceSalesQty.BorderStyle = BorderStyle.None;
            InvoiceSalesQty.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InvoiceSalesQty.ForeColor = Color.FromArgb(76, 75, 78);
            InvoiceSalesQty.Location = new Point(802, 359);
            InvoiceSalesQty.Name = "InvoiceSalesQty";
            InvoiceSalesQty.Size = new Size(210, 28);
            InvoiceSalesQty.TabIndex = 51;
            InvoiceSalesQty.KeyUp += InvoiceSalesQty_KeyUp;
            // 
            // label64
            // 
            label64.AutoSize = true;
            label64.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label64.ForeColor = Color.FromArgb(76, 75, 78);
            label64.Location = new Point(787, 300);
            label64.Name = "label64";
            label64.Size = new Size(170, 27);
            label64.TabIndex = 50;
            label64.Text = "Sales Quantity";
            // 
            // cyberTextBox39
            // 
            cyberTextBox39.Alpha = 20;
            cyberTextBox39.BackColor = Color.Transparent;
            cyberTextBox39.Background_WidthPen = 3F;
            cyberTextBox39.BackgroundPen = true;
            cyberTextBox39.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox39.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox39.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox39.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox39.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox39.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox39.Enabled = false;
            cyberTextBox39.Font = new Font("Arial", 13F);
            cyberTextBox39.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox39.Lighting = false;
            cyberTextBox39.LinearGradientPen = false;
            cyberTextBox39.Location = new Point(787, 346);
            cyberTextBox39.Name = "cyberTextBox39";
            cyberTextBox39.PenWidth = 15;
            cyberTextBox39.RGB = false;
            cyberTextBox39.Rounding = true;
            cyberTextBox39.RoundingInt = 60;
            cyberTextBox39.Size = new Size(240, 55);
            cyberTextBox39.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox39.TabIndex = 49;
            cyberTextBox39.TabStop = false;
            cyberTextBox39.Tag = "Cyber";
            cyberTextBox39.TextButton = "";
            cyberTextBox39.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox39.Timer_RGB = 300;
            // 
            // CreateInvoiceBtn
            // 
            CreateInvoiceBtn.Alpha = 20;
            CreateInvoiceBtn.BackColor = Color.Transparent;
            CreateInvoiceBtn.Background = true;
            CreateInvoiceBtn.Background_WidthPen = 4F;
            CreateInvoiceBtn.BackgroundPen = true;
            CreateInvoiceBtn.ColorBackground = Color.FromArgb(236, 236, 236);
            CreateInvoiceBtn.ColorBackground_1 = SystemColors.ScrollBar;
            CreateInvoiceBtn.ColorBackground_2 = SystemColors.ActiveBorder;
            CreateInvoiceBtn.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            CreateInvoiceBtn.ColorLighting = Color.White;
            CreateInvoiceBtn.ColorPen_1 = SystemColors.WindowFrame;
            CreateInvoiceBtn.ColorPen_2 = Color.FromArgb(64, 64, 64);
            CreateInvoiceBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            CreateInvoiceBtn.Effect_1 = true;
            CreateInvoiceBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            CreateInvoiceBtn.Effect_1_Transparency = 25;
            CreateInvoiceBtn.Effect_2 = true;
            CreateInvoiceBtn.Effect_2_ColorBackground = Color.White;
            CreateInvoiceBtn.Effect_2_Transparency = 20;
            CreateInvoiceBtn.Font = new Font("Arial", 11F);
            CreateInvoiceBtn.ForeColor = Color.Black;
            CreateInvoiceBtn.Lighting = false;
            CreateInvoiceBtn.LinearGradient_Background = false;
            CreateInvoiceBtn.LinearGradientPen = false;
            CreateInvoiceBtn.Location = new Point(764, 677);
            CreateInvoiceBtn.Name = "CreateInvoiceBtn";
            CreateInvoiceBtn.PenWidth = 15;
            CreateInvoiceBtn.Rounding = true;
            CreateInvoiceBtn.RoundingInt = 70;
            CreateInvoiceBtn.Size = new Size(265, 72);
            CreateInvoiceBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            CreateInvoiceBtn.TabIndex = 48;
            CreateInvoiceBtn.Tag = "Cyber";
            CreateInvoiceBtn.TextButton = "Create Invoice";
            CreateInvoiceBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            CreateInvoiceBtn.Timer_Effect_1 = 5;
            CreateInvoiceBtn.Timer_RGB = 300;
            CreateInvoiceBtn.Click += CreateInvoiceBtn_Click;
            // 
            // InvoiceDateMod
            // 
            InvoiceDateMod.AutoSize = true;
            InvoiceDateMod.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InvoiceDateMod.ForeColor = Color.FromArgb(76, 75, 78);
            InvoiceDateMod.Location = new Point(496, 523);
            InvoiceDateMod.Name = "InvoiceDateMod";
            InvoiceDateMod.Size = new Size(160, 27);
            InvoiceDateMod.TabIndex = 47;
            InvoiceDateMod.Text = "xxxx-xxxx-xxxx";
            // 
            // label57
            // 
            label57.AutoSize = true;
            label57.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label57.ForeColor = Color.FromArgb(76, 75, 78);
            label57.Location = new Point(496, 465);
            label57.Name = "label57";
            label57.Size = new Size(159, 27);
            label57.TabIndex = 46;
            label57.Text = "Date Modified";
            // 
            // invoiceProdQty
            // 
            invoiceProdQty.BackColor = Color.FromArgb(236, 236, 236);
            invoiceProdQty.BorderStyle = BorderStyle.None;
            invoiceProdQty.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            invoiceProdQty.ForeColor = Color.FromArgb(76, 75, 78);
            invoiceProdQty.Location = new Point(481, 359);
            invoiceProdQty.Name = "invoiceProdQty";
            invoiceProdQty.ReadOnly = true;
            invoiceProdQty.Size = new Size(210, 28);
            invoiceProdQty.TabIndex = 45;
            // 
            // label58
            // 
            label58.AutoSize = true;
            label58.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label58.ForeColor = Color.FromArgb(76, 75, 78);
            label58.Location = new Point(481, 300);
            label58.Name = "label58";
            label58.Size = new Size(194, 27);
            label58.TabIndex = 44;
            label58.Text = "Product Quantity";
            // 
            // cyberTextBox34
            // 
            cyberTextBox34.Alpha = 20;
            cyberTextBox34.BackColor = Color.Transparent;
            cyberTextBox34.Background_WidthPen = 3F;
            cyberTextBox34.BackgroundPen = true;
            cyberTextBox34.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox34.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox34.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox34.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox34.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox34.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox34.Enabled = false;
            cyberTextBox34.Font = new Font("Arial", 13F);
            cyberTextBox34.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox34.Lighting = false;
            cyberTextBox34.LinearGradientPen = false;
            cyberTextBox34.Location = new Point(466, 346);
            cyberTextBox34.Name = "cyberTextBox34";
            cyberTextBox34.PenWidth = 15;
            cyberTextBox34.RGB = false;
            cyberTextBox34.Rounding = true;
            cyberTextBox34.RoundingInt = 60;
            cyberTextBox34.Size = new Size(240, 55);
            cyberTextBox34.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox34.TabIndex = 43;
            cyberTextBox34.TabStop = false;
            cyberTextBox34.Tag = "Cyber";
            cyberTextBox34.TextButton = "";
            cyberTextBox34.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox34.Timer_RGB = 300;
            // 
            // label59
            // 
            label59.AutoSize = true;
            label59.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label59.ForeColor = Color.FromArgb(76, 75, 78);
            label59.Location = new Point(787, 130);
            label59.Name = "label59";
            label59.Size = new Size(157, 27);
            label59.TabIndex = 42;
            label59.Text = "Product Price";
            // 
            // invoiceProdPrice
            // 
            invoiceProdPrice.AcceptsReturn = true;
            invoiceProdPrice.BackColor = Color.FromArgb(236, 236, 236);
            invoiceProdPrice.BorderStyle = BorderStyle.None;
            invoiceProdPrice.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            invoiceProdPrice.ForeColor = Color.FromArgb(76, 75, 78);
            invoiceProdPrice.Location = new Point(787, 189);
            invoiceProdPrice.Name = "invoiceProdPrice";
            invoiceProdPrice.ReadOnly = true;
            invoiceProdPrice.Size = new Size(225, 28);
            invoiceProdPrice.TabIndex = 41;
            // 
            // cyberTextBox35
            // 
            cyberTextBox35.Alpha = 20;
            cyberTextBox35.BackColor = Color.Transparent;
            cyberTextBox35.Background_WidthPen = 3F;
            cyberTextBox35.BackgroundPen = true;
            cyberTextBox35.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox35.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox35.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox35.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox35.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox35.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox35.Enabled = false;
            cyberTextBox35.Font = new Font("Arial", 13F);
            cyberTextBox35.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox35.Lighting = false;
            cyberTextBox35.LinearGradientPen = false;
            cyberTextBox35.Location = new Point(772, 174);
            cyberTextBox35.Name = "cyberTextBox35";
            cyberTextBox35.PenWidth = 15;
            cyberTextBox35.RGB = false;
            cyberTextBox35.Rounding = true;
            cyberTextBox35.RoundingInt = 60;
            cyberTextBox35.Size = new Size(256, 55);
            cyberTextBox35.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox35.TabIndex = 40;
            cyberTextBox35.TabStop = false;
            cyberTextBox35.Tag = "Cyber";
            cyberTextBox35.TextButton = "";
            cyberTextBox35.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox35.Timer_RGB = 300;
            // 
            // invoiceProdName
            // 
            invoiceProdName.BackColor = Color.FromArgb(236, 236, 236);
            invoiceProdName.BorderStyle = BorderStyle.None;
            invoiceProdName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            invoiceProdName.ForeColor = Color.FromArgb(76, 75, 78);
            invoiceProdName.Location = new Point(126, 187);
            invoiceProdName.Name = "invoiceProdName";
            invoiceProdName.ReadOnly = true;
            invoiceProdName.Size = new Size(506, 28);
            invoiceProdName.TabIndex = 39;
            // 
            // cyberTextBox36
            // 
            cyberTextBox36.Alpha = 20;
            cyberTextBox36.BackColor = Color.Transparent;
            cyberTextBox36.Background_WidthPen = 3F;
            cyberTextBox36.BackgroundPen = true;
            cyberTextBox36.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox36.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox36.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox36.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox36.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox36.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox36.Enabled = false;
            cyberTextBox36.Font = new Font("Arial", 13F);
            cyberTextBox36.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox36.Lighting = false;
            cyberTextBox36.LinearGradientPen = false;
            cyberTextBox36.Location = new Point(111, 508);
            cyberTextBox36.Name = "cyberTextBox36";
            cyberTextBox36.PenWidth = 15;
            cyberTextBox36.RGB = false;
            cyberTextBox36.Rounding = true;
            cyberTextBox36.RoundingInt = 60;
            cyberTextBox36.Size = new Size(246, 55);
            cyberTextBox36.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox36.TabIndex = 36;
            cyberTextBox36.TabStop = false;
            cyberTextBox36.Tag = "Cyber";
            cyberTextBox36.TextButton = "";
            cyberTextBox36.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox36.Timer_RGB = 300;
            // 
            // label60
            // 
            label60.AutoSize = true;
            label60.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label60.ForeColor = Color.FromArgb(76, 75, 78);
            label60.Location = new Point(111, 464);
            label60.Name = "label60";
            label60.Size = new Size(193, 27);
            label60.TabIndex = 35;
            label60.Text = "Product Supplier";
            // 
            // cyberTextBox37
            // 
            cyberTextBox37.Alpha = 20;
            cyberTextBox37.BackColor = Color.Transparent;
            cyberTextBox37.Background_WidthPen = 3F;
            cyberTextBox37.BackgroundPen = true;
            cyberTextBox37.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox37.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox37.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox37.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox37.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox37.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox37.Enabled = false;
            cyberTextBox37.Font = new Font("Arial", 15F);
            cyberTextBox37.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox37.Lighting = false;
            cyberTextBox37.LinearGradientPen = false;
            cyberTextBox37.Location = new Point(111, 335);
            cyberTextBox37.Name = "cyberTextBox37";
            cyberTextBox37.PenWidth = 15;
            cyberTextBox37.RGB = false;
            cyberTextBox37.Rounding = true;
            cyberTextBox37.RoundingInt = 60;
            cyberTextBox37.Size = new Size(246, 62);
            cyberTextBox37.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox37.TabIndex = 34;
            cyberTextBox37.TabStop = false;
            cyberTextBox37.Tag = "Cyber";
            cyberTextBox37.TextButton = "";
            cyberTextBox37.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox37.Timer_RGB = 300;
            // 
            // label61
            // 
            label61.AutoSize = true;
            label61.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label61.ForeColor = Color.FromArgb(76, 75, 78);
            label61.Location = new Point(111, 291);
            label61.Name = "label61";
            label61.Size = new Size(200, 27);
            label61.TabIndex = 33;
            label61.Text = "Product Category";
            // 
            // cyberTextBox38
            // 
            cyberTextBox38.Alpha = 20;
            cyberTextBox38.BackColor = Color.Transparent;
            cyberTextBox38.Background_WidthPen = 3F;
            cyberTextBox38.BackgroundPen = true;
            cyberTextBox38.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox38.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox38.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox38.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox38.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox38.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox38.Enabled = false;
            cyberTextBox38.Font = new Font("Arial", 13F);
            cyberTextBox38.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox38.Lighting = false;
            cyberTextBox38.LinearGradientPen = false;
            cyberTextBox38.Location = new Point(111, 172);
            cyberTextBox38.Name = "cyberTextBox38";
            cyberTextBox38.PenWidth = 15;
            cyberTextBox38.RGB = false;
            cyberTextBox38.Rounding = true;
            cyberTextBox38.RoundingInt = 60;
            cyberTextBox38.Size = new Size(545, 55);
            cyberTextBox38.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox38.TabIndex = 32;
            cyberTextBox38.TabStop = false;
            cyberTextBox38.Tag = "Cyber";
            cyberTextBox38.TextButton = "";
            cyberTextBox38.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox38.Timer_RGB = 300;
            // 
            // label62
            // 
            label62.AutoSize = true;
            label62.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label62.ForeColor = Color.FromArgb(76, 75, 78);
            label62.Location = new Point(111, 128);
            label62.Name = "label62";
            label62.Size = new Size(166, 27);
            label62.TabIndex = 31;
            label62.Text = "Product Name";
            // 
            // label63
            // 
            label63.AutoSize = true;
            label63.BackColor = Color.FromArgb(236, 236, 236);
            label63.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label63.Location = new Point(111, 45);
            label63.Name = "label63";
            label63.Size = new Size(321, 33);
            label63.TabIndex = 29;
            label63.Text = "Create Product Invoice";
            // 
            // textBox10
            // 
            textBox10.BackColor = Color.FromArgb(222, 224, 235);
            textBox10.BorderStyle = BorderStyle.None;
            textBox10.Font = new Font("Arial Narrow", 8F, FontStyle.Bold);
            textBox10.Location = new Point(111, 71);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(323, 19);
            textBox10.TabIndex = 30;
            textBox10.TabStop = false;
            // 
            // supplierPanel
            // 
            supplierPanel.Controls.Add(supplierHdrPrompt);
            supplierPanel.Controls.Add(pictureBox2);
            supplierPanel.Controls.Add(addSupplierNavBtn);
            supplierPanel.Controls.Add(searchSupplierField);
            supplierPanel.Controls.Add(label22);
            supplierPanel.Controls.Add(label21);
            supplierPanel.Controls.Add(label20);
            supplierPanel.Controls.Add(cyberTextBox12);
            supplierPanel.Controls.Add(cyberTextBox11);
            supplierPanel.Controls.Add(supplierTable);
            supplierPanel.Location = new Point(4, 5);
            supplierPanel.Name = "supplierPanel";
            supplierPanel.Size = new Size(1140, 795);
            supplierPanel.TabIndex = 5;
            supplierPanel.Text = "Supplier";
            supplierPanel.UseVisualStyleBackColor = true;
            // 
            // supplierHdrPrompt
            // 
            supplierHdrPrompt.AutoSize = true;
            supplierHdrPrompt.Font = new Font("Arial", 12F, FontStyle.Bold);
            supplierHdrPrompt.Location = new Point(311, 252);
            supplierHdrPrompt.Margin = new Padding(4, 0, 4, 0);
            supplierHdrPrompt.Name = "supplierHdrPrompt";
            supplierHdrPrompt.Size = new Size(485, 29);
            supplierHdrPrompt.TabIndex = 35;
            supplierHdrPrompt.Text = "Suppliers not found Please add products";
            supplierHdrPrompt.TextAlign = ContentAlignment.MiddleCenter;
            supplierHdrPrompt.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Resources.searchIcon;
            pictureBox2.Location = new Point(118, 29);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 33);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // addSupplierNavBtn
            // 
            addSupplierNavBtn.Alpha = 20;
            addSupplierNavBtn.BackColor = Color.Transparent;
            addSupplierNavBtn.Background = true;
            addSupplierNavBtn.Background_WidthPen = 4F;
            addSupplierNavBtn.BackgroundPen = true;
            addSupplierNavBtn.ColorBackground = Color.FromArgb(236, 236, 236);
            addSupplierNavBtn.ColorBackground_1 = SystemColors.ScrollBar;
            addSupplierNavBtn.ColorBackground_2 = SystemColors.ActiveBorder;
            addSupplierNavBtn.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            addSupplierNavBtn.ColorLighting = Color.White;
            addSupplierNavBtn.ColorPen_1 = SystemColors.WindowFrame;
            addSupplierNavBtn.ColorPen_2 = Color.FromArgb(64, 64, 64);
            addSupplierNavBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            addSupplierNavBtn.Effect_1 = true;
            addSupplierNavBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            addSupplierNavBtn.Effect_1_Transparency = 25;
            addSupplierNavBtn.Effect_2 = true;
            addSupplierNavBtn.Effect_2_ColorBackground = Color.White;
            addSupplierNavBtn.Effect_2_Transparency = 20;
            addSupplierNavBtn.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addSupplierNavBtn.ForeColor = Color.Black;
            addSupplierNavBtn.Lighting = false;
            addSupplierNavBtn.LinearGradient_Background = false;
            addSupplierNavBtn.LinearGradientPen = false;
            addSupplierNavBtn.Location = new Point(877, 717);
            addSupplierNavBtn.Name = "addSupplierNavBtn";
            addSupplierNavBtn.PenWidth = 15;
            addSupplierNavBtn.Rounding = true;
            addSupplierNavBtn.RoundingInt = 70;
            addSupplierNavBtn.Size = new Size(172, 56);
            addSupplierNavBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            addSupplierNavBtn.TabIndex = 34;
            addSupplierNavBtn.Tag = "Cyber";
            addSupplierNavBtn.TextButton = "+ Add Supplier";
            addSupplierNavBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            addSupplierNavBtn.Timer_Effect_1 = 5;
            addSupplierNavBtn.Timer_RGB = 300;
            addSupplierNavBtn.Click += addSupplierNavBtn_Click;
            // 
            // searchSupplierField
            // 
            searchSupplierField.BackColor = Color.FromArgb(236, 236, 236);
            searchSupplierField.BorderStyle = BorderStyle.None;
            searchSupplierField.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchSupplierField.ForeColor = Color.FromArgb(174, 174, 172);
            searchSupplierField.Location = new Point(159, 29);
            searchSupplierField.Name = "searchSupplierField";
            searchSupplierField.Size = new Size(795, 28);
            searchSupplierField.TabIndex = 19;
            searchSupplierField.Text = "Search Supplier Name";
            searchSupplierField.KeyUp += searchSupplierField_KeyUp;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.FromArgb(230, 230, 226);
            label22.Font = new Font("Arial", 12F);
            label22.ForeColor = Color.FromArgb(174, 174, 172);
            label22.Location = new Point(752, 119);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(169, 27);
            label22.TabIndex = 11;
            label22.Text = "Supplier Email";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.FromArgb(230, 230, 226);
            label21.Font = new Font("Arial", 12F);
            label21.ForeColor = Color.FromArgb(174, 174, 172);
            label21.Location = new Point(478, 119);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(172, 27);
            label21.TabIndex = 10;
            label21.Text = "Supplier Name";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.FromArgb(230, 230, 226);
            label20.Font = new Font("Arial", 12F);
            label20.ForeColor = Color.FromArgb(174, 174, 172);
            label20.Location = new Point(175, 119);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(129, 27);
            label20.TabIndex = 9;
            label20.Text = "Supplier Id";
            // 
            // cyberTextBox12
            // 
            cyberTextBox12.Alpha = 20;
            cyberTextBox12.BackColor = Color.Transparent;
            cyberTextBox12.Background_WidthPen = 3F;
            cyberTextBox12.BackgroundPen = true;
            cyberTextBox12.ColorBackground = Color.FromArgb(230, 230, 226);
            cyberTextBox12.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox12.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox12.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox12.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox12.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox12.Enabled = false;
            cyberTextBox12.Font = new Font("Arial", 18F);
            cyberTextBox12.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox12.Lighting = false;
            cyberTextBox12.LinearGradientPen = false;
            cyberTextBox12.Location = new Point(98, 97);
            cyberTextBox12.Name = "cyberTextBox12";
            cyberTextBox12.PenWidth = 15;
            cyberTextBox12.RGB = false;
            cyberTextBox12.Rounding = true;
            cyberTextBox12.RoundingInt = 60;
            cyberTextBox12.Size = new Size(961, 72);
            cyberTextBox12.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox12.TabIndex = 5;
            cyberTextBox12.TabStop = false;
            cyberTextBox12.Tag = "Cyber";
            cyberTextBox12.TextButton = "";
            cyberTextBox12.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox12.Timer_RGB = 300;
            // 
            // cyberTextBox11
            // 
            cyberTextBox11.Alpha = 20;
            cyberTextBox11.BackColor = Color.Transparent;
            cyberTextBox11.Background_WidthPen = 3F;
            cyberTextBox11.BackgroundPen = true;
            cyberTextBox11.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox11.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox11.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox11.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox11.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox11.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox11.Enabled = false;
            cyberTextBox11.Font = new Font("Arial", 13F);
            cyberTextBox11.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox11.Lighting = false;
            cyberTextBox11.LinearGradientPen = false;
            cyberTextBox11.Location = new Point(98, 13);
            cyberTextBox11.Name = "cyberTextBox11";
            cyberTextBox11.PenWidth = 15;
            cyberTextBox11.RGB = false;
            cyberTextBox11.Rounding = true;
            cyberTextBox11.RoundingInt = 60;
            cyberTextBox11.Size = new Size(897, 55);
            cyberTextBox11.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox11.TabIndex = 4;
            cyberTextBox11.TabStop = false;
            cyberTextBox11.Tag = "Cyber";
            cyberTextBox11.TextButton = "";
            cyberTextBox11.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox11.Timer_RGB = 300;
            // 
            // supplierTable
            // 
            supplierTable.BackgroundColor = Color.FromArgb(236, 236, 236);
            supplierTable.BorderStyle = BorderStyle.None;
            supplierTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.LightGray;
            dataGridViewCellStyle9.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            supplierTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            supplierTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle10.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            supplierTable.DefaultCellStyle = dataGridViewCellStyle10;
            supplierTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            supplierTable.EnableHeadersVisualStyles = false;
            supplierTable.Location = new Point(105, 169);
            supplierTable.Margin = new Padding(4);
            supplierTable.Name = "supplierTable";
            supplierTable.ReadOnly = true;
            supplierTable.RowHeadersVisible = false;
            supplierTable.RowHeadersWidth = 120;
            supplierTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            supplierTable.RowTemplate.Height = 50;
            supplierTable.Size = new Size(961, 541);
            supplierTable.TabIndex = 1;
            supplierTable.CellClick += supplierTable_CellClick;
            // 
            // supplierMorePanel
            // 
            supplierMorePanel.Controls.Add(saveSupChangesBtn);
            supplierMorePanel.Controls.Add(stopEditingSupBtn);
            supplierMorePanel.Controls.Add(editSupplierBtn);
            supplierMorePanel.Controls.Add(moreSupIdField);
            supplierMorePanel.Controls.Add(moreSupAddressField);
            supplierMorePanel.Controls.Add(moreSupEmailField);
            supplierMorePanel.Controls.Add(moreSupNumField);
            supplierMorePanel.Controls.Add(moreSupNameField);
            supplierMorePanel.Controls.Add(moreSupProductLbl);
            supplierMorePanel.Controls.Add(info_supplierProductsCmb);
            supplierMorePanel.Controls.Add(info_supplierAdd);
            supplierMorePanel.Controls.Add(moreSupProdBg);
            supplierMorePanel.Controls.Add(label29);
            supplierMorePanel.Controls.Add(info_supplierEmail);
            supplierMorePanel.Controls.Add(label30);
            supplierMorePanel.Controls.Add(info_supplierNum);
            supplierMorePanel.Controls.Add(label31);
            supplierMorePanel.Controls.Add(label32);
            supplierMorePanel.Controls.Add(info_supplierId);
            supplierMorePanel.Controls.Add(info_supplierName);
            supplierMorePanel.Controls.Add(label33);
            supplierMorePanel.Controls.Add(supllierMoreHdr);
            supplierMorePanel.Controls.Add(textBox6);
            supplierMorePanel.Location = new Point(4, 5);
            supplierMorePanel.Name = "supplierMorePanel";
            supplierMorePanel.Size = new Size(1140, 795);
            supplierMorePanel.TabIndex = 7;
            supplierMorePanel.Text = "Supplier";
            supplierMorePanel.UseVisualStyleBackColor = true;
            // 
            // saveSupChangesBtn
            // 
            saveSupChangesBtn.Alpha = 20;
            saveSupChangesBtn.BackColor = Color.Transparent;
            saveSupChangesBtn.Background = true;
            saveSupChangesBtn.Background_WidthPen = 4F;
            saveSupChangesBtn.BackgroundPen = true;
            saveSupChangesBtn.ColorBackground = Color.FromArgb(236, 236, 236);
            saveSupChangesBtn.ColorBackground_1 = SystemColors.ScrollBar;
            saveSupChangesBtn.ColorBackground_2 = SystemColors.ActiveBorder;
            saveSupChangesBtn.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            saveSupChangesBtn.ColorLighting = Color.White;
            saveSupChangesBtn.ColorPen_1 = SystemColors.WindowFrame;
            saveSupChangesBtn.ColorPen_2 = Color.FromArgb(64, 64, 64);
            saveSupChangesBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            saveSupChangesBtn.Effect_1 = true;
            saveSupChangesBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            saveSupChangesBtn.Effect_1_Transparency = 25;
            saveSupChangesBtn.Effect_2 = true;
            saveSupChangesBtn.Effect_2_ColorBackground = Color.White;
            saveSupChangesBtn.Effect_2_Transparency = 20;
            saveSupChangesBtn.Font = new Font("Arial", 11F);
            saveSupChangesBtn.ForeColor = Color.Black;
            saveSupChangesBtn.Lighting = false;
            saveSupChangesBtn.LinearGradient_Background = false;
            saveSupChangesBtn.LinearGradientPen = false;
            saveSupChangesBtn.Location = new Point(635, 674);
            saveSupChangesBtn.Name = "saveSupChangesBtn";
            saveSupChangesBtn.PenWidth = 15;
            saveSupChangesBtn.Rounding = true;
            saveSupChangesBtn.RoundingInt = 70;
            saveSupChangesBtn.Size = new Size(265, 72);
            saveSupChangesBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            saveSupChangesBtn.TabIndex = 54;
            saveSupChangesBtn.Tag = "Cyber";
            saveSupChangesBtn.TextButton = "Save Changes";
            saveSupChangesBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            saveSupChangesBtn.Timer_Effect_1 = 5;
            saveSupChangesBtn.Timer_RGB = 300;
            saveSupChangesBtn.Click += saveSupChangesBtn_Click;
            // 
            // stopEditingSupBtn
            // 
            stopEditingSupBtn.Alpha = 20;
            stopEditingSupBtn.BackColor = Color.Transparent;
            stopEditingSupBtn.Background = true;
            stopEditingSupBtn.Background_WidthPen = 4F;
            stopEditingSupBtn.BackgroundPen = true;
            stopEditingSupBtn.ColorBackground = Color.FromArgb(236, 236, 236);
            stopEditingSupBtn.ColorBackground_1 = SystemColors.ScrollBar;
            stopEditingSupBtn.ColorBackground_2 = SystemColors.ActiveBorder;
            stopEditingSupBtn.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            stopEditingSupBtn.ColorLighting = Color.White;
            stopEditingSupBtn.ColorPen_1 = SystemColors.WindowFrame;
            stopEditingSupBtn.ColorPen_2 = Color.FromArgb(64, 64, 64);
            stopEditingSupBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            stopEditingSupBtn.Effect_1 = true;
            stopEditingSupBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            stopEditingSupBtn.Effect_1_Transparency = 25;
            stopEditingSupBtn.Effect_2 = true;
            stopEditingSupBtn.Effect_2_ColorBackground = Color.White;
            stopEditingSupBtn.Effect_2_Transparency = 20;
            stopEditingSupBtn.Font = new Font("Arial", 11F);
            stopEditingSupBtn.ForeColor = Color.Black;
            stopEditingSupBtn.Lighting = false;
            stopEditingSupBtn.LinearGradient_Background = false;
            stopEditingSupBtn.LinearGradientPen = false;
            stopEditingSupBtn.Location = new Point(289, 674);
            stopEditingSupBtn.Name = "stopEditingSupBtn";
            stopEditingSupBtn.PenWidth = 15;
            stopEditingSupBtn.Rounding = true;
            stopEditingSupBtn.RoundingInt = 70;
            stopEditingSupBtn.Size = new Size(265, 72);
            stopEditingSupBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            stopEditingSupBtn.TabIndex = 53;
            stopEditingSupBtn.Tag = "Cyber";
            stopEditingSupBtn.TextButton = "Stop Editing";
            stopEditingSupBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            stopEditingSupBtn.Timer_Effect_1 = 5;
            stopEditingSupBtn.Timer_RGB = 300;
            stopEditingSupBtn.Click += stopEditingSupBtn_Click;
            // 
            // editSupplierBtn
            // 
            editSupplierBtn.Alpha = 20;
            editSupplierBtn.BackColor = Color.Transparent;
            editSupplierBtn.Background = true;
            editSupplierBtn.Background_WidthPen = 4F;
            editSupplierBtn.BackgroundPen = true;
            editSupplierBtn.ColorBackground = Color.FromArgb(236, 236, 236);
            editSupplierBtn.ColorBackground_1 = SystemColors.ScrollBar;
            editSupplierBtn.ColorBackground_2 = SystemColors.ActiveBorder;
            editSupplierBtn.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            editSupplierBtn.ColorLighting = Color.White;
            editSupplierBtn.ColorPen_1 = SystemColors.WindowFrame;
            editSupplierBtn.ColorPen_2 = Color.FromArgb(64, 64, 64);
            editSupplierBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            editSupplierBtn.Effect_1 = true;
            editSupplierBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            editSupplierBtn.Effect_1_Transparency = 25;
            editSupplierBtn.Effect_2 = true;
            editSupplierBtn.Effect_2_ColorBackground = Color.White;
            editSupplierBtn.Effect_2_Transparency = 20;
            editSupplierBtn.Font = new Font("Arial", 11F);
            editSupplierBtn.ForeColor = Color.Black;
            editSupplierBtn.Lighting = false;
            editSupplierBtn.LinearGradient_Background = false;
            editSupplierBtn.LinearGradientPen = false;
            editSupplierBtn.Location = new Point(635, 674);
            editSupplierBtn.Name = "editSupplierBtn";
            editSupplierBtn.PenWidth = 15;
            editSupplierBtn.Rounding = true;
            editSupplierBtn.RoundingInt = 70;
            editSupplierBtn.Size = new Size(265, 72);
            editSupplierBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            editSupplierBtn.TabIndex = 52;
            editSupplierBtn.Tag = "Cyber";
            editSupplierBtn.TextButton = "Edit Supplier";
            editSupplierBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            editSupplierBtn.Timer_Effect_1 = 5;
            editSupplierBtn.Timer_RGB = 300;
            editSupplierBtn.Click += editSupplierBtn_Click;
            // 
            // moreSupIdField
            // 
            moreSupIdField.BackColor = Color.FromArgb(236, 236, 236);
            moreSupIdField.BorderStyle = BorderStyle.None;
            moreSupIdField.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            moreSupIdField.ForeColor = Color.FromArgb(76, 75, 78);
            moreSupIdField.Location = new Point(618, 204);
            moreSupIdField.Name = "moreSupIdField";
            moreSupIdField.ReadOnly = true;
            moreSupIdField.Size = new Size(396, 28);
            moreSupIdField.TabIndex = 51;
            moreSupIdField.TabStop = false;
            // 
            // moreSupAddressField
            // 
            moreSupAddressField.BackColor = Color.FromArgb(236, 236, 236);
            moreSupAddressField.BorderStyle = BorderStyle.None;
            moreSupAddressField.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            moreSupAddressField.ForeColor = Color.FromArgb(76, 75, 78);
            moreSupAddressField.Location = new Point(618, 366);
            moreSupAddressField.Name = "moreSupAddressField";
            moreSupAddressField.Size = new Size(439, 28);
            moreSupAddressField.TabIndex = 50;
            // 
            // moreSupEmailField
            // 
            moreSupEmailField.BackColor = Color.FromArgb(236, 236, 236);
            moreSupEmailField.BorderStyle = BorderStyle.None;
            moreSupEmailField.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            moreSupEmailField.ForeColor = Color.FromArgb(76, 75, 78);
            moreSupEmailField.Location = new Point(119, 536);
            moreSupEmailField.Name = "moreSupEmailField";
            moreSupEmailField.Size = new Size(363, 28);
            moreSupEmailField.TabIndex = 49;
            // 
            // moreSupNumField
            // 
            moreSupNumField.BackColor = Color.FromArgb(236, 236, 236);
            moreSupNumField.BorderStyle = BorderStyle.None;
            moreSupNumField.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            moreSupNumField.ForeColor = Color.FromArgb(76, 75, 78);
            moreSupNumField.Location = new Point(119, 366);
            moreSupNumField.Name = "moreSupNumField";
            moreSupNumField.Size = new Size(363, 28);
            moreSupNumField.TabIndex = 48;
            // 
            // moreSupNameField
            // 
            moreSupNameField.BackColor = Color.FromArgb(236, 236, 236);
            moreSupNameField.BorderStyle = BorderStyle.None;
            moreSupNameField.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            moreSupNameField.ForeColor = Color.FromArgb(76, 75, 78);
            moreSupNameField.Location = new Point(119, 204);
            moreSupNameField.Name = "moreSupNameField";
            moreSupNameField.Size = new Size(435, 28);
            moreSupNameField.TabIndex = 47;
            // 
            // moreSupProductLbl
            // 
            moreSupProductLbl.AutoSize = true;
            moreSupProductLbl.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            moreSupProductLbl.ForeColor = Color.FromArgb(76, 75, 78);
            moreSupProductLbl.Location = new Point(618, 475);
            moreSupProductLbl.Name = "moreSupProductLbl";
            moreSupProductLbl.Size = new Size(205, 27);
            moreSupProductLbl.TabIndex = 46;
            moreSupProductLbl.Text = "Supplier Products";
            // 
            // info_supplierProductsCmb
            // 
            info_supplierProductsCmb.BackColor = Color.FromArgb(236, 236, 236);
            info_supplierProductsCmb.ColorA = Color.FromArgb(64, 64, 64);
            info_supplierProductsCmb.ColorB = Color.FromArgb(64, 64, 64);
            info_supplierProductsCmb.ColorC = Color.FromArgb(239, 237, 236);
            info_supplierProductsCmb.ColorD = Color.FromArgb(239, 237, 236);
            info_supplierProductsCmb.ColorE = Color.FromArgb(239, 237, 236);
            info_supplierProductsCmb.ColorF = Color.FromArgb(236, 236, 236);
            info_supplierProductsCmb.ColorG = Color.Black;
            info_supplierProductsCmb.ColorH = Color.FromArgb(236, 236, 236);
            info_supplierProductsCmb.ColorI = Color.FromArgb(236, 236, 236);
            info_supplierProductsCmb.DrawMode = DrawMode.OwnerDrawFixed;
            info_supplierProductsCmb.DropDownHeight = 100;
            info_supplierProductsCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            info_supplierProductsCmb.Font = new Font("Arial", 12F);
            info_supplierProductsCmb.ForeColor = Color.FromArgb(76, 75, 78);
            info_supplierProductsCmb.FormattingEnabled = true;
            info_supplierProductsCmb.HoverSelectionColor = Color.Empty;
            info_supplierProductsCmb.IntegralHeight = false;
            info_supplierProductsCmb.ItemHeight = 20;
            info_supplierProductsCmb.Location = new Point(635, 533);
            info_supplierProductsCmb.Name = "info_supplierProductsCmb";
            info_supplierProductsCmb.Size = new Size(379, 26);
            info_supplierProductsCmb.StartIndex = 0;
            info_supplierProductsCmb.TabIndex = 44;
            // 
            // info_supplierAdd
            // 
            info_supplierAdd.Alpha = 20;
            info_supplierAdd.BackColor = Color.Transparent;
            info_supplierAdd.Background_WidthPen = 3F;
            info_supplierAdd.BackgroundPen = true;
            info_supplierAdd.ColorBackground = Color.FromArgb(236, 236, 236);
            info_supplierAdd.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            info_supplierAdd.ColorLighting = Color.FromArgb(174, 174, 172);
            info_supplierAdd.ColorPen_1 = Color.FromArgb(174, 174, 172);
            info_supplierAdd.ColorPen_2 = Color.FromArgb(174, 174, 172);
            info_supplierAdd.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            info_supplierAdd.Enabled = false;
            info_supplierAdd.Font = new Font("Arial", 13F);
            info_supplierAdd.ForeColor = Color.FromArgb(245, 245, 245);
            info_supplierAdd.Lighting = false;
            info_supplierAdd.LinearGradientPen = false;
            info_supplierAdd.Location = new Point(606, 349);
            info_supplierAdd.Name = "info_supplierAdd";
            info_supplierAdd.PenWidth = 15;
            info_supplierAdd.RGB = false;
            info_supplierAdd.Rounding = true;
            info_supplierAdd.RoundingInt = 60;
            info_supplierAdd.Size = new Size(463, 55);
            info_supplierAdd.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            info_supplierAdd.TabIndex = 43;
            info_supplierAdd.TabStop = false;
            info_supplierAdd.Tag = "Cyber";
            info_supplierAdd.TextButton = "";
            info_supplierAdd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            info_supplierAdd.Timer_RGB = 300;
            // 
            // moreSupProdBg
            // 
            moreSupProdBg.Alpha = 20;
            moreSupProdBg.BackColor = Color.Transparent;
            moreSupProdBg.Background_WidthPen = 3F;
            moreSupProdBg.BackgroundPen = true;
            moreSupProdBg.ColorBackground = Color.FromArgb(236, 236, 236);
            moreSupProdBg.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            moreSupProdBg.ColorLighting = Color.FromArgb(174, 174, 172);
            moreSupProdBg.ColorPen_1 = Color.FromArgb(174, 174, 172);
            moreSupProdBg.ColorPen_2 = Color.FromArgb(174, 174, 172);
            moreSupProdBg.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            moreSupProdBg.Enabled = false;
            moreSupProdBg.Font = new Font("Arial", 13F);
            moreSupProdBg.ForeColor = Color.FromArgb(245, 245, 245);
            moreSupProdBg.Lighting = false;
            moreSupProdBg.LinearGradientPen = false;
            moreSupProdBg.Location = new Point(606, 519);
            moreSupProdBg.Name = "moreSupProdBg";
            moreSupProdBg.PenWidth = 15;
            moreSupProdBg.RGB = false;
            moreSupProdBg.Rounding = true;
            moreSupProdBg.RoundingInt = 60;
            moreSupProdBg.Size = new Size(420, 55);
            moreSupProdBg.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            moreSupProdBg.TabIndex = 45;
            moreSupProdBg.TabStop = false;
            moreSupProdBg.Tag = "Cyber";
            moreSupProdBg.TextButton = "";
            moreSupProdBg.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            moreSupProdBg.Timer_RGB = 300;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label29.ForeColor = Color.FromArgb(76, 75, 78);
            label29.Location = new Point(606, 305);
            label29.Name = "label29";
            label29.Size = new Size(196, 27);
            label29.TabIndex = 42;
            label29.Text = "Supplier Address";
            // 
            // info_supplierEmail
            // 
            info_supplierEmail.Alpha = 20;
            info_supplierEmail.BackColor = Color.Transparent;
            info_supplierEmail.Background_WidthPen = 3F;
            info_supplierEmail.BackgroundPen = true;
            info_supplierEmail.ColorBackground = Color.FromArgb(236, 236, 236);
            info_supplierEmail.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            info_supplierEmail.ColorLighting = Color.FromArgb(174, 174, 172);
            info_supplierEmail.ColorPen_1 = Color.FromArgb(174, 174, 172);
            info_supplierEmail.ColorPen_2 = Color.FromArgb(174, 174, 172);
            info_supplierEmail.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            info_supplierEmail.Enabled = false;
            info_supplierEmail.Font = new Font("Arial", 13F);
            info_supplierEmail.ForeColor = Color.FromArgb(245, 245, 245);
            info_supplierEmail.Lighting = false;
            info_supplierEmail.LinearGradientPen = false;
            info_supplierEmail.Location = new Point(105, 519);
            info_supplierEmail.Name = "info_supplierEmail";
            info_supplierEmail.PenWidth = 15;
            info_supplierEmail.RGB = false;
            info_supplierEmail.Rounding = true;
            info_supplierEmail.RoundingInt = 60;
            info_supplierEmail.Size = new Size(387, 55);
            info_supplierEmail.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            info_supplierEmail.TabIndex = 41;
            info_supplierEmail.TabStop = false;
            info_supplierEmail.Tag = "Cyber";
            info_supplierEmail.TextButton = "";
            info_supplierEmail.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            info_supplierEmail.Timer_RGB = 300;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label30.ForeColor = Color.FromArgb(76, 75, 78);
            label30.Location = new Point(105, 475);
            label30.Name = "label30";
            label30.Size = new Size(263, 27);
            label30.TabIndex = 40;
            label30.Text = "Supplier Email Address";
            // 
            // info_supplierNum
            // 
            info_supplierNum.Alpha = 20;
            info_supplierNum.BackColor = Color.Transparent;
            info_supplierNum.Background_WidthPen = 3F;
            info_supplierNum.BackgroundPen = true;
            info_supplierNum.ColorBackground = Color.FromArgb(236, 236, 236);
            info_supplierNum.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            info_supplierNum.ColorLighting = Color.FromArgb(174, 174, 172);
            info_supplierNum.ColorPen_1 = Color.FromArgb(174, 174, 172);
            info_supplierNum.ColorPen_2 = Color.FromArgb(174, 174, 172);
            info_supplierNum.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            info_supplierNum.Enabled = false;
            info_supplierNum.Font = new Font("Arial", 13F);
            info_supplierNum.ForeColor = Color.FromArgb(245, 245, 245);
            info_supplierNum.Lighting = false;
            info_supplierNum.LinearGradientPen = false;
            info_supplierNum.Location = new Point(105, 349);
            info_supplierNum.Name = "info_supplierNum";
            info_supplierNum.PenWidth = 15;
            info_supplierNum.RGB = false;
            info_supplierNum.Rounding = true;
            info_supplierNum.RoundingInt = 60;
            info_supplierNum.Size = new Size(387, 55);
            info_supplierNum.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            info_supplierNum.TabIndex = 39;
            info_supplierNum.TabStop = false;
            info_supplierNum.Tag = "Cyber";
            info_supplierNum.TextButton = "";
            info_supplierNum.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            info_supplierNum.Timer_RGB = 300;
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label31.ForeColor = Color.FromArgb(76, 75, 78);
            label31.Location = new Point(105, 305);
            label31.Name = "label31";
            label31.Size = new Size(292, 27);
            label31.TabIndex = 38;
            label31.Text = "Supplier Contact Number ";
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label32.ForeColor = Color.FromArgb(76, 75, 78);
            label32.Location = new Point(618, 151);
            label32.Name = "label32";
            label32.Size = new Size(129, 27);
            label32.TabIndex = 37;
            label32.Text = "Supplier Id";
            // 
            // info_supplierId
            // 
            info_supplierId.Alpha = 20;
            info_supplierId.BackColor = Color.Transparent;
            info_supplierId.Background_WidthPen = 3F;
            info_supplierId.BackgroundPen = true;
            info_supplierId.ColorBackground = Color.FromArgb(236, 236, 236);
            info_supplierId.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            info_supplierId.ColorLighting = Color.FromArgb(174, 174, 172);
            info_supplierId.ColorPen_1 = Color.FromArgb(174, 174, 172);
            info_supplierId.ColorPen_2 = Color.FromArgb(174, 174, 172);
            info_supplierId.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            info_supplierId.Enabled = false;
            info_supplierId.Font = new Font("Arial", 13F);
            info_supplierId.ForeColor = Color.FromArgb(245, 245, 245);
            info_supplierId.Lighting = false;
            info_supplierId.LinearGradientPen = false;
            info_supplierId.Location = new Point(606, 181);
            info_supplierId.Name = "info_supplierId";
            info_supplierId.PenWidth = 15;
            info_supplierId.RGB = false;
            info_supplierId.Rounding = true;
            info_supplierId.RoundingInt = 60;
            info_supplierId.Size = new Size(463, 55);
            info_supplierId.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            info_supplierId.TabIndex = 36;
            info_supplierId.TabStop = false;
            info_supplierId.Tag = "Cyber";
            info_supplierId.TextButton = "";
            info_supplierId.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            info_supplierId.Timer_RGB = 300;
            // 
            // info_supplierName
            // 
            info_supplierName.Alpha = 20;
            info_supplierName.BackColor = Color.Transparent;
            info_supplierName.Background_WidthPen = 3F;
            info_supplierName.BackgroundPen = true;
            info_supplierName.ColorBackground = Color.FromArgb(236, 236, 236);
            info_supplierName.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            info_supplierName.ColorLighting = Color.FromArgb(174, 174, 172);
            info_supplierName.ColorPen_1 = Color.FromArgb(174, 174, 172);
            info_supplierName.ColorPen_2 = Color.FromArgb(174, 174, 172);
            info_supplierName.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            info_supplierName.Enabled = false;
            info_supplierName.Font = new Font("Arial", 13F);
            info_supplierName.ForeColor = Color.FromArgb(245, 245, 245);
            info_supplierName.Lighting = false;
            info_supplierName.LinearGradientPen = false;
            info_supplierName.Location = new Point(105, 181);
            info_supplierName.Name = "info_supplierName";
            info_supplierName.PenWidth = 15;
            info_supplierName.RGB = false;
            info_supplierName.Rounding = true;
            info_supplierName.RoundingInt = 60;
            info_supplierName.Size = new Size(474, 55);
            info_supplierName.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            info_supplierName.TabIndex = 35;
            info_supplierName.TabStop = false;
            info_supplierName.Tag = "Cyber";
            info_supplierName.TextButton = "";
            info_supplierName.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            info_supplierName.Timer_RGB = 300;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label33.ForeColor = Color.FromArgb(76, 75, 78);
            label33.Location = new Point(105, 137);
            label33.Name = "label33";
            label33.Size = new Size(172, 27);
            label33.TabIndex = 34;
            label33.Text = "Supplier Name";
            // 
            // supllierMoreHdr
            // 
            supllierMoreHdr.AutoSize = true;
            supllierMoreHdr.BackColor = Color.FromArgb(236, 236, 236);
            supllierMoreHdr.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            supllierMoreHdr.Location = new Point(105, 54);
            supllierMoreHdr.Name = "supllierMoreHdr";
            supllierMoreHdr.Size = new Size(299, 33);
            supllierMoreHdr.TabIndex = 32;
            supllierMoreHdr.Text = " Supplier Information";
            // 
            // textBox6
            // 
            textBox6.BackColor = Color.FromArgb(222, 224, 235);
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Arial Narrow", 8F, FontStyle.Bold);
            textBox6.Location = new Point(105, 80);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(323, 19);
            textBox6.TabIndex = 33;
            textBox6.TabStop = false;
            // 
            // addSupplier
            // 
            addSupplier.Controls.Add(addSupplierBtn);
            addSupplier.Controls.Add(addSupplierAddress);
            addSupplier.Controls.Add(cyberTextBox17);
            addSupplier.Controls.Add(label28);
            addSupplier.Controls.Add(addSupplierEmail);
            addSupplier.Controls.Add(cyberTextBox16);
            addSupplier.Controls.Add(label27);
            addSupplier.Controls.Add(addSupplierNum);
            addSupplier.Controls.Add(cyberTextBox15);
            addSupplier.Controls.Add(label26);
            addSupplier.Controls.Add(label23);
            addSupplier.Controls.Add(addSupplierId);
            addSupplier.Controls.Add(cyberTextBox13);
            addSupplier.Controls.Add(addSupplierName);
            addSupplier.Controls.Add(cyberTextBox14);
            addSupplier.Controls.Add(label24);
            addSupplier.Controls.Add(label25);
            addSupplier.Controls.Add(textBox8);
            addSupplier.Location = new Point(4, 5);
            addSupplier.Name = "addSupplier";
            addSupplier.Size = new Size(1140, 795);
            addSupplier.TabIndex = 6;
            addSupplier.Text = "Supplier / Add supplier";
            addSupplier.UseVisualStyleBackColor = true;
            // 
            // addSupplierBtn
            // 
            addSupplierBtn.Alpha = 20;
            addSupplierBtn.BackColor = Color.Transparent;
            addSupplierBtn.Background = true;
            addSupplierBtn.Background_WidthPen = 4F;
            addSupplierBtn.BackgroundPen = true;
            addSupplierBtn.ColorBackground = Color.FromArgb(236, 236, 236);
            addSupplierBtn.ColorBackground_1 = SystemColors.ScrollBar;
            addSupplierBtn.ColorBackground_2 = SystemColors.ActiveBorder;
            addSupplierBtn.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            addSupplierBtn.ColorLighting = Color.White;
            addSupplierBtn.ColorPen_1 = SystemColors.WindowFrame;
            addSupplierBtn.ColorPen_2 = Color.FromArgb(64, 64, 64);
            addSupplierBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            addSupplierBtn.Effect_1 = true;
            addSupplierBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            addSupplierBtn.Effect_1_Transparency = 25;
            addSupplierBtn.Effect_2 = true;
            addSupplierBtn.Effect_2_ColorBackground = Color.White;
            addSupplierBtn.Effect_2_Transparency = 20;
            addSupplierBtn.Font = new Font("Arial", 11F);
            addSupplierBtn.ForeColor = Color.Black;
            addSupplierBtn.Lighting = false;
            addSupplierBtn.LinearGradient_Background = false;
            addSupplierBtn.LinearGradientPen = false;
            addSupplierBtn.Location = new Point(649, 590);
            addSupplierBtn.Name = "addSupplierBtn";
            addSupplierBtn.PenWidth = 15;
            addSupplierBtn.Rounding = true;
            addSupplierBtn.RoundingInt = 70;
            addSupplierBtn.Size = new Size(265, 72);
            addSupplierBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            addSupplierBtn.TabIndex = 33;
            addSupplierBtn.Tag = "Cyber";
            addSupplierBtn.TextButton = "Add Supplier";
            addSupplierBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            addSupplierBtn.Timer_Effect_1 = 5;
            addSupplierBtn.Timer_RGB = 300;
            addSupplierBtn.Click += addSupplierBtn_Click;
            // 
            // addSupplierAddress
            // 
            addSupplierAddress.BackColor = Color.FromArgb(236, 236, 236);
            addSupplierAddress.BorderStyle = BorderStyle.None;
            addSupplierAddress.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addSupplierAddress.ForeColor = Color.FromArgb(76, 75, 78);
            addSupplierAddress.Location = new Point(649, 346);
            addSupplierAddress.Name = "addSupplierAddress";
            addSupplierAddress.Size = new Size(435, 28);
            addSupplierAddress.TabIndex = 32;
            // 
            // cyberTextBox17
            // 
            cyberTextBox17.Alpha = 20;
            cyberTextBox17.BackColor = Color.Transparent;
            cyberTextBox17.Background_WidthPen = 3F;
            cyberTextBox17.BackgroundPen = true;
            cyberTextBox17.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox17.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox17.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox17.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox17.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox17.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox17.Enabled = false;
            cyberTextBox17.Font = new Font("Arial", 13F);
            cyberTextBox17.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox17.Lighting = false;
            cyberTextBox17.LinearGradientPen = false;
            cyberTextBox17.Location = new Point(629, 331);
            cyberTextBox17.Name = "cyberTextBox17";
            cyberTextBox17.PenWidth = 15;
            cyberTextBox17.RGB = false;
            cyberTextBox17.Rounding = true;
            cyberTextBox17.RoundingInt = 60;
            cyberTextBox17.Size = new Size(455, 55);
            cyberTextBox17.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox17.TabIndex = 31;
            cyberTextBox17.TabStop = false;
            cyberTextBox17.Tag = "Cyber";
            cyberTextBox17.TextButton = "";
            cyberTextBox17.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox17.Timer_RGB = 300;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label28.ForeColor = Color.FromArgb(76, 75, 78);
            label28.Location = new Point(634, 287);
            label28.Name = "label28";
            label28.Size = new Size(196, 27);
            label28.TabIndex = 30;
            label28.Text = "Supplier Address";
            // 
            // addSupplierEmail
            // 
            addSupplierEmail.BackColor = Color.FromArgb(236, 236, 236);
            addSupplierEmail.BorderStyle = BorderStyle.None;
            addSupplierEmail.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addSupplierEmail.ForeColor = Color.FromArgb(76, 75, 78);
            addSupplierEmail.Location = new Point(105, 516);
            addSupplierEmail.Name = "addSupplierEmail";
            addSupplierEmail.Size = new Size(435, 28);
            addSupplierEmail.TabIndex = 29;
            // 
            // cyberTextBox16
            // 
            cyberTextBox16.Alpha = 20;
            cyberTextBox16.BackColor = Color.Transparent;
            cyberTextBox16.Background_WidthPen = 3F;
            cyberTextBox16.BackgroundPen = true;
            cyberTextBox16.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox16.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox16.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox16.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox16.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox16.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox16.Enabled = false;
            cyberTextBox16.Font = new Font("Arial", 13F);
            cyberTextBox16.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox16.Lighting = false;
            cyberTextBox16.LinearGradientPen = false;
            cyberTextBox16.Location = new Point(90, 501);
            cyberTextBox16.Name = "cyberTextBox16";
            cyberTextBox16.PenWidth = 15;
            cyberTextBox16.RGB = false;
            cyberTextBox16.Rounding = true;
            cyberTextBox16.RoundingInt = 60;
            cyberTextBox16.Size = new Size(474, 55);
            cyberTextBox16.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox16.TabIndex = 28;
            cyberTextBox16.TabStop = false;
            cyberTextBox16.Tag = "Cyber";
            cyberTextBox16.TextButton = "";
            cyberTextBox16.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox16.Timer_RGB = 300;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label27.ForeColor = Color.FromArgb(76, 75, 78);
            label27.Location = new Point(90, 457);
            label27.Name = "label27";
            label27.Size = new Size(263, 27);
            label27.TabIndex = 27;
            label27.Text = "Supplier Email Address";
            // 
            // addSupplierNum
            // 
            addSupplierNum.BackColor = Color.FromArgb(236, 236, 236);
            addSupplierNum.BorderStyle = BorderStyle.None;
            addSupplierNum.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addSupplierNum.ForeColor = Color.FromArgb(76, 75, 78);
            addSupplierNum.Location = new Point(105, 346);
            addSupplierNum.Name = "addSupplierNum";
            addSupplierNum.Size = new Size(435, 28);
            addSupplierNum.TabIndex = 26;
            // 
            // cyberTextBox15
            // 
            cyberTextBox15.Alpha = 20;
            cyberTextBox15.BackColor = Color.Transparent;
            cyberTextBox15.Background_WidthPen = 3F;
            cyberTextBox15.BackgroundPen = true;
            cyberTextBox15.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox15.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox15.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox15.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox15.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox15.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox15.Enabled = false;
            cyberTextBox15.Font = new Font("Arial", 13F);
            cyberTextBox15.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox15.Lighting = false;
            cyberTextBox15.LinearGradientPen = false;
            cyberTextBox15.Location = new Point(90, 331);
            cyberTextBox15.Name = "cyberTextBox15";
            cyberTextBox15.PenWidth = 15;
            cyberTextBox15.RGB = false;
            cyberTextBox15.Rounding = true;
            cyberTextBox15.RoundingInt = 60;
            cyberTextBox15.Size = new Size(474, 55);
            cyberTextBox15.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox15.TabIndex = 25;
            cyberTextBox15.TabStop = false;
            cyberTextBox15.Tag = "Cyber";
            cyberTextBox15.TextButton = "";
            cyberTextBox15.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox15.Timer_RGB = 300;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label26.ForeColor = Color.FromArgb(76, 75, 78);
            label26.Location = new Point(90, 287);
            label26.Name = "label26";
            label26.Size = new Size(292, 27);
            label26.TabIndex = 24;
            label26.Text = "Supplier Contact Number ";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.FromArgb(76, 75, 78);
            label23.Location = new Point(649, 119);
            label23.Name = "label23";
            label23.Size = new Size(129, 27);
            label23.TabIndex = 23;
            label23.Text = "Supplier Id";
            // 
            // addSupplierId
            // 
            addSupplierId.BackColor = Color.FromArgb(236, 236, 236);
            addSupplierId.BorderStyle = BorderStyle.None;
            addSupplierId.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addSupplierId.ForeColor = Color.FromArgb(76, 75, 78);
            addSupplierId.Location = new Point(649, 178);
            addSupplierId.Name = "addSupplierId";
            addSupplierId.Size = new Size(284, 28);
            addSupplierId.TabIndex = 22;
            // 
            // cyberTextBox13
            // 
            cyberTextBox13.Alpha = 20;
            cyberTextBox13.BackColor = Color.Transparent;
            cyberTextBox13.Background_WidthPen = 3F;
            cyberTextBox13.BackgroundPen = true;
            cyberTextBox13.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox13.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox13.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox13.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox13.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox13.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox13.Enabled = false;
            cyberTextBox13.Font = new Font("Arial", 13F);
            cyberTextBox13.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox13.Lighting = false;
            cyberTextBox13.LinearGradientPen = false;
            cyberTextBox13.Location = new Point(638, 159);
            cyberTextBox13.Name = "cyberTextBox13";
            cyberTextBox13.PenWidth = 15;
            cyberTextBox13.RGB = false;
            cyberTextBox13.Rounding = true;
            cyberTextBox13.RoundingInt = 60;
            cyberTextBox13.Size = new Size(319, 55);
            cyberTextBox13.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox13.TabIndex = 21;
            cyberTextBox13.TabStop = false;
            cyberTextBox13.Tag = "Cyber";
            cyberTextBox13.TextButton = "";
            cyberTextBox13.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox13.Timer_RGB = 300;
            // 
            // addSupplierName
            // 
            addSupplierName.BackColor = Color.FromArgb(236, 236, 236);
            addSupplierName.BorderStyle = BorderStyle.None;
            addSupplierName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addSupplierName.ForeColor = Color.FromArgb(76, 75, 78);
            addSupplierName.Location = new Point(105, 178);
            addSupplierName.Name = "addSupplierName";
            addSupplierName.Size = new Size(435, 28);
            addSupplierName.TabIndex = 20;
            // 
            // cyberTextBox14
            // 
            cyberTextBox14.Alpha = 20;
            cyberTextBox14.BackColor = Color.Transparent;
            cyberTextBox14.Background_WidthPen = 3F;
            cyberTextBox14.BackgroundPen = true;
            cyberTextBox14.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox14.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox14.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox14.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox14.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox14.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox14.Enabled = false;
            cyberTextBox14.Font = new Font("Arial", 13F);
            cyberTextBox14.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox14.Lighting = false;
            cyberTextBox14.LinearGradientPen = false;
            cyberTextBox14.Location = new Point(90, 163);
            cyberTextBox14.Name = "cyberTextBox14";
            cyberTextBox14.PenWidth = 15;
            cyberTextBox14.RGB = false;
            cyberTextBox14.Rounding = true;
            cyberTextBox14.RoundingInt = 60;
            cyberTextBox14.Size = new Size(474, 55);
            cyberTextBox14.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox14.TabIndex = 19;
            cyberTextBox14.TabStop = false;
            cyberTextBox14.Tag = "Cyber";
            cyberTextBox14.TextButton = "";
            cyberTextBox14.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox14.Timer_RGB = 300;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.ForeColor = Color.FromArgb(76, 75, 78);
            label24.Location = new Point(90, 119);
            label24.Name = "label24";
            label24.Size = new Size(172, 27);
            label24.TabIndex = 18;
            label24.Text = "Supplier Name";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = Color.FromArgb(236, 236, 236);
            label25.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(90, 36);
            label25.Name = "label25";
            label25.Size = new Size(189, 33);
            label25.TabIndex = 16;
            label25.Text = "Add Supplier";
            // 
            // textBox8
            // 
            textBox8.BackColor = Color.FromArgb(222, 224, 235);
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Arial Narrow", 8F, FontStyle.Bold);
            textBox8.Location = new Point(90, 62);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.Size = new Size(323, 19);
            textBox8.TabIndex = 17;
            textBox8.TabStop = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // userLbl
            // 
            userLbl.AutoSize = true;
            userLbl.Font = new Font("Arial", 10F);
            userLbl.Location = new Point(1335, 49);
            userLbl.Margin = new Padding(4, 0, 4, 0);
            userLbl.Name = "userLbl";
            userLbl.Size = new Size(64, 23);
            userLbl.TabIndex = 3;
            userLbl.Text = "Admin";
            // 
            // headerLbl
            // 
            headerLbl.AutoSize = true;
            headerLbl.Font = new Font("Arial", 16F, FontStyle.Bold);
            headerLbl.Location = new Point(478, 49);
            headerLbl.Margin = new Padding(4, 0, 4, 0);
            headerLbl.Name = "headerLbl";
            headerLbl.Size = new Size(159, 37);
            headerLbl.TabIndex = 4;
            headerLbl.Text = "Overview";
            // 
            // categoryMore
            // 
            categoryMore.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoryMore.ImageScalingSize = new Size(24, 24);
            categoryMore.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            categoryMore.Name = "categoryMore";
            categoryMore.Size = new Size(165, 32);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(164, 28);
            toolStripMenuItem1.Text = "View More";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // supplierMoreStrip
            // 
            supplierMoreStrip.ImageScalingSize = new Size(24, 24);
            supplierMoreStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            supplierMoreStrip.Name = "supplierMoreStrip";
            supplierMoreStrip.Size = new Size(200, 36);
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(199, 32);
            toolStripMenuItem2.Text = "View Suppliers";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // returnBtn
            // 
            returnBtn.FlatAppearance.BorderSize = 0;
            returnBtn.FlatStyle = FlatStyle.Flat;
            returnBtn.Image = Resources.icons8_back_64;
            returnBtn.Location = new Point(395, 30);
            returnBtn.Name = "returnBtn";
            returnBtn.Size = new Size(63, 58);
            returnBtn.TabIndex = 5;
            returnBtn.UseVisualStyleBackColor = true;
            returnBtn.Click += returnBtn_Click;
            // 
            // outOfStockStrip
            // 
            outOfStockStrip.ImageScalingSize = new Size(24, 24);
            outOfStockStrip.Items.AddRange(new ToolStripItem[] { addStocks });
            outOfStockStrip.Name = "outOfStockStrip";
            outOfStockStrip.Size = new Size(228, 36);
            // 
            // addStocks
            // 
            addStocks.Name = "addStocks";
            addStocks.Size = new Size(227, 32);
            addStocks.Text = "Please Add stocks";
            addStocks.Click += addStocks_Click;
            // 
            // profileBtn
            // 
            profileBtn.FlatAppearance.BorderSize = 0;
            profileBtn.FlatStyle = FlatStyle.Flat;
            profileBtn.Image = Resources.profileIcon;
            profileBtn.Location = new Point(1408, 37);
            profileBtn.Name = "profileBtn";
            profileBtn.Size = new Size(53, 51);
            profileBtn.TabIndex = 6;
            profileBtn.UseVisualStyleBackColor = true;
            profileBtn.Click += profileBtn_Click;
            // 
            // accountStrip
            // 
            accountStrip.ImageScalingSize = new Size(24, 24);
            accountStrip.Items.AddRange(new ToolStripItem[] { regAccount });
            accountStrip.Name = "accountStrip";
            accountStrip.Size = new Size(248, 36);
            // 
            // regAccount
            // 
            regAccount.Name = "regAccount";
            regAccount.Size = new Size(247, 32);
            regAccount.Text = "register new account";
            regAccount.Click += regAccount_Click;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(14F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1559, 907);
            Controls.Add(profileBtn);
            Controls.Add(returnBtn);
            Controls.Add(headerLbl);
            Controls.Add(userLbl);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "mainForm";
            Text = "main menu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            Dashboard.ResumeLayout(false);
            Dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)arrivingProductTable).EndInit();
            ((System.ComponentModel.ISupportInitialize)productOverviewMenuBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)stocksOverviewMenuBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)arrivingSoonMenu).EndInit();
            viewProducts.ResumeLayout(false);
            viewProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productTable).EndInit();
            productMorePage.ResumeLayout(false);
            productMorePage.PerformLayout();
            addProduct.ResumeLayout(false);
            addProduct.PerformLayout();
            Orders.ResumeLayout(false);
            Orders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)ordersTable).EndInit();
            OrderInformation.ResumeLayout(false);
            OrderInformation.PerformLayout();
            orderProduct.ResumeLayout(false);
            orderProduct.PerformLayout();
            viewStocks.ResumeLayout(false);
            viewStocks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)stocksTable).EndInit();
            invoicePanel.ResumeLayout(false);
            invoicePanel.PerformLayout();
            supplierPanel.ResumeLayout(false);
            supplierPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)supplierTable).EndInit();
            supplierMorePanel.ResumeLayout(false);
            supplierMorePanel.PerformLayout();
            addSupplier.ResumeLayout(false);
            addSupplier.PerformLayout();
            categoryMore.ResumeLayout(false);
            supplierMoreStrip.ResumeLayout(false);
            outOfStockStrip.ResumeLayout(false);
            accountStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TabControl tabControl1;
        private TabPage viewProducts;
        private Button dashBoardNavBtn;
        private Button viewProdBtn;
        private TabPage Dashboard;
        private TabPage productMorePage;
        private DataGridView productTable;
        private Label label8;
        private Button button4;
        private Button supplierNavbtn;
        private Button viewStocksBtn;
        private Button OrderTabNavBtn;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox searchProductField;
        private Label label1;
        private Label label9;
        private Label label10;
        private Label userLbl;
        private Label headerLbl;
        private Label ProductMorePageHdr;
        private TextBox textBox2;
        private Label label12;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox1;
        public ReaLTaiizor.Controls.CyberTextBox lbltextt;
        private Label label13;
        private ReaLTaiizor.Controls.DungeonComboBox cmbCategory;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox3;
        private Label label14;
        private ReaLTaiizor.Controls.CyberButton editProductSaveBtn;
        private ReaLTaiizor.Controls.DungeonComboBox cmbSuppliers;
        private Label label16;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox4;
        private Label label15;
        private TextBox moreProductPriceField;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox2;
        private TextBox moreProductNameField;
        private ReaLTaiizor.Controls.CyberButton prodQtyMinus;
        private ReaLTaiizor.Controls.CyberButton prodQtyAdd;
        private TextBox MoreProductQty;
        private Label ProdDateModified;
        private Label label18;
        private Button categoryMoreBtn;
        private ContextMenuStrip categoryMore;
        private Button supplierMoreBtn;
        private ToolStripMenuItem toolStripMenuItem1;
        private ContextMenuStrip supplierMoreStrip;
        private ToolStripMenuItem toolStripMenuItem2;
        private TabPage orderProduct;
        private Label label19;
        private ReaLTaiizor.Controls.CyberButton orderProductBtn;
        private TextBox orderProductQtyField;
        private Label label5;
        private ReaLTaiizor.Controls.DungeonComboBox orderProductsuppCmb;
        private Label label6;
        private Label label7;
        private Label label2;
        private TextBox orderProductPriceField;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox5;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox8;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox6;
        public ReaLTaiizor.Controls.CyberTextBox cyberTextBox9;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox7;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox10;
        private Label label3;
        private Label label4;
        private TextBox textBox7;
        private TabPage supplierPanel;
        private DataGridView supplierTable;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox12;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox11;
        private TextBox searchSupplierField;
        private Label label22;
        private Label label21;
        private Label label20;
        private ReaLTaiizor.Controls.CyberButton addSupplierNavBtn;
        private TabPage addSupplier;
        private Label label23;
        private TextBox addSupplierId;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox13;
        private TextBox addSupplierName;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox14;
        private Label label24;
        private Label label25;
        private TextBox textBox8;
        private TabPage supplierMorePanel;
        private TextBox addSupplierAddress;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox17;
        private Label label28;
        private TextBox addSupplierEmail;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox16;
        private Label label27;
        private TextBox addSupplierNum;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox15;
        private Label label26;
        private ReaLTaiizor.Controls.CyberButton addSupplierBtn;
        private ReaLTaiizor.Controls.CyberTextBox info_supplierAdd;
        private Label label29;
        private ReaLTaiizor.Controls.CyberTextBox info_supplierEmail;
        private Label label30;
        private ReaLTaiizor.Controls.CyberTextBox info_supplierNum;
        private Label label31;
        private Label label32;
        private ReaLTaiizor.Controls.CyberTextBox info_supplierId;
        private ReaLTaiizor.Controls.CyberTextBox info_supplierName;
        private Label label33;
        private Label supllierMoreHdr;
        private TextBox textBox6;
        private Label moreSupProductLbl;
        private ReaLTaiizor.Controls.DungeonComboBox info_supplierProductsCmb;
        private ReaLTaiizor.Controls.CyberTextBox moreSupProdBg;
        private Button returnBtn;
        private TabPage addProduct;
        private Label label36;
        private TextBox addProductIdField;
        private ReaLTaiizor.Controls.DungeonComboBox addProductSupplierCmb;
        private ReaLTaiizor.Controls.DungeonComboBox addProductCategoryCmb;
        private Label label38;
        private Label label39;
        private Label label40;
        private TextBox addProductPrice;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox19;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox20;
        private TextBox addProductNameField;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox21;
        public ReaLTaiizor.Controls.CyberTextBox cyberTextBox22;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox23;
        private Label label41;
        private ReaLTaiizor.Controls.CyberButton addProductBtn;
        private Button addProdSupViewMore;
        private Button addProdCatViewMore;
        private Label label37;
        private TextBox textBox12;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox24;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox25;
        private TextBox orderProductIDField;
        private ReaLTaiizor.Controls.DungeonComboBox orderProductNamecmb;
        private ReaLTaiizor.Controls.CyberButton addProductNavBtn;
        private Label noProductPrompt;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.CyberButton editProductBtn;
        private ReaLTaiizor.Controls.CyberButton returnToProductView;
        private TextBox moreSupAddressField;
        private TextBox moreSupEmailField;
        private TextBox moreSupNumField;
        private TextBox moreSupNameField;
        private ReaLTaiizor.Controls.CyberButton editSupplierBtn;
        private TextBox moreSupIdField;
        private ReaLTaiizor.Controls.CyberButton stopEditingSupBtn;
        private ReaLTaiizor.Controls.CyberButton saveSupChangesBtn;
        private PictureBox pictureBox2;
        private Label supplierHdrPrompt;
        private TabPage Orders;
        private Label noOrdersPrompt;
        private PictureBox pictureBox4;
        private ReaLTaiizor.Controls.CyberButton orderProdNavBtn;
        private TextBox orderPanelSearchField;
        private Label label17;
        private Label label34;
        private Label label35;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox18;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox26;
        private DataGridView ordersTable;
        private Label label42;
        private ReaLTaiizor.Controls.DungeonComboBox productPageCatCmb;
        public ReaLTaiizor.Controls.CyberTextBox cyberTextBox27;
        private TextBox textBox3;
        private TextBox orderProductCatField;
        private Label estimatedArrivalLbl;
        private Label label44;
        private Label orderTotalLbl;
        private Label label43;
        private TabPage OrderInformation;
        private Label label50;
        private Label label49;
        private Label label48;
        private Label label47;
        private TextBox viewProdQtyOrderLbl;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox31;
        private TextBox viewOrderIdLbl;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox30;
        private TextBox viewProductSupOrderLbl;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox29;
        private Label label46;
        private TextBox textBox5;
        private Label ViewdateOrderedLbl;
        private Label label45;
        private TextBox viewProductNameOrderLbl;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox28;
        private Label ViewEstArrivalLbl;
        private Label label51;
        private Label viewOrderStatusLbl;
        private Label label52;
        private ReaLTaiizor.Controls.CyberButton recieveOrderBtn;
        private TabPage viewStocks;
        private PictureBox pictureBox5;
        private Label stocksTablePrompt;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox32;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox33;
        private DataGridView stocksTable;
        private TextBox stocksSearchField;
        private Label label56;
        private Label label55;
        private Label label54;
        private Label label53;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
        private TabPage invoicePanel;
        private ReaLTaiizor.Controls.CyberButton CreateInvoiceBtn;
        private Label InvoiceDateMod;
        private Label label57;
        private TextBox invoiceProdQty;
        private Label label58;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox34;
        private Label label59;
        private TextBox invoiceProdPrice;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox35;
        private TextBox invoiceProdName;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox36;
        private Label label60;
        public ReaLTaiizor.Controls.CyberTextBox cyberTextBox37;
        private Label label61;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox38;
        private Label label62;
        private Label label63;
        private TextBox textBox10;
        private Label InvoiceTotalSalesQty;
        private Label label66;
        private TextBox InvoiceSalesQty;
        private Label label64;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox39;
        private ReaLTaiizor.Controls.CyberButton invoiceOrderProdBtn;
        private TextBox InvoiceSup;
        private TextBox InvoiceProdCat;
        private TextBox invoiceProdQuantity;
        private ContextMenuStrip outOfStockStrip;
        private ToolStripMenuItem addStocks;
        private TextBox textBox1;
        private ReaLTaiizor.Controls.DungeonComboBox selectedStatus;
        public ReaLTaiizor.Controls.CyberTextBox cyberTextBox40;
        private ReaLTaiizor.Controls.CyberButton delOrderBtn;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox43;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox42;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox41;
        private PictureBox stocksOverviewMenuBtn;
        private PictureBox arrivingSoonMenu;
        private Label label68;
        private Label label67;
        private Label label65;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox47;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox46;
        private Label label11;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox45;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox44;
        private PictureBox productOverviewMenuBtn;
        private Label lowStockLblOverView;
        private Label label72;
        private Label label71;
        private Label arrivingSoonPrompt;
        private DataGridView arrivingProductTable;
        private Label label70;
        private Label label69;
        private Label NoOfProdLblOverView;
        private Label OutOfStockLbl;
        private Label totalStocksLbl;
        private Label label74;
        private Label label73;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private Button profileBtn;
        private ContextMenuStrip accountStrip;
        private ToolStripMenuItem regAccount;
    }
}