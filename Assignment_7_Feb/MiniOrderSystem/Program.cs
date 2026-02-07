public class Program
{
    public static void Main()
    {
        try
            {
                Customer customer = new Customer(1, "Khushi");
                Product laptop = new Product(1, "Laptop", 50000, 5);
                Product mouse = new Product(2, "Mouse", 500, 10);

                Coupon coupon = new Coupon("SAVE10", 10, 2000);

                Order order = new Order(customer);
                order.AddToCart(laptop, 1);
                order.AddToCart(mouse, 2);

                order.PlaceOrder(coupon);
                Payment.MakePayment(order.PayableAmount);

                Console.WriteLine("\n===== INVOICE =====");
                Console.WriteLine($"Invoice No: {order.InvoiceNumber}");
                Console.WriteLine($"Customer: {customer.Name}");
                Console.WriteLine($"Total: ₹{order.TotalAmount}");
                Console.WriteLine($"Payable: ₹{order.PayableAmount}");
            }
            catch (OrderException ex)
            {
                Console.WriteLine($"Order Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected Error: {ex.Message}");
            }
    }
}