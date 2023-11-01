public class Activity {
    protected string _name;
    protected string _description;
    protected int _duration;
    protected List<string> _animatedStrings;

    public void DisplayStartMsg() {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}! We hope you enjoy it!");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("For how long (in seconds) do you want to play this activity?:");
        _duration = int.Parse(Console.ReadLine());
    }

    public void DisplayEndMsg() {
        Console.WriteLine("Great!!");
        Console.WriteLine();
        Console.WriteLine($"Congrats! You have completed {_duration} seconds of a {_name}!");
    }

    public void DisplayMenu() {
        BreathingActivity ba = new BreathingActivity();
        ReflectionActivity ra = new ReflectionActivity();
        ListingActivity la = new ListingActivity();
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