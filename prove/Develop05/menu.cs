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

    public int GetUserInput()
    {
        Console.Write("\nSelect a choice from the menu: ");
        string userInput = Console.ReadLine();
        int ConvInput = int.Parse(userInput);

        return ConvInput;
    }

}