public class Employee
{
    public int ID{get;set;}
    public string Name{get;set;}
    public string Department{get;set;}
    public decimal Salary{get;set;}
    public virtual decimal GetBonus()
    {
        return 0;
    }
}