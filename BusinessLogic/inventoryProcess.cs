namespace BusinessLogic
{
    public class inventoryProcess
    {

        public static List<String> productName = new List<String>();
        public static List<int> productQty = new List<int>();
        public static List<Double> productPrice = new List<Double>();

        public static bool checkStocksAmount()
        {

            return productName.Count==0;
        }

        public static void addItemToList(String ProductName, int ProductQty, Double ProductPrice)
        {
            productName.Add(ProductName);
            productQty.Add(ProductQty);
            productPrice.Add(ProductPrice);
          
        }

        public static void updateAllAtProdId(String newProductName, int newProductQty, Double newProductPrice, int id)
        {
            productName[id] = newProductName;
            productQty[id] = newProductQty;
            productPrice[id] = newProductPrice;
        }

        public static void updateProductNameAtProdId(String newProductName, int id)
        {
            productName[id] = newProductName;
        }

        public static void updateProductQtyAtProdId(int newProductQty, int id)
        {
            productQty[id] = newProductQty;
        }
        public static void updateProductPriceAtProdId(Double newProductPrice, int id)
        {
            productPrice[id] = newProductPrice;
        }

        public static void removeProduct(int id)
        {
            inventoryProcess.productName.RemoveAt(id - 1);
            inventoryProcess.productQty.RemoveAt(id - 1);
            inventoryProcess.productPrice.RemoveAt(id - 1);

        }

    }
}
