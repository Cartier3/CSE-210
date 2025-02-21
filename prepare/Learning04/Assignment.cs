
public class Assignment
{
    private string studentName;

    private string _topic;
    
    public Assignment (string name, string topic)
    {
        studentName = name;
        
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"\nStudent Name: {studentName}  \nTopic: {_topic}";
    }

}

