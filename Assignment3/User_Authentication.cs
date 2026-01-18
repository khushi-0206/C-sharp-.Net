using System;
class User
{
    public string Name{get;set;}
    public string Password{get;set;}
    public string ConfirmationPassword{get;set;}
}
class Program
{
    public static void Main()
    {
        try
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Password: ");
            string password = Console.ReadLine();

            Console.Write("Confirm Password: ");
            string confirmPassword = Console.ReadLine();

            User u = ValidatePassword(name,password,confirmPassword);
            Console.WriteLine("Registered Successfully");
        }
        catch(PasswordMismatchException p)
        {
            System.Console.WriteLine(p.Message);
        }
    }
    public static User ValidatePassword(string name, string password, string confirmPassword)
    {
        
        User uObj = new User()
        {
            Name = name,
            Password = password,
            ConfirmationPassword = confirmPassword
        };
        if (password != confirmPassword)
        {
            throw new PasswordMismatchException("Password entered does not match");
        }
        return uObj;
    }
}
class PasswordMismatchException : Exception
{
    public PasswordMismatchException()
    {
        
    }
    public PasswordMismatchException(string message) : base(message)
    {
        
    }
}