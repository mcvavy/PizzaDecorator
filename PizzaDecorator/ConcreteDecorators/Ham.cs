using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaDecorator.Decorator;

namespace PizzaDecorator.ConcreteDecorators
{
    public class Ham : PizzDecorator
    {
        private const decimal Price = 3.75m;

        public Ham(Pizza pizza) : base(pizza)
        {
            Description = "Ham";
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
