abstract public class Transaction:IReportable
{
    public int TransactionId{get;set;}
    public DateTime TransactionDate{get;set;}
    public int Amount{get;set;}
    public string Description{get;set;}
    public Transaction(int id, DateTime date, int amount, string description)
    {
        TransactionId = id;
        TransactionDate = date;
        Amount = amount;
        Description = description;

    }
    abstract public string GetSummary();
}