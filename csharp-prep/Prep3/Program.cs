using System;
using System.Globalization;
using System.Net;
using System.Security.Cryptography;
using System.Security.Permissions;

class Program
{
    static void Main(string[] args)
    {
        Random magic = new Random();
        int mNumber = magic.Next(1,101);
        int guess = -2;
        
        while (guess != mNumber)
        {
            Console.Write("What is the magic number?\n");
            guess = int.Parse(Console.ReadLine());
        
            if (guess > mNumber)
            {
                Console.WriteLine("Guess Lower!");
            }
            else if (guess < mNumber)
            {
                Console.WriteLine("Guess Higher!");
            }
        
            else 
            {
                Console.WriteLine("You guessed it! You win!");
            }
        
        }  
             
    }
}