namespace Test;

public class DarkRoast : Beverage
{
    public string getDescription()
    {
        return "Dark roast";
    }

    public decimal cost()
    {
        return new decimal(3.2);
    }
}