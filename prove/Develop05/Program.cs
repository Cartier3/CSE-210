using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();

        string fileName = "myFile.txt";
        
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
                menu.DisplayGoalMenu();
                int userGoal = menu.GetUserGoal();

                Console.Clear();

                if (userGoal == 1)
                {
                    Console.Write("\nSimple Goal Test:");

                    Console.Write("\nWhat is the name of your goal? ");
                    string goalNameType1 = Console.ReadLine();

                    Console.Write("\nWrite a short description of your goal: ");
                    string goalDescType1 = Console.ReadLine();

                    Console.Write("\nHow many points will be associated with this goal? ");
                    string goalPointsType1 = Console.ReadLine();
                    int convPoints = int.Parse(goalPointsType1);

                    SimpleGoal sGoal = new SimpleGoal(goalNameType1, goalDescType1, convPoints);
                    
                }

                else if (userGoal == 2)
                {
                    Console.Write("\nEternal Goal Test");
                    
                    Console.Write("\nWhat is the name of your goal? ");
                    string goalNameType2 = Console.ReadLine();

                    Console.Write("\nWrite a short description of your goal: ");
                    string goalDescType2 = Console.ReadLine();

                    Console.Write("\nHow many points will be associated with this goal? ");
                    string goalPointsType2 = Console.ReadLine();
                    int convPoints = int.Parse(goalPointsType2);

                    EternalGoal eGoal = new EternalGoal(goalNameType2, goalDescType2, convPoints);
                }

                else if (userGoal == 3)
                {
                    Console.Write("\nChecklist Goal Test");
                    
                    Console.Write("\nWhat is the name of your goal? ");
                    string goalNameType3 = Console.ReadLine();

                    Console.Write("\nWrite a short description of your goal: ");
                    string goalDescType3 = Console.ReadLine();

                    Console.Write("\nHow many points will be associated with this goal? ");
                    string goalPointsType3 = Console.ReadLine();
                    int convPoints = int.Parse(goalPointsType3);

                    CheckGoal cGoal = new CheckGoal(goalNameType3, goalDescType3, convPoints);
                    
                }
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
    public void Save(List<Goal> goals, string FileName)
    {

    }

    public void Load()
    {

    }

    public void Display()
    {

    }

}