using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите свое имя");
            string a = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию");
            string b = Console.ReadLine();
            Console.WriteLine("Введите свой возраст");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите свой вес");
            int d = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Имя:{a} Фамилия:{b} Возраст:{c} Вес:{d}");

        }
    }
}
