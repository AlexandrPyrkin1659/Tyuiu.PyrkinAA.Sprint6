using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PyrkinAA.Sprint6.Task2.V8.Lib
{
    public class DataService : ISprint6Task2V8
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = stopValue - startValue + 1;
            double[] ArrayFunc = new double[len];

            int Index = 0;
            for (int i = startValue; i <= stopValue; i++)
            {
                if ((i + 2.5) == 0)
                {
                    ArrayFunc[Index] = 0;
                }
                else
                {
                    double res = Math.Cos(2 * i) + (Math.Sin(i) / (i + 2.5)) + 2 * i;
                    ArrayFunc[Index] = Math.Round(res, 2);
                }
                Index++;
            }
            return ArrayFunc;
        }
    }
}