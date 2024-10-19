
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RubanovEO.Sprint3.Task2.V16.Lib
{
    public class DataService : ISprint3Task2V16
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double i = startValue;
            double ans = 1;
            do
            {
                ans *= Math.Round( Math.Pow(1d / Math.Pow(i,value), -1), 3);
                i++;
            }while (i <= stopValue);
            return ans;
        }
    }
}
