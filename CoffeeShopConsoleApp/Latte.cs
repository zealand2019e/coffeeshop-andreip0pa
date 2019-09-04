using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Latte:Coffee,Milk
    {
        public int mlMilk()
        {
            return 200;
        }

        public override int price()
        {
            return 40;
        }

        public override string Strength()
        {
            return "Weak";
        }
    }
}
