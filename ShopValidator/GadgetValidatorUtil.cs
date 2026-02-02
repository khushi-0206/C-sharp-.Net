using System.Text.RegularExpressions;

class GadgetValidatorUtil
{
    public bool validateGadgetId(string id)
    {
        if (Regex.IsMatch(id, @"^[A-Z]\d{3}$"))
        {
            return true;
        }
        else
        {
            throw new InvalidGadgetExcetion("Invalid gadget Id");
        }
    }

    public bool validateWarrantyPeriod(int period)
    {
        if (period >= 6 && period <=36)
        {
            return true;
        }
        else
        {
            throw new InvalidGadgetExcetion("Invalid warranty period");
        }
    }

}