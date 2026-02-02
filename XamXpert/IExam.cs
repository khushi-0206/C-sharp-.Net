interface Exam
{
    public double CalculateScore();
    public static string EvaluateResult(double percentage)
    {
        if (percentage >= 85)
        {
            return "Merit";
        }
        else if(percentage >=60 && percentage < 85)
        {
            return "Pass";
        }
        else
        {
            return "Fail";
        }
    }
}