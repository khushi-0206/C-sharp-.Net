class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter Exam Details: ");

        Console.WriteLine("Student Name: ");
        string studentNAme = Console.ReadLine();

        Console.WriteLine("Question Type (MCQ/Coding): ");
        string type = Console.ReadLine();

        Console.WriteLine("Total Question: ");
        int totalQuestions = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Correct Answer: ");
        int correctAnswers = Int32.Parse(Console.ReadLine());

        Console.WriteLine("Wrong Answer: ");
        int wrongAnswers = Int32.Parse(Console.ReadLine());

        OnlineTest obj = new OnlineTest(studentNAme,totalQuestions,correctAnswers,wrongAnswers,type);
        obj.DisplaySummary();
    }
}