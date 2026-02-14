class VisitingConsultant : Consultant
{
    public int ConsultationsCount {get;set;}
    public double RatesPerVisit{get;set;}
    
    public VisitingConsultant(string id, int visits, double rate) : base(id)
    {
        ConsultationsCount = visits;
        RatesPerVisit = rate;
    }

    public override double CalculateGrossPayout()
    {
        return ConsultationsCount * RatesPerVisit;
    }
    public override double CalculateTDS(double grossAmount)
    {
        return 0.10;
    }
}