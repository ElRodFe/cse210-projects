public abstract class Goal {
    protected string _name;
    protected string _description;
    protected int _goalPoints;
    protected int _pointsEarned;
    protected List<Goal> _goalsList = new List<Goal>();

    public string GetName() {
        return _name;
    }
    public abstract void CreateGoal();
    public abstract void RecordEvent();
    public abstract void CheckIfCompleted();
}