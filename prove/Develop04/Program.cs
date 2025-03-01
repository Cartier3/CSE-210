using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // The way I made this project my own is, in the reflection activity code there is a do-while loop and an if statement that check if each question assigned for each different prompt is not a duplicate.
        // This was mentioned in the demo video as a stretch challenge if I wished to do it. I figured out how to make it work and sort through each question given throughout the duration of the activity.
        
        bool finished = false;
        
        Console.WriteLine("\nWelcome to the Mindfulness Activity Program!");

        do 
        {
            Menu menu = new Menu();
            menu.DisplayMenu();
            int userChoice = menu.GetUserInput();

            Console.Clear();
            
            if (userChoice == 1)
            {
                BreathingActivity breathingAct = new BreathingActivity();

                breathingAct.DoActivity();
            }

            else if (userChoice == 2)
            {
                ReflectionActivity refAct = new ReflectionActivity();

                refAct.DoActivity();
            }

            else if (userChoice == 3)
            {
                ListingActivity listAct = new ListingActivity();

                listAct.DoActivity();
            }
            
            else if (userChoice == 4)
            {
                finished = true;
                Console.WriteLine("Thank you for using the Mindfullness Program!");
                Thread.Sleep(5000);
                Console.Clear();
            }
    
        } while (finished == false);
            
      
    }
}