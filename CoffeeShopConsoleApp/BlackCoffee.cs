using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    class BlackCoffee:Coffee
    {
        public override string Strength()
        {
            return "Strong";
        }
        public BlackCoffee(int discount) : base(discount)
        {
            Discount = discount;
        }
    }
}
