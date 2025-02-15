using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

class Reference

{
    private List<string> references;

    public Reference(string userRef)
    {
        // Thic constructor creates a new 'references' list and uses the AddRef()function to add the user inputted reference into the 'references' list.
        references = new List<string>();
        AddRef(userRef);
    }

    public void AddRef(string reference)
    {
        // This method allows whatever reference the user inputted to be added to the 'references' list.
        references.Add(reference);
    }

    public void DisplayReference()
    {
        // This displays the Scriptural Reference Physically fromn the 'references' list within the Terminal above the verse being memorized.
        Console.WriteLine(string.Join(", ", references));
    }
}



