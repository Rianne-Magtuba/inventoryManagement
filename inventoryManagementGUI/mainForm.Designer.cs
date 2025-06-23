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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label8 = new Label();
            viewProdBtn = new Button();
            tab2 = new Button();
            addProdBtn = new Button();
            tabControl1 = new TabControl();
            Overview = new TabPage();
            viewProducts = new TabPage();
            label10 = new Label();
            label9 = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            productTable = new DataGridView();
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
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            pictureBox3 = new PictureBox();
            userLbl = new Label();
            headerLbl = new Label();
            categoryMore = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            supplierMoreStrip = new ContextMenuStrip(components);
            toolStripMenuItem2 = new ToolStripMenuItem();
            orderProduct = new TabPage();
            tabPage2 = new TabPage();
            label2 = new Label();
            orderProductPriceBtn = new TextBox();
            cyberTextBox5 = new ReaLTaiizor.Controls.CyberTextBox();
            orderProductNameBtn = new TextBox();
            cyberTextBox6 = new ReaLTaiizor.Controls.CyberTextBox();
            label3 = new Label();
            label4 = new Label();
            textBox7 = new TextBox();
            orderProductBtn = new ReaLTaiizor.Controls.CyberButton();
            orderProductQtyBtn = new TextBox();
            label5 = new Label();
            orderProductsuppBtn = new ReaLTaiizor.Controls.DungeonComboBox();
            orderProductCatBtn = new ReaLTaiizor.Controls.DungeonComboBox();
            label6 = new Label();
            label7 = new Label();
            cyberTextBox7 = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox8 = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox9 = new ReaLTaiizor.Controls.CyberTextBox();
            cyberTextBox10 = new ReaLTaiizor.Controls.CyberTextBox();
            orderProductIdBtn = new TextBox();
            label19 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            viewProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productTable).BeginInit();
            editProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            categoryMore.SuspendLayout();
            supplierMoreStrip.SuspendLayout();
            orderProduct.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 30, 30);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
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
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 10F);
            button3.ForeColor = Color.White;
            button3.Image = Resources.supplierIcon;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(0, 653);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Padding = new Padding(42, 0, 0, 0);
            button3.Size = new Size(368, 86);
            button3.TabIndex = 8;
            button3.Text = "Suppliers";
            button3.UseVisualStyleBackColor = true;
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
            label8.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(70, 44);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(174, 46);
            label8.TabIndex = 5;
            label8.Text = "Computer \n Inventory System ";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            label8.Click += label8_Click;
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
            viewProdBtn.Click += button1_Click;
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
            tab2.Text = "Overview";
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
            tabControl1.Controls.Add(Overview);
            tabControl1.Controls.Add(viewProducts);
            tabControl1.Controls.Add(editProducts);
            tabControl1.Controls.Add(orderProduct);
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
            // Overview
            // 
            Overview.Location = new Point(4, 5);
            Overview.Margin = new Padding(4);
            Overview.Name = "Overview";
            Overview.Size = new Size(1140, 795);
            Overview.TabIndex = 2;
            Overview.Text = "tabPage3";
            Overview.UseVisualStyleBackColor = true;
            // 
            // viewProducts
            // 
            viewProducts.BackColor = Color.FromArgb(236, 236, 236);
            viewProducts.Controls.Add(label10);
            viewProducts.Controls.Add(label9);
            viewProducts.Controls.Add(label1);
            viewProducts.Controls.Add(pictureBox2);
            viewProducts.Controls.Add(textBox1);
            viewProducts.Controls.Add(pictureBox1);
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
            // pictureBox2
            // 
            pictureBox2.Image = Resources.productHeader;
            pictureBox2.Location = new Point(99, 66);
            pictureBox2.Margin = new Padding(4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1030, 97);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(236, 236, 236);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(174, 174, 172);
            textBox1.Location = new Point(126, 24);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(696, 23);
            textBox1.TabIndex = 6;
            textBox1.Text = "Search";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Resources.test;
            pictureBox1.Location = new Point(45, 4);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1084, 81);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
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
            productTable.Size = new Size(961, 591);
            productTable.TabIndex = 0;
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
            cyberButton1.ColorBackground_1 = Color.FromArgb(174, 174, 172);
            cyberButton1.ColorBackground_2 = Color.FromArgb(174, 174, 172);
            cyberButton1.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberButton1.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberButton1.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberButton1.ColorPen_2 = Color.FromArgb(174, 174, 172);
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
            prodQtyMinus.ColorBackground_1 = Color.FromArgb(174, 174, 172);
            prodQtyMinus.ColorBackground_2 = Color.FromArgb(174, 174, 172);
            prodQtyMinus.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            prodQtyMinus.ColorLighting = Color.FromArgb(174, 174, 172);
            prodQtyMinus.ColorPen_1 = Color.FromArgb(174, 174, 172);
            prodQtyMinus.ColorPen_2 = Color.FromArgb(174, 174, 172);
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
            prodQtyAdd.ColorBackground_1 = Color.FromArgb(174, 174, 172);
            prodQtyAdd.ColorBackground_2 = Color.FromArgb(174, 174, 172);
            prodQtyAdd.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            prodQtyAdd.ColorLighting = Color.FromArgb(174, 174, 172);
            prodQtyAdd.ColorPen_1 = Color.FromArgb(174, 174, 172);
            prodQtyAdd.ColorPen_2 = Color.FromArgb(174, 174, 172);
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
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Resources.profileIcon;
            pictureBox3.Location = new Point(1419, 13);
            pictureBox3.Margin = new Padding(4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(58, 69);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // userLbl
            // 
            userLbl.AutoSize = true;
            userLbl.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            userLbl.Location = new Point(1343, 30);
            userLbl.Margin = new Padding(4, 0, 4, 0);
            userLbl.Name = "userLbl";
            userLbl.Size = new Size(59, 21);
            userLbl.TabIndex = 3;
            userLbl.Text = "Admin";
            // 
            // headerLbl
            // 
            headerLbl.AutoSize = true;
            headerLbl.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerLbl.Location = new Point(521, 30);
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
            categoryMore.Size = new Size(190, 32);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(189, 28);
            toolStripMenuItem1.Text = "Add Category";
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
            // orderProduct
            // 
            orderProduct.Controls.Add(label19);
            orderProduct.Controls.Add(orderProductIdBtn);
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
            orderProduct.Controls.Add(orderProductNameBtn);
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
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 5);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1140, 795);
            tabPage2.TabIndex = 5;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
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
            // orderProductNameBtn
            // 
            orderProductNameBtn.BackColor = Color.FromArgb(236, 236, 236);
            orderProductNameBtn.BorderStyle = BorderStyle.None;
            orderProductNameBtn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderProductNameBtn.ForeColor = Color.FromArgb(76, 75, 78);
            orderProductNameBtn.Location = new Point(70, 198);
            orderProductNameBtn.Name = "orderProductNameBtn";
            orderProductNameBtn.Size = new Size(435, 28);
            orderProductNameBtn.TabIndex = 20;
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
            cyberTextBox6.Location = new Point(55, 183);
            cyberTextBox6.Name = "cyberTextBox6";
            cyberTextBox6.PenWidth = 15;
            cyberTextBox6.RGB = false;
            cyberTextBox6.Rounding = true;
            cyberTextBox6.RoundingInt = 60;
            cyberTextBox6.Size = new Size(474, 55);
            cyberTextBox6.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox6.TabIndex = 19;
            cyberTextBox6.TabStop = false;
            cyberTextBox6.Tag = "Cyber";
            cyberTextBox6.TextButton = "";
            cyberTextBox6.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox6.Timer_RGB = 300;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(76, 75, 78);
            label3.Location = new Point(55, 139);
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
            label4.Location = new Point(55, 56);
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
            textBox7.Location = new Point(55, 82);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(323, 19);
            textBox7.TabIndex = 17;
            textBox7.TabStop = false;
            // 
            // orderProductBtn
            // 
            orderProductBtn.Alpha = 20;
            orderProductBtn.BackColor = Color.Transparent;
            orderProductBtn.Background = true;
            orderProductBtn.Background_WidthPen = 4F;
            orderProductBtn.BackgroundPen = true;
            orderProductBtn.ColorBackground = Color.FromArgb(236, 236, 236);
            orderProductBtn.ColorBackground_1 = Color.FromArgb(174, 174, 172);
            orderProductBtn.ColorBackground_2 = Color.FromArgb(174, 174, 172);
            orderProductBtn.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            orderProductBtn.ColorLighting = Color.FromArgb(174, 174, 172);
            orderProductBtn.ColorPen_1 = Color.FromArgb(174, 174, 172);
            orderProductBtn.ColorPen_2 = Color.FromArgb(174, 174, 172);
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
            orderProductsuppBtn.Location = new Point(66, 517);
            orderProductsuppBtn.Name = "orderProductsuppBtn";
            orderProductsuppBtn.Size = new Size(220, 26);
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
            orderProductCatBtn.Location = new Point(66, 350);
            orderProductCatBtn.Name = "orderProductCatBtn";
            orderProductCatBtn.Size = new Size(220, 26);
            orderProductCatBtn.StartIndex = 0;
            orderProductCatBtn.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(76, 75, 78);
            label6.Location = new Point(66, 453);
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
            label7.Location = new Point(66, 280);
            label7.Name = "label7";
            label7.Size = new Size(200, 27);
            label7.TabIndex = 27;
            label7.Text = "Product Category";
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
            cyberTextBox7.Location = new Point(618, 183);
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
            cyberTextBox8.Location = new Point(55, 500);
            cyberTextBox8.Name = "cyberTextBox8";
            cyberTextBox8.PenWidth = 15;
            cyberTextBox8.RGB = false;
            cyberTextBox8.Rounding = true;
            cyberTextBox8.RoundingInt = 60;
            cyberTextBox8.Size = new Size(246, 55);
            cyberTextBox8.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox8.TabIndex = 35;
            cyberTextBox8.TabStop = false;
            cyberTextBox8.Tag = "Cyber";
            cyberTextBox8.TextButton = "";
            cyberTextBox8.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox8.Timer_RGB = 300;
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
            cyberTextBox9.Location = new Point(55, 328);
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
            // orderProductIdBtn
            // 
            orderProductIdBtn.BackColor = Color.FromArgb(236, 236, 236);
            orderProductIdBtn.BorderStyle = BorderStyle.None;
            orderProductIdBtn.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderProductIdBtn.ForeColor = Color.FromArgb(76, 75, 78);
            orderProductIdBtn.Location = new Point(632, 198);
            orderProductIdBtn.Name = "orderProductIdBtn";
            orderProductIdBtn.Size = new Size(360, 28);
            orderProductIdBtn.TabIndex = 38;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.FromArgb(76, 75, 78);
            label19.Location = new Point(632, 139);
            label19.Name = "label19";
            label19.Size = new Size(126, 27);
            label19.TabIndex = 39;
            label19.Text = "Product ID";
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(14F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1515, 919);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)productTable).EndInit();
            editProducts.ResumeLayout(false);
            editProducts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            categoryMore.ResumeLayout(false);
            supplierMoreStrip.ResumeLayout(false);
            orderProduct.ResumeLayout(false);
            orderProduct.PerformLayout();
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
        private TabPage Overview;
        private TabPage editProducts;
        private DataGridView productTable;
        private Label label8;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox3;
        private Label userLbl;
        private Label headerLbl;
        private Label label11;
        private TextBox textBox2;
        private Label label12;
        private PictureBox pictureBox1;
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
        private TextBox orderProductIdBtn;
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
        private TextBox orderProductNameBtn;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox6;
        public ReaLTaiizor.Controls.CyberTextBox cyberTextBox9;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox7;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox10;
        private Label label3;
        private Label label4;
        private TextBox textBox7;
        private TabPage tabPage2;
    }
}