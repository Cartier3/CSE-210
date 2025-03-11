using System;
using System.Net.NetworkInformation;

class Program
{
    static void Main(string[] args)
    {
        bool finished = false;

        Console.WriteLine("\nWelcome to the Eternal Quest Program!");

        do
        {
            Menu menu = new Menu();
            menu.DisplayMenu();
            int userChoice = menu.GetUserInput();

            Console.Clear();

            if (userChoice == 1)
            {

            }

            else if (userChoice == 2)
            {

            }

            else if (userChoice == 3)
            {

            }

            else if (userChoice == 4)
            {

            }

            else if (userChoice == 5)
            {

            }

            else if (userChoice == 6)
            {
                finished = true;

                Console.WriteLine("Thank you for using the Eternal Quest Program!");
                Thread.Sleep(3000);
                Console.Clear();
            }


        }while (finished == false);
        


    }
}