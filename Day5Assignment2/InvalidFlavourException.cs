using System;

namespace Day6Assignment2;

public class InvalidFlavourException:Exception
{
    public InvalidFlavourException():base("Flavour not available. Please select the available flavour")
    {
        
    }
    public InvalidFlavourException(string message) : base(message)
    {
        
    }
}
