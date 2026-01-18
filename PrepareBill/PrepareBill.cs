class PrepareBill
{
    readonly private IDictionary<CommodityCategory,double> _taxRates;
    public PrepareBill()
    {
        _taxRates = new Dictionary<CommodityCategory,double>();
    }
    public void SetTaxRates(CommodityCategory category, double taxRate)
    {
        if (!_taxRates.ContainsKey(category))
        {
            _taxRates.Add(category,taxRate);
        }
    }
    public double CalculateBillAmount(IList<Commodity> items)
    {
        double totalAmount = 0;
        foreach(var item in items)
        {
            if (!_taxRates.ContainsKey(item.Category))
            {
                throw new ArgumentException("Tax rate not found for category");
            }
            double baseAmount = item.CommodityQuantity * item.CommodityPrice;
            double tax = baseAmount * _taxRates[item.Category];
            totalAmount += baseAmount + tax;
        }
        return totalAmount;
    }
}