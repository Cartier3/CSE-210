using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {

        Console.Write($"What is your grade percentage for the course? ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        string letter = "";
        
        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your Grade is: {letter}");
    
        if (number >= 70)
        {
            Console.WriteLine("\nYou passed the Course! Well Done!!");
        }

        else
        {
            Console.WriteLine("\nYou have failed this course. If at first you don't succeed, try, try again!");
        }      
    }
}    