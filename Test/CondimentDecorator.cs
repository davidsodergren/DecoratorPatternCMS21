namespace Test;

public abstract class CondimentDecorator : Beverage
{
    public Beverage Beverage;

    protected CondimentDecorator(Beverage beverage)
    {
        Beverage = beverage;
    }

    public abstract string getDescription();

    public abstract decimal cost();
}