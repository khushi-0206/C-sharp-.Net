using System.Runtime.CompilerServices;

public class Order
{
    public static int InvoiceSeed = 1000;
    public string InvoiceNumber{get;set;}

    public Customer Customers{get;set;}
    public List<OrderItem> Items{get;set;} = new();
    public decimal TotalAmount{get;set;}
    public decimal PayableAmount{get;set;}

    public Order(Customer customer)
    {
        Customers = customer;
        InvoiceNumber = $"INV-{Interlocked.Increment(ref InvoiceSeed)}";
    }

    public void AddToCart(Product product, int quantity)
    {
        if (quantity <= 0)
        {
            throw new OrderException("Quantity must be greater than zero");
        }
        Items.Add(new OrderItem(product,quantity));
    }

    public void PlaceOrder(Coupon coupon = null)
    {
        if (!Items.Any())
        {
            throw new OrderException("Cart is Empty");
        }
        foreach(var item in Items)
        {
            if(item.Item.Stock < item.Quantity)
            {
                throw new OutOfStockException(item.Item.Name);
            }
        }
        foreach(var item in Items)
        {
            item.Item.DeductStock(item.Quantity);
        }
        TotalAmount = Items.Sum(i => i.TotalPrice);
        PayableAmount = coupon != null ? coupon.Apply(TotalAmount):TotalAmount;
    }
    


}