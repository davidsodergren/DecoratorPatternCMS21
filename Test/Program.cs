// Hello World! program
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Mocha(new Whip(new Soy(new Espresso())));
            
            
            Console.WriteLine(beverage.cost());
            Console.WriteLine(beverage.getDescription());

        }
    }
}
