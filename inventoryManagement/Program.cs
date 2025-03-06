using System;

namespace inventoryManagement
{
    internal class Program
    {
         List<String> productName;
        List<int> productQty;
        List<Double> productPrice;
        static void Main(string[] args)
        {
            Console.WriteLine("Computer Inventory Management");
            
            Program program = new Program();
            //list initialization
            program.productName = new List<String>();
            program.productQty = new List<int>();
            program.productPrice = new List<Double>();

            //testing vlaues
            program.productName.Add("test");
            program.productName.Add("tes2t");
            program.productQty.Add(5);
            program.productQty.Add(3);
            program.productPrice.Add(67);
            program.productPrice.Add(44);

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
                        program.viewStocks();
                        retry = program.tryAgain();
                        break;

                    case 2:
                        program.addItem();
                        retry = program.tryAgain();
                        break;

                    case 3:
                        program.updateStocks();
                        retry = program.tryAgain();
                        break;

                    case 4:

                        program.removeItem();
                        retry = program.tryAgain();
                        break;

                    default:

                        break;
                }
            } while (retry==true);
            
        }

        public Boolean tryAgain()
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
        public void addItem()
        {
            String pName;
            int pQty;
            double pPrice;

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

         
        }
        
       
        public void viewStocks()
        {
            Console.WriteLine("Product Name\t| Qty \t| Price ");
            String space = "  ";
            for (int i =0; i < productName.Count(); i++)
            { 
                Console.WriteLine("  " + productName[i].Trim() + "        \t|    " + Convert.ToString(productQty[i]) + "\t|  "+ Convert.ToString(productPrice[i]));

            }
           
        }

        public void updateStocks()
        {
            Console.WriteLine("Product Name\t  Qty \t Price \t");
            for (int i = 0; i < productName.Count(); i++)
            {
                Console.WriteLine("  " + productName[i] + " [" + (i + 1) + "]" + " \t  " + Convert.ToString(productQty[i]) + "\t " + Convert.ToString(productPrice[i]));

            }
            Console.WriteLine("Please select  the product id  that you want to update: ");
            int input = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("You've selected " + productName[input-1] + " What values do you want to change? ");
            Console.WriteLine("productName[1]\t product quantity[2] \t product price[3] \t  all of them[4]");
            int choice = Convert.ToInt16(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter new value for product Name");
                    productName[input - 1] = Console.ReadLine().Trim();

                    break;

                case 2:
                    Console.WriteLine("Enter new value for product Quantity");
                    productQty[input - 1] = Convert.ToInt32(Console.ReadLine().Trim());
                    break;

                case 3:
                    Console.WriteLine("Enter new value for product price");
                    productPrice[input - 1] = Convert.ToDouble(Console.ReadLine().Trim());

                    break;

               case 4:
                    Console.WriteLine("Enter new value for product Name");
                    productName[input - 1] = Console.ReadLine().Trim();
                    Console.WriteLine("Enter new value for product Quantity");
                    productQty[input - 1] = Convert.ToInt32(Console.ReadLine().Trim());
                    Console.WriteLine("Enter new value for product price");
                    productPrice[input - 1] = Convert.ToDouble(Console.ReadLine().Trim());
               
                    break;
                default:
                    Console.WriteLine("Error Please enter the required input");

                    break;

            }


        }
        public void removeItem()
        {
         
            Console.WriteLine("Product Name\t  Qty \t Price \t");
            for (int i = 0; i < productName.Count(); i++)
            {
                Console.WriteLine("  " + productName[i] + " ["+ (i+1) + "]" + " \t  " + Convert.ToString(productQty[i]) + "\t " + Convert.ToString(productPrice[i]));

            }
            Console.WriteLine("Please select  the product id  that you want to remove: ");
            int input = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Are you sure you want to remove the product: " + productName[input-1] + "? Y/N");
            String ans = Console.ReadLine();

            if (ans.ToUpper().Equals("Y"))
            {
                productName.RemoveAt(input - 1);
                productQty.RemoveAt(input - 1);
                productPrice.RemoveAt(input - 1);
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
