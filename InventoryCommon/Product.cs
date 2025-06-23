namespace InventoryCommon
{
    public class Product
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public string supplierId { get; set; }

        public double Price { get; set; }

        public string category { get; set; }

        public DateOnly dateModified { get; set; }

    }
}
