using System;

class Program
{
    static void Main(string[] args)
    {
        Activity act = new Activity();
        BreathingActivity ba = new BreathingActivity();
        ReflectionActivity ra = new ReflectionActivity();
        ListingActivity la = new ListingActivity();
        
        Console.WriteLine("Welcome to the Mindfulness program!");
        string userInput= "";

        while (userInput != "4") {
            Console.WriteLine("Menu Otions:");
            Console.WriteLine("1- Breathing Activity.\n 2- Reflection Activity.\n 3- Listing Activity.\n 4- Quit.");
            userInput = Console.ReadLine();

            if (userInput == "1") {
                ba.StartBreathing();
            }
            else if (userInput == "2") {
                ra.StartReflecting();
            }
            else if (userInput == "3") {
                la.StartListing();
            }
        }

    }
}