public enum Location{Mumbai,Pune,Chennai}
public enum PrefferedLocation{Mumbai,Pune,Chennai,Delhi,Kolkata,Bangalore}
public enum CoreCompetency{DotNet,Java,Oracle,Testing}
public class Applicant
{
    public string ApplicantId{get;set;}
    public string Name{get;set;}
    public Location CurrentLocation{get;set;}
    public PrefferedLocation preferredLocation{get;set;}
    public CoreCompetency coreCompetency{get;set;}
    public int PassingYear{get;set;}
}
