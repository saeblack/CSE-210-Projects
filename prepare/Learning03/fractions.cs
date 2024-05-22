using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public override string ToString()
    {
        string fractionText = $"{_numerator}/{_denominator}";
        return fractionText;
    }

    public double ToDecimal()
    {
        double decimalValue = (double)_numerator / (double)_denominator;
        return decimalValue;
    }
}

