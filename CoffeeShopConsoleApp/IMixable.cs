using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopConsoleApp
{
    interface IMixable
    {
         void Mix(IMixable otherMixable);
    }
}
