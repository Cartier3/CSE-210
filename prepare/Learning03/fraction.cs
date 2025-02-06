using System.Diagnostics.Contracts;
using System.Xml;
using System.Xml.XPath;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int _bottom)
    {
        _bottom = 1;
    }

    public Fraction(int _top, int _bottom)
    {
        
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int new_top)
    {
        _top = new_top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int new_bottom)
    {
        _bottom = new_bottom;
    }

    public void GetFractionString()
    {
        Console.WriteLine($"\n{_top}/{_bottom}");
    }

    public void GetDecimalValue()
    {
        double dec = (double)_top / (double)_bottom;
        Console.WriteLine($"\n{dec}");
    }

}