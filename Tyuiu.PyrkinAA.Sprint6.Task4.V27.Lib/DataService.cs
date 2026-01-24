using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PyrkinAA.Sprint6.Task4.V27.Lib
{
    public class DataService : ISprint6Task4V27
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] res = new double[len];
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double y = 0;

              
                if (x == -1)
                {
                    y = 0;
                }
                else
                {
                   
                    y = Math.Cos(x) / (x + 1) - Math.Cos(x) * 1.3 + 3 * x;
                }

                res[count] = Math.Round(y, 2);
                count++;
            }

            return res;
        }
    }
}