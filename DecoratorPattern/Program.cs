using DecoratorPattern.ConcreteDecorator;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Girl fata = new Girl();
            fata.name = "Dora";
            BackpackDecorator backpackDecorator = new BackpackDecorator(fata);
            LunchDecorator lunchDecorator = new LunchDecorator(backpackDecorator);
            BowDecorator bowDecorator = new BowDecorator(lunchDecorator);
            Console.WriteLine(bowDecorator.GirlDescription());
        }
    }
}
