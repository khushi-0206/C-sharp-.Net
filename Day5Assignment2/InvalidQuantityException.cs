using System;
using Day6Assignment2;

public class InvalidQuatityException : Exception
{
    public InvalidQuatityException():base("Quantity must be grater than zero")
    {
        
    }
    public InvalidQuatityException(string message) : base(message)
    {
        
    }
}