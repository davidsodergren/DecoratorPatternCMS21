namespace Test;

public class Espresso : Beverage
{
    public string getDescription()
    {
        return "Espresso";
    }

    public decimal cost()
    {
        return new decimal(4.3);
    }
}