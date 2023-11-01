public class BreathingActivity: Activity {
    public BreathingActivity() {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out\n slowly. Clear your mind and focus on your breathing.";
    }

    public void StartBreathing() {
        DisplayStartMsg();
        Console.WriteLine("");
        DateTime startingTime = DateTime.Now;
        DateTime finishingTime = startingTime.AddSeconds(_duration);

        do {
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
        } while (startingTime != finishingTime);
    }
}