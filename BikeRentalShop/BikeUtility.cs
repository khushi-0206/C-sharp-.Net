class BikeUtility
{
    public void AddBikeDetails(string model, string brand, int pricePerDay)
    {
        Bike bObj = new Bike();
        bObj.Model = model;
        bObj.Brand = brand;
        bObj.PricePerDay = pricePerDay;
        int key = Program.bikeDetails.Count + 1;
        Program.bikeDetails.Add(key,bObj);

    }
    public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
    {
        SortedDictionary<string,List<Bike>> result = new SortedDictionary<string, List<Bike>>();
        foreach(var pair in Program.bikeDetails)
        {
            Bike bObj = pair.Value;
            if (!result.ContainsKey(bObj.Brand))
            {
                result[bObj.Brand] = new List<Bike>();
            }
            result[bObj.Brand].Add(bObj);
        }
        return result;
    }
}