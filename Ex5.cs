using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
            // б) Сделать задание, только вывод организовать в центре экрана.

            Console.WriteLine("Ввдедите свое имя: ");
            string a = Console.ReadLine();
            Console.WriteLine("Введите свою фамилию: ");
            string b = Console.ReadLine();
            Console.WriteLine("Введите город проживания: ");
            string c = Console.ReadLine();
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine($"Имя: {a} Фамилия: {b} Город проживания: {c}");



        }
    }
}
