using System.Text.RegularExpressions;

class EntryUtility
{
    public bool ValidateEmployeeId(string employeeId)
    {
        if (Regex.IsMatch(employeeId, @"^GOAIR/\d{4}$"))
        {
            return true;
        }
        else
        {
            throw new InvalidEntryException("Invalid entry details");
        }

    }
    public bool ValidateDuration(int duration)
    {
        if(duration>=1 && duration <= 5)
        {
            return true;
        }
        else
        {
            throw new InvalidEntryException("Invalid entry details");
        }
    }
}