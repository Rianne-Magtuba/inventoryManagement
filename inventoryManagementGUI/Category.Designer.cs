using BusinessLogic;

namespace inventoryManagementGUI
{
    partial class Category
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
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label2 = new Label();
            cyberTextBox1 = new ReaLTaiizor.Controls.CyberTextBox();
            label41 = new Label();
            cyberButton3 = new ReaLTaiizor.Controls.CyberButton();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            catNameField = new TextBox();
            updateCatPage = new TabPage();
            newCatName = new TextBox();
            label1 = new Label();
            cyberTextBox2 = new ReaLTaiizor.Controls.CyberTextBox();
            updateCatCmb = new ReaLTaiizor.Controls.DungeonComboBox();
            label39 = new Label();
            cyberTextBox22 = new ReaLTaiizor.Controls.CyberTextBox();
            updateCatBtn = new ReaLTaiizor.Controls.CyberButton();
            removeCatPage = new TabPage();
            removeCatCmb = new ReaLTaiizor.Controls.DungeonComboBox();
            label3 = new Label();
            cyberTextBox3 = new ReaLTaiizor.Controls.CyberTextBox();
            removeCatBtn = new ReaLTaiizor.Controls.CyberButton();
            categoryHdr = new Label();
            textBox12 = new TextBox();
            menuBtn = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            updateCategory = new ToolStripMenuItem();
            removeCategory = new ToolStripMenuItem();
            AddCategory = new ToolStripMenuItem();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            updateCatPage.SuspendLayout();
            removeCatPage.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 18F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(114, 33);
            label2.Name = "label2";
            label2.Size = new Size(0, 41);
            label2.TabIndex = 1;
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
            cyberTextBox1.Font = new Font("Arial", 14F);
            cyberTextBox1.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox1.Lighting = false;
            cyberTextBox1.LinearGradientPen = false;
            cyberTextBox1.Location = new Point(87, 104);
            cyberTextBox1.Name = "cyberTextBox1";
            cyberTextBox1.PenWidth = 15;
            cyberTextBox1.RGB = false;
            cyberTextBox1.Rounding = true;
            cyberTextBox1.RoundingInt = 60;
            cyberTextBox1.Size = new Size(340, 57);
            cyberTextBox1.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox1.TabIndex = 1;
            cyberTextBox1.Tag = "Cyber";
            cyberTextBox1.TextButton = "";
            cyberTextBox1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox1.Timer_RGB = 300;
            // 
            // label41
            // 
            label41.AutoSize = true;
            label41.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label41.ForeColor = Color.FromArgb(76, 75, 78);
            label41.Location = new Point(151, 45);
            label41.Name = "label41";
            label41.Size = new Size(179, 27);
            label41.TabIndex = 41;
            label41.Text = "Category Name";
            // 
            // cyberButton3
            // 
            cyberButton3.Alpha = 20;
            cyberButton3.BackColor = Color.Transparent;
            cyberButton3.Background = true;
            cyberButton3.Background_WidthPen = 4F;
            cyberButton3.BackgroundPen = true;
            cyberButton3.ColorBackground = Color.FromArgb(236, 236, 236);
            cyberButton3.ColorBackground_1 = Color.FromArgb(174, 174, 172);
            cyberButton3.ColorBackground_2 = Color.FromArgb(174, 174, 172);
            cyberButton3.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            cyberButton3.ColorLighting = Color.FromArgb(174, 174, 172);
            cyberButton3.ColorPen_1 = Color.FromArgb(174, 174, 172);
            cyberButton3.ColorPen_2 = Color.FromArgb(174, 174, 172);
            cyberButton3.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            cyberButton3.Effect_1 = true;
            cyberButton3.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            cyberButton3.Effect_1_Transparency = 25;
            cyberButton3.Effect_2 = true;
            cyberButton3.Effect_2_ColorBackground = Color.White;
            cyberButton3.Effect_2_Transparency = 20;
            cyberButton3.Font = new Font("Arial", 11F);
            cyberButton3.ForeColor = Color.Black;
            cyberButton3.Lighting = false;
            cyberButton3.LinearGradient_Background = false;
            cyberButton3.LinearGradientPen = false;
            cyberButton3.Location = new Point(126, 226);
            cyberButton3.Name = "cyberButton3";
            cyberButton3.PenWidth = 15;
            cyberButton3.Rounding = true;
            cyberButton3.RoundingInt = 70;
            cyberButton3.Size = new Size(247, 59);
            cyberButton3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberButton3.TabIndex = 65;
            cyberButton3.Tag = "Cyber";
            cyberButton3.TextButton = "Add Category";
            cyberButton3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            cyberButton3.Timer_Effect_1 = 5;
            cyberButton3.Timer_RGB = 300;
            cyberButton3.Click += cyberButton3_Click;
            // 
            // tabControl1
            // 
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(updateCatPage);
            tabControl1.Controls.Add(removeCatPage);
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.Location = new Point(3, 105);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(567, 388);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 66;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(catNameField);
            tabPage1.Controls.Add(cyberButton3);
            tabPage1.Controls.Add(cyberTextBox1);
            tabPage1.Controls.Add(label41);
            tabPage1.Location = new Point(4, 5);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(559, 379);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // catNameField
            // 
            catNameField.BackColor = Color.FromArgb(236, 236, 236);
            catNameField.BorderStyle = BorderStyle.None;
            catNameField.Font = new Font("Arial", 12F);
            catNameField.ForeColor = Color.FromArgb(76, 75, 78);
            catNameField.Location = new Point(107, 119);
            catNameField.Name = "catNameField";
            catNameField.Size = new Size(307, 28);
            catNameField.TabIndex = 74;
            // 
            // updateCatPage
            // 
            updateCatPage.Controls.Add(newCatName);
            updateCatPage.Controls.Add(label1);
            updateCatPage.Controls.Add(cyberTextBox2);
            updateCatPage.Controls.Add(updateCatCmb);
            updateCatPage.Controls.Add(label39);
            updateCatPage.Controls.Add(cyberTextBox22);
            updateCatPage.Controls.Add(updateCatBtn);
            updateCatPage.Location = new Point(4, 5);
            updateCatPage.Name = "updateCatPage";
            updateCatPage.Padding = new Padding(3);
            updateCatPage.Size = new Size(559, 379);
            updateCatPage.TabIndex = 1;
            updateCatPage.Text = "tabPage2";
            updateCatPage.UseVisualStyleBackColor = true;
            // 
            // newCatName
            // 
            newCatName.BackColor = Color.FromArgb(236, 236, 236);
            newCatName.BorderStyle = BorderStyle.None;
            newCatName.Font = new Font("Arial", 9F);
            newCatName.ForeColor = Color.FromArgb(76, 75, 78);
            newCatName.Location = new Point(157, 207);
            newCatName.Name = "newCatName";
            newCatName.Size = new Size(211, 21);
            newCatName.TabIndex = 73;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 9F);
            label1.ForeColor = Color.FromArgb(76, 75, 78);
            label1.Location = new Point(157, 148);
            label1.Name = "label1";
            label1.Size = new Size(176, 21);
            label1.TabIndex = 72;
            label1.Text = "New Category Name";
            label1.Click += label1_Click;
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
            cyberTextBox2.Font = new Font("Arial", 12F);
            cyberTextBox2.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox2.Lighting = false;
            cyberTextBox2.LinearGradientPen = false;
            cyberTextBox2.Location = new Point(147, 188);
            cyberTextBox2.Name = "cyberTextBox2";
            cyberTextBox2.PenWidth = 15;
            cyberTextBox2.RGB = false;
            cyberTextBox2.Rounding = true;
            cyberTextBox2.RoundingInt = 60;
            cyberTextBox2.Size = new Size(226, 49);
            cyberTextBox2.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox2.TabIndex = 71;
            cyberTextBox2.TabStop = false;
            cyberTextBox2.Tag = "Cyber";
            cyberTextBox2.TextButton = "";
            cyberTextBox2.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox2.Timer_RGB = 300;
            // 
            // updateCatCmb
            // 
            updateCatCmb.BackColor = Color.FromArgb(236, 236, 236);
            updateCatCmb.ColorA = Color.FromArgb(64, 64, 64);
            updateCatCmb.ColorB = Color.FromArgb(64, 64, 64);
            updateCatCmb.ColorC = Color.FromArgb(239, 237, 236);
            updateCatCmb.ColorD = Color.FromArgb(239, 237, 236);
            updateCatCmb.ColorE = Color.FromArgb(239, 237, 236);
            updateCatCmb.ColorF = Color.FromArgb(236, 236, 236);
            updateCatCmb.ColorG = Color.Black;
            updateCatCmb.ColorH = Color.FromArgb(236, 236, 236);
            updateCatCmb.ColorI = Color.FromArgb(236, 236, 236);
            updateCatCmb.DrawMode = DrawMode.OwnerDrawFixed;
            updateCatCmb.DropDownHeight = 100;
            updateCatCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            updateCatCmb.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateCatCmb.ForeColor = Color.FromArgb(76, 75, 78);
            updateCatCmb.FormattingEnabled = true;
            updateCatCmb.HoverSelectionColor = Color.Empty;
            updateCatCmb.IntegralHeight = false;
            updateCatCmb.ItemHeight = 20;
            updateCatCmb.Location = new Point(169, 93);
            updateCatCmb.Name = "updateCatCmb";
            updateCatCmb.Size = new Size(189, 26);
            updateCatCmb.StartIndex = 0;
            updateCatCmb.TabIndex = 69;
            updateCatCmb.SelectedIndexChanged += updateCatCmb_SelectedIndexChanged;
            // 
            // label39
            // 
            label39.AutoSize = true;
            label39.Font = new Font("Arial", 9F);
            label39.ForeColor = Color.FromArgb(76, 75, 78);
            label39.Location = new Point(157, 45);
            label39.Name = "label39";
            label39.Size = new Size(190, 21);
            label39.TabIndex = 68;
            label39.Text = "Select Category Name";
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
            cyberTextBox22.Font = new Font("Arial", 12F);
            cyberTextBox22.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox22.Lighting = false;
            cyberTextBox22.LinearGradientPen = false;
            cyberTextBox22.Location = new Point(147, 80);
            cyberTextBox22.Name = "cyberTextBox22";
            cyberTextBox22.PenWidth = 15;
            cyberTextBox22.RGB = false;
            cyberTextBox22.Rounding = true;
            cyberTextBox22.RoundingInt = 60;
            cyberTextBox22.Size = new Size(226, 49);
            cyberTextBox22.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox22.TabIndex = 70;
            cyberTextBox22.TabStop = false;
            cyberTextBox22.Tag = "Cyber";
            cyberTextBox22.TextButton = "";
            cyberTextBox22.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox22.Timer_RGB = 300;
            // 
            // updateCatBtn
            // 
            updateCatBtn.Alpha = 20;
            updateCatBtn.BackColor = Color.Transparent;
            updateCatBtn.Background = true;
            updateCatBtn.Background_WidthPen = 4F;
            updateCatBtn.BackgroundPen = true;
            updateCatBtn.ColorBackground = Color.FromArgb(236, 236, 236);
            updateCatBtn.ColorBackground_1 = Color.FromArgb(174, 174, 172);
            updateCatBtn.ColorBackground_2 = Color.FromArgb(174, 174, 172);
            updateCatBtn.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            updateCatBtn.ColorLighting = Color.FromArgb(174, 174, 172);
            updateCatBtn.ColorPen_1 = Color.FromArgb(174, 174, 172);
            updateCatBtn.ColorPen_2 = Color.FromArgb(174, 174, 172);
            updateCatBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            updateCatBtn.Effect_1 = true;
            updateCatBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            updateCatBtn.Effect_1_Transparency = 25;
            updateCatBtn.Effect_2 = true;
            updateCatBtn.Effect_2_ColorBackground = Color.White;
            updateCatBtn.Effect_2_Transparency = 20;
            updateCatBtn.Font = new Font("Arial", 10F);
            updateCatBtn.ForeColor = Color.Black;
            updateCatBtn.Lighting = false;
            updateCatBtn.LinearGradient_Background = false;
            updateCatBtn.LinearGradientPen = false;
            updateCatBtn.Location = new Point(174, 274);
            updateCatBtn.Name = "updateCatBtn";
            updateCatBtn.PenWidth = 15;
            updateCatBtn.Rounding = true;
            updateCatBtn.RoundingInt = 70;
            updateCatBtn.Size = new Size(184, 52);
            updateCatBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            updateCatBtn.TabIndex = 67;
            updateCatBtn.Tag = "Cyber";
            updateCatBtn.TextButton = "Update Category";
            updateCatBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            updateCatBtn.Timer_Effect_1 = 5;
            updateCatBtn.Timer_RGB = 300;
            updateCatBtn.Click += updateCatBtn_Click;
            // 
            // removeCatPage
            // 
            removeCatPage.Controls.Add(removeCatCmb);
            removeCatPage.Controls.Add(label3);
            removeCatPage.Controls.Add(cyberTextBox3);
            removeCatPage.Controls.Add(removeCatBtn);
            removeCatPage.Location = new Point(4, 5);
            removeCatPage.Name = "removeCatPage";
            removeCatPage.Size = new Size(559, 379);
            removeCatPage.TabIndex = 2;
            removeCatPage.Text = "tabPage3";
            removeCatPage.UseVisualStyleBackColor = true;
            // 
            // removeCatCmb
            // 
            removeCatCmb.BackColor = Color.FromArgb(236, 236, 236);
            removeCatCmb.ColorA = Color.FromArgb(64, 64, 64);
            removeCatCmb.ColorB = Color.FromArgb(64, 64, 64);
            removeCatCmb.ColorC = Color.FromArgb(239, 237, 236);
            removeCatCmb.ColorD = Color.FromArgb(239, 237, 236);
            removeCatCmb.ColorE = Color.FromArgb(239, 237, 236);
            removeCatCmb.ColorF = Color.FromArgb(236, 236, 236);
            removeCatCmb.ColorG = Color.Black;
            removeCatCmb.ColorH = Color.FromArgb(236, 236, 236);
            removeCatCmb.ColorI = Color.FromArgb(236, 236, 236);
            removeCatCmb.DrawMode = DrawMode.OwnerDrawFixed;
            removeCatCmb.DropDownHeight = 100;
            removeCatCmb.DropDownStyle = ComboBoxStyle.DropDownList;
            removeCatCmb.Font = new Font("Arial", 11F);
            removeCatCmb.ForeColor = Color.FromArgb(76, 75, 78);
            removeCatCmb.FormattingEnabled = true;
            removeCatCmb.HoverSelectionColor = Color.Empty;
            removeCatCmb.IntegralHeight = false;
            removeCatCmb.ItemHeight = 20;
            removeCatCmb.Location = new Point(172, 120);
            removeCatCmb.Name = "removeCatCmb";
            removeCatCmb.Size = new Size(189, 26);
            removeCatCmb.StartIndex = 0;
            removeCatCmb.TabIndex = 72;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11F);
            label3.ForeColor = Color.FromArgb(76, 75, 78);
            label3.Location = new Point(135, 58);
            label3.Name = "label3";
            label3.Size = new Size(231, 25);
            label3.TabIndex = 71;
            label3.Text = "Select Category Name";
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
            cyberTextBox3.Font = new Font("Arial", 14F);
            cyberTextBox3.ForeColor = Color.FromArgb(245, 245, 245);
            cyberTextBox3.Lighting = false;
            cyberTextBox3.LinearGradientPen = false;
            cyberTextBox3.Location = new Point(135, 101);
            cyberTextBox3.Name = "cyberTextBox3";
            cyberTextBox3.PenWidth = 15;
            cyberTextBox3.RGB = false;
            cyberTextBox3.Rounding = true;
            cyberTextBox3.RoundingInt = 60;
            cyberTextBox3.Size = new Size(236, 56);
            cyberTextBox3.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            cyberTextBox3.TabIndex = 73;
            cyberTextBox3.TabStop = false;
            cyberTextBox3.Tag = "Cyber";
            cyberTextBox3.TextButton = "";
            cyberTextBox3.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            cyberTextBox3.Timer_RGB = 300;
            // 
            // removeCatBtn
            // 
            removeCatBtn.Alpha = 20;
            removeCatBtn.BackColor = Color.Transparent;
            removeCatBtn.Background = true;
            removeCatBtn.Background_WidthPen = 4F;
            removeCatBtn.BackgroundPen = true;
            removeCatBtn.ColorBackground = Color.FromArgb(236, 236, 236);
            removeCatBtn.ColorBackground_1 = Color.FromArgb(174, 174, 172);
            removeCatBtn.ColorBackground_2 = Color.FromArgb(174, 174, 172);
            removeCatBtn.ColorBackground_Pen = Color.FromArgb(174, 174, 172);
            removeCatBtn.ColorLighting = Color.FromArgb(174, 174, 172);
            removeCatBtn.ColorPen_1 = Color.FromArgb(174, 174, 172);
            removeCatBtn.ColorPen_2 = Color.FromArgb(174, 174, 172);
            removeCatBtn.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            removeCatBtn.Effect_1 = true;
            removeCatBtn.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            removeCatBtn.Effect_1_Transparency = 25;
            removeCatBtn.Effect_2 = true;
            removeCatBtn.Effect_2_ColorBackground = Color.White;
            removeCatBtn.Effect_2_Transparency = 20;
            removeCatBtn.Font = new Font("Arial", 11F);
            removeCatBtn.ForeColor = Color.Black;
            removeCatBtn.Lighting = false;
            removeCatBtn.LinearGradient_Background = false;
            removeCatBtn.LinearGradientPen = false;
            removeCatBtn.Location = new Point(129, 237);
            removeCatBtn.Name = "removeCatBtn";
            removeCatBtn.PenWidth = 15;
            removeCatBtn.Rounding = true;
            removeCatBtn.RoundingInt = 70;
            removeCatBtn.Size = new Size(247, 59);
            removeCatBtn.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            removeCatBtn.TabIndex = 66;
            removeCatBtn.Tag = "Cyber";
            removeCatBtn.TextButton = "Remove Category";
            removeCatBtn.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            removeCatBtn.Timer_Effect_1 = 5;
            removeCatBtn.Timer_RGB = 300;
            removeCatBtn.Click += removeCatBtn_Click;
            // 
            // categoryHdr
            // 
            categoryHdr.AutoSize = true;
            categoryHdr.BackColor = Color.White;
            categoryHdr.Font = new Font("Arial", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            categoryHdr.Location = new Point(114, 33);
            categoryHdr.Name = "categoryHdr";
            categoryHdr.Size = new Size(307, 33);
            categoryHdr.TabIndex = 67;
            categoryHdr.Text = "Add Product category";
            // 
            // textBox12
            // 
            textBox12.BackColor = Color.FromArgb(222, 224, 235);
            textBox12.BorderStyle = BorderStyle.None;
            textBox12.Font = new Font("Arial Narrow", 8F, FontStyle.Bold);
            textBox12.Location = new Point(114, 59);
            textBox12.Name = "textBox12";
            textBox12.ReadOnly = true;
            textBox12.Size = new Size(323, 19);
            textBox12.TabIndex = 68;
            textBox12.TabStop = false;
            // 
            // menuBtn
            // 
            menuBtn.BackColor = Color.White;
            menuBtn.FlatAppearance.BorderSize = 0;
            menuBtn.FlatStyle = FlatStyle.Flat;
            menuBtn.Image = Resources.menuIcon;
            menuBtn.Location = new Point(12, 16);
            menuBtn.Name = "menuBtn";
            menuBtn.Size = new Size(72, 58);
            menuBtn.TabIndex = 66;
            menuBtn.UseVisualStyleBackColor = false;
            menuBtn.Click += menuBtn_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { updateCategory, removeCategory, AddCategory });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(226, 100);
            // 
            // updateCategory
            // 
            updateCategory.Name = "updateCategory";
            updateCategory.Size = new Size(225, 32);
            updateCategory.Text = "Update Category";
            updateCategory.Click += updateCategory_Click;
            // 
            // removeCategory
            // 
            removeCategory.Name = "removeCategory";
            removeCategory.Size = new Size(225, 32);
            removeCategory.Text = "Remove Category";
            removeCategory.Click += removeCategory_Click;
            // 
            // AddCategory
            // 
            AddCategory.Name = "AddCategory";
            AddCategory.Size = new Size(225, 32);
            AddCategory.Text = "Add Category";
            AddCategory.Click += AddCategory_Click;
            // 
            // Category
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(529, 488);
            Controls.Add(menuBtn);
            Controls.Add(categoryHdr);
            Controls.Add(textBox12);
            Controls.Add(tabControl1);
            Controls.Add(label2);
            Name = "Category";
            Text = "Category Menu";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            updateCatPage.ResumeLayout(false);
            updateCatPage.PerformLayout();
            removeCatPage.ResumeLayout(false);
            removeCatPage.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private ReaLTaiizor.Controls.CyberTextBox cyberTextBox1;
        private Label label41;
        private ReaLTaiizor.Controls.CyberButton cyberButton3;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage updateCatPage;
        private Label categoryHdr;
        private TextBox textBox12;
        private Button menuBtn;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem updateCategory;
        private ToolStripMenuItem removeCategory;
        private TabPage removeCatPage;
        private ToolStripMenuItem AddCategory;
        private ReaLTaiizor.Controls.CyberButton updateCatBtn;
        private ReaLTaiizor.Controls.CyberButton removeCatBtn;
        private Label label1;
        public ReaLTaiizor.Controls.CyberTextBox cyberTextBox2;
        private ReaLTaiizor.Controls.DungeonComboBox updateCatCmb;
        private Label label39;
        public ReaLTaiizor.Controls.CyberTextBox cyberTextBox22;
        private TextBox newCatName;
        private ReaLTaiizor.Controls.DungeonComboBox removeCatCmb;
        private Label label3;
        public ReaLTaiizor.Controls.CyberTextBox cyberTextBox3;
        private TextBox catNameField;
    }
}