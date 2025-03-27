using System;
using BusinessLogic;

namespace inventoryManagement
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Computer Inventory Management");


            //list initialization

            //testing vlaues
            Console.WriteLine("TEST");
            inventoryProcess.productName.Add("test");
            inventoryProcess.productName.Add("tes2t");
            inventoryProcess.productQty.Add(5);
            inventoryProcess.productQty.Add(3);
            inventoryProcess.productPrice.Add(67);
            inventoryProcess.productPrice.Add(44);

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
                        retry =tryAgain();
                        break;

                    default:

                        break;
                }
            } while (retry==true);
            
        }

        static public Boolean tryAgain()
        {
            Boolean tryAgain = false;
            Console.WriteLine("Do you want to run the program again?  Y/N");
            String input = Console.ReadLine();
           
            if (input.ToUpper().Equals("Y"))
            {
                tryAgain = true;
            }
            else if(input.ToUpper().Equals("N"))
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
            String pName;
            int pQty=0;
            double pPrice=0;

            Console.WriteLine("Please enter a product name");
            pName = Console.ReadLine();
            try
            {
                Console.WriteLine("Please enter its quantity");
                pQty = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter its Price");
                pPrice = Convert.ToDouble(Console.ReadLine());


            }
            catch (FormatException e)
            {
         
                Console.WriteLine("ERROR! Please enter a number.");
            }

            inventoryProcess.addItemToList(pName,pQty,pPrice);



        }


        static public void viewStocks()
        {
     
            if (inventoryProcess.checkStocksAmount() == true)
            {
                Console.WriteLine("Your Stocks is empty please add stocks");
            }  else   {
                Console.WriteLine("Product Name\t  Qty \t Price \t");
                for (int i = 0; i < inventoryProcess.productName.Count(); i++)
                {
                    Console.WriteLine("  " + inventoryProcess.productName[i] + " [" + (i + 1) + "]" + " \t  " + Convert.ToString(inventoryProcess.productQty[i]) + "\t " + Convert.ToString(inventoryProcess.productPrice[i]));

                }
            }

         
           
        }

        static public void updateStocks()
        {
            if(inventoryProcess.checkStocksAmount() == true)
            {
                Console.WriteLine("Your Stocks is empty please add stocks");
            }
            else
            {
                viewStocks();

                Console.WriteLine("Please select  the product id  that you want to update: ");
                int input = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("You've selected " + inventoryProcess.productName[input - 1] + " What values do you want to change? ");
                Console.WriteLine("productName[1]\t product quantity[2] \t product price[3] \t  all of them[4]");
                int choice = Convert.ToInt16(Console.ReadLine());
                String newProductName;
                int newProductQty = 0;
                Double newProductPrice = 0;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter new value for product Name");
                        newProductName = Console.ReadLine().Trim();
                        inventoryProcess.updateProductNameAtProdId(newProductName, input - 1);
                        break;

                    case 2:
                        Console.WriteLine("Enter new value for product Quantity");
                        newProductQty = Convert.ToInt32(Console.ReadLine().Trim());
                        inventoryProcess.updateProductQtyAtProdId(newProductQty, input - 1);

                        break;

                    case 3:
                        Console.WriteLine("Enter new value for product price");
                        newProductPrice = Convert.ToDouble(Console.ReadLine().Trim());
                        inventoryProcess.updateProductPriceAtProdId(newProductPrice, input - 1);
                        break;

                    case 4:
                        Console.WriteLine("Enter new value for product Name");
                        newProductName = Console.ReadLine().Trim();
                        Console.WriteLine("Enter new value for product Quantity");
                        newProductQty = Convert.ToInt32(Console.ReadLine().Trim());
                        Console.WriteLine("Enter new value for product price");
                        newProductPrice = Convert.ToDouble(Console.ReadLine().Trim());


                        inventoryProcess.updateAllAtProdId(newProductName, newProductQty, newProductPrice, input - 1);
                        break;
                    default:
                        Console.WriteLine("Error Please enter the required input");

                        break;

                }
            }
               


        }
        static public void removeItem()
        {
            if (inventoryProcess.checkStocksAmount())
            {
                Console.WriteLine("Your Stocks is empty please add stocks");
            }
            else {
                viewStocks();

                Console.WriteLine("Please select  the product id  that you want to remove: ");
                int input = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Are you sure you want to remove the product: " + inventoryProcess.productName[input - 1] + "? Y/N");
                String ans = Console.ReadLine();

                if (ans.ToUpper().Equals("Y"))
                {
                    inventoryProcess.removeProduct(input - 1);
                    Console.WriteLine("Item removed succesfully");
                }
                else if (ans.ToUpper().Equals("N"))
                {
                    Console.WriteLine("Action cancelled");
                }
                else
                {
                    Console.WriteLine("ERROR! Please input the requested value");
                }

            }

        }
    }
}
