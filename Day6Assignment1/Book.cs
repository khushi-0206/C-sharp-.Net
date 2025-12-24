using System;

namespace Day6Assignment1;

public class Book
{
    string title;
    string author;
    int numPages;
    DateTime dueDate;
    DateTime returnedDate;
    public Book()
    {
        
    }
    public Book(string title, string author, int numPages, DateTime dueDate, DateTime returnedDate)
    {
        this.title = title;
        this.author = author;
        this.numPages = numPages;
        this.dueDate = dueDate;
        this.returnedDate = returnedDate;
    }
    public double AveragePagesReadPerDay(int daysToRead)
    {
        return numPages/daysToRead;
    }
    public double CalculateLateFee(double dailyLateFeeRate)
    {
        int numDaysLate = (returnedDate - dueDate).Days;
        return numDaysLate * dailyLateFeeRate;
    }
}
