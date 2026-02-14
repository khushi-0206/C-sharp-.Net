using System.Text.RegularExpressions;

public abstract class Consultant{
    public string ConsultantId{get;set;}
    public Consultant(string consultantId)
    {
        if (!ValidConsultantId(consultantId)){
            throw new ArgumentException("Invalid doctor id");
        }
        ConsultantId = consultantId;
    }
    public abstract double CalculateGrossPayout();
    public virtual double CalculateTDS(double grossAmount)
    {
        if(grossAmount <= 5000)
        {
            return 0.005;
        }
        else
        {
            return 0.15;
        }
    }
    private bool ValidConsultantId(string id)
    {
        return Regex.IsMatch(id,@"DR\d{4}$");
    }
    
}
