class Video
{
    private string _title;

    private string _author;

    private int _length;

    List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        // Sets the title, author, and length variables for each Video class instance.
        
        _title = title;

        _author = author;

        _length = length;
    }

    public void DisplayVidInfo()
    {
        // Displays a string which contains each Video class' instance info.
        
        Console.WriteLine(" ");
        Console.WriteLine(" ");
        Console.WriteLine($"\nVideo Title: {_title} -- Author: {_author} -- Length(seconds): {_length} seconds");
    }

    public void AddComment(Comment comment)
    {   
        //This IF statement will add each comment to the "_comments" list as long as the list contains less than 4 comments already.
        
        if (_comments.Count < 4)
        {
            _comments.Add(comment);
        }
            
        if (_comments.Count == 4)
        {
            Console.WriteLine("\n(The maximum amount of comments already attached.)");
        }
    }

    public void DisplayAllComments()
    {
        // This method displays each comment within the "_comments" list within a Writeline statement. It accomplishes this through the DisplayComment() method, which is found within the Comment class.

        Console.WriteLine("\nComments: ");
        
        foreach (var comment in _comments)
        {
            Console.WriteLine($"\n{comment.DisplayComment()}");
        }
    }



}