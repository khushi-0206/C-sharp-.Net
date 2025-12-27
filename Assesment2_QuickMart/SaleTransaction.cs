class SaleTransaction
{
    string invoiceNo;
    public string CustomerName{get;set;}
    public string ItemName{get;set;}
    int quantity;
    decimal purchaseAmount;
    decimal sellingAmount;
    public string InvoiceNo
    {
        get
        {
            return invoiceNo;
        }
        set
        {
            if (value != null)
            {
                invoiceNo = value;
            }
        }
    }
    public int Quantity
    {
        get
        {
            return quantity;
        }
        set
        {
            if(value > 0)
            {
                quantity = value;
            }
        }
    }
    public decimal PurchaseAmount
    {
        get
        {
            return purchaseAmount;
        }
        set
        {
            if(value > 0)
            {
                purchaseAmount = value;
            }
        }
    }
    public decimal SellingAmount
    {
        get
        {
            return sellingAmount;
        }
        set
        {
            if(value >= 0)
            {
                sellingAmount = value;
            }
        }
    }
    public string ProfitOrLossStatus
    {
        get
        {
            if(sellingAmount > purchaseAmount)
            {
                return "Profit";
            }
            else if(sellingAmount < purchaseAmount)
            {
                return "Loss";
            }
            else
            {
                return "Break-Even";
            }
        }
    }
    public decimal ProfitOrLossAmount
    {
        get
        {
            if(sellingAmount > purchaseAmount)
            {
                return sellingAmount -  purchaseAmount;
            }
            else if(sellingAmount < purchaseAmount)
            {
                return purchaseAmount - sellingAmount;
            }
            else
            {
                return 0;
            }
        }
    }
    public decimal PofitMarginPercent
    {
        get
        {
            return (ProfitOrLossAmount/PurchaseAmount)*100;
        }
    }
    public static SaleTransaction lastTransaction;
    public static bool hasLastTransaction;



}