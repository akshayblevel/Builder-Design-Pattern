using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution3
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new MyPizzaBuilder();
            builder.CreatePizza();
           var pizza = builder.GetPizza();
            pizza.PizzaContent();

            Console.ReadKey();
        }
        
    }
}
