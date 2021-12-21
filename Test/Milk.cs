namespace Test;

public class Milk : CondimentDecorator
{
    public Milk(Beverage beverage) : base(beverage)
    {
    }

    public override string getDescription()
    {
        return Beverage.getDescription() + ", Milk";
    }

    public override decimal cost()
    {
        return new decimal(0.9) + Beverage.cost();
    }
}