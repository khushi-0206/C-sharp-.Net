using System;

class EstimateDetails
{
    public float ConstructionArea{get;set;}
    public float SiteArea{get;set;}
}

class Program
{
    public static void Main()
    {
        try
        {
            Console.Write("Enter Construction Area: ");
            float constructionArea = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter Site Area: ");
            float siteArea = Convert.ToSingle(Console.ReadLine());

            EstimateDetails es = ValidateConstructionEstimate(constructionArea,siteArea);
            Console.WriteLine("Validation successful");
        }
        catch (EstimateException e)
        {
            Console.WriteLine(e.Message);
        }
         

    }
    public static EstimateDetails ValidateConstructionEstimate(float constructionArea, float siteArea)
    {
        if (constructionArea <= 0 || siteArea <= 0)
        {
            throw new EstimateException("Area values must be greater than zero");
        }
        if (constructionArea > siteArea)
        {
            throw new EstimateException("Sorry your Construction Estimate is not approved");
        }
        EstimateDetails edObj = new EstimateDetails()
        {
            ConstructionArea = constructionArea,
            SiteArea = siteArea            
        };
        return edObj;
    }
}
class EstimateException : Exception
{
    public EstimateException()
    {
        
    }
    public EstimateException(string message) : base(message)
    {
        
    }
}