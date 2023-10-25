using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Pedro Lescano", "Mathematics");

        a1.GetSummary();
        Console.WriteLine();

        MathAssignment m1 = new MathAssignment("Marcus", "Fractions", "7.3", "8-10");
        m1.GetSummary();
        m1.GetHomeworkList();
        Console.WriteLine();

        WritingAssignment w1 = new WritingAssignment("The causes of World War II", "Marcus Thompson", "European History");
        w1.GetSummary();
        w1.GetWritingInformation();
    }
}