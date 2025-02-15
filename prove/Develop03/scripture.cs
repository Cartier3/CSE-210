using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Linq;

class Scripture
{

    private List<Word> words; 

    private Random random;
    
    
    public Scripture(string text)
    {
        // This Constructor calls and converts each new, random Instance of the 'Word' class into a 'Word' object, puts them in the 'words' list, and splits them.
        words = text.Split(' ') 
                .Select(w => new Word(w))
                .ToList();
        random = new Random();
    }
    
     public void HideWord()
    {
        // This method insures that the subsequent words that are being hidden are new and not previously hidden words.
        var visibleWords = words.Where(w => !w.IsHidden()).ToList();

        if (visibleWords.Count > 0)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
        }
    }

    public void DisplayVerse()
    {
        // This method writes the verse out physically with the underscored words added.
        Console.WriteLine();
        Console.WriteLine(string.Join(" ", words.Select(w => w.GetDisplayText())));
    }

    public bool IsCompletelyHidden()
    {
        // This method returns all words that are completely hidden.
        return words.All(w => w.IsHidden());
    }
}








