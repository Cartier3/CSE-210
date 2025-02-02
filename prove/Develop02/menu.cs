using System.ComponentModel;

class Menu
{

   public void DisplayMenu()
    {
        Console.WriteLine("\nPlease select from one of the following options:");
        Console.WriteLine("\n1. Write an Entry");
        Console.WriteLine("2. Display Current Written Entries");
        Console.WriteLine("3. Save Entries");
        Console.WriteLine("4. Load Previous Written Entries from File");
        Console.WriteLine("5. Quit Program");
    }
}