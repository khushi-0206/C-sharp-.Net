//Q13

using System.Security.AccessControl;

public class KeyValueStore
{
    
    Dictionary<String, int> store = new Dictionary<string, int>();
    
    public int this[string key]
    {
        get
        {
            if (store.ContainsKey(key))
            {
                return store[key];
            }
            return 0;
        }
        set
        {
            store[key] = value;
        }
    }
    public static void ProcessCommands()
    {
        Console.Write("Enter number of commands: ");
        int n = int.Parse(Console.ReadLine());

        string[] commands = new string[n];

        for(int i = 0; i < n; i++)
        {
            commands[i] = Console.ReadLine();
        }
        List<int> results = new List<int>();
        KeyValueStore kv = new KeyValueStore();
        foreach(string command in commands)
        {
            string[] parts = command.Split(' ');
            string type = parts[0];
            if (type == "SET")
            {
                kv[parts[1]] = int.Parse(parts[2]);
            }
            else if(type == "ADD")
            {
                kv[parts[1]] = kv[parts[1]] + int.Parse(parts[2]);
            }
            else if(type == "GET")
            {
                results.Add(kv[parts[1]]);
            }
        }
        Console.WriteLine("Get results: ");
        foreach(int x in results)
        {
            Console.WriteLine(x);
        }
    }

}