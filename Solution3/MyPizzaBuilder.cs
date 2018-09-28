using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution3
{
    public class MyPizzaBuilder
    {
        Pizza pizza;

        public Pizza GetPizza()
        {
            return pizza;
        }

        public void CreatePizza()
        {
            pizza = new Pizza();

            PrepareDough();
            ApplyVegetables();
            ApplyCheese();
            AddCondiments();
        }

        private void AddCondiments()
        {
            pizza.isRedPepper = true;
        }

        private void ApplyCheese()
        {
            pizza.cheeseType = CheeseType.American;
        }

        private void ApplyVegetables()
        {
            pizza.vegetables = new List<string> { "Tomato", "Corn" };
        }

        private void PrepareDough()
        {
            pizza.doughType = DoughType.Neapolitan_Pizza_Dough;
            pizza.size = Size.Large;
        }
    }
}
