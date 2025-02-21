using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("David Grey","Algebra 101");

        MathAssignment math1 = new MathAssignment("Martin Flowers","Calculus", "6.9", "Problems 5-10");

        WritingAssignment writ1 = new WritingAssignment("Larry King", "Literature", "Peace and Warfare");
        
        Console.WriteLine(assignment1.GetSummary());

        Console.WriteLine(math1.GetSummary());
        Console.WriteLine(math1.GetHomeworkList());

        Console.WriteLine(writ1.GetSummary());
        Console.WriteLine(writ1.GetWritingInformation());
    }
}