// See https://aka.ms/new-console-template for more information

Console.Write("Enter size: ");
int size = Int32.Parse(Console.ReadLine());

int[] data = new int[size];
Console.WriteLine("Enter elements: ");
for(int i = 0; i < size; i++)
{
    data[i] = Int32.Parse(Console.ReadLine());
}
Counter cObj = null;
try
{
    cObj = new Counter(data);
    string res = cObj.GetCount();
    Console.WriteLine(res);
}
catch(ExceptionZero ex)
{
    Console.WriteLine(ex.Message);
}
catch(ExceptionOne ex)
{
    Console.WriteLine(ex.Message);
}