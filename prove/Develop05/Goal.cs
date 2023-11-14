public abstract class Goal {
    protected string _name;
    protected string _description;
    protected int _goalPoints;
    protected int _pointsEarned;

    public string GetName() {
        return _name;
    }
    public string GetDescrpition() {
        return _description;
    }
    public int GetPoints() {
        return _goalPoints;
    }
    public abstract void CreateGoal();
    public abstract void RecordEvent();
    public abstract void CheckIfCompleted();
}