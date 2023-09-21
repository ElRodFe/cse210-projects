using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade porcentage?: ");
        string gradePorcentage = Console.ReadLine();

        int porcentage = int.Parse(gradePorcentage);

        if (porcentage >= 90)
        {   
            Console.WriteLine("You have an 'A'");
        }

        else if (porcentage >= 80)
        {
            Console.WriteLine("You have a 'B'");
        }

        else if (porcentage >= 70)
        {
            Console.WriteLine("You have a 'C'");
        }

        else if (porcentage >= 60)
        {
            Console.WriteLine("You have a 'D'");
        }

        else
        {
            Console.WriteLine("You have a 'F'");
        }


    }
}