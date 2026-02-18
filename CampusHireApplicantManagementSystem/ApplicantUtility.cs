using System.Text.RegularExpressions;
public class ApplicantUtility
{
    List<Applicant> applicants = new List<Applicant>();

    public void AddApplicant(Applicant applicant)
    {
        if (string.IsNullOrWhiteSpace(applicant.ApplicantId) ||
            string.IsNullOrWhiteSpace(applicant.Name))
        {
            throw new InvalidDataException("All fields are mandatory");
        }
        if (!Regex.IsMatch(applicant.ApplicantId, @"^CH\d{6}$"))
        {
            throw new InvalidDataException("Applicant Id is invalid");
        }
        if(applicant.Name.Length <4 || applicant.Name.Length > 15)
        {
            throw new InvalidDataException("Name must in range 4 to 15 characters");
        }
        if(applicant.PassingYear > DateTime.Now.Year)
        {
            throw new InvalidDataException("Passing year is greater then current year");
        }
        if(applicants.Any(a=> a.ApplicantId == applicant.ApplicantId))
        {
            throw new InvalidDataException("Applicant ID already exists");
        }

        applicants.Add(applicant);

    }

    public void DisplayAllApplicants()
    {
        foreach(var applicant in applicants)
        {
            Console.WriteLine($"{applicant.ApplicantId}-{applicant.Name}-{applicant.coreCompetency}-{applicant.PassingYear}");
        }
    }

    public Applicant SearchApplicant(string id)
    {
        return applicants.FirstOrDefault(a=>a.ApplicantId==id);
    }

    public void UpdateApplicants(string id,Applicant applicant)
    {
        var existing = applicants.FirstOrDefault(a => a.ApplicantId == id);
        if(existing == null)
        {
            throw new InvalidDataException("Applicant not registered");
        }
        existing.Name = applicant.Name;
        existing.CurrentLocation = applicant.CurrentLocation;
        existing.preferredLocation = applicant.preferredLocation;
        existing.coreCompetency = applicant.coreCompetency;
        existing.PassingYear = applicant.PassingYear;
        
    }
    public void DeleteApplicant(string id)
    {
        var applicant = applicants.FirstOrDefault(a => a.ApplicantId==id);
        if(applicant == null)
        {
            throw new InvalidDataException("Appicant not registered");
        }
        applicants.Remove(applicant);
    }
}