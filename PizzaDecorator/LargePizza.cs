using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    public class LargePizza : Pizza
    {
        private const decimal Price = 10.00m;
        public LargePizza()
        {
            Description = "Large Pizza";
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
