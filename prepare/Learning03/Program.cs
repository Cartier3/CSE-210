using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nWelcome to the Fraction Program!");

        Fraction make_Fraction1 = new Fraction(); 
        make_Fraction1.GetFractionString();
        
        Fraction make_Fraction2 = new Fraction();
        make_Fraction2.SetTop(6);
        make_Fraction2.GetFractionString();

        
        Fraction make_Fraction3 = new Fraction();
        make_Fraction3.SetTop(6);
        make_Fraction3.SetBottom(7);
        make_Fraction3.GetFractionString();

        Fraction make_Fraction4 = new Fraction();
        make_Fraction4.SetTop(3);
        make_Fraction4.SetBottom(4);
        make_Fraction4.GetFractionString();
        make_Fraction4.GetDecimalValue();

        Fraction make_Fraction5 = new Fraction();
        make_Fraction5.SetTop(1);
        make_Fraction5.SetBottom(3);
        make_Fraction5.GetFractionString();
        make_Fraction5.GetDecimalValue();

    }
}