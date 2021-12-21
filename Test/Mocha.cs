namespace Test;

public class Mocha : CondimentDecorator
{
    public Mocha(Beverage beverage) : base(beverage)
    {
    }

    public override string getDescription()
    {
        return Beverage.getDescription() + ", Mocha";
    }

    public override decimal cost()
    {
        return new decimal(1.1) + Beverage.cost();
    }
}