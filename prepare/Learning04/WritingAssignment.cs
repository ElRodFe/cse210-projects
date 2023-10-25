public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string title, string studentName, string topic) : base (studentName, topic)
    {
        _title = title;
        _studentName = studentName;
        _topic = topic;
    }

    public void GetWritingInformation()
    {
        Console.WriteLine($"{_title} by {_studentName}");
    }
}