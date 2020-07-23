using System;
using DecoratorPattern.Drink;
using DecoratorPattern.Condiment;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // 买一杯果汁
            BaseDrink juice = new JuiceDrink();

            Console.WriteLine($"{juice.GetName()}");

            // 加椰果
            BaseCondiment last = new CoconutGrain(juice);

            Console.WriteLine($"name:{last.GetName()},price:{last.GetPrice()}");

            // 加布丁
            last = new Pudding(last);

            Console.WriteLine($"name:{last.GetName()},price:{last.GetPrice()}");

            Console.ReadLine();
        }
    }
}
