using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        DisplayWelcome();

        string PromptUserName()
        {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        return userName;
        }

        string userName = PromptUserName();

        int PromptUserNumber()
        {
        Console.Write("Please enter your favorite number: ");
        int userNumber = int.Parse(Console.ReadLine());
        
        return userNumber;
        }

        int userNumber = PromptUserNumber();

        int SquareNumber(int userNumber)
        {
            int squaredNumber = userNumber * userNumber;

            return squaredNumber;
        }

        int squaredNumber = SquareNumber(userNumber);

        static void DisplayResult(string userName, int squaredNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {squaredNumber}");
        }

        DisplayResult(userName, squaredNumber);


    }
}