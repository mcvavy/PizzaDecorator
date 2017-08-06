using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaDecorator.Decorator;

namespace PizzaDecorator.ConcreteDecorators
{
    public class Cheese : PizzDecorator
    {
        private const decimal Price = 1.85m;

        public Cheese(Pizza pizza) : base(pizza)
        {
            Description = "Cheese";
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
