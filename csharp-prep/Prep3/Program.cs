using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int userGuess = 0;

        while (userGuess != magicNumber)
        {
            Console.Write("What is your guess?: ");
            string uG = Console.ReadLine();
            userGuess = int.Parse(uG);

            if (userGuess == magicNumber)
            {
                Console.WriteLine("You guessed it!");
            } 

            else if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            else
            {
                Console.WriteLine("Higher");
            }
        }
        
    }
}