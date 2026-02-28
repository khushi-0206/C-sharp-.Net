namespace AuthenticationDemo.Models
{
    public class ProductRepo
    {
        public static List<Product> cosmeticProducts = new List<Product>()
        {
            new Product
    {
        ProductId = 1,
        Name = "Matte Lipstick",
        Cost = 499,
        Description = "Long-lasting matte finish lipstick",
        Category = "Makeup",
        Brand = "Lakme",
        StockQuantity = 50,
        ImageUrl = "/Images/Logo.png"

    },
    new Product
    {
        ProductId = 2,
        Name = "Liquid Foundation",
        Cost = 799,
        Description = "Lightweight liquid foundation for smooth coverage",
        Category = "Makeup",
        Brand = "Maybelline",
        StockQuantity = 40,
        ImageUrl = "/Images/Logo.png"
    },
    new Product
    {
        ProductId = 3,
        Name = "Kajal Pencil",
        Cost = 299,
        Description = "Smudge-proof kajal for bold eyes",
        Category = "Eye Makeup",
        Brand = "Lakme",
        StockQuantity = 100,
        ImageUrl = "/Images/Logo.png"
    },
    new Product
    {
        ProductId = 4,
        Name = "Face Compact Powder",
        Cost = 399,
        Description = "Oil control compact powder",
        Category = "Makeup",
        Brand = "Swiss Beauty",
        StockQuantity = 60,
        ImageUrl = "/Images/Logo.png"
    },
    new Product
    {
        ProductId = 5,
        Name = "Aloe Vera Face Wash",
        Cost = 249,
        Description = "Gentle face wash with aloe vera",
        Category = "Skincare",
        Brand = "WOW",
        StockQuantity = 80,
        ImageUrl = "/Images/Logo.png"
    },
    new Product
    {
        ProductId = 6,
        Name = "Vitamin C Serum",
        Cost = 999,
        Description = "Brightening vitamin C serum",
        Category = "Skincare",
        Brand = "Mamaearth",
        StockQuantity = 30,
        ImageUrl = "/Images/Logo.png"
    },
    new Product
    {
        ProductId = 7,
        Name = "Hair Repair Shampoo",
        Cost = 349,
        Description = "Strengthens and repairs damaged hair",
        Category = "Hair Care",
        Brand = "Tresemme",
        StockQuantity = 70,
        ImageUrl = "/Images/Logo.png"
    },
    new Product
    {
        ProductId = 8,
        Name = "Hair Conditioner",
        Cost = 299,
        Description = "Smoothening hair conditioner",
        Category = "Hair Care",
        Brand = "Dove",
        StockQuantity = 65,
        ImageUrl = "/Images/Logo.png"
    },
    new Product
    {
        ProductId = 9,
        Name = "Perfumed Body Lotion",
        Cost = 399,
        Description = "Moisturizing body lotion with fragrance",
        Category = "Body Care",
        Brand = "Nivea",
        StockQuantity = 55,
        ImageUrl = "/Images/Logo.png"
    },
    new Product
    {
        ProductId = 10,
        Name = "Nail Paint",
        Cost = 199,
        Description = "Glossy nail polish with quick dry formula",
        Category = "Nail Care",
        Brand = "Colorbar",
        StockQuantity = 120,
        ImageUrl = "/Images/Logo.png"
    }
        };
        
        public List<Product> GetAllCosmeticProducts()
        {
            return cosmeticProducts;
        }
    }
}
