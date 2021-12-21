namespace Test;

public class HouseBlend : Beverage
{
    public string getDescription()
    {
        return "House blend";
    }

    public decimal cost()
    {
        return new decimal(2);
    }
}