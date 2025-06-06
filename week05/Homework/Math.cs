public class Math : HomeworkAssignment
{
    private string _textbookSection;
    private string _problems;

    public Math(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
        {
            _textbookSection = textbookSection;
            _problems = problems;
        }


    public string GetHomeworkList()
    {
        return $"{_studentName} - {_topic}\n{_textbookSection} - Problems: {_problems}";
    }

        
    // problems from section(_firstQuestions and _lastQuestion variables?

    // public string ReturnSummary()
    // {
    //     return $"Student: {StudentName}, Topic: {Topic}"
    // }
    //  Textbook Section: {TextbookSection}, Problems: {_firstQuestion} - {_lastQuestion}";
}