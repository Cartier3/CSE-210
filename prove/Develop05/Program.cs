using System;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.IO;
using System.Numerics;
using System.Xml.Linq;

class Program
{
    static List<Goal> goals = new List<Goal>();

    static void Main(string[] args)
    {
        
        bool finished = false;

        int totalPoints = 0;
        
        Console.WriteLine("\nWelcome to the Eternal Quest Program!");

        // This do-while loop runs the code that allows the user to create a goal, list the goals that have been created, or save the current goals, or load it from a file they have created, or record an event instance of a goal that they have completed, and finally quit the program.
        do
        {
            Console.WriteLine($"\nYou have {totalPoints} points!");
            
            Menu menu = new Menu();
            menu.DisplayMenu();
            int userChoice = menu.GetUserInput();

            Console.Clear();

            // This if statement allows the user to create one of the three options of goals. It asks the user for the appropriate name, description, point value, and for checkGoal it asks for the bonus point and times completed numbers.
            if (userChoice == 1)
            {
                menu.DisplayGoalMenu();
                int userGoal = menu.GetUserGoal();

                Console.Clear();

                if (userGoal == 1)
                {
                    Console.Write("\nWhat is the name of your goal? ");
                    string goalNameType1 = Console.ReadLine();

                    Console.Write("\nWrite a short description of your goal: ");
                    string goalDescType1 = Console.ReadLine();

                    Console.Write("\nHow many points will be associated with this goal? ");
                    string goalPointsType1 = Console.ReadLine();
                    int convPoints = int.Parse(goalPointsType1);

                    SimpleGoal sGoal = new SimpleGoal(goalNameType1, goalDescType1, convPoints);
                    goals.Add(sGoal);
                    
                }

                else if (userGoal == 2)
                {
                    Console.Write("\nWhat is the name of your goal? ");
                    string goalNameType2 = Console.ReadLine();

                    Console.Write("\nWrite a short description of your goal: ");
                    string goalDescType2 = Console.ReadLine();

                    Console.Write("\nHow many points will be associated with this goal? ");
                    string goalPointsType2 = Console.ReadLine();
                    int convPoints = int.Parse(goalPointsType2);

                    EternalGoal eGoal = new EternalGoal(goalNameType2, goalDescType2, convPoints);
                    goals.Add(eGoal);
                }

                else if (userGoal == 3)
                {
                    Console.Write("\nWhat is the name of your goal? ");
                    string goalNameType3 = Console.ReadLine();

                    Console.Write("\nWrite a short description of your goal: ");
                    string goalDescType3 = Console.ReadLine();

                    Console.Write("\nHow many points will be associated with this goal? ");
                    string goalPointsType3 = Console.ReadLine();
                    int convPoints = int.Parse(goalPointsType3);

                    Console.Write("\nHow many bonus points will you add after completing your Cheklist Goal? ");
                    string goalBonusPoints = Console.ReadLine();
                    int convBPoints = int.Parse(goalBonusPoints);

                    Console.Write("\nHow many times(write as a number) would you like to complete this goal? ");
                    string timesReq = Console.ReadLine();
                    int convTimes = int.Parse(timesReq);

                    CheckGoal cGoal = new CheckGoal(goalNameType3, goalDescType3, convPoints, convBPoints, convTimes);
                    goals.Add(cGoal);
                    
                }
            }

            //This else-if statement displays all of the goals that the user has created within the program.
            else if (userChoice == 2)
            {
                if (goals.Count == 0)
                {
                    Console.WriteLine("No goals have been created yet!");
                }
                
                foreach (Goal goal in goals)
                {
                    Console.WriteLine(goal.GetGoalDetails());
                }  
            }

            // This statement runs the Save() method which saves the goal variables in the right format on a file that the user types in.
            else if (userChoice == 3)
            {
                Console.Write("\nWhat is the filename that you would like to use? ");
                string _fileName = Console.ReadLine();

                Console.WriteLine($"Saving to the file {_fileName}...");

                Save(goals, _fileName);
                Console.WriteLine("Goals saved successfully!");
            }

            //This statement loads the saved goals from a file of a user's choosing. The Load() method also has a debug system that determines if the text on the file is the right format for the goals.
            else if (userChoice == 4)
            {
                Console.Write("\nWhat is the filename that you would like to use? ");
                string fileName = Console.ReadLine();

                Console.WriteLine($"Loading from the file {fileName}...");

                Load(fileName);
            }

            // This else-if statement allows the user to choose from the appropriately labeled goals they have created. They choose which goal they have just completed and it will count the points for it depending on which goal was completed and it will add to the "total_points" variable how many points were assigned to the goal.
            else if (userChoice == 5)
            {
                for (int i = 0; i < goals.Count; i++)
                {
                     if (goals[i] is SimpleGoal)
                        Console.WriteLine($"{i + 1}. {goals[i].GetName()} (Simple Goal)");
                    else if (goals[i] is EternalGoal)
                        Console.WriteLine($"{i + 1}. {goals[i].GetName()} (Eternal Goal)");
                    else if (goals[i] is CheckGoal)
                        Console.WriteLine($"{i + 1}. {goals[i].GetName()} (Checklist Goal)");
                }
                
                Console.Write("\nWhich goal(select the goal number) would you like to complete? ");
                
                int goalIndex = int.Parse(Console.ReadLine()) - 1;
                Goal selectedGoal = goals[goalIndex];

                if (selectedGoal is SimpleGoal simpleGoal)
                {
                    simpleGoal.IsCompleted();
                    totalPoints += simpleGoal.GetPoints();
                    goals.RemoveAt(goalIndex);
                }
                else if (selectedGoal is EternalGoal eternalGoal)
                {
                    totalPoints += eternalGoal.GetPoints();
                }
                else if (selectedGoal is CheckGoal checklistGoal)
                {
                    checklistGoal.RecordCompletion();
                    totalPoints += checklistGoal.GetTotal();
                }
            }

            // This statement closes the program when the user chooses.
            else if (userChoice == 6)
            {
                finished = true;

                Console.WriteLine("Thank you for using the Eternal Quest Program!");
                Thread.Sleep(3000);
                Console.Clear();
            }


        }while (finished == false); 
    }
    public static void Save(List<Goal> goals, string fileName)
    {
        // The Save() method writes out each goal within the Goals list out on the file of the user's choosing. There is a method in the goal.cs file that puts the user's goal data in the right format for the Load() method to read.
        
        string fileNamePass = $"{fileName}";

        using (StreamWriter outputFile = new StreamWriter(fileNamePass))
        {
            foreach (Goal goal in goals)
            {
                string goalDetails = goal.GetGoalDetailsForSave(); 

                Console.WriteLine(goalDetails);

                outputFile.WriteLine(goalDetails);
            }
        }
    }

    public static void Load(string fileName)
    {
        // The Load() method was challenging to configure, but this method removes the white spaces from the data while going through the file that the user types in.
        // It then checks each line for which type of goal the data matches on the text file preferably. If the text on the file is not written in the right format, it will display an error message.
        
        string fileNamePass2 = $"{fileName}";

        string[] lines = System.IO.File.ReadAllLines(fileNamePass2);

        foreach (string line in lines)
        {

            string[] parts = line.Split('|');

            if (parts.Length >= 4)
            {
                string goalType = parts[0].Trim();   
                string name = parts[1].Trim();       
                string desc = parts[2].Trim();       
                int points = int.Parse(parts[3].Trim()); 

                Console.WriteLine($"Goal Type: {goalType}, Name: {name}, Description: {desc}, Points: {points}"); 

                if (goalType == "SimpleGoal" && parts.Length == 4)
                {
                    SimpleGoal simpleGoal = new SimpleGoal(name, desc, points);
                    goals.Add(simpleGoal);
                }
                else if (goalType == "EternalGoal" && parts.Length == 4)
                {
                    EternalGoal eternalGoal = new EternalGoal(name, desc, points);
                    goals.Add(eternalGoal);
                }
                else if (goalType == "CheckGoal" && parts.Length == 6)
                {
                    int bonusPoints = int.Parse(parts[4].Trim());
                    int goalTimes = int.Parse(parts[5].Trim());

                    CheckGoal checkGoal = new CheckGoal(name, desc, points, bonusPoints, goalTimes);
                    goals.Add(checkGoal);
                }
                else
                {
                    Console.WriteLine("Invalid goal format found within the file."); 
                }
            }
            else
            {
                Console.WriteLine("Invalid goal format found within the file.");
            }
        }
    }

}