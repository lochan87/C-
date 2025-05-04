using System;

class GPACalculator
{
    static void Main()
    {
        Console.Write("Enter number of subjects: ");
        int n = int.Parse(Console.ReadLine());

        double totalGradePoints = 0;
        double totalCredits = 0;

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"\nSubject {i}:");
            Console.Write("Enter marks (out of 100): ");
            int marks = int.Parse(Console.ReadLine());

            Console.Write("Enter credit for subject: ");
            double credit = double.Parse(Console.ReadLine());

            double gradePoint = GetGradePoint(marks);
            
            totalGradePoints += gradePoint * credit;
            totalCredits += credit;
        }

        double gpa = totalGradePoints / totalCredits;
        Console.WriteLine($"\nYour GPA is: {gpa}");
    }

    static double GetGradePoint(int marks)
    {
        // Simple grade point logic
        if (marks >= 90) return 10;
        else if (marks >= 80) return 9;
        else if (marks >= 70) return 8;
        else if (marks >= 60) return 7;
        else if (marks >= 50) return 6;
        else if (marks >= 40) return 5;
        else return 0;
    }
}
