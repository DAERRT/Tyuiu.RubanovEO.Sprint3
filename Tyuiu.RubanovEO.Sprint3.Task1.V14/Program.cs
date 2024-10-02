
using Tyuiu.RubanovEO.Sprint3.Task1.V14.Lib;

namespace Tyuiu.RubanovEO.Sprint3.Task1.V14;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.WriteLine(ds.GetSumSeries(0.7,1,14));
    }
}
