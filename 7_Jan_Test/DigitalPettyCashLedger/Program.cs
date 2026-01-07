class Program
{
    public static void Main(string[] args)
    {
        Ledger<IncomeTransaction> incomeLedger = new Ledger<IncomeTransaction>();
        Ledger<ExpenseTransaction> expenseLedger = new Ledger<ExpenseTransaction>();
        do
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            System.Console.WriteLine("---------------------- MENU ---------------------------");
            System.Console.WriteLine("1. Add Income");
            System.Console.WriteLine("2. Add Expense");
            System.Console.WriteLine("3. Show total");
            System.Console.WriteLine("4. Show all tranactions");
            System.Console.WriteLine("5. Exit");
            Console.ForegroundColor = ConsoleColor.White;

            System.Console.Write("Enter Choice: ");
            int choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                {
                    AddIncome(incomeLedger);
                    break;   
                }
                case 2:
                {
                    AddExpense(expenseLedger);
                    break;   
                }
                case 3:
                {
                    ShowTotals(incomeLedger,expenseLedger);
                    break;   
                }
                case 4:
                {
                    ShowAllTransactions(incomeLedger,expenseLedger);
                    break;   
                }
                case 5:
                {
                    System.Console.WriteLine("Existing the application.");
                    return;   
                }
                default:
                {
                    System.Console.WriteLine("Invalid choice..Please Try Again");
                    break;   
                }
            }
        }while(true);
    }
    public static void AddIncome(Ledger<IncomeTransaction> incomeLedger)
    {
        Console.Write("Enter Transaction ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Amount: ");
        int amount = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Description: ");
        string description = Console.ReadLine();

        Console.Write("Enter Source (Main Cash/Bank): ");
        string source = Console.ReadLine();

        IncomeTransaction income = new IncomeTransaction(
            id,
            DateTime.Now,
            amount,
            description,
            source
        );
        incomeLedger.AddTransaction(income);
        Console.WriteLine("Income added successfully!");
    }
    public static void AddExpense(Ledger<ExpenseTransaction> expenseLedger)
    {
        Console.Write("Enter Transaction ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Amount: ");
        int amount = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Description: ");
        string description = Console.ReadLine();

        Console.Write("Enter Category (Food/Stationery/Travel): ");
        string category = Console.ReadLine();

        ExpenseTransaction expense = new ExpenseTransaction(
            id,
            DateTime.Now,
            amount,
            description,
            category
        );
        expenseLedger.AddTransaction(expense);
        Console.WriteLine("Expense added successfully!!");
    }
    static void ShowTotals(Ledger<IncomeTransaction> incomeLedger, Ledger<ExpenseTransaction> expenseLedger)
    {
        int totalIncome = incomeLedger.CalculateTotal();
        int totalExpense = expenseLedger.CalculateTotal();
        int balance = totalIncome - totalExpense;

        Console.WriteLine("\n----- TOTALS -----");
        Console.WriteLine("Total Income: " + totalIncome);
        Console.WriteLine("Total Expense: " + totalExpense);
        Console.WriteLine("Net Balance: " + balance);
    }
    static void ShowAllTransactions(Ledger<IncomeTransaction> incomeLedger,Ledger<ExpenseTransaction> expenseLedger)
    {
        Console.WriteLine("\n----- ALL TRANSACTIONS -----");
        // Income Transactions
        List<IncomeTransaction> incomeTransactions = incomeLedger.GetAllTransactions();
        foreach(var transaction in incomeTransactions)
        {
            Console.WriteLine(transaction.GetSummary());
        }

        // Expense Tranactions
        List<ExpenseTransaction> expenseTransactions = expenseLedger.GetAllTransactions();
        foreach(var tranaction in expenseTransactions)
        {
            Console.WriteLine(tranaction.GetSummary());
        }
    }
}

