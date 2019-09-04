using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class IrishCoffee:Coffee
    {
        public IrishCoffee(int discount):base(discount)
        {

        }

        public override string Strength()
        {
            return "Strong";
        }
    }
}
