// See https://aka.ms/new-console-template for more information

PassengerTicket ptObj = new PassengerTicket();
Console.Write("Enter Passenger Id: ");
ptObj.PassengerId = Int32.Parse(Console.ReadLine());

Console.Write("Enter Passenger Name: ");
ptObj.PassengerName = Console.ReadLine();

Console.Write("Enter Age: ");
ptObj.Age = Int32.Parse(Console.ReadLine());

if(!ptObj.ValidateAge()) return;

Console.Write("Enter Base Fare: ");
ptObj.BaseFare = double.Parse(Console.ReadLine());

Console.WriteLine("-----Choose Travel Type-------");
Console.WriteLine("1. Bus\t2.Train\t3.Flight");
Console.Write("Enter choice: ");
ptObj.TravelType = Int32.Parse(Console.ReadLine());

ptObj.SelectTravelType();

Console.Write("1.Yes\t2.No\nIs GovernmentEmployee: ");
ptObj.IsGovernmentEmployee = Int32.Parse(Console.ReadLine());

ptObj.DiscountCalculation();
ptObj.FareCalculationAfterDiscount();
ptObj.BookingStatusCheck();
ptObj.DisplayDetails();
