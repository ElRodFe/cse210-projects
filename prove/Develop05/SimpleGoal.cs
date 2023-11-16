public class SimpleGoal: Goal {
    public SimpleGoal(string name, string description, int goalPoints) {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
    }

    public override void CreateGoal() {
        Console.Write("What is the name of your goal?: ");
        _name = Console.ReadLine();
        Console.WriteLine();

        Console.Write("What is a short description of it?: ");
        _description = Console.ReadLine();
        Console.WriteLine();

        Console.Write("How many point do you want to earn by completting the goal?: ");
        _goalPoints = int.Parse(Console.ReadLine());
    }

    public override void RecordEvent() {
        _completed = true;
        Console.WriteLine($"Congratulations, you have earned {_goalPoints} points!");
        Console.WriteLine();
    }

    public override void CheckIfCompleted() {
        
    }
}