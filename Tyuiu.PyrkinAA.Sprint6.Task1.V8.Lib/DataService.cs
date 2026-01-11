using tyuiu.cources.programming.interfaces.Sprint6;
using System;

namespace Tyuiu.PyrkinAA.Sprint6.Task1.V8.Lib
{
    public class DataService : ISprint6Task1V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] valueArray = new double[len];

            for (int i = 0; i < len; i++)
            {
                int x = startValue + i;
                double denominator = x - 0.4;


                if (Math.Abs(denominator) < 0.0001)
                {
                    valueArray[i] = 0;
                }
                else
                {

                    double result = Math.Cos(x) / denominator + Math.Sin(x) * 8 * x + 2;
                    valueArray[i] = Math.Round(result, 2);
                }
            }
            return valueArray;
        }
    }
}
