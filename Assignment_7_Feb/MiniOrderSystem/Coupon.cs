public class Coupon
{
    public string Code{get;set;}
    public decimal DiscountPercentage{get;set;}
    public decimal MinimumOrderAmount{get;set;}
    public Coupon(string code, decimal discountPercentage, decimal minAmount)
    {
        Code = code;
        DiscountPercentage = discountPercentage;
        MinimumOrderAmount = minAmount;
    }

    public decimal Apply(decimal total)
    {
        if(total < MinimumOrderAmount)
        {
            throw new InvalidCouponException("Order amount is loww for this coupon");
        }
        return total - (total * DiscountPercentage /100);
    }
}