namespace Test;

public class Decaf : Beverage
{
    public string getDescription()
    {
        return "Decaf";
    }

    public decimal cost()
    {
        return new decimal(1.9);
    }
}