using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution4
{
   public  class PizzaMaker
    {
       private readonly PizzaBuilder builder;

       public PizzaMaker(PizzaBuilder builder)
       {
           this.builder = builder;
       }

       public void BuildPizza()
       {
           builder.CreateNewPizza();
           builder.PrepareDough();
           builder.ApplyVegetables();
           builder.ApplyCheese();
           builder.AddCondiments();
       }

       public Pizza GetPizza()
       {
           return builder.GetPizza();
       }
    }
}
