using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution4
{
    public class Pizza
    {
       public DoughType doughType {get; set;}
       public bool isRedPeeper { get; set; }
       public Size size { get; set; }
       public CheeseType cheeseType { get; set; }
       public List<string> vegetables { get; set; }
       
        public void PizzaContent()
        {
            Console.WriteLine("Pizza with {0}", doughType);
            if (isRedPeeper)
                Console.WriteLine("Red Peeper");
            Console.WriteLine("Size: {0}", size);
            Console.WriteLine("Cheese Type: {0}", cheeseType);
            Console.WriteLine("Vegetables:");
            foreach (var item in vegetables)
            {
                Console.WriteLine(" {0}", item);
            }
        }
    }
    public enum DoughType
    {
        Neapolitan_Pizza_Dough = 1,
        NewYorkStyle_Pizza_Dough = 2,
        SquarePan_Pizza_Dough = 3
    }

    public enum CheeseType
    {
        American = 1,
        Swiss = 2,
    }

    public enum Size
    {
        Small = 1,
        Medium = 2,
        Large = 3
    }
}
