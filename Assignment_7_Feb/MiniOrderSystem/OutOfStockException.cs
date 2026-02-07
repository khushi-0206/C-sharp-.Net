public class OutOfStockException : OrderException
{
    public OutOfStockException()
    {
        
    }
    public OutOfStockException(string message):base($"Product is Out of Stock")
    {
        
    }
}