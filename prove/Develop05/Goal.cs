public abstract class Goal {
    protected string _name;
    protected string _description;
    protected int _goalPoints;
    protected bool _completed = false;

    public string GetName() {
        return _name;
    }
    public string GetDescrpition() {
        return _description;
    }
    public int GetPoints() {
        return _goalPoints;
    }
    public bool GetCompleted() {
        return _completed;
    }
    public void SetName(string name) {
        _name = name;
    }
    public void SetDescription(string description) {
        _description = description;
    }
    public void SetGoalPoints(int goalpoints) {
        _goalPoints = goalpoints;
    }
    public void SetCompleted(bool completed) {
        _completed = completed;
    }
    public abstract void CreateGoal();
    public abstract void RecordEvent();
    public abstract void CheckIfCompleted();
}