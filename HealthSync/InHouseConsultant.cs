class InHouseConsultant: Consultant
{
    public double MonthlyStipend{get;set;}
    public double Allowances{get;set;}
    public double Bonus{get;set;}

    public InHouseConsultant(string id, double stipend, double allownace, double bonus) : base(id)
    {
        MonthlyStipend = stipend;
        Allowances = allownace;
        Bonus = bonus;
    }

    public override double CalculateGrossPayout()
    {
        return MonthlyStipend + Allowances + Bonus;
    }
}