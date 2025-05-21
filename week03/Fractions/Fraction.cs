using System.Dynamic;

public class Fraction 
{
    private int _numerator;
    private int _denominator;

// Constructor with no parameters
// Initializes the fraction to 1/1
    public Fraction()
    {
      _numerator = 1;
      _denominator = 1;
      
    }

// Constructor with one parameter
// Initializes the fraction to numerator/1
    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

// Constructor with two parameters
// Initializes the fraction to numerator/denominator
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public override string ToString()
    {
        return $"{_numerator}/{_denominator}";
    }


    public void GetNumerator()
    {
    }
    public void SetNumerator()
    {
    }

    public void GetDenominator()
    {
    }
    public void SetDenominator()
    {
    }

    public double GetDecimal()
    {
        return (double)_numerator / _denominator;
    }

    public string GetString()
    {

        string text = $"{_numerator}/{_denominator}";
        return text;

    }

}

