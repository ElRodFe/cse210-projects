using System.Diagnostics;

public class BreathingActivity: Activity {
    public BreathingActivity() {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out\n slowly. Clear your mind and focus on your breathing.";
    }

    public void StartBreathing() {
        DisplayStartMsg();
        Console.WriteLine();
        Stopwatch timer = new Stopwatch();
        DisplaySpinner(5);


        timer.Start();
        do {
            Console.WriteLine();
            Console.Write("Breathe in...");
            for (int i = 4; i > 0; i--) {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
            Console.WriteLine();

            Console.Write("Breathe out...");
            for (int i = 4; i > 0; i--) {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        } while (timer.Elapsed.TotalSeconds < _duration);
        timer.Stop();
        Console.WriteLine();

        DisplayEndMsg();
        DisplaySpinner(3);
        Console.WriteLine();
    }
}