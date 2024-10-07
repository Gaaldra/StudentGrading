using System;

namespace StudentGrading;

public class Student
{
     private readonly string studentName;
    private readonly List<int> examScores = new();
    private readonly List<int> extraScores = new();
    private readonly int examAmount = 5;

    public Student(string name, int[] scores)
    {
        this.studentName = name;
        int scoreIndex = 0;
        foreach (int score in scores)
        {
            scoreIndex++;
            if (scoreIndex <= examAmount)
            {
                examScores.Add(score);
            }
            else
            {
                extraScores.Add(score);
            }
        }
    }
    public string getName()
    {
        return studentName;
    }

    public decimal studentExamScore()
    {
        decimal studentExamScore = (decimal)examScores.Sum() / examAmount;
        return studentExamScore;
    }

    public decimal studentExtraCreditScore()
    {
        decimal studentExtraCreditScore = (decimal)extraScores.Sum() / extraScores.Count;
        return studentExtraCreditScore;
    }

    public decimal studentGrade()
    {
        decimal studentGrade = (examScores.Sum() + ((decimal)extraScores.Sum() / 10)) / examAmount;
        return studentGrade;
    }

    public decimal extraCredit()
    {
        decimal extraCredit = (decimal)extraScores.Sum() / 10 / examAmount;
        return extraCredit;
    }

    public string studentGradeLetter()
    {
        switch (studentGrade())
        {
            case >= 97:
                return "A+";
            case >= 93:
                return "A";
            case >= 90:
                return "A-";
            case >= 87:
                return "B+";
            case >= 83:
                return "B";
            case >= 80:
                return "B-";
            case >= 77:
                return "C+";
            case >= 73:
                return "C";
            case >= 70:
                return "C-";
            case >= 67:
                return "D+";
            case >= 63:
                return "D";
            case >= 60:
                return "D-";
            default:
                return "F";
        }
    }

}
