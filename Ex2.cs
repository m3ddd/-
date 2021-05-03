using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Ввести вес и рост человека. Рассчитать и вывести индекс массы тела(ИМТ) по формуле I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.

            Console.WriteLine("Расчет индекса массы тела");
            Console.WriteLine("Введите вес:");
            string a = Console.ReadLine();
            double m = Convert.ToDouble(a);
            Console.WriteLine("Введите рос:");
            string b = Console.ReadLine();
            double h = Convert.ToDouble(b);
            double c = m / (h * h);
            Console.WriteLine("ИМТ:");
            Console.WriteLine(c);
            Console.WriteLine();

        }
    }
}
