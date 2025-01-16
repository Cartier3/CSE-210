using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);

    }

   static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");

    }   
        
    static string PromptUserName() 
    {
        Console.WriteLine("What is your name:");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber() 
    {
        Console.WriteLine("What is your favorite number:");
        int favNumber = int.Parse(Console.ReadLine());

        return favNumber;
        
    } 

    static int SquareNumber(int fav_number)
    {
        int square = fav_number * fav_number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is: {square}");
    }

       


    

    

    
    


}