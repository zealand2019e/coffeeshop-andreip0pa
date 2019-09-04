using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
     class Cortado : Coffee, Milk,IMixable
    {

       
        public Cortado(int discount) : base (discount)
        {
            Discount = discount;
        }

        public void Mix(IMixable otherMixable)
        {
            if (otherMixable.GetType() == typeof(Latte))
            {
                Console.Write("You got some milky weird mix!");

            }

            if (otherMixable.GetType() == typeof(Cortado))
            {
                Console.Write("You just got a very big Cortado! Nothing special!");
            }
        }

        public int mlMilk()
        {
            return 40;
        }
       
        public override int price()
        {
            return 25;
        }

        public override string Strength()
        {
            return "Medium";
        }
    }
}
