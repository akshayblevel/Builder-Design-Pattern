using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizza = new Pizza();
            pizza.doughType = DoughType.Neapolitan_Pizza_Dough;
            pizza.isRedPepper = true;
            pizza.size = Size.Large;
            pizza.cheeseType = CheeseType.American;
            pizza.vegetables = new List<string> { "Tomato", "Corn" };

            pizza.PizzaContent();

            Console.ReadKey();
        }
    }
}
