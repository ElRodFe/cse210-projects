using System.Diagnostics;

public class ListingActivity: Activity {
    private List<string> _promptsList = new List<string>();

    public ListingActivity() {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having\n you list as many things as you can in a certain area.";

        //populate prompts list
        _promptsList.Add("Who are people that you appreciate?");
        _promptsList.Add("What are personal strengths of yours?");
        _promptsList.Add("Who are people that you have helped this week?");
        _promptsList.Add("When have you felt the Holy Ghost this month?");
        _promptsList.Add("Who are some of your personal heroes?");
    }

    public void GetPrompt() {
        Random rnd = new Random();
        int index = rnd.Next(0, _promptsList.Count);

        Console.WriteLine(_promptsList[index]);
    }

    public void StartListing() {
        DisplayStartMsg();
        Console.WriteLine();
        Stopwatch timer = new Stopwatch();
        DisplaySpinner(5);

        timer.Start();
        GetPrompt();
        DisplaySpinner(8);
        int itemsEntered = 0;
        do {
            Console.ReadLine();
            itemsEntered++;

        } while (timer.Elapsed.TotalSeconds < _duration);
        timer.Stop();
        Console.WriteLine();
        Console.Write($"You have listed {itemsEntered} items.");

        DisplayEndMsg();
        DisplaySpinner(3);
        Console.WriteLine();
    }
}