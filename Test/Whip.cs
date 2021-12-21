namespace Test;

public class Whip : CondimentDecorator
{
    public Whip(Beverage beverage) : base(beverage)
    {
    }

    public override string getDescription()
    {
        return Beverage.getDescription() + ", Whip";
    }

    public override decimal cost()
    {
        return new decimal(1.4) + Beverage.cost();
    }
}