using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructors

    // Default
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // top given
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    // top and bottom given
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // User Inputs

    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Format Strings
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}