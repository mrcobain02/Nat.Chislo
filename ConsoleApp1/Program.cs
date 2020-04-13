using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool av = true;
            Console.WriteLine("Введите число");
            double a = Convert.ToInt32(Console.ReadLine());
            if (a / 0)
            {
                av = false;
            }
        }
    }
}
