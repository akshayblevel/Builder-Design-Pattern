using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution4
{
    public class MyPizzaBuilder : PizzaBuilder
    {
        public override void AddCondiments()
        {
            pizza.isRedPeeper = true;
        }

        public override void ApplyCheese()
        {
            pizza.cheeseType = CheeseType.American;
        }

        public override void ApplyVegetables()
        {
            pizza.vegetables = new List<string> { "Tomato", "Corn" };
        }

        public override void PrepareDough()
        {
            pizza.doughType = DoughType.Neapolitan_Pizza_Dough;
            pizza.size = Size.Large;
        }
    }
}
