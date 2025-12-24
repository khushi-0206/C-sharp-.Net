// See https://aka.ms/new-console-template for more information

using Day6Assignment2;

CabDetails cabDetailsObj = new CabDetails();
Console.WriteLine("Enter the booking id: ");
cabDetailsObj.BookingId = Console.ReadLine();

bool validateId = cabDetailsObj.ValidateBookingId();
if (!validateId)
{
    Console.WriteLine("Invalis Booking id");
    return;
}

Console.WriteLine("Enter Cab type: ");
cabDetailsObj.CabType = Console.ReadLine();

Console.WriteLine("Enter the distance: ");
cabDetailsObj.Distance = double.Parse(Console.ReadLine());

Console.WriteLine("Enter the wating time in minutes: ");
cabDetailsObj.WatingTime= Int32.Parse(Console.ReadLine());

double fareAmount = cabDetailsObj.CalculateFareAmount();

Console.WriteLine("The fare Amount is: {0:F2}", fareAmount);