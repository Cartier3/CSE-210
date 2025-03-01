class Menu
{
    public void DisplayMenu()
    {
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("1. Breathing Activity ");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
    }

    public int GetUserInput()
    {
        Console.Write("\nSelect an Activity Number from the Menu: ");
        string userInput = Console.ReadLine();
        int ConvInput = int.Parse(userInput);

        return ConvInput;
    }
}