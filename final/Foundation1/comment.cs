class Comment
{
    private string _userName;

    private string _commentText;


    public Comment(string userName, string commentTxt)
    {
        // The class constructor sets the user name and comment text variables.
        
        _userName = userName;

        _commentText = commentTxt;
    }

    public string DisplayComment()
    {
        //Returns the comment variables written in a string form.

        return $"{_userName}: {_commentText}";
    }

}