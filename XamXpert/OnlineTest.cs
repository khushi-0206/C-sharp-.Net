class OnlineTest : Exam
{
    string studentName;
    int totalQuestions;
    int correctAnswers;
    int wrongAnswers;
    string questionType;
    public OnlineTest(string studentName, int totalQuestions, int correctAnswers, int wrongAnswers, string questionType)
    {
        this.studentName = studentName;
        this.totalQuestions = totalQuestions;
        this.correctAnswers = correctAnswers;
        this.wrongAnswers = wrongAnswers;
        this.questionType = questionType;
    }

    public double CalculateScore()
    {
        int marksPerQuestion = questionType=="MCQ"?2:5;
        double totalScore = (correctAnswers * marksPerQuestion) - (wrongAnswers * (marksPerQuestion *0.10));
        double percentage = (totalScore/(totalQuestions * marksPerQuestion))* 100;
        return percentage;
    }
    public void DisplaySummary()
    {
        double percentage = CalculateScore();
        Console.WriteLine($"{questionType}: {studentName}, Total Score: {percentage:F1}, Result: {Exam.EvaluateResult(percentage)}");
    }

}