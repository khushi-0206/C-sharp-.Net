class PersonImplementation
{
    public string GetName(IList<Person> person)
    {
        string result = "";
        foreach(Person p in person)
        {
            string info = p.Name +" "+ p.Address;
            result += info + " " ;
        }
        return result;
    }
    public double Average(IList<Person> person)
    {
        double sumAge = 0;
        int count = 0;
        foreach(Person p in person)
        {
            sumAge += p.Age;
            count++;
        }
        return sumAge/count;
    }
    public int Max(IList<Person> person)
    {
        var maxAge = person.Max(p => p.Age);
        return maxAge;
    }
}