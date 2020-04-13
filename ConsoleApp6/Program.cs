using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            
                bool prost = true;
                Console.WriteLine("Введите число");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 2; i <= n / 2; i++)
                {
                    if (n % i == 0)
                    {
                        prost = false;
                        break;
                    }
                }
                if (prost)
                {
                    Console.WriteLine("Число простое");
                }
                else
                {
                    Console.WriteLine("Число не простое");
                }
                Console.ReadKey();
            

        }
    }
}
