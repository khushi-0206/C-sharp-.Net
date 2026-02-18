public class Program
{
    public static void Main()
    {
        try
        {
            
            ApplicantUtility applicantUtility = new ApplicantUtility();
            do
            {
                Console.WriteLine("\n1. Add Applicant");
                Console.WriteLine("2. Search Applicant");
                Console.WriteLine("3. Remove Applicant");
                Console.WriteLine("4. Update Applicant");
                Console.WriteLine("5. Show All Applicants");
                Console.WriteLine("6. Exit");
                
                Console.WriteLine();
                Console.WriteLine("Enter choice: ");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                    {
                        Applicant applicant = new Applicant();
                        Console.Write("Enter Id: ");
                        applicant.ApplicantId = Console.ReadLine();

                        Console.Write("Enter Name: ");
                        applicant.Name = Console.ReadLine();

                        Console.Write("Enter Current Location (Mumbai, Pune, Chennai): ");
                        string currentLocation = Console.ReadLine();
                        if(!Enum.TryParse(currentLocation,true,out Location location))
                        {
                            throw new InvalidDataException("Invalid Current Location");
                        }
                        else
                        {
                            applicant.CurrentLocation = location;
                        }

                        Console.Write("Enter Preferred Location (Mumbai, Pune, Chennai, Delhi, Kolkata, Bangalore): ");
                        string preferredLocation = Console.ReadLine();
                        if(!Enum.TryParse(preferredLocation,true,out PrefferedLocation prefferedlocation))
                        {
                            throw new InvalidDataException("Invalid Current Location");
                        }
                        else
                        {
                            applicant.preferredLocation = prefferedlocation;
                        }

                        Console.Write("Enter Core competency (DotNet, Java, Oracle, Testing): ");
                        string coreCompetency = Console.ReadLine();
                        if(!Enum.TryParse(coreCompetency,true,out CoreCompetency competency))
                        {
                            throw new InvalidDataException("Invalid Current Location");
                        }
                        else
                        {
                            applicant.coreCompetency = competency;
                        }

                        Console.Write("Enter Passing Year: ");
                        applicant.PassingYear = Convert.ToInt32(Console.ReadLine());

                        applicantUtility.AddApplicant(applicant);
                        Console.WriteLine("Applicant added succesfully");
                        
                        break;  
                    }
                    case 2:
                    {
                        Console.WriteLine("Enter id to search: ");
                        string id = Console.ReadLine();

                        Applicant applicant = applicantUtility.SearchApplicant(id);
                        if(applicant == null)
                        {
                            Console.WriteLine("Applicant not found");
                            
                        }
                        else
                        {
                            Console.WriteLine("Applicant details: ");
                            Console.WriteLine($"{applicant.ApplicantId}|{applicant.Name}|{applicant.CurrentLocation}|{applicant.preferredLocation}|{applicant.coreCompetency}|{applicant.PassingYear}");
                        }
                        break;  
                    }
                    case 3:
                    {
                        Console.WriteLine("Enter Id to delete: ");
                        string id = Console.ReadLine();
                        applicantUtility.DeleteApplicant(id);
                        Console.WriteLine("Applicant Deleted Successfully");
                        break;  
                    }
                    case 4:
                    {
                        Console.WriteLine("Enter id to Update: ");
                        string id = Console.ReadLine();
                        Applicant applicant = new Applicant();
                        Console.Write("Enter Name: ");
                        applicant.Name = Console.ReadLine();

                        Console.Write("Enter Current Location (Mumbai, Pune, Chennai): ");
                        string currentLocation = Console.ReadLine();
                        if(!Enum.TryParse(currentLocation,true,out Location location))
                        {
                            throw new InvalidDataException("Invalid Current Location");
                        }
                        else
                        {
                            applicant.CurrentLocation = location;
                        }

                        Console.Write("Enter Preferred Location (Mumbai, Pune, Chennai, Delhi, Kolkata, Bangalore): ");
                        string preferredLocation = Console.ReadLine();
                        if(!Enum.TryParse(preferredLocation,true,out PrefferedLocation prefferedlocation))
                        {
                            throw new InvalidDataException("Invalid Current Location");
                        }
                        else
                        {
                            applicant.preferredLocation = prefferedlocation;
                        }

                        Console.Write("Enter Core competency (DotNet, Java, Oracle, Testing): ");
                        string coreCompetency = Console.ReadLine();
                        if(!Enum.TryParse(coreCompetency,true,out CoreCompetency competency))
                        {
                            throw new InvalidDataException("Invalid Current Location");
                        }
                        else
                        {
                            applicant.coreCompetency = competency;
                        }

                        Console.Write("Enter Passing Year: ");
                        applicant.PassingYear = Convert.ToInt32(Console.ReadLine());

                        applicantUtility.UpdateApplicants(id,applicant);
                        Console.WriteLine("Update Successfully");
                        break;  
                    }
                    case 5:
                    {
                        applicantUtility.DisplayAllApplicants();
                        break;  
                    }
                    case 6:
                    {
                        Console.WriteLine("Exiting...Thank You");
                        return;  
                    }
                    default:
                    {
                        Console.WriteLine("Invalid Choice");
                        break;  
                    }
                }
                
            }
            while(true);
        }
        catch(InvalidDataException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}