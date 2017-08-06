using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator.Decorator
{
    public class PizzDecorator : Pizza
    {
        protected readonly Pizza _pizza;

        public PizzDecorator(Pizza pizza)
        {
            _pizza = pizza;
        }

        public override string GetDescription()
        {
            return _pizza.Description;
        }

        public override decimal CalculateCost()
        {
            return _pizza.CalculateCost();
        }
    }
}
