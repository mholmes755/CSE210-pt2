public class Video
{
    private string _title;
    private string _author;
    private int _length; // in seconds

    private List<Comment> _comments;


    public Video()
    {
        _comments = new List<Comment>(); // initialize the list of comments
    }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>(); // initialize the list of comments
    }


    public string Title // getter and setter for title
    {
        get { return _title; }
        set { _title = value; }
    }

    public string Author // getter and setter for author
    {
        get { return _author; }
        set { _author = value; }
    }

    public int Length // getter and setter for length
    {
        get { return _length; }
        set { _length = value; }
    }


    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

// this doesn't create a new list. It returns the existing list of comments
// "List<Comment>" is the return type of the method
    public List<Comment> GetComments() 
    {
        return _comments;
    }
}