using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Написать программу обмена значениями двух переменных типа int без использования вспомогательных методов.
            // а) с использованием третьей переменной;
            // б) *без использования третьей переменной.


            Console.WriteLine("Введите a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ввелиие b: ");
            int b = int.Parse(Console.ReadLine());

            int c = a;

            a = b;
            b = c;

            Console.WriteLine($"a = {a} b = {b}");

        }
    }
}
