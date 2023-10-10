public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int numerator)
    {
        _top = numerator;
        _bottom = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _top = numerator;
        _bottom = denominator;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public void GetTop()
    {
        Console.WriteLine($"Numerator number: {_top}");
    }

    public void GetBottom()
    {
        Console.WriteLine($"Denominator number: {_bottom}");
    }

    public void GetFraction()
    {
        Console.WriteLine($"{_top}/{_bottom}");
    }

    public void GetDecimal()
    {
        float decimalNumber = (float)_top / _bottom;
        Console.WriteLine(decimalNumber);
    }
}