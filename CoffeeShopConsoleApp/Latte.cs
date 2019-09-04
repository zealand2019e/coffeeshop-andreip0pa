using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Latte:Coffee,Milk,IMixable
    {
        public int mlMilk()
        {
            return 200;
        }
        public Latte(int discount) : base(discount)
        {
            Discount = discount;
        }
        public override int price()
        {
            return 40;
        }

        public override string Strength()
        {
            return "Weak";
        }

        public void Mix(IMixable otherMixable)
        {
            if (otherMixable.GetType() == typeof(Latte))
            {
                Console.Write("You just got a very big latte! Nothing special!");

            }

            if (otherMixable.GetType() == typeof(Cortado))
            {
                Console.Write("You got some weird milky mix!");
                Discount += 5;
            }
        }
    }
}
