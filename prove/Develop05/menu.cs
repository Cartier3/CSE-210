class Menu
{
    public void DisplayMenu()
    {
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
    }

    public void DisplayGoalMenu()
    {
        Console.WriteLine("\nThe types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
    }

    public int GetUserInput()
    {
        Console.Write("\nSelect a choice(number) from the menu: ");
        string userInput = Console.ReadLine();
        int ConvInput = int.Parse(userInput);

        return ConvInput;
    }

    public int GetUserGoal()
    {
        Console.Write("\nWhich type of Goal(number) would you like to create? ");
        string userInput = Console.ReadLine();
        int ConvInput = int.Parse(userInput);

        return ConvInput;
    }

    

}