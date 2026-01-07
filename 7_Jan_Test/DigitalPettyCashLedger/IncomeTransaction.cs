class IncomeTransaction : Transaction
{
    public string Source{get;set;}
    public IncomeTransaction(int id, DateTime date, int amount, string description, string source):base(id,date,amount,description)
    {
        Source = source;
    }
    public override string GetSummary()
    {
        string summary = "Amount Received: "+ Amount + "\nSource: "+ Source + "\nDescription: "+Description;
        return summary;
    }
}