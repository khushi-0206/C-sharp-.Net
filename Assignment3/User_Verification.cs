using System;

class User
{
    public string Name{get;set;}
    public string PhoneNumber{get;set;}

}
class Program
{
    public static void Main()
    {
        try
        {
            Console.Write("Enter you name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Phone number: ");
            string phoneNumber = Console.ReadLine();

            User user = ValidatePhoneNumber(name, phoneNumber);
            Console.WriteLine("User verified Successfully");

        }
        catch(InvalidPhoneNumberException e)
        {
            Console.WriteLine(e.Message);
        }
    }
    public static User ValidatePhoneNumber(string name, string phoneNumber)
    {
        if (phoneNumber.Length!=10)
        {
            throw new InvalidPhoneNumberException("Invalid phone number");
        }
        User user = new User()
        {
            Name = name,
            PhoneNumber = phoneNumber
        };
        return user;
    }
}

class InvalidPhoneNumberException : Exception
{
    public InvalidPhoneNumberException()
    {
        
    }
    public InvalidPhoneNumberException(string message) : base(message)
    {
        
    }
}
