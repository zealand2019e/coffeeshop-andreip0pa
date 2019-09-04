using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class Cortado:Coffee,Milk
    {
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
