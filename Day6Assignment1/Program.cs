// See https://aka.ms/new-console-template for more information

using Day6Assignment1;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("Enter the title: ");
string title = Console.ReadLine();

Console.Write("Enter the author: ");
string author = Console.ReadLine();

Console.Write("Enter the number of pages: ");
int numOfPages = Int32.Parse(Console.ReadLine());

Console.Write("Enter the due date {dd/mm/yyyy}: ");
DateTime dueDate = DateTime.Parse(Console.ReadLine());

Console.Write("Enter the return date {dd/mm/yyyy}: ");
DateTime returnDate = DateTime.Parse(Console.ReadLine());

Console.Write("Enter the days to read: ");
int daysToread = Int32.Parse(Console.ReadLine());

Console.Write("Enter the daily late fee rate: ");
int dailyLateFeeRate = Int32.Parse(Console.ReadLine());

Book bookObj = new Book(title,author,numOfPages,dueDate,returnDate);

double averagePageReadPerDay = bookObj.AveragePagesReadPerDay(daysToread);
double lateFee = bookObj.CalculateLateFee(dailyLateFeeRate);

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine("Average Pages Per Day: {0}",averagePageReadPerDay);
Console.WriteLine("Late Fee: {0}",lateFee);

Console.ForegroundColor = ConsoleColor.White;