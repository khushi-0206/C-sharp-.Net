public class PermanentEmployee : Employee
{
    public override decimal GetBonus()
    {
        return Salary*10/100;
    }

    
}