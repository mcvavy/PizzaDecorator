using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaDecorator.Decorator;


namespace PizzaDecorator.ConcreteDecorators
{
    public class DoubleCheese : PizzDecorator
    {
        private const decimal Price = 3.85m;

        public DoubleCheese(Pizza pizza) : base(pizza)
        {
            Description = "Double Cheese";
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
