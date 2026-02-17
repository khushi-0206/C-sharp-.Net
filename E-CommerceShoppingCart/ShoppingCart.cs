public class ShoppingCart<T> where T: Product
{
    private Dictionary<T,int> _cartItems = new Dictionary<T, int>();
    public void AddToCart(T product, int quantity)
    {
        if (_cartItems.ContainsKey(product))
        {
            _cartItems[product] += quantity;
        }
        else
        {
            _cartItems.Add(product,quantity);
        }
        
    }
    public double CalculateTotal(Func<T,double,double> discountCalculator = null)
    {
        double total = 0;
        foreach(var item in _cartItems)
        {
            double price = item.Key.Price * item.Value;
            if(discountCalculator != null)
            {
                price = discountCalculator(item.Key,price);
            }
            total += price; 
        }
        return total;
    }
    public List<T> GetTopExpensiveItems(int n)
    {
        var expensiveItems = _cartItems.OrderByDescending(i => i.Key.Price).Select(i => i.Key).Take(n).ToList();
        return expensiveItems;
    }
}