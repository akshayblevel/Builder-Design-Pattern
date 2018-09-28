using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution4
{
     public class TomatoPizzaBuilder : PizzaBuilder
    {
        public override void AddCondiments()
        {
            pizza.isRedPeeper = true;
        }

        public override void ApplyCheese()
        {
            pizza.cheeseType = CheeseType.Swiss;
        }

        public override void ApplyVegetables()
        {
            pizza.vegetables = new List<string> { "Tomato" };
        }

        public override void PrepareDough()
        {
            pizza.doughType = DoughType.Neapolitan_Pizza_Dough;
            pizza.size = Size.Large;
        }
    }
}
