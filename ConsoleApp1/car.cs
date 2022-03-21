using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class car
    {
        string color = "red";
        int cc = 1500;
        string brand = "bmw";

        public void StartEngin()
        {
            Console.WriteLine("發動引擎");
        }

        public void ShowInfo()
        {
            Console.WriteLine("顏色：" + color);
            Console.WriteLine("cc數：" + cc);
            Console.WriteLine("品牌" + brand);
        }
    }
}
