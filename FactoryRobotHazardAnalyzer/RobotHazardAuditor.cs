class RobotHazardAuditor
{
    public double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState)
    {
        if(armPrecision < 0.0 || armPrecision > 1.0)
        {
            throw new RobotSafetyException("Error: Arm precision must be 0.0-1.0");
        }
        else if(workerDensity < 1 || workerDensity > 20)
        {
            throw new RobotSafetyException("Error: Worker density must be 1-20");
        }
        else if(machineryState!="Worn" && machineryState!="Faulty" && machineryState != "Critical")
        {
            throw new RobotSafetyException("Error: Unsupported machinery state");
        }
        else
        {
            double hazardRisk = 0;
            switch (machineryState)
            {
                case "Worn":
                {
                    hazardRisk = ((1.0-armPrecision)*15.0) + (workerDensity * 1.3);
                    break;
                        
                }
                case "Faulty":
                {
                    hazardRisk = ((1.0-armPrecision)*15.0) + (workerDensity * 2.0);
                    break;
                        
                }
                case "Critical":
                {
                    hazardRisk = ((1.0-armPrecision)*15.0) + (workerDensity * 3.0);
                    break;
                        
                }
                default:
                {
                    Console.WriteLine("Invalid choice");
                    break;
                        
                }
            }
            return hazardRisk;
        }
    }
}