using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution4
{
    public abstract class PizzaBuilder
    {
        protected Pizza pizza;

        public Pizza GetPizza()
        {
            return pizza;
        }

        public void CreateNewPizza()
        {
            pizza = new Pizza();
        }

        public abstract void PrepareDough();
        public abstract void ApplyVegetables();
        public abstract void ApplyCheese();
        public abstract void AddCondiments();
    }
}
