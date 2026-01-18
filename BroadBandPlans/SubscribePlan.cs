class SubscribePlan
{
    readonly private IList<IBroadbandPlan> _broadbandPlans;
    public SubscribePlan(IList<IBroadbandPlan> broadbandPlans)
    {
        if (broadbandPlans == null)
        {
            throw new ArgumentNullException();
        }
        _broadbandPlans = new List<IBroadbandPlan>(broadbandPlans);
    } 
    public IList<Tuple<string, int>> GetSubscriptionPlan()
    {
        if (_broadbandPlans == null)
        {
            throw new ArgumentNullException();
        }
        IList<Tuple<string,int>> result = new List<Tuple<string,int>>();
        foreach(var plan in _broadbandPlans)
        {
            string planType = plan.GetType().Name;
            int amount = plan.GetBroadbandPlanAmount();
            result.Add(new Tuple<string,int>(planType,amount));
        }
        return result;
    }
}