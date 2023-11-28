using System;

class Program
{
    static void Main(string[] args)
    {   
        Console.Clear();
        Interface Interface = new Interface();
        Console.WriteLine("Welcome to the Recipe Organizer");
        Console.WriteLine();
        string userChoice = "";

        while (userChoice != "6") {
            Console.WriteLine(String.Format("{0," + Console.WindowWidth / 5 + "}", "Menu Options:"));
            Console.WriteLine("1- New Recipe \n2- Display Recipe \n3- Edit Recipe \n4- Save File \n5- Load File \n6- Exit");
            Console.Write("Select an option: ");
            userChoice = Console.ReadLine();
            Console.WriteLine();
            Interface.Menu(userChoice);
        }

    }
}