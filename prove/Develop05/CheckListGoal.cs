public class CheckListGoal: Goal {
    private int _timesToComplete;
    public CheckListGoal(string name, string description, int goalPoints, int timesToComplete) {
        _name = name;
        _description = description;
        _goalPoints = goalPoints;
        _timesToComplete = timesToComplete;
    }

    public override void CreateGoal() {
    
    }

    public override void RecordEvent() {
    
    }

    public override void CheckIfCompleted() {

    }
}