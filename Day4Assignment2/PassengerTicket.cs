using System.Runtime.Serialization;

public class PassengerTicket
{
    public int PassengerId{get; set;}
    public string PassengerName{get; set;}
    public int Age{get; set;}
    public int TravelType{get; set;}
    public int TravelClass{get; set;}
    public double BaseFare{get; set;}
    public double FinalFare{get; set;}
    public double DiscountAmount{get; set;}
    public int IsGovernmentEmployee{get; set;}
    public string BookingStatus{get;set;}
    public string TravelTypeName{get; set;}
    public string TravelClassName{get; set;}
    public bool ValidateAge()
    {
        if (Age < 5)
        {
            Console.WriteLine("Free Ticket – No Booking Required");
            return false;
        }
        else if (Age > 80)
        {
            Console.WriteLine("Medical Clearance Required");
            return false;
        }
        return true;
    }
    
    public void SelectTravelType()
    {
        switch (TravelType)
        {
            case 1:
            {
                TravelTypeName = "Bus";
                Console.WriteLine("------ choose class type --------");
                Console.Write("1. Sleeper\t2. Seater\nEnter choice: ");
                TravelClass = Int32.Parse(Console.ReadLine());
                switch (TravelClass)
                {
                    case 1:
                    {
                        TravelClassName = "Sleeper";
                        FinalFare = BaseFare * 1.2;
                        break;
                    }
                    case 2:
                    {
                        TravelClassName = "Seater";
                        FinalFare = BaseFare * 1.0;
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Invalid choice");
                        break;   
                    }
                }
                
                break;
            }
            case 2:
            {
                TravelTypeName = "Train";
                Console.WriteLine("------ choose class type --------");
                Console.Write("1. General\t2. Sleeper\t3.AC\nEnter choice: ");
                TravelClass = Int32.Parse(Console.ReadLine());
                switch (TravelClass)
                {
                    case 1:
                    {
                        TravelClassName = "General";
                        FinalFare = BaseFare * 1.0;
                        break;
                    }
                    case 2:
                    {
                        TravelClassName = "Sleeper";
                        FinalFare = BaseFare * 1.3;
                        break;
                    }
                    case 3:
                    {
                        TravelClassName = "AC";
                        FinalFare = BaseFare * 1.6;
                        break;   
                    }
                    default:
                    {
                        Console.WriteLine("Invalid choice");
                        break;   
                    }
                }
                break;
            }
            case 3:
            {
                TravelTypeName = "Flight";
                Console.WriteLine("------ choose class type --------");
                Console.Write("1. Economy\t2. Business\nEnter choice: ");
                TravelClass = Int32.Parse(Console.ReadLine());

                switch (TravelClass)
                {
                    case 1:
                    {
                        TravelClassName = "Economy";
                        FinalFare = BaseFare * 2.5;
                        break;
                    }
                    case 2:
                    {
                        TravelClassName = "Business";
                        FinalFare = BaseFare * 3.5;
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Invalid choice");
                        break;   
                    }
                }
                break;
            }
            default:
            {
                Console.WriteLine("Invalid choice");
                break;   
            }
        }
    }
    public void DiscountCalculation()
    {
        if (Age >= 60)
        {
            DiscountAmount = FinalFare * 0.30;
        }
        else if (IsGovernmentEmployee==1)
        {
            DiscountAmount = FinalFare * 0.15;
        }
        else if(Age>=5 && Age <= 12)
        {
            DiscountAmount = FinalFare * 0.50;
        }
        else
        {
            DiscountAmount = 0;
        }
    }
    public void FareCalculationAfterDiscount()
    {
        FinalFare = FinalFare - DiscountAmount;
    }
    public void BookingStatusCheck()
    {
        if(FinalFare >= 10000)
        {
            if(TravelType == 3)
            {
                BookingStatus = "Confirmed";
            }
            else
            {
                BookingStatus = "Waiting List";
            }
        }
        else
        {
            BookingStatus = "Confirmed";
        }
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Passenger Id: {0}",PassengerId);
        Console.WriteLine("Passenger Name: {0}",PassengerName);
        Console.WriteLine("Passenger Age: {0}",Age);
        Console.WriteLine("Travel Type: {0}",TravelTypeName);
        Console.WriteLine("Travel Class: {0}",TravelClassName);
        Console.WriteLine("Base Fare: {0}",BaseFare);
        Console.WriteLine("Final Fare: {0}",FinalFare);
        Console.WriteLine("Discount Applied: {0}",DiscountAmount);
        Console.WriteLine("Booking Status: {0}",BookingStatus);
    }
}