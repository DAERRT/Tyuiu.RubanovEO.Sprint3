﻿
using System.Threading.Tasks.Dataflow;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.RubanovEO.Sprint3.Task4.V25.Lib
{
    public class DataService : ISprint3Task4V25
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            if ((startValue >= -5) && (stopValue <=5))
            {
                for (double i = startValue; i <= stopValue; i++)
                {
                    if (i == 0)
                    {
                        continue;
                    }else
                    {
                        res += i / (Math.Cos(i) - Math.Sin(i));
                    }

                }
                return Math.Round(res,3);
            }
                return 0;  
        }
    }
}
