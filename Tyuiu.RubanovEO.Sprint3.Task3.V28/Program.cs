
using Tyuiu.RubanovEO.Sprint3.Task3.V28.Lib;

namespace Tyuiu.RubanovEO.Sprint3.Task3.V28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3| Выполнил: Рубанов Е. О. | ПКТБ-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла foreach.                                           *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #28                                                             *");
            Console.WriteLine("* Выполнил: Рубанов Егор Олегович | ПКТБ-24-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach заменить цифры на букву r в строке:              *");
            Console.WriteLine("* f35hyt t4j 3gkg45                                                       *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Введите строку: ");
            string a = Console.ReadLine();
            Console.WriteLine("Введите символ: ");
            char start = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(ds.ReplaceNumOnChar(a, start));
            Console.ReadKey();

        }
    }
}
