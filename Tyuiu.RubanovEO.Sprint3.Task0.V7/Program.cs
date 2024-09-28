
using Tyuiu.RubanovEO.Sprint3.Task0.V7.Lib;

namespace Tyuiu.RubanovEO.Sprint3.Task0.V7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3| Выполнил: Рубанов Е. О. | ПКТБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Рубанов Егор Олегович | ПКТБ-24-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значение двух    *");
            Console.WriteLine("* одинаковых массивов по длинне.                                          *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите а: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите предел: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите k: ");
            int stop = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetSumSeries(a,start,stop));
            Console.ReadKey();

        }
    }
}
