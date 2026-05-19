/* Used to remind myself how ": this()" works
 * path = Learning03/duck.ai_2026-05-19_14-09-54.txt
 */

 public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructors
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber) : this() {
        _top = wholeNumber;
    }

    public Fraction(int top, int bottom) : this(top)
    {
        _bottom = bottom;
    }


    // Getters and Setters
    public void SetTop(int top)
    {
        _top = top;
    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    public int GetTop()
    {
        return _top;
    }
    public int GetBottom()
    {
        return _bottom;
    }

    // Methods
    public double GetDecimalValue()
    {
        double decimalValue = (double)_top / _bottom;
        return decimalValue;
    }
    public string GetFractionString()
    {
        string resultAsString = $"{_top}/{_bottom}";
        return resultAsString;
    }

}