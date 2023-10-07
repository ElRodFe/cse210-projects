using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your Journal");
        Console.WriteLine();

        int userChoice = 0;
        Journal theJournal = new Journal();

        while(userChoice != 5){

        Console.WriteLine("Please select an option: ");
        Console.WriteLine("1- New Entry");
        Console.WriteLine("2- Display Journal");
        Console.WriteLine("3- Save Journal");
        Console.WriteLine("4- Load Journal");
        Console.WriteLine("5- Exit");

        Console.Write(">");
        userChoice = int.Parse(Console.ReadLine());
        Console.WriteLine();

        

        if (userChoice == 1) {
            theJournal.NewEntry();
            Console.WriteLine();
        }

        else if (userChoice == 2) {
            theJournal.DisplayEntries();
            Console.WriteLine();
        }

        else if (userChoice == 3) {
            Console.WriteLine("Write a name for your Journal file: ");
            string fileName = Console.ReadLine();
            Console.WriteLine("File saved successfully");

            theJournal.SaveFile(fileName);
            Console.WriteLine();
        }

        else if (userChoice == 4) {
            Console.WriteLine("Write the filename to open: ");
            string fileName = Console.ReadLine();

            Console.WriteLine("Reading file...");
            Console.WriteLine();

            theJournal.LoadFile(fileName);
            Console.WriteLine();
        }

        else if (userChoice == 5) {
            Environment.Exit(0);
        }

        else {
            Console.WriteLine("Invalid choice, please select a valid one...");
            Console.WriteLine();
        }

        }

    }

}