using System.Collections;
using System;

class MeditationCenter
{
    public int MemberId{get;set;}
    public int Age{get;set;}
    public double Weight{get;set;}
    public double Height{get;set;}
    public string Goal{get;set;}
    public double BMI{get;set;}
}

class Program
{
    public static ArrayList memberList = new ArrayList();

    public static void Main()
    {
        Program pObj = new Program();
        while (true)
        {
            Console.WriteLine("\n--- Meditation Center Menu ---");
            Console.WriteLine("1. Add Yoga Member");
            Console.WriteLine("2. Calculate BMI");
            Console.WriteLine("3. Calculate Yoga Fee");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter Member Id: ");
                    int memberId = int.Parse(Console.ReadLine());

                    Console.Write("Enter Age: ");
                    int age = int.Parse(Console.ReadLine());

                    Console.Write("Enter Weight (kg): ");
                    double weight = double.Parse(Console.ReadLine());

                    Console.Write("Enter Height (in cm): ");
                    double heightCm = double.Parse(Console.ReadLine());
                    double height = heightCm/100;

                    Console.Write("Enter Goal: ");
                    string goal = Console.ReadLine();

                    pObj.AddYogaMember(memberId, age, weight, height, goal);
                    Console.WriteLine("Member added successfully.");
                    break;

                case 2:
                    Console.Write("Enter Member Id to calculate BMI: ");
                    int bmiId = int.Parse(Console.ReadLine());

                    double bmi = pObj.CalculateBMI(bmiId);
                    if (bmi == 0)
                        Console.WriteLine("Member not found.");
                    else
                        Console.WriteLine($"BMI: {bmi:F2}");
                    break;

                case 3:
                    Console.Write("Enter Member Id to calculate Yoga Fee: ");
                    int feeId = int.Parse(Console.ReadLine());

                    int fee = pObj.CalculateYogaFee(feeId);
                    if (fee == 0)
                        Console.WriteLine("Member not found.");
                    else
                        Console.WriteLine($"Yoga Fee: {fee}");
                    break;

                case 4:
                    Console.WriteLine("Exiting program...");
                    return;

                default:
                    Console.WriteLine("Invalid choice. Try again.");
                    break;
            }
        }
    }

    public void AddYogaMember(int memberId, int age, double weight, double height, string goal)
    {
        memberList.Add(new MeditationCenter{MemberId=memberId,Age=age,Weight= weight,Height =height,Goal=goal});

    }

    public double CalculateBMI(int memberId)
    {
        foreach(MeditationCenter member in memberList)
        {
            if(member.MemberId == memberId)
            {
                member.BMI = member.Weight/(member.Height*member.Height);
                return member.BMI;
            }
        }
        return 0;
    }
    public int CalculateYogaFee(int memberId)
    {
        foreach (MeditationCenter member in memberList)
        {
            if (member.MemberId == memberId)
            {
                // Ensure BMI is calculated
                if (member.BMI == 0)
                {
                    member.BMI = member.Weight / (member.Height * member.Height);
                }

                if (member.Goal == "Weight Gain")
                {
                    return 2500;
                }
                else if (member.Goal == "Weight Loss")
                {
                    if (member.BMI >= 25 && member.BMI < 30) return 2000;
                    else if (member.BMI >= 30 && member.BMI <= 35) return 2500;
                    else return 3000;
                }
            }
        }
        return 0; // Member not found
    }

}