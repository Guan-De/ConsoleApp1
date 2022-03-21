using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double meal_cost = 100;
            int tip_percent = 15;
            int tax_percent = 8;

            int meal_costint = (int)meal_cost;

            int sum = meal_costint + tip_percent + tax_percent;

            Console.WriteLine("Total Cost：" + sum);
            */

            //await Mhttp();

            int minRange = 0, maxRange = 100;
            int ans = MyRandom(0, 100);
            Console.WriteLine("答案："+ans);
            int guess;
            Console.Write("請輸入0~100間的數：");
            guess = int.Parse(Console.ReadLine());
            int count = 5;

            while(count > 0)
            {               
                count--;
                if(guess == ans)
                {
                    Console.WriteLine("答對了！");
                    break;
                }
                if (guess > ans)
                {
                    maxRange = guess;
                    Console.Write("介於" + maxRange + "到" + minRange + "之間");
                    
                }
                if(guess < ans)
                {
                    minRange = guess;
                    Console.Write("介於" + maxRange + "到" + minRange + "之間");
               
                }
                Console.Write("，剩餘" + count + "次\n");
                Console.Write("請輸入"+ maxRange + "~" + minRange +"間的數：");
                guess = int.Parse(Console.ReadLine());
            }

        }

        /*
        static async Task Mhttp()
        {
            // Call asynchronous network methods in a try/catch block to handle exceptions.
            HttpClient client = new HttpClient();
            try
            {
                HttpResponseMessage response = await client.GetAsync("http://www.contoso.com/");
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                // Above three lines can be replaced with new helper method below
                // string responseBody = await client.GetStringAsync(uri);

                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
        }
        */

        static private int MyRandom(int minNum, int maxNum)
        {
            Random random = new Random();

            return random.Next(minNum, maxNum + 1);
        }
    }
}
