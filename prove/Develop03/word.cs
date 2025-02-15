class Word
{
    private string text; // Stores the actual word within the variable.
    private bool isHidden; // Tracks if the word is hidden or not.

    public Word(string word)
    {
        // This Constructor Defaults each word string to be visible.
        text = word;
        isHidden = false; 
    }

    public void Hide()
    {
        // This method marks the word as hidden. 
        isHidden = true; 
    }

    public bool IsHidden()
    {
        // This method returns the words that are hidden.
        return isHidden;
    }

    public string GetDisplayText()
    {
        // This method is called to Display the marked hidden words as underscores within the Terminal display.
        return isHidden ? new string('_', text.Length) : text; // 
    }

}