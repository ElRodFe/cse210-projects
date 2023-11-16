public class CheckListGoal: Goal {
    private int _timesToComplete;
    private int _timesCompleted;
    private int _bonus;
    public CheckListGoal(string name, string description, int goalPoints, int timesToComplete, int timesCompleted, int bonus) {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
        _timesToComplete = timesToComplete;
        _timesCompleted = timesCompleted;
        _bonus = bonus;
    }

    public int GetTimesCompleted() {
        return _timesCompleted;
    }
    public int GetTimesToComplete() {
        return _timesToComplete;
    }
    public int GetBonus() {
        return _bonus;
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
        Console.WriteLine();

        Console.Write("What is the bonus for completing the whole goal?: ");
        _bonus = int.Parse(Console.ReadLine());
    }

    public override void RecordEvent() {
        _timesCompleted ++;
        Console.WriteLine($"Congratulations, you have earned {_goalPoints} points!");
        Console.WriteLine();
    }

    public override void CheckIfCompleted() {
        if (_timesCompleted == _timesToComplete) {
            _completed = true;
        }
    }
}