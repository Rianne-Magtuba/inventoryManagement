using BusinessLogic;
using DataLogic;
using InventoryCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.Serialization.Json;

namespace inventoryManagement
{
    internal class Program
    {
         static inventoryProcess inventoryProcess = new inventoryProcess();
        static void Main(string[] args)
        {
            Console.WriteLine("Computer Inventory Management");


            //list initialization




            Boolean retry = false;
            do
            {
                Console.WriteLine("Please Select An Action");
                Console.WriteLine("View Stocks[1]");
                Console.WriteLine("Add Item[2]");
                Console.WriteLine("Update Stocks[3]");
                Console.WriteLine("Remove item[4]");
                int choice = Convert.ToInt16(Console.ReadLine());

                switch (choice)
                {
                    case 1:

                        viewStocks();
                        retry = tryAgain();
                        break;

                    case 2:
                        addItem();
                        retry = tryAgain();
                        break;

                    case 3:
                        updateStocks();
                        retry = tryAgain();
                        break;

                    case 4:

                        removeItem();
                        retry = tryAgain();
                        break;

                    default:

                        break;
                }
            } while (retry == true);

        }

        static public bool tryAgain()
        {
            Boolean tryAgain = false;
            Console.WriteLine("Do you want to run the program again?  Y/N");
            String input = Console.ReadLine();

            if (input.ToUpper().Equals("Y"))
            {
                tryAgain = true;
            }
            else if (input.ToUpper().Equals("N"))
            {
                tryAgain = false;
                Console.WriteLine("Program Terminated, Thank you");
            }
            else
            {
                Console.WriteLine("ERROR! Please input accordingly based on the given choices.");
                tryAgain = true;
            }

            return tryAgain;
        }

        static public void addItem()
        {
            string pId, pName, pSupplier;

            int pQty = 0;
            double pPrice = 0;

            Console.WriteLine("Please enter the product ID ");
            pId = Console.ReadLine();

            Console.WriteLine("Please enter the product name ");
            pName = Console.ReadLine();

            bool properInput = false;
            while (properInput!=true)
            {
                try
                {
                    Console.WriteLine("Please enter its quantity ");
                    pQty = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Please enter its Price ");
                    pPrice = Convert.ToDouble(Console.ReadLine());

                    properInput = true;



                }
                catch (FormatException e)
                {
             

                    Console.WriteLine("ERROR! Please enter a number.");
                    properInput = false;
                }
            }
            

            Console.WriteLine("Please enter the Supplier name ");
            pSupplier = Console.ReadLine();

            Console.WriteLine("Enter the product category ");
            string pCategory = Console.ReadLine();

            inventoryProcess.addProduct(pId, pName, pQty, pSupplier, pPrice, pCategory);



        }

        static void removeItem()
        {
            inventoryProcess inventoryProcess = new inventoryProcess();
        
            List<Product> products = inventoryProcess.getProducts();
            if (products.Count == 0)
            {
                Console.WriteLine("ERROR No Product found to remove");
            }
            else
            {
                viewStocks();

                Console.WriteLine("Please select  the product id  that you want to remove: ");
               var input = Console.ReadLine();
                //string productName = inventoryProcess.getProductName(input);
                if (inventoryProcess.removeProduct(input)==true)
                {
                    Console.WriteLine("Product removed succesfully");

                }
                else
                {
                    Console.WriteLine("Error cannot remove product");
                }
                    ;

            }
                    





        }
      
        static public void viewStocks()
        {
             inventoryProcess inventoryProcess = new inventoryProcess();
            string space = " ";   
            List<Product> products = inventoryProcess.getProducts();
            if (products.Count ==0)
            {
                Console.WriteLine("Your Stocks is empty please add stocks");
            }
            else
            {
                Console.WriteLine("  Product Name \t | Product ID \t |  Product Quantity \t  | Product Price \t | Product Supplier ");
                foreach (var product in products)
                {
                    Console.WriteLine( "  " + product.Name  +space + "\t|  " + space + product.Id +  "\t \t| " + space +  product.Quantity + space + "\t \t| " + space + product.Price + space + "\t \t| " + space + product.supplierId );
                }

            }


        }

        //public static void searchProducts(string productId)
        //{
        //    List<Product> products = inventoryProcess.searchProduct(productId);
        //    if(inventoryProcess.productExist(productId)) {

        //        foreach (var product in products)
        //        {
        //            Console.WriteLine(product.Name + "\t" + product.Id + "\t" + product.Quantity + "\t" + product.Price + "\t"  + product.Supplier );
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("The product doesn't exist");
        //    }
        //}


        public static void updateStocks()
        {
            viewStocks();
            Console.WriteLine("Please select product id of the product you want to update.");
            var id = Console.ReadLine();
            Console.WriteLine("Please enter the new product name.");
            var newProductName = Console.ReadLine();
            Console.WriteLine("Please enter new product Id.");
            var newProdId = Console.ReadLine();
            Console.WriteLine("Please enter new product quantity.");
            int newProdQty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter new product price.");
            double newProdPrice = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter new product supplier.");
            var newProdSupplier = Console.ReadLine();
            Console.WriteLine("Please enter new product category.");
            var newCategory = Console.ReadLine();

            inventoryProcess.updateProduct( newProductName, newProdId, newProdQty, newProdPrice, newProdSupplier, newCategory);


        }


    }


}
