namespace energyEC.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public int CategoryId { get; set; }
        public string ProductDescription { get; set; }

        public string ProductImages { get; set; }
    }
}
