using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main (string[] args)
    {
        bool finished = false;

        Console.WriteLine("\nWelcome to the Journal Program!");
        Console.WriteLine("(Note: Please remember to save any entries that you would like to keep recorded!)");
        
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        
        PromptMain randomGenPrompt = new PromptMain();
        string dailyPrompt = randomGenPrompt.GetRandomPrompt();
    
        
        Journal user_Journal = new Journal();

        do 
        {
            Menu main_Menu = new Menu(); 
            main_Menu.DisplayMenu();

            Console.Write($"What would you like to do?: ");
            string input = Console.ReadLine();
            int userInput = int.Parse(input);
        
            if (userInput == 1)
            {
                Console.WriteLine($"Today's Date: {dateText}");
                
                Console.Write(dailyPrompt);
                
                Console.WriteLine("\nWrite your entry here:");
                string entry1 = Console.ReadLine();

                Journal date_Save = new Journal();
                date_Save.Date = dateText;

                user_Journal.AddEntry(dateText, dailyPrompt, entry1);
            }
            else if (userInput == 2)
            {    
                user_Journal.DisplayEntries();
            }
            else if (userInput == 3)
            {
                user_Journal.Save();
            }
            else if (userInput == 4)
            {
                user_Journal.LoadFile();
            }
            else if (userInput == 5)
            {
                finished = true;
                
                Console.WriteLine("Thank your for using the Journal Program!");
            }
            else
            {
                Console.WriteLine("Sorry that is not a valid response for this program!");
                
                Console.WriteLine("Please try again!");
            }
    
        }
        while (finished != true);
    }

}     

        
        
        
        

        

        
        
       