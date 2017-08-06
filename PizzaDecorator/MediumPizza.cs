using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDecorator
{
    public class MediumPizza : Pizza
    {
        private const decimal Price = 7.00m;
        public MediumPizza()
        {
            Description = "Medium Pizza";
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
