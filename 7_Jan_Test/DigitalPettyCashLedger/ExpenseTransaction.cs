class ExpenseTransaction : Transaction
{
    public string Category{get;set;}
    public ExpenseTransaction(int id, DateTime date, int amount, string description, string category) : base(id,date,amount,description)
    {
        Category = category;
    }
    public override string GetSummary()
    {
        string summary = "Amount Spent: " + Amount +"\nCategory: " + Category +"\nDescription: " + Description;
        return summary;
    }
}