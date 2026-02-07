public class OrderItem
    {
        public Product Item { get; }
        public int Quantity { get; }

        public decimal TotalPrice => Item.Price * Quantity;

        public OrderItem(Product product, int quantity)
        {
            Item = product;
            Quantity = quantity;
        }
    }