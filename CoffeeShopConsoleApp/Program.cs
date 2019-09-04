using System;
using System.Collections.Generic;

namespace CoffeeShopConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Coffee Shop!");

            // a list of all the orders for coffe in the coffee shop
            List<Coffee> orderList = new List<Coffee>()
            {
               new Latte(0),
                new BlackCoffee(15),
                new Cortado(15)

            };

            List<Milk> milkyList = new List<Milk>();
            milkyList.Add(new Latte(10));
            milkyList.Add(new Cortado(20));
            orderList.Add(new IrishCoffee(30));


            foreach (var coffee in orderList)
            {
                Console.WriteLine("the Price of the coffee is : "+ coffee.price() +", the strength of the coffe is: "+coffee.Strength());
            }



        }
    }
}
