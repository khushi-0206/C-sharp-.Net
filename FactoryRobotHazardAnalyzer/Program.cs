class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Enter Arm Precision (0.0-1.0):");
            double armPrecision = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Worker Density (1-20):");
            int workerDensity = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter Machinery State (Worn/Faulty/Critical): ");
            string machineryState = Console.ReadLine();

            RobotHazardAuditor robotObj = new RobotHazardAuditor();
            double hazardRisk = robotObj.CalculateHazardRisk(armPrecision,workerDensity,machineryState);

            Console.WriteLine($"Robot Hazard Risk Score: {hazardRisk:F2}");
        }
        catch(RobotSafetyException e)
        {
            Console.WriteLine(e.Message);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}