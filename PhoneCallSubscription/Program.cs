using System;
class Program
{
    static void Main()
    {
        PhoneCall pc = new PhoneCall();

        pc.MakePhoneCall(true);
        System.Console.WriteLine(pc.Message);

        pc.MakePhoneCall(false);
        System.Console.WriteLine(pc.Message);
    }
}