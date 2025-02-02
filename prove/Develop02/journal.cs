using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Xml.Linq;

public class Journal 
{ 
    public string filename;
    public string Date;
    public string Prompt;
    public string Text;

    public List<string> entries = new List<string>();


    public void AddEntry(string Date, string Prompt,  string Text)
    {
        entries.Add($"Date: {Date}\nPrompt: {Prompt}\nEntry: {Text}\n");
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No Entries Available.");
        }
        else
            foreach (string entry in entries)
            
                Console.WriteLine(entry);
    }

    public void Save()
    {
        string filename = "journal.txt";

        string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;

        // Combine the project directory with the desired filename
        string filePath = Path.Combine(projectDirectory, "journal.txt");

        Console.WriteLine("\nSaving to File to journal.txt...");

        using(StreamWriter outputFile = new StreamWriter(filename, append:true))
        {
            foreach (string entry in entries)
            {
                outputFile.WriteLine(entry);
            }
        }
    }

    public void LoadFile()
    {
        Console.WriteLine("\nLoading from File...");
        
        string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;

    // Combine the project directory with the desired filename
        string filePath = Path.Combine(projectDirectory, "journal.txt");

        string [] lines = System.IO.File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }

    }
   

}