using System.Runtime.ConstrainedExecution;

IList<Person> p = new List<Person>();
p.Add(new Person{Name = "Aarya", Address = "A2101", Age = 69});
p.Add(new Person {Name = "Daniel", Address = "D104",Age = 40});
p.Add(new Person {Name = "Ira", Address = "H801",Age = 25});
p.Add(new Person {Name = "Jennifer", Address = "I1704",Age = 33});

PersonImplementation piObj = new PersonImplementation();
System.Console.WriteLine(piObj.GetName(p));
System.Console.WriteLine(piObj.Average(p));
System.Console.WriteLine(piObj.Max(p));
