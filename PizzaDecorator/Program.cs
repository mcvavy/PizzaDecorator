using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaDecorator.ConcreteDecorators;
using PizzaDecorator.Decorator;

namespace PizzaDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza largePizza = new LargePizza();
            largePizza = new Cheese(largePizza);
            largePizza = new Olive(largePizza);
            largePizza = new Ham(largePizza);

            Console.WriteLine($"{largePizza.GetDescription()} costs £{largePizza.CalculateCost()}");


            Pizza smallPizza = new SmallPizza();
            smallPizza = new Cheese(smallPizza);
            smallPizza = new Olive(smallPizza);
            smallPizza = new Ham(smallPizza);

            Console.WriteLine($"{smallPizza.GetDescription()} costs £{smallPizza.CalculateCost()}");


            Pizza mediumPizza = new MediumPizza();
            mediumPizza = new Cheese(mediumPizza);
            mediumPizza = new Olive(mediumPizza);

            Console.WriteLine($"{mediumPizza.GetDescription()} costs £{mediumPizza.CalculateCost()}");



            Pizza mediumPizza2 = new MediumPizza();
            mediumPizza2 = new DoubleCheese(mediumPizza2);
            mediumPizza2 = new Olive(mediumPizza2);

            Console.WriteLine($"{mediumPizza2.GetDescription()} costs £{mediumPizza2.CalculateCost()}");


            Console.ReadLine();
        }
    }
}
