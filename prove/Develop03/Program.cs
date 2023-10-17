using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string passage = "And now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that afaith is things which are bhoped for and cnot seen; wherefore, dispute not because ye see not, for ye receive no dwitness until after the trial of your faith.";
        string book = "Ether";
        int chapter = 12;
        int versicle = 6;

        Word wordsList = new Word();
        Scripture s1 = new Scripture(passage, wordsList);
        Reference r1 = new Reference(book, chapter, versicle);
        string userInput = "";

        Console.Clear();
        Console.WriteLine("Welcome to the Scripture memorizer!");
        Console.WriteLine();
        r1.DisplayReference();
        s1.DisplayScripture();
        Console.WriteLine();
        Console.Write("Type 'quit' to exit or just press 'enter' to hide a word: ");
        userInput = Console.ReadLine();

        while (userInput != "quit") {
            Console.Clear();
            r1.DisplayReference();
            s1.HideWord();
            userInput = Console.ReadLine();

            if  (userInput == "quit") {
                Environment.Exit(0);
            }
        }
        
    }
}