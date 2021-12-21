namespace Test;

public class Soy : CondimentDecorator
{
    public Soy(Beverage beverage) : base(beverage)
    {
    }

    public override string getDescription()
    {
        return Beverage.getDescription() + ", Soy";
    }

    public override decimal cost()
    {
        return new decimal(0.3) + Beverage.cost();
    }
}