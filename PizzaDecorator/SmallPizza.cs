using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    public class SmallPizza : Pizza
    {
        private const decimal Price = 5.00m;
        public SmallPizza()
        {
            Description = "Small Pizza";
        }
        public override string GetDescription()
        {
            return Description;
        }

        public override decimal CalculateCost()
        {
            return Price;
        }
    }
}
