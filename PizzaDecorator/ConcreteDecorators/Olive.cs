using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaDecorator.Decorator;

namespace PizzaDecorator.ConcreteDecorators
{
    public class Olive : PizzDecorator
    {
        private const decimal Price = 3.75m;

        public Olive(Pizza pizza) : base(pizza)
        {
            Description = "Olives";
        }

        public override string GetDescription()
        {
            return _pizza.GetDescription() + ", " + Description;
        }

        public override decimal CalculateCost()
        {
            return _pizza.CalculateCost() + Price;
        }
    }
}
