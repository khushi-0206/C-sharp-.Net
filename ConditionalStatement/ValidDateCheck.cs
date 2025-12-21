using System;

namespace ConditionalStatement;

public class ValidDateCheck
{
    public static void DateChecker()
    {
        Console.Write("Enter Day: ");
        int day = Int32.Parse(Console.ReadLine());
        Console.Write("Enter month: ");
        int month = Int32.Parse(Console.ReadLine());
        Console.Write("Enter Year: ");
        int year = Int32.Parse(Console.ReadLine());
        if(month>=1 && month <= 12)
        {
            if (month==1 || month==3 || month==5 || month==7 || month==8 || month==10|| month == 12)
            {
                if(day>=1 && day <= 31)
                {
                    Console.WriteLine("Date is valid");
                }
                else
                {
                    Console.WriteLine("Date is not valid");
                }
            }
            else if (month == 2)
            {
                if((year%4==0 && year%100!=0)|| (year % 400 == 0))
                {
                    if(day>=1 && day <= 29)
                    {
                        Console.WriteLine("Date is valid");
                    }
                    else
                    {
                        Console.WriteLine("not valid");
                  
                    }
                }
                else
                {
                    if(day>=1 && day<=28){
                        Console.WriteLine("Date is valid");
                    }
                    else
                    {
                        Console.WriteLine("Date is not valid");
                    }
                }
            }
            else
            {
                if(day>=1 && day <= 30)
                {
                        Console.WriteLine("Date is valid");
                }
                else
                {
                    Console.WriteLine("not valid");
                }
            }
            
        }
        else
        {
            Console.WriteLine("Not valid date...Please enter valid month");
        }
    }
}
