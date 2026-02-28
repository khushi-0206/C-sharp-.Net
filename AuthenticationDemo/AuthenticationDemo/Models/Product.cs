namespace AuthenticationDemo.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public String Name{ get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public int StockQuantity { get; set; }
        public string ImageUrl { get; set; }
    }
}
