public class Ledger<T> where T:Transaction
{
    private List<T> transactions;
    public Ledger()
    {
        transactions = new List<T>();
    }
    public void AddTransaction(T transaction)
    {
        transactions.Add(transaction);
    }
    public List<T> GetTransactionByDate(DateTime date)
    {
        List<T> result = new List<T>();
        for (int i=0;i<transactions.Count;i++)
        {
            if (transactions[i].TransactionDate.Date == date.Date)
            {
                result.Add(transactions[i]);
            }
        }
        return result;
    }
    public int CalculateTotal()
    {
        int total = 0;
        foreach (var t in transactions)
        {
            total = total +  t.Amount;
        }
        return total;
    }

    public List<T> GetAllTransactions()
    {
        return transactions;
    }
}