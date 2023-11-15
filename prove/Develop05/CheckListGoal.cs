public class CheckListGoal: Goal {
    private int _timesToComplete;
    private int _timesCompleted;
    public CheckListGoal(string name, string description, int goalPoints, int timesToComplete, int timesCompleted) {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
        _timesToComplete = timesToComplete;
        _timesCompleted = timesCompleted;
    }

    public int GetTimesCompleted() {
        return _timesCompleted;
    }
    public int GetTimesToComplete() {
        return _timesToComplete;
    }

    public override void CreateGoal() {
        Console.Write("What is the name of your goal?: ");
        _name = Console.ReadLine();
        Console.WriteLine();

        Console.Write("Give a short description of it: ");
        _description = Console.ReadLine();
        Console.WriteLine();

        Console.Write("How many point do you want to earn by completting the goal?: ");
        _goalPoints = int.Parse(Console.ReadLine());
        Console.WriteLine();

        Console.Write("How many times does this goal needs to be completed for a bonus?: ");
        _timesToComplete = int.Parse(Console.ReadLine());
    }

    public override void RecordEvent() {
    
    }

    public override void CheckIfCompleted() {

    }
}