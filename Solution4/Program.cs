using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution4
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizzaMaker = new PizzaMaker(new MyPizzaBuilder());
            pizzaMaker.BuildPizza();
            var pizza1 = pizzaMaker.GetPizza();

            pizza1.PizzaContent();

            pizzaMaker = new PizzaMaker(new TomatoPizzaBuilder());
            pizzaMaker.BuildPizza();
            var pizza2 = pizzaMaker.GetPizza();

            pizza2.PizzaContent();

            Console.ReadKey();
        }
    }
}
