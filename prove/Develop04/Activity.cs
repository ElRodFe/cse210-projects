public class Activity {
    protected string _name;
    protected string _description;
    protected int _duration;
    protected List<string> _animatedStrings = new List<string>();

    public Activity() {
        _animatedStrings.Add("(O.O)");
        _animatedStrings.Add("(o.o)");
        _animatedStrings.Add("(-.-)");
    }

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
        Console.WriteLine();
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

    public void DisplaySpinner(int seconds) {
        DateTime startTime = DateTime.Now;
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        int i = 0;
        int maxStringLength = _animatedStrings.Max(s => s.Length);
        Console.CursorVisible = false;

        while (DateTime.Now < endTime) {
            string s = _animatedStrings[i];
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', maxStringLength));
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(s);
            i++;
            Thread.Sleep(800);
            Console.Write("Wait a moment...");

            if (i >= _animatedStrings.Count()) {
                i = 0;
            }
        }

        Console.WriteLine();
        Console.CursorVisible = true;
    }
}