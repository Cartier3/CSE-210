using System;
using System.Formats.Asn1;
using System.Reflection.Metadata;
using System.Threading.Tasks.Dataflow;

class Program
{
   // This is the code for the James Bond Name Code. 
    
    static void Main(string[] args)
    {

        Console.Write($"What is your first name?");
        string name1 = Console.ReadLine();
        
        Console.Write($"What is your last name?");
        string name2 = Console.ReadLine();

        Console.WriteLine($"\nYour name is {name2}, {name1} {name2}.");

    }


}