// See https://aka.ms/new-console-template for more information

while (true)
{
    System.Console.WriteLine("----------------- QuickMart Traders ---------------");
    System.Console.WriteLine("1. Create New Tranaction (Enter Purchases & Selling Details)\n2. View Last Transaction\n3.Calculate Profit/Loss\n4.Exit");
    System.Console.WriteLine("Enter your choice: ");
    int choice = Int32.Parse(Console.ReadLine());
    SaleTransaction stObj = null;
    switch (choice)
    {
        case 1:
        {
            stObj = new SaleTransaction();
            Console.Write("Enter Invoice No: ");
            stObj.InvoiceNo = Console.ReadLine();

            Console.Write("Enter Customer name: ");
            stObj.CustomerName = Console.ReadLine();

            Console.Write("Enter Item Name: ");
            stObj.ItemName = Console.ReadLine();

            Console.Write("Enter Quantity: ");
            stObj.Quantity = Int32.Parse(Console.ReadLine());

            Console.Write("Enter Purchase Amount: ");
            stObj.PurchaseAmount = decimal.Parse(Console.ReadLine());

            Console.Write("Enter Selling Amount: ");
            stObj.SellingAmount = decimal.Parse(Console.ReadLine());

            SaleTransaction.lastTransaction = stObj;
            SaleTransaction.hasLastTransaction = true;
            Console.WriteLine("Transaction saved successfully");

            Console.WriteLine("status: {0}",stObj.ProfitOrLossStatus);
            Console.WriteLine("Profit/Loss Amount: {0}",stObj.ProfitOrLossAmount);
            Console.WriteLine("Profit Margin (%): {0:F2}",stObj.PofitMarginPercent);
            
            break;
        }
        case 2:
        {
            if (SaleTransaction.hasLastTransaction)
            {
                Console.WriteLine("------------------- Last Transaction --------------- ");
                Console.WriteLine("InvoiceNo: {0}",SaleTransaction.lastTransaction.InvoiceNo);
                Console.WriteLine("Customer: {0}",SaleTransaction.lastTransaction.CustomerName);
                Console.WriteLine("Item: {0}",SaleTransaction.lastTransaction.ItemName);
                Console.WriteLine("Quantity: {0}",SaleTransaction.lastTransaction.Quantity);
                Console.WriteLine("IPurchase Amount: {0}",SaleTransaction.lastTransaction.PurchaseAmount);
                Console.WriteLine("Selling Amount: {0}",SaleTransaction.lastTransaction.SellingAmount);
                Console.WriteLine("Staus: {0}",SaleTransaction.lastTransaction.ProfitOrLossStatus);
                Console.WriteLine("Profit/Loss Amount: {0}",SaleTransaction.lastTransaction.ProfitOrLossAmount);
                Console.WriteLine("Profit Margin (%): {0:F2}",SaleTransaction.lastTransaction.PofitMarginPercent);

            }
            else
            {
                System.Console.WriteLine("No transaction. Please create new transaction");
            }
            
            break;
        }
        case 3:
        {
            SaleTransaction.lastTransaction = null;
            SaleTransaction.hasLastTransaction = false;
            Console.Write("Clear last transaction");
            break;  
        }
        case 4:
        {
            Console.Write("Thank you. Application closed normally");
            return;

        }
        default:
        {
            Console.Write("Invalid choice!!");
            break;  
        }
    }
}