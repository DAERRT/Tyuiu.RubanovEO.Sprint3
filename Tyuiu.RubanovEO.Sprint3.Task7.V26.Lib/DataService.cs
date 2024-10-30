
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RubanovEO.Sprint3.Task7.V26.Lib
{
    public class DataService : ISprint3Task7V26
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[11];
            int j = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if (2d * i - 0.5d != 0)
                {
                    result[j] = Math.Round(5d - 3d * i + ((1d + Math.Sin(i))/(2d * i - 0.5d)), 2);
                    j++;
                }
                else
                {
                    result[j] = 0;
                    j++;
                }
            }
            return result;
        }
    }
}
