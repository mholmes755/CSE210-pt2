public class Writing : HomeworkAssignment
{
    private string _assignmentTitle;

    public Writing(string studentName, string topic, string assignmentTitle) : base(studentName, topic)
    {
        _assignmentTitle = assignmentTitle;
    }

    public string GetWritingInfo()
    {
        return $"{_studentName} - {_topic}\n{_assignmentTitle}";
    }

}