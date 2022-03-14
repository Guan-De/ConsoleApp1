using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double meal_cost = 100;
            int tip_percent = 15;
            int tax_percent = 8;

            int meal_costint = (int)meal_cost;

            int sum = meal_costint + tip_percent + tax_percent;

            Console.WriteLine("Total Cost：" + sum);
        }
    }
}
