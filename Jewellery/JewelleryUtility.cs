public class JewelleryUtility
{
    public Dictionary<string,string> GetJewelleryDetails(string id)
    {
        Dictionary<string,string> details = new Dictionary<string, string>();
        if (Program.jewelleryDetails.ContainsKey(id))
        {
            Jewellery jObj = Program.jewelleryDetails[id];
            details.Add(id,$"{jObj.Type}_{jObj.Material}");
        }

        return details;
    }
    public Dictionary<string,Jewellery> UpdateJewelleryPrice(string id, int price)
    {
        Dictionary<string, Jewellery> res = new Dictionary<string, Jewellery>();
        if (Program.jewelleryDetails.ContainsKey(id))
        {
            Jewellery jObj = Program.jewelleryDetails[id];
            jObj.Price = price;
            res.Add(id,jObj);
        }
        return res;
    }
}