using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main (string[] args)
    {
        // The way I modified the code to make it my own is, I made the Scripture Reference and Scripture Verses user-generated so that they can choose which scripture/reference they would like to memorize.
        Console.WriteLine("\nWelcome to the Scripture Memorization Program!");

        // Collects the User inputted Scripture Reference and passes it to the Reference Class Constructor.
        Console.WriteLine("\nWhat is the scriptural reference in the format:(Book Chapter:Verses), of the scripture you would like to memorize today?");
        string userRef = Console.ReadLine().Trim();
        Reference refU = new Reference(userRef);

        // Collects the User Inputted Scripture and passes it to the Scripture Class Constructor.
        Console.WriteLine("Please type or copy & paste the scripture out word by word here:");
        string userScript = Console.ReadLine();
        Scripture scriptures = new Scripture(userScript);


        while (true)
        {
            
            Console.Clear();    // This while loop will clear the console each time before calling the following methods.
            refU.DisplayReference();    // This calls the DisplayReference() Method within the 'reference' class.
            scriptures.DisplayVerse();  // This calls the DisplayVerse() Method within the 'scripture' class.
            
             
            Console.WriteLine("\nPress the 'Enter' key to hide more words or type 'quit' to exit:");     //This prompts the user to press Enter to continue hiding the words within their verse.
            string userInput = Console.ReadLine();  //This collects the user's input to enter or quit the program.
            if (userInput.ToLower() == "quit") break;   // This code tells the program to break/quit if the user types the word'quit' whether the letters are lowercase or uppercase.
            
            scriptures.HideWord();  // This calls the HideWord() Method within the scripture class to begin the process of hiding the words within the scriptures variables which is a new instance of the scripture class in action.
        }

    }
}