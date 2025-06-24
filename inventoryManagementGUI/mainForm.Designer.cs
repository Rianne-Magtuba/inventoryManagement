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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button4 = new Button();
            supplierNavbtn = new Button();
            button2 = new Button();
            button1 = new Button();
            label8 = new Label();
            viewProdBtn = new Button();
            tab2 = new Button();
            addProdBtn = new Button();
            tabControl1 = new TabControl();
            Dashboard = new TabPage();
            viewProducts = new TabPage();
            noProductPrompt = new Label();
            addProductNavBtn = new ReaLTaiizor.Controls.CyberButton();
            textBox1 = new TextBox();
            cyberTextBox24 = new ReaLTaiizor.Controls.CyberTextBox();
            label10 = new Label();
            label9 = new Label();
            label1 = new Label();
            cyberTextBox25 = new ReaLTaiizor.Controls.CyberTextBox();
            productTable = new DataGridView();
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
            editProducts = new TabPage();
            supplierMoreBtn = new Button();
            categoryMoreBtn = new Button();
            cyberButton1 = new ReaLTaiizor.Controls.CyberButton();
            ProdDateModified = new Label();
            prodDateAdded = new Label();
            label18 = new Label();
            label17 = new Label();
            prodQtyMinus = new ReaLTaiizor.Controls.CyberButton();
            prodQtyAdd = new ReaLTaiizor.Controls.CyberButton();
            textBox4 = new TextBox();
            label16 = new Label();
            cyberTextBox4 = new ReaLTaiizor.Controls.CyberTextBox();
            label15 = new Label();
            textBox3 = new TextBox();
            cyberTextBox2 = new ReaLTaiizor.Controls.CyberTextBox();
            productNameEdit = new TextBox();
            cmbSuppliers = new ReaLTaiizor.Controls.DungeonComboBox();
            cmbCategory = new ReaLTaiizor.Controls.DungeonComboBox();
            cyberTextBox3 = new ReaLTaiizor.Controls.CyberTextBox();
            label14 = new Label();
            lbltextt = new ReaLTaiizor.Controls.CyberTextBox();
            label13 = new Label();
            cyberTextBox1 = new ReaLTaiizor.Controls.CyberTextBox();
            label12 = new Label();
            label11 = new Label();
            textBox2 = new TextBox();
            orderProduct = new TabPage();
            orderProductIDField = new TextBox();
            orderProductNamecmb = new ReaLTaiizor.Controls.DungeonComboBox();
            label19 = new Label();
            orderProductBtn = new ReaLTaiizor.Controls.CyberButton();
            orderProductQtyBtn = new TextBox();
            label5 = new Label();
            orderProductsuppBtn = new ReaLTaiizor.Controls.DungeonComboBox();
            orderProductCatBtn = new ReaLTaiizor.Controls.DungeonComboBox();
            label6 = new Label();
            label7 = new Label();
            label2 = new Label();
            orderProductPriceBtn = new TextBox();
            cyberTextBox5 = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox8 = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox6 = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox9 = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox7 = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox10 = new ReaLTaiizor.Controls.CyberTextBox();
            label3 = new Label();
            label4 = new Label();
            textBox7 = new TextBox();
            supplierPanel = new TabPage();
            cyberButton2 = new ReaLTaiizor.Controls.CyberButton();
            searchSupplier = new TextBox();
            label22 = new Label();
            label21 = new Label();
            label20 = new Label();
            cyberTextBox12 = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox11 = new ReaLTaiizor.Controls.CyberTextBox();
            supplierTable = new DataGridView();
            editSupplier = new TabPage();
            saveEditSupplierBtn = new ReaLTaiizor.Controls.CyberButton();
            editSupplierAddress = new TextBox();
            cyberTextBox17 = new ReaLTaiizor.Controls.CyberTextBox();
            label28 = new Label();
            editSupplierEmail = new TextBox();
            cyberTextBox16 = new ReaLTaiizor.Controls.CyberTextBox();
            label27 = new Label();
            editSupplierNum = new TextBox();
            cyberTextBox15 = new ReaLTaiizor.Controls.CyberTextBox();
            label26 = new Label();
            label23 = new Label();
            editSupplierId = new TextBox();
            cyberTextBox13 = new ReaLTaiizor.Controls.CyberTextBox();
            editSupplierName = new TextBox();
            cyberTextBox14 = new ReaLTaiizor.Controls.CyberTextBox();
            label24 = new Label();
            label25 = new Label();
            textBox8 = new TextBox();
            supplierInfo = new TabPage();
            label35 = new Label();
            info_supplierProductsCmb = new ReaLTaiizor.Controls.DungeonComboBox();
            info_supplierAdd = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox18 = new ReaLTaiizor.Controls.CyberTextBox();
            label29 = new Label();
            info_supplierEmail = new ReaLTaiizor.Controls.CyberTextBox();
            label30 = new Label();
            info_supplierNum = new ReaLTaiizor.Controls.CyberTextBox();
            label31 = new Label();
            label32 = new Label();
            info_supplierId = new ReaLTaiizor.Controls.CyberTextBox();
            info_supplierName = new ReaLTaiizor.Controls.CyberTextBox();
            label33 = new Label();
            label34 = new Label();
            textBox6 = new TextBox();
            tabPage2 = new TabPage();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            pictureBox3 = new PictureBox();
            userLbl = new Label();
            headerLbl = new Label();
            categoryMore = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            supplierMoreStrip = new ContextMenuStrip(components);
            toolStripMenuItem2 = new ToolStripMenuItem();
            button3 = new Button();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            viewProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productTable).BeginInit();
            addProduct.SuspendLayout();
            editProducts.SuspendLayout();
            orderProduct.SuspendLayout();
            supplierPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)supplierTable).BeginInit();
            editSupplier.SuspendLayout();
            supplierInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            categoryMore.SuspendLayout();
            supplierMoreStrip.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 30);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(supplierNavbtn);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(viewProdBtn);
            panel1.Controls.Add(tab2);
            panel1.Controls.Add(addProdBtn);
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
            button4.Location = new Point(0, 794);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(368, 86);
            button4.TabIndex = 9;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            // 
            // supplierNavbtn
            // 
            supplierNavbtn.FlatAppearance.BorderSize = 0;
            supplierNavbtn.FlatStyle = FlatStyle.Flat;
            supplierNavbtn.Font = new Font("Arial", 10F);
            supplierNavbtn.ForeColor = Color.White;
            supplierNavbtn.Image = Resources.supplierIcon;
            supplierNavbtn.ImageAlign = ContentAlignment.MiddleLeft;
            supplierNavbtn.Location = new Point(0, 653);
            supplierNavbtn.Margin = new Padding(4);
            supplierNavbtn.Name = "supplierNavbtn";
            supplierNavbtn.Padding = new Padding(42, 0, 0, 0);
            supplierNavbtn.Size = new Size(368, 86);
            supplierNavbtn.TabIndex = 8;
            supplierNavbtn.Text = "Suppliers";
            supplierNavbtn.UseVisualStyleBackColor = true;
            supplierNavbtn.Click += supplierNavbtn_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 10F);
            button2.ForeColor = Color.White;
            button2.Image = Resources.stocksIcon;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 560);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Padding = new Padding(42, 0, 0, 0);
            button2.Size = new Size(368, 86);
            button2.TabIndex = 7;
            button2.Text = "View Stocks";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 10F);
            button1.ForeColor = Color.White;
            button1.Image = Resources.orderProducts_icon;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 466);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Padding = new Padding(42, 0, 0, 0);
            button1.Size = new Size(368, 86);
            button1.TabIndex = 6;
            button1.Text = "View Orders";
            button1.UseVisualStyleBackColor = true;
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
            // tab2
            // 
            tab2.FlatAppearance.BorderSize = 0;
            tab2.FlatStyle = FlatStyle.Flat;
            tab2.Font = new Font("Arial", 10F);
            tab2.ForeColor = Color.White;
            tab2.Image = Resources.dashboard_icon;
            tab2.ImageAlign = ContentAlignment.MiddleLeft;
            tab2.Location = new Point(0, 176);
            tab2.Margin = new Padding(4);
            tab2.Name = "tab2";
            tab2.Padding = new Padding(42, 0, 14, 0);
            tab2.Size = new Size(368, 86);
            tab2.TabIndex = 1;
            tab2.Text = "Dashboard";
            tab2.UseVisualStyleBackColor = true;
            tab2.Click += tab2_Click;
            // 
            // addProdBtn
            // 
            addProdBtn.FlatAppearance.BorderSize = 0;
            addProdBtn.FlatStyle = FlatStyle.Flat;
            addProdBtn.Font = new Font("Segoe UI", 10F);
            addProdBtn.ForeColor = Color.White;
            addProdBtn.Image = Resources.orderProducts_icon;
            addProdBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addProdBtn.Location = new Point(4, 372);
            addProdBtn.Margin = new Padding(4);
            addProdBtn.Name = "addProdBtn";
            addProdBtn.Padding = new Padding(42, 0, 0, 0);
            addProdBtn.Size = new Size(364, 86);
            addProdBtn.TabIndex = 0;
            addProdBtn.Text = "   Order Products";
            addProdBtn.UseVisualStyleBackColor = true;
            addProdBtn.Click += button2_Click;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(Dashboard);
            tabControl1.Controls.Add(viewProducts);
            tabControl1.Controls.Add(addProduct);
            tabControl1.Controls.Add(editProducts);
            tabControl1.Controls.Add(orderProduct);
            tabControl1.Controls.Add(supplierPanel);
            tabControl1.Controls.Add(editSupplier);
            tabControl1.Controls.Add(supplierInfo);
            tabControl1.Controls.Add(tabPage2);
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
            Dashboard.Location = new Point(4, 5);
            Dashboard.Margin = new Padding(4);
            Dashboard.Name = "Dashboard";
            Dashboard.Size = new Size(1140, 795);
            Dashboard.TabIndex = 2;
            Dashboard.Text = "tabPage3";
            Dashboard.UseVisualStyleBackColor = true;
            // 
            // viewProducts
            // 
            viewProducts.BackColor = Color.FromArgb(236, 236, 236);
            viewProducts.Controls.Add(noProductPrompt);
            viewProducts.Controls.Add(addProductNavBtn);
            viewProducts.Controls.Add(textBox1);
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
            viewProducts.Text = "tabPage2";
            viewProducts.Click += viewProducts_Click;
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
            addProductNavBtn.ColorBackground_Pen = SystemColors.ActiveBorder;
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
            addProductNavBtn.Location = new Point(911, 7);
            addProductNavBtn.Name = "addProductNavBtn";
            addProductNavBtn.PenWidth = 15;
            addProductNavBtn.Rounding = true;
            addProductNavBtn.RoundingInt = 70;
            addProductNavBtn.Size = new Size(192, 55);
            addProductNavBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            addProductNavBtn.TabIndex = 59;
            addProductNavBtn.Tag = "Cyber";
            addProductNavBtn.TextButton = "+ Add Product";
            addProductNavBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            addProductNavBtn.Timer_Effect_1 = 5;
            addProductNavBtn.Timer_RGB = 300;
            addProductNavBtn.Click += addProductNavBtn_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(236, 236, 236);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(174, 174, 172);
            textBox1.Location = new Point(143, 24);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(696, 23);
            textBox1.TabIndex = 6;
            textBox1.Text = "Search";
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
            cyberTextBox24.Size = new Size(776, 55);
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
            label10.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(174, 174, 172);
            label10.Location = new Point(748, 115);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(165, 23);
            label10.TabIndex = 10;
            label10.Text = "Product Category";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(230, 230, 226);
            label9.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(174, 174, 172);
            label9.Location = new Point(484, 115);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(135, 23);
            label9.TabIndex = 9;
            label9.Text = "Product Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(230, 230, 226);
            label1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(174, 174, 172);
            label1.Location = new Point(184, 115);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(104, 23);
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
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.LightGray;
            dataGridViewCellStyle7.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            productTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            productTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            productTable.DefaultCellStyle = dataGridViewCellStyle8;
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
            productTable.Size = new Size(961, 591);
            productTable.TabIndex = 0;
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
            addProductBtn.ColorBackground_Pen = SystemColors.ActiveBorder;
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
            addProductBtn.Location = new Point(517, 645);
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
            label40.Location = new Point(656, 310);
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
            addProductPrice.Location = new Point(656, 369);
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
            cyberTextBox19.Location = new Point(641, 354);
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
            cyberTextBox20.Location = new Point(79, 507);
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
            // editProducts
            // 
            editProducts.BackColor = Color.FromArgb(236, 236, 236);
            editProducts.Controls.Add(supplierMoreBtn);
            editProducts.Controls.Add(categoryMoreBtn);
            editProducts.Controls.Add(cyberButton1);
            editProducts.Controls.Add(ProdDateModified);
            editProducts.Controls.Add(prodDateAdded);
            editProducts.Controls.Add(label18);
            editProducts.Controls.Add(label17);
            editProducts.Controls.Add(prodQtyMinus);
            editProducts.Controls.Add(prodQtyAdd);
            editProducts.Controls.Add(textBox4);
            editProducts.Controls.Add(label16);
            editProducts.Controls.Add(cyberTextBox4);
            editProducts.Controls.Add(label15);
            editProducts.Controls.Add(textBox3);
            editProducts.Controls.Add(cyberTextBox2);
            editProducts.Controls.Add(productNameEdit);
            editProducts.Controls.Add(cmbSuppliers);
            editProducts.Controls.Add(cmbCategory);
            editProducts.Controls.Add(cyberTextBox3);
            editProducts.Controls.Add(label14);
            editProducts.Controls.Add(lbltextt);
            editProducts.Controls.Add(label13);
            editProducts.Controls.Add(cyberTextBox1);
            editProducts.Controls.Add(label12);
            editProducts.Controls.Add(label11);
            editProducts.Controls.Add(textBox2);
            editProducts.Font = new Font("Arial Narrow", 12F, FontStyle.Bold);
            editProducts.Location = new Point(4, 5);
            editProducts.Margin = new Padding(4);
            editProducts.Name = "editProducts";
            editProducts.Size = new Size(1140, 795);
            editProducts.TabIndex = 3;
            editProducts.Text = "tabPage4";
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
            cyberButton1.ColorBackground_Pen = SystemColors.ActiveBorder;
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
            cyberButton1.Location = new Point(548, 656);
            cyberButton1.Name = "cyberButton1";
            cyberButton1.PenWidth = 15;
            cyberButton1.Rounding = true;
            cyberButton1.RoundingInt = 70;
            cyberButton1.Size = new Size(265, 72);
            cyberButton1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton1.TabIndex = 26;
            cyberButton1.Tag = "Cyber";
            cyberButton1.TextButton = "Save Changes";
            cyberButton1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            cyberButton1.Timer_Effect_1 = 5;
            cyberButton1.Timer_RGB = 300;
            // 
            // ProdDateModified
            // 
            ProdDateModified.AutoSize = true;
            ProdDateModified.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProdDateModified.ForeColor = Color.FromArgb(76, 75, 78);
            ProdDateModified.Location = new Point(844, 509);
            ProdDateModified.Name = "ProdDateModified";
            ProdDateModified.Size = new Size(160, 27);
            ProdDateModified.TabIndex = 25;
            ProdDateModified.Text = "xxxx-xxxx-xxxx";
            // 
            // prodDateAdded
            // 
            prodDateAdded.AutoSize = true;
            prodDateAdded.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            prodDateAdded.ForeColor = Color.FromArgb(76, 75, 78);
            prodDateAdded.Location = new Point(548, 510);
            prodDateAdded.Name = "prodDateAdded";
            prodDateAdded.Size = new Size(160, 27);
            prodDateAdded.TabIndex = 24;
            prodDateAdded.Text = "xxxx-xxxx-xxxx";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(76, 75, 78);
            label18.Location = new Point(844, 451);
            label18.Name = "label18";
            label18.Size = new Size(159, 27);
            label18.TabIndex = 23;
            label18.Text = "Date Modified";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(76, 75, 78);
            label17.Location = new Point(548, 451);
            label17.Name = "label17";
            label17.Size = new Size(138, 27);
            label17.TabIndex = 22;
            label17.Text = "Date Added";
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
            prodQtyMinus.ColorBackground_Pen = SystemColors.ActiveBorder;
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
            prodQtyMinus.Location = new Point(1003, 326);
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
            prodQtyAdd.ColorBackground_Pen = SystemColors.ActiveBorder;
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
            prodQtyAdd.Location = new Point(865, 326);
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
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(236, 236, 236);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.ForeColor = Color.FromArgb(76, 75, 78);
            textBox4.Location = new Point(619, 346);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(210, 28);
            textBox4.TabIndex = 18;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(76, 75, 78);
            label16.Location = new Point(619, 289);
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
            cyberTextBox4.Location = new Point(604, 333);
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
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(236, 236, 236);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.ForeColor = Color.FromArgb(76, 75, 78);
            textBox3.Location = new Point(619, 174);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(225, 28);
            textBox3.TabIndex = 14;
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
            // productNameEdit
            // 
            productNameEdit.BackColor = Color.FromArgb(236, 236, 236);
            productNameEdit.BorderStyle = BorderStyle.None;
            productNameEdit.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            productNameEdit.ForeColor = Color.FromArgb(76, 75, 78);
            productNameEdit.Location = new Point(100, 174);
            productNameEdit.Name = "productNameEdit";
            productNameEdit.Size = new Size(435, 28);
            productNameEdit.TabIndex = 12;
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
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(236, 236, 236);
            label11.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(85, 32);
            label11.Name = "label11";
            label11.Size = new Size(344, 33);
            label11.TabIndex = 0;
            label11.Text = "Edit Product Information";
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
            // orderProduct
            // 
            orderProduct.Controls.Add(orderProductIDField);
            orderProduct.Controls.Add(orderProductNamecmb);
            orderProduct.Controls.Add(label19);
            orderProduct.Controls.Add(orderProductBtn);
            orderProduct.Controls.Add(orderProductQtyBtn);
            orderProduct.Controls.Add(label5);
            orderProduct.Controls.Add(orderProductsuppBtn);
            orderProduct.Controls.Add(orderProductCatBtn);
            orderProduct.Controls.Add(label6);
            orderProduct.Controls.Add(label7);
            orderProduct.Controls.Add(label2);
            orderProduct.Controls.Add(orderProductPriceBtn);
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
            orderProduct.Text = "tabPage1";
            orderProduct.UseVisualStyleBackColor = true;
            // 
            // orderProductIDField
            // 
            orderProductIDField.BackColor = Color.FromArgb(236, 236, 236);
            orderProductIDField.BorderStyle = BorderStyle.None;
            orderProductIDField.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderProductIDField.ForeColor = Color.FromArgb(76, 75, 78);
            orderProductIDField.Location = new Point(66, 362);
            orderProductIDField.Name = "orderProductIDField";
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
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.FromArgb(76, 75, 78);
            label19.Location = new Point(124, 284);
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
            orderProductBtn.ColorBackground_Pen = SystemColors.ActiveBorder;
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
            orderProductBtn.Location = new Point(563, 657);
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
            // 
            // orderProductQtyBtn
            // 
            orderProductQtyBtn.BackColor = Color.FromArgb(236, 236, 236);
            orderProductQtyBtn.BorderStyle = BorderStyle.None;
            orderProductQtyBtn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderProductQtyBtn.ForeColor = Color.FromArgb(76, 75, 78);
            orderProductQtyBtn.Location = new Point(632, 527);
            orderProductQtyBtn.Name = "orderProductQtyBtn";
            orderProductQtyBtn.Size = new Size(210, 28);
            orderProductQtyBtn.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(76, 75, 78);
            label5.Location = new Point(632, 460);
            label5.Name = "label5";
            label5.Size = new Size(194, 27);
            label5.TabIndex = 31;
            label5.Text = "Product Quantity";
            // 
            // orderProductsuppBtn
            // 
            orderProductsuppBtn.BackColor = Color.FromArgb(236, 236, 236);
            orderProductsuppBtn.ColorA = Color.FromArgb(64, 64, 64);
            orderProductsuppBtn.ColorB = Color.FromArgb(64, 64, 64);
            orderProductsuppBtn.ColorC = Color.FromArgb(239, 237, 236);
            orderProductsuppBtn.ColorD = Color.FromArgb(239, 237, 236);
            orderProductsuppBtn.ColorE = Color.FromArgb(239, 237, 236);
            orderProductsuppBtn.ColorF = Color.FromArgb(236, 236, 236);
            orderProductsuppBtn.ColorG = Color.Black;
            orderProductsuppBtn.ColorH = Color.FromArgb(236, 236, 236);
            orderProductsuppBtn.ColorI = Color.FromArgb(236, 236, 236);
            orderProductsuppBtn.DrawMode = DrawMode.OwnerDrawFixed;
            orderProductsuppBtn.DropDownHeight = 100;
            orderProductsuppBtn.DropDownStyle = ComboBoxStyle.DropDownList;
            orderProductsuppBtn.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderProductsuppBtn.ForeColor = Color.FromArgb(76, 75, 78);
            orderProductsuppBtn.FormattingEnabled = true;
            orderProductsuppBtn.HoverSelectionColor = Color.Empty;
            orderProductsuppBtn.IntegralHeight = false;
            orderProductsuppBtn.ItemHeight = 20;
            orderProductsuppBtn.Location = new Point(66, 203);
            orderProductsuppBtn.Name = "orderProductsuppBtn";
            orderProductsuppBtn.Size = new Size(335, 26);
            orderProductsuppBtn.StartIndex = 0;
            orderProductsuppBtn.TabIndex = 30;
            // 
            // orderProductCatBtn
            // 
            orderProductCatBtn.BackColor = Color.FromArgb(236, 236, 236);
            orderProductCatBtn.ColorA = Color.FromArgb(64, 64, 64);
            orderProductCatBtn.ColorB = Color.FromArgb(64, 64, 64);
            orderProductCatBtn.ColorC = Color.FromArgb(239, 237, 236);
            orderProductCatBtn.ColorD = Color.FromArgb(239, 237, 236);
            orderProductCatBtn.ColorE = Color.FromArgb(239, 237, 236);
            orderProductCatBtn.ColorF = Color.FromArgb(236, 236, 236);
            orderProductCatBtn.ColorG = Color.Black;
            orderProductCatBtn.ColorH = Color.FromArgb(236, 236, 236);
            orderProductCatBtn.ColorI = Color.FromArgb(236, 236, 236);
            orderProductCatBtn.DrawMode = DrawMode.OwnerDrawFixed;
            orderProductCatBtn.DropDownHeight = 100;
            orderProductCatBtn.DropDownStyle = ComboBoxStyle.DropDownList;
            orderProductCatBtn.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderProductCatBtn.ForeColor = Color.FromArgb(76, 75, 78);
            orderProductCatBtn.FormattingEnabled = true;
            orderProductCatBtn.HoverSelectionColor = Color.Empty;
            orderProductCatBtn.IntegralHeight = false;
            orderProductCatBtn.ItemHeight = 20;
            orderProductCatBtn.Location = new Point(81, 533);
            orderProductCatBtn.Name = "orderProductCatBtn";
            orderProductCatBtn.Size = new Size(220, 26);
            orderProductCatBtn.StartIndex = 0;
            orderProductCatBtn.TabIndex = 29;
            orderProductCatBtn.SelectedIndexChanged += orderProductCatBtn_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(76, 75, 78);
            label6.Location = new Point(66, 139);
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
            label7.Location = new Point(66, 464);
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
            label2.Location = new Point(632, 303);
            label2.Name = "label2";
            label2.Size = new Size(157, 27);
            label2.TabIndex = 23;
            label2.Text = "Product Price";
            // 
            // orderProductPriceBtn
            // 
            orderProductPriceBtn.BackColor = Color.FromArgb(236, 236, 236);
            orderProductPriceBtn.BorderStyle = BorderStyle.None;
            orderProductPriceBtn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderProductPriceBtn.ForeColor = Color.FromArgb(76, 75, 78);
            orderProductPriceBtn.Location = new Point(632, 362);
            orderProductPriceBtn.Name = "orderProductPriceBtn";
            orderProductPriceBtn.Size = new Size(225, 28);
            orderProductPriceBtn.TabIndex = 22;
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
            cyberTextBox5.Location = new Point(617, 347);
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
            cyberTextBox9.Location = new Point(66, 512);
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
            cyberTextBox10.Location = new Point(617, 512);
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
            label3.Location = new Point(526, 143);
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
            // supplierPanel
            // 
            supplierPanel.Controls.Add(cyberButton2);
            supplierPanel.Controls.Add(searchSupplier);
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
            supplierPanel.Text = "supplier";
            supplierPanel.UseVisualStyleBackColor = true;
            // 
            // cyberButton2
            // 
            cyberButton2.Alpha = 20;
            cyberButton2.BackColor = Color.Transparent;
            cyberButton2.Background = true;
            cyberButton2.Background_WidthPen = 4F;
            cyberButton2.BackgroundPen = true;
            cyberButton2.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberButton2.ColorBackground_1 = SystemColors.ScrollBar;
            cyberButton2.ColorBackground_2 = SystemColors.ActiveBorder;
            cyberButton2.ColorBackground_Pen = Color.FromArgb(120, 120, 120);
            cyberButton2.ColorLighting = Color.White;
            cyberButton2.ColorPen_1 = SystemColors.WindowFrame;
            cyberButton2.ColorPen_2 = Color.FromArgb(64, 64, 64);
            cyberButton2.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton2.Effect_1 = true;
            cyberButton2.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton2.Effect_1_Transparency = 25;
            cyberButton2.Effect_2 = true;
            cyberButton2.Effect_2_ColorBackground = Color.White;
            cyberButton2.Effect_2_Transparency = 20;
            cyberButton2.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cyberButton2.ForeColor = Color.Black;
            cyberButton2.Lighting = false;
            cyberButton2.LinearGradient_Background = false;
            cyberButton2.LinearGradientPen = false;
            cyberButton2.Location = new Point(932, 13);
            cyberButton2.Name = "cyberButton2";
            cyberButton2.PenWidth = 15;
            cyberButton2.Rounding = true;
            cyberButton2.RoundingInt = 70;
            cyberButton2.Size = new Size(172, 56);
            cyberButton2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton2.TabIndex = 34;
            cyberButton2.Tag = "Cyber";
            cyberButton2.TextButton = "+ Add Supplier";
            cyberButton2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            cyberButton2.Timer_Effect_1 = 5;
            cyberButton2.Timer_RGB = 300;
            // 
            // searchSupplier
            // 
            searchSupplier.BackColor = Color.FromArgb(236, 236, 236);
            searchSupplier.BorderStyle = BorderStyle.None;
            searchSupplier.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchSupplier.ForeColor = Color.FromArgb(174, 174, 172);
            searchSupplier.Location = new Point(159, 29);
            searchSupplier.Name = "searchSupplier";
            searchSupplier.Size = new Size(670, 28);
            searchSupplier.TabIndex = 19;
            searchSupplier.Text = "Search";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.BackColor = Color.FromArgb(230, 230, 226);
            label22.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label22.ForeColor = Color.FromArgb(174, 174, 172);
            label22.Location = new Point(752, 119);
            label22.Margin = new Padding(4, 0, 4, 0);
            label22.Name = "label22";
            label22.Size = new Size(135, 23);
            label22.TabIndex = 11;
            label22.Text = "Supplier Email";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.BackColor = Color.FromArgb(230, 230, 226);
            label21.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label21.ForeColor = Color.FromArgb(174, 174, 172);
            label21.Location = new Point(478, 119);
            label21.Margin = new Padding(4, 0, 4, 0);
            label21.Name = "label21";
            label21.Size = new Size(138, 23);
            label21.TabIndex = 10;
            label21.Text = "Supplier Name";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.FromArgb(230, 230, 226);
            label20.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(174, 174, 172);
            label20.Location = new Point(175, 119);
            label20.Margin = new Padding(4, 0, 4, 0);
            label20.Name = "label20";
            label20.Size = new Size(104, 23);
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
            cyberTextBox11.Size = new Size(774, 55);
            cyberTextBox11.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox11.TabIndex = 4;
            cyberTextBox11.TabStop = false;
            cyberTextBox11.Tag = "Cyber";
            cyberTextBox11.TextButton = "";
            cyberTextBox11.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox11.Timer_RGB = 300;
            cyberTextBox11.Load += cyberTextBox11_Load;
            // 
            // supplierTable
            // 
            supplierTable.BackgroundColor = Color.FromArgb(236, 236, 236);
            supplierTable.BorderStyle = BorderStyle.None;
            supplierTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.LightGray;
            dataGridViewCellStyle5.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            supplierTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            supplierTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle6.Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            supplierTable.DefaultCellStyle = dataGridViewCellStyle6;
            supplierTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            supplierTable.EnableHeadersVisualStyles = false;
            supplierTable.Location = new Point(98, 176);
            supplierTable.Margin = new Padding(4);
            supplierTable.Name = "supplierTable";
            supplierTable.ReadOnly = true;
            supplierTable.RowHeadersVisible = false;
            supplierTable.RowHeadersWidth = 120;
            supplierTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            supplierTable.RowTemplate.Height = 50;
            supplierTable.Size = new Size(961, 591);
            supplierTable.TabIndex = 1;
            supplierTable.CellClick += supplierTable_CellClick;
            // 
            // editSupplier
            // 
            editSupplier.Controls.Add(saveEditSupplierBtn);
            editSupplier.Controls.Add(editSupplierAddress);
            editSupplier.Controls.Add(cyberTextBox17);
            editSupplier.Controls.Add(label28);
            editSupplier.Controls.Add(editSupplierEmail);
            editSupplier.Controls.Add(cyberTextBox16);
            editSupplier.Controls.Add(label27);
            editSupplier.Controls.Add(editSupplierNum);
            editSupplier.Controls.Add(cyberTextBox15);
            editSupplier.Controls.Add(label26);
            editSupplier.Controls.Add(label23);
            editSupplier.Controls.Add(editSupplierId);
            editSupplier.Controls.Add(cyberTextBox13);
            editSupplier.Controls.Add(editSupplierName);
            editSupplier.Controls.Add(cyberTextBox14);
            editSupplier.Controls.Add(label24);
            editSupplier.Controls.Add(label25);
            editSupplier.Controls.Add(textBox8);
            editSupplier.Location = new Point(4, 5);
            editSupplier.Name = "editSupplier";
            editSupplier.Size = new Size(1140, 795);
            editSupplier.TabIndex = 6;
            editSupplier.Text = "editSupplier";
            editSupplier.UseVisualStyleBackColor = true;
            // 
            // saveEditSupplierBtn
            // 
            saveEditSupplierBtn.Alpha = 20;
            saveEditSupplierBtn.BackColor = Color.Transparent;
            saveEditSupplierBtn.Background = true;
            saveEditSupplierBtn.Background_WidthPen = 4F;
            saveEditSupplierBtn.BackgroundPen = true;
            saveEditSupplierBtn.ColorBackground = Color.FromArgb(236, 236, 236);
            saveEditSupplierBtn.ColorBackground_1 = SystemColors.ScrollBar;
            saveEditSupplierBtn.ColorBackground_2 = SystemColors.ActiveBorder;
            saveEditSupplierBtn.ColorBackground_Pen = Color.FromArgb(120, 120, 120);
            saveEditSupplierBtn.ColorLighting = Color.White;
            saveEditSupplierBtn.ColorPen_1 = SystemColors.WindowFrame;
            saveEditSupplierBtn.ColorPen_2 = Color.FromArgb(64, 64, 64);
            saveEditSupplierBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            saveEditSupplierBtn.Effect_1 = true;
            saveEditSupplierBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            saveEditSupplierBtn.Effect_1_Transparency = 25;
            saveEditSupplierBtn.Effect_2 = true;
            saveEditSupplierBtn.Effect_2_ColorBackground = Color.White;
            saveEditSupplierBtn.Effect_2_Transparency = 20;
            saveEditSupplierBtn.Font = new Font("Arial", 11F);
            saveEditSupplierBtn.ForeColor = Color.Black;
            saveEditSupplierBtn.Lighting = false;
            saveEditSupplierBtn.LinearGradient_Background = false;
            saveEditSupplierBtn.LinearGradientPen = false;
            saveEditSupplierBtn.Location = new Point(649, 590);
            saveEditSupplierBtn.Name = "saveEditSupplierBtn";
            saveEditSupplierBtn.PenWidth = 15;
            saveEditSupplierBtn.Rounding = true;
            saveEditSupplierBtn.RoundingInt = 70;
            saveEditSupplierBtn.Size = new Size(265, 72);
            saveEditSupplierBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            saveEditSupplierBtn.TabIndex = 33;
            saveEditSupplierBtn.Tag = "Cyber";
            saveEditSupplierBtn.TextButton = "Save Changes";
            saveEditSupplierBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            saveEditSupplierBtn.Timer_Effect_1 = 5;
            saveEditSupplierBtn.Timer_RGB = 300;
            saveEditSupplierBtn.Click += saveEditSupplierBtn_Click;
            // 
            // editSupplierAddress
            // 
            editSupplierAddress.BackColor = Color.FromArgb(236, 236, 236);
            editSupplierAddress.BorderStyle = BorderStyle.None;
            editSupplierAddress.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editSupplierAddress.ForeColor = Color.FromArgb(76, 75, 78);
            editSupplierAddress.Location = new Point(649, 346);
            editSupplierAddress.Name = "editSupplierAddress";
            editSupplierAddress.Size = new Size(435, 28);
            editSupplierAddress.TabIndex = 32;
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
            // editSupplierEmail
            // 
            editSupplierEmail.BackColor = Color.FromArgb(236, 236, 236);
            editSupplierEmail.BorderStyle = BorderStyle.None;
            editSupplierEmail.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editSupplierEmail.ForeColor = Color.FromArgb(76, 75, 78);
            editSupplierEmail.Location = new Point(105, 516);
            editSupplierEmail.Name = "editSupplierEmail";
            editSupplierEmail.Size = new Size(435, 28);
            editSupplierEmail.TabIndex = 29;
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
            // editSupplierNum
            // 
            editSupplierNum.BackColor = Color.FromArgb(236, 236, 236);
            editSupplierNum.BorderStyle = BorderStyle.None;
            editSupplierNum.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editSupplierNum.ForeColor = Color.FromArgb(76, 75, 78);
            editSupplierNum.Location = new Point(105, 346);
            editSupplierNum.Name = "editSupplierNum";
            editSupplierNum.Size = new Size(435, 28);
            editSupplierNum.TabIndex = 26;
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
            // editSupplierId
            // 
            editSupplierId.BackColor = Color.FromArgb(236, 236, 236);
            editSupplierId.BorderStyle = BorderStyle.None;
            editSupplierId.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editSupplierId.ForeColor = Color.FromArgb(76, 75, 78);
            editSupplierId.Location = new Point(649, 178);
            editSupplierId.Name = "editSupplierId";
            editSupplierId.ReadOnly = true;
            editSupplierId.Size = new Size(284, 28);
            editSupplierId.TabIndex = 22;
            editSupplierId.TabStop = false;
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
            // editSupplierName
            // 
            editSupplierName.BackColor = Color.FromArgb(236, 236, 236);
            editSupplierName.BorderStyle = BorderStyle.None;
            editSupplierName.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            editSupplierName.ForeColor = Color.FromArgb(76, 75, 78);
            editSupplierName.Location = new Point(105, 178);
            editSupplierName.Name = "editSupplierName";
            editSupplierName.Size = new Size(435, 28);
            editSupplierName.TabIndex = 20;
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
            label25.Size = new Size(352, 33);
            label25.TabIndex = 16;
            label25.Text = "Edit Supplier Information";
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
            // supplierInfo
            // 
            supplierInfo.Controls.Add(label35);
            supplierInfo.Controls.Add(info_supplierProductsCmb);
            supplierInfo.Controls.Add(info_supplierAdd);
            supplierInfo.Controls.Add(cyberTextBox18);
            supplierInfo.Controls.Add(label29);
            supplierInfo.Controls.Add(info_supplierEmail);
            supplierInfo.Controls.Add(label30);
            supplierInfo.Controls.Add(info_supplierNum);
            supplierInfo.Controls.Add(label31);
            supplierInfo.Controls.Add(label32);
            supplierInfo.Controls.Add(info_supplierId);
            supplierInfo.Controls.Add(info_supplierName);
            supplierInfo.Controls.Add(label33);
            supplierInfo.Controls.Add(label34);
            supplierInfo.Controls.Add(textBox6);
            supplierInfo.Location = new Point(4, 5);
            supplierInfo.Name = "supplierInfo";
            supplierInfo.Size = new Size(1140, 795);
            supplierInfo.TabIndex = 7;
            supplierInfo.Text = "tabPage2";
            supplierInfo.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label35.ForeColor = Color.FromArgb(76, 75, 78);
            label35.Location = new Point(653, 475);
            label35.Name = "label35";
            label35.Size = new Size(205, 27);
            label35.TabIndex = 46;
            label35.Text = "Supplier Products";
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
            info_supplierProductsCmb.Location = new Point(678, 533);
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
            info_supplierAdd.Location = new Point(649, 349);
            info_supplierAdd.Name = "info_supplierAdd";
            info_supplierAdd.PenWidth = 15;
            info_supplierAdd.RGB = false;
            info_supplierAdd.Rounding = true;
            info_supplierAdd.RoundingInt = 60;
            info_supplierAdd.Size = new Size(420, 55);
            info_supplierAdd.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            info_supplierAdd.TabIndex = 43;
            info_supplierAdd.TabStop = false;
            info_supplierAdd.Tag = "Cyber";
            info_supplierAdd.TextButton = "";
            info_supplierAdd.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            info_supplierAdd.Timer_RGB = 300;
            // 
            // cyberTextBox18
            // 
            cyberTextBox18.Alpha = 20;
            cyberTextBox18.BackColor = Color.Transparent;
            cyberTextBox18.Background_WidthPen = 3F;
            cyberTextBox18.BackgroundPen = true;
            cyberTextBox18.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberTextBox18.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberTextBox18.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberTextBox18.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberTextBox18.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberTextBox18.CyberTextBoxStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberTextBox18.Enabled = false;
            cyberTextBox18.Font = new Font("Arial", 13F);
            cyberTextBox18.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox18.Lighting = false;
            cyberTextBox18.LinearGradientPen = false;
            cyberTextBox18.Location = new Point(649, 519);
            cyberTextBox18.Name = "cyberTextBox18";
            cyberTextBox18.PenWidth = 15;
            cyberTextBox18.RGB = false;
            cyberTextBox18.Rounding = true;
            cyberTextBox18.RoundingInt = 60;
            cyberTextBox18.Size = new Size(420, 55);
            cyberTextBox18.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox18.TabIndex = 45;
            cyberTextBox18.TabStop = false;
            cyberTextBox18.Tag = "Cyber";
            cyberTextBox18.TextButton = "";
            cyberTextBox18.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox18.Timer_RGB = 300;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label29.ForeColor = Color.FromArgb(76, 75, 78);
            label29.Location = new Point(649, 305);
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
            info_supplierEmail.Size = new Size(474, 55);
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
            info_supplierNum.Size = new Size(474, 55);
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
            label32.Location = new Point(664, 137);
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
            info_supplierId.Location = new Point(653, 177);
            info_supplierId.Name = "info_supplierId";
            info_supplierId.PenWidth = 15;
            info_supplierId.RGB = false;
            info_supplierId.Rounding = true;
            info_supplierId.RoundingInt = 60;
            info_supplierId.Size = new Size(319, 55);
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
            // label34
            // 
            label34.AutoSize = true;
            label34.BackColor = Color.FromArgb(236, 236, 236);
            label34.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label34.Location = new Point(105, 54);
            label34.Name = "label34";
            label34.Size = new Size(299, 33);
            label34.TabIndex = 32;
            label34.Text = " Supplier Information";
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
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1140, 795);
            tabPage2.TabIndex = 9;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Resources.profileIcon;
            pictureBox3.Location = new Point(1418, 36);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(58, 52);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
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
            headerLbl.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLbl.Location = new Point(478, 49);
            headerLbl.Margin = new Padding(4, 0, 4, 0);
            headerLbl.Name = "headerLbl";
            headerLbl.Size = new Size(140, 33);
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
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = Resources.icons8_back_64;
            button3.Location = new Point(395, 30);
            button3.Name = "button3";
            button3.Size = new Size(63, 58);
            button3.TabIndex = 5;
            button3.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(14F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1515, 919);
            Controls.Add(button3);
            Controls.Add(headerLbl);
            Controls.Add(userLbl);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(tabControl1);
            Font = new Font("Arial Narrow", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "mainForm";
            Text = "main menu";
            Load += mainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            viewProducts.ResumeLayout(false);
            viewProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productTable).EndInit();
            addProduct.ResumeLayout(false);
            addProduct.PerformLayout();
            editProducts.ResumeLayout(false);
            editProducts.PerformLayout();
            orderProduct.ResumeLayout(false);
            orderProduct.PerformLayout();
            supplierPanel.ResumeLayout(false);
            supplierPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)supplierTable).EndInit();
            editSupplier.ResumeLayout(false);
            editSupplier.PerformLayout();
            supplierInfo.ResumeLayout(false);
            supplierInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            categoryMore.ResumeLayout(false);
            supplierMoreStrip.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Panel panel1;
        private TabControl tabControl1;
        private TabPage viewProducts;
        private Button addProdBtn;
        private Button tab2;
        private Button viewProdBtn;
        private TabPage Dashboard;
        private TabPage editProducts;
        private DataGridView productTable;
        private Label label8;
        private Button button4;
        private Button supplierNavbtn;
        private Button button2;
        private Button button1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox textBox1;
        private Label label1;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox3;
        private Label userLbl;
        private Label headerLbl;
        private Label label11;
        private TextBox textBox2;
        private Label label12;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox1;
        public ReaLTaiizor.Controls.CyberTextBox lbltextt;
        private Label label13;
        private ReaLTaiizor.Controls.DungeonComboBox cmbCategory;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox3;
        private Label label14;
        private ReaLTaiizor.Controls.CyberButton cyberButton1;
        private ReaLTaiizor.Controls.DungeonComboBox cmbSuppliers;
        private Label label16;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox4;
        private Label label15;
        private TextBox textBox3;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox2;
        private TextBox productNameEdit;
        private ReaLTaiizor.Controls.CyberButton prodQtyMinus;
        private ReaLTaiizor.Controls.CyberButton prodQtyAdd;
        private TextBox textBox4;
        private Label ProdDateModified;
        private Label prodDateAdded;
        private Label label18;
        private Label label17;
        private Button categoryMoreBtn;
        private ContextMenuStrip categoryMore;
        private Button supplierMoreBtn;
        private ToolStripMenuItem toolStripMenuItem1;
        private ContextMenuStrip supplierMoreStrip;
        private ToolStripMenuItem toolStripMenuItem2;
        private TabPage orderProduct;
        private Label label19;
        private ReaLTaiizor.Controls.CyberButton orderProductBtn;
        private TextBox orderProductQtyBtn;
        private Label label5;
        private ReaLTaiizor.Controls.DungeonComboBox orderProductsuppBtn;
        private ReaLTaiizor.Controls.DungeonComboBox orderProductCatBtn;
        private Label label6;
        private Label label7;
        private Label label2;
        private TextBox orderProductPriceBtn;
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
        private TextBox searchSupplier;
        private Label label22;
        private Label label21;
        private Label label20;
        private ReaLTaiizor.Controls.CyberButton cyberButton2;
        private TabPage editSupplier;
        private Label label23;
        private TextBox editSupplierId;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox13;
        private TextBox editSupplierName;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox14;
        private Label label24;
        private Label label25;
        private TextBox textBox8;
        private TabPage supplierInfo;
        private TextBox editSupplierAddress;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox17;
        private Label label28;
        private TextBox editSupplierEmail;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox16;
        private Label label27;
        private TextBox editSupplierNum;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox15;
        private Label label26;
        private ReaLTaiizor.Controls.CyberButton saveEditSupplierBtn;
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
        private Label label34;
        private TextBox textBox6;
        private Label label35;
        private ReaLTaiizor.Controls.DungeonComboBox info_supplierProductsCmb;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox18;
        private Button button3;
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
        private TabPage tabPage2;
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
    }
}