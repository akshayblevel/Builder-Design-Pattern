using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution1
{
    class Program
    {
        static void Main(string[] args)
        {
            new Pizza(DoughType.Neapolitan_Pizza_Dough, true, Size.Medium, CheeseType.Swiss, new List<string> { "Tomato", "Capsicum","Corn" }).PizzaContent();
            Console.ReadKey();
        }
    }
}
