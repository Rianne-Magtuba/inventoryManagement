using System;
using System.Data;
using BusinessLogic;
using InventoryCommon;

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

            inventoryProcess.AddProduct(pId, pName, pQty, pSupplier, pPrice);



        }

        static void removeItem()
        {
            if (inventoryProcess.checkProductAmount())
            {
                Console.WriteLine("ERROR No Product found to remove");
            }
            else
            {
                viewStocks();

                Console.WriteLine("Please select  the product id  that you want to remove: ");
                string input = Console.ReadLine();
                string productName = inventoryProcess.getProductName(input);

                if (inventoryProcess.removeProduct(input) == false)
                {
                    Console.WriteLine("ERROR! Please enter an ID within the list");
                }
                else
                {
                    Console.WriteLine("Are you sure you want to remove" + productName + " ? ");
                    string choice = Console.ReadLine();
                    string toUp = choice.ToUpper();
                    if (toUp == "Y")
                    {
                        Console.WriteLine("Product remove succesfully.");
                    }
                    else
                    {
                        Console.WriteLine("Product removal cancelled.");
                    }


                }
                    ;




            }

        }
        static public void viewStocks()
        {
            string space = " ";   
            List<Product> products = inventoryProcess.getProducts();
            if (inventoryProcess.checkStocksAmount() == true)
            {
                Console.WriteLine("Your Stocks is empty please add stocks");
            }
            else
            {
                Console.WriteLine("  Product Name \t | Product ID \t |  Product Quantity \t  | Product Price \t | Product Supplier ");
                foreach (var product in products)
                {
                    Console.WriteLine( "  " + product.Name  +space + "\t|  " + space + product.Id +  "\t \t| " + space +  product.Quantity + space + "\t \t| " + space + product.Price + space + "\t \t| " + space + product.Supplier );
                }

            }

          
        }
        
        public static void searchProducts(string productId)
        {
            List<Product> products = inventoryProcess.searchProduct(productId);
            if(inventoryProcess.productExist(productId)) {

                foreach (var product in products)
                {
                    Console.WriteLine(product.Name + "\t" + product.Id + "\t" + product.Quantity + "\t" + product.Price + "\t"  + product.Supplier );
                }
            }
            else
            {
                Console.WriteLine("The product doesn't exist");
            }
        }
      
    
        public static void updateStocks()
        {
       
            string idIn = "";
            bool productExist = false;
            do
            {
                viewStocks();
                Console.WriteLine("Please enter the product id that you want to update. ");
                idIn = Console.ReadLine();
                if (inventoryProcess.productExist(idIn))
                {
                    productExist = true;

                }
                else
                {
                    Console.WriteLine("ERROR please input a product that's in the list. ");
                    productExist = false;
                }

            } while (productExist == false);
            


            string selectedName = inventoryProcess.getProductName(idIn);
          

            Console.WriteLine("Please select what to update in " + selectedName);

            searchProducts(idIn);
            Console.WriteLine("[1]Update product name  \t [2] Update product id \t [3] Update product quantity  \t [4 ]Update product price   \t [5] Update product supplier \t [6] update all values  ");
            int choice = Convert.ToInt16(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Please enter the new Product Name");
                    string newProductName = Console.ReadLine();
                    if (inventoryProcess.updateProductName( idIn, newProductName) ==false)
                    {
                        Console.WriteLine(" Error Product doesn't exist please try again. ");
                    }
                    else
                    {
                        Console.WriteLine("Product name changed succesfully from "  + selectedName + " to " + newProductName);

                    }

                    break;

                case 2:
                    Console.WriteLine("Please enter the new Product Id");
                    string newProductId = Console.ReadLine();
                    if (inventoryProcess.updateProductId(idIn, newProductId) == false)
                    {
                        Console.WriteLine(" Error Product doesn't exist please try again. ");
                    }
                    else
                    {
                        Console.WriteLine("Product ID changed succesfully from " + idIn + " to " + newProductId);

                    }
                    break;
                case 3:
                    Console.WriteLine("Please enter the new Product Quantity");
                    int newProductQuantity = 0;

                    try
                    {
                        newProductQuantity = Convert.ToInt32(Console.ReadLine());

                        if(newProductQuantity <= 0)
                        {
                            Console.WriteLine("Error Please ente a valid number");
                            break;
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Error Please enter Valid number.");
                    }

                    if (inventoryProcess.updateProductQuantity(idIn, newProductQuantity) == false)
                    {
                        Console.WriteLine(" Error Product doesn't exist please try again. ");
                    }
                    else
                    {
                        Console.WriteLine("Product quantity changed succesfully");

                    }
                    break;

                case 4:
                    Console.WriteLine("Please enter the new Product price");
                    double newProductPrice = 0;
                    try
                    {
                        newProductPrice = Convert.ToDouble(Console.ReadLine());
                        if (newProductPrice <= 0)
                        {
                            Console.WriteLine("Error Please ente a valid number");
                            break;
                        }
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine("Error Please enter Valid number.");
                    }


                    if (inventoryProcess.updateProductPrice(idIn, newProductPrice) == false)
                    {
                        Console.WriteLine(" Error Product doesn't exist please try again. ");
                    }
                    else
                    {
                        Console.WriteLine("Product price changed succesfully");

                    }
                    break;

                case 5:
                    Console.WriteLine("Please enter the new Product Supplier");
                    string newProductSupplier  = Console.ReadLine();


                    if (inventoryProcess.updateProductSupplier(idIn, newProductSupplier) == false)
                    {
                        Console.WriteLine(" Error Product doesn't exist please try again. ");
                    }
                    else
                    {
                        Console.WriteLine("Product Supplier changed succesfully");

                    }
                    break;
                case 6:

                    Console.WriteLine("Please enter new product name ");
                    string NewProductname = Console.ReadLine(); 
                    Console.WriteLine("Please enter new product ID ");
                    string NewProductId = Console.ReadLine();
                    int NewProductQuantity = 0;
                    double NewProductPrice = 0;
                    try
                    {

                        Console.WriteLine("Please enter new product Quantity ");
                        NewProductQuantity = Convert.ToInt32(Console.ReadLine());

                    
                        
                        Console.WriteLine("Please enter new product Price ");
                        NewProductPrice = Convert.ToInt32(Console.ReadLine());
                        if (NewProductQuantity<=0 || NewProductPrice <= 0)
                        {
                            Console.WriteLine("ERROR Please enter a valid number");
                            break;
                        }

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("ERROR Please enter a valid number");
                    }
                   
                    Console.WriteLine("Please enter new product Supplier ");
                    string newSupplier = Console.ReadLine();

                    if (inventoryProcess.updateAllProducts(idIn, NewProductname,NewProductId, NewProductQuantity, NewProductPrice, newSupplier) == false)
                    {
                        Console.WriteLine(" Error Product doesn't exist please try again. ");
                    }
                    else
                    {
                        Console.WriteLine("All values of the product with product id: " +idIn + " is changed succesfully");

                    }
                    break;

                default:
                    Console.WriteLine("Error Please enter numbers within ranged");
                    break;

            }

        }
    }


}
