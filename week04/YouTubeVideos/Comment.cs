public class Comment
{

    private string _commenterName;
    private string _commentText;


    
    public Comment(string name, string text)
    {
        _commenterName = name;
        _commentText = text;    
    }

    public string GetCommenterName // getter and setter for commenter name
    {
        get { return _commenterName; }
        set { _commenterName = value; }
    }

    public string GetCommentText // getter and setter for comment text
    {
        get { return _commentText; }
        set { _commentText = value; }
    }

    public override string ToString() // override ToString method to return comment text
    {
        return $"{_commenterName}: {_commentText}";
    }
    
}