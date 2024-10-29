
using Tyuiu.RubanovEO.Sprint3.Task5.V4.Lib;

namespace Tyuiu.RubanovEO.Sprint3.Task5.V4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3| Выполнил: Рубанов Е. О. | ПКТБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Вложенные циклы.                                                  *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Рубанов Егор Олегович | ПКТБ-24-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* 'формула' при х = 5.                                                    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите а: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите начало 1: ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конец 1: ");
            int stop = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите начало 2: ");
            int start2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конец 2: ");
            int stop2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.GetSumSumSeries(a, start, start2, stop, stop2));
            Console.ReadKey();
        }
    }
}
