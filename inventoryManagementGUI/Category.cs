using BusinessLogic;
using Microsoft.Identity.Client;
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
    public partial class Category : Form
    {
        private mainForm mainFormRef;
        inventoryProcess inventoryProcess;
        public Category(mainForm mainFormRef, inventoryProcess _inventoryProcess)
        {
            InitializeComponent();
            inventoryProcess = _inventoryProcess;
            this.mainFormRef = mainFormRef;
            this.FormClosed += AddProductForm_FormClosed;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void AddProductForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mainFormRef.loadCategoriesNSsupplier();


        }
        private void cyberButton3_Click(object sender, EventArgs e)
        { string catName = catNameField.Text.Trim();
            if (catName != "")
            {
                inventoryProcess.addCategory(catNameField.Text);
                MessageBox.Show("Category Added Successfully");
            }
           
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            var buttonLocation = menuBtn.PointToScreen(new Point(0, menuBtn.Height));
            contextMenuStrip1.Show(buttonLocation);
        }

        private void updateCategory_Click(object sender, EventArgs e)
        {

            categoryHdr.Text = "Update Category";
            tabControl1.SelectedTab = updateCatPage;
            setupUpdateCategoryPage();

        }



        public void setupUpdateCategoryPage()
        {
            updateCatCmb.DataSource = inventoryProcess.GetCategoryNames();


        }

        private void removeCategory_Click(object sender, EventArgs e)
        {
            categoryHdr.Text = "Remove Category";
            tabControl1.SelectedTab = removeCatPage;
            setupRemoveCategoryPage();
        }

        public void setupRemoveCategoryPage()
        {
            removeCatCmb.DataSource = inventoryProcess.GetCategoryNames();
        }

        private void AddCategory_Click(object sender, EventArgs e)
        {
            categoryHdr.Text = "Add Category";
            tabControl1.SelectedTab = tabPage1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void updateCatCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("CHANGED");
            newCatName.Text = updateCatCmb.Text;
        }

        private void removeCatBtn_Click(object sender, EventArgs e)
        {
            inventoryProcess.removeCategory(removeCatCmb.Text);
            MessageBox.Show("Category Removed Successfully");
            setupRemoveCategoryPage();


        }

        private void updateCatBtn_Click(object sender, EventArgs e)
        {
            inventoryProcess.updateCategory( newCatName.Text, updateCatCmb.Text);
            MessageBox.Show("Category Updated Successfully");
            setupUpdateCategoryPage();
        }
    }
}
