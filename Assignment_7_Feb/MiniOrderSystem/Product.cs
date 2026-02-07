public class Product
{
    private readonly object stockLock = new object();
    public int Id{get;set;}
    public string Name{get;set;}
    public decimal Price{get;set;}
    public int Stock{get;set;}

    public Product(int id, string name,decimal price, int stock)
    {
        Id = id;
        Name = name;
        Price = price;
        Stock = stock;
    }
    public void DeductStock(int quantity)
    {
        lock (stockLock)
        {
            if (Stock < quantity)                    
                throw new OutOfStockException(Name);
            Stock -= quantity;
        }
    }

}