public class HospitalManager
{
    private Dictionary<int, Patient> _patients = new Dictionary<int, Patient>();
    private Queue<Patient> _appointmentQueue = new Queue<Patient>();

    public void RegisterPatient(int id, string name, int age, string condition)
    {
        Patient p = new Patient()
        {
          Id = id,
          Name = name,
          Age = age,
          Condition = condition  
        };

        _patients.Add(id,p);
    }
    public void ScheduleAppointment(int pateintId)
    {
        if (_patients.ContainsKey(pateintId))
        {
            _appointmentQueue.Enqueue(_patients[pateintId]);
        }
    }
    public Patient ProcessNextAppointment()
    {
        Patient p = _appointmentQueue.Dequeue();
        return p; 
    }
    public List<Patient> FindPatientByCondition(string condition)
    {
        List<Patient> filteredPatients = _patients.Where(p =>  p.Value.Condition==condition).Select(p => p.Value).ToList();
        return filteredPatients;
    }
}