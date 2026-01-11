using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.PyrkinAA.Sprint6.Task0.V27.Lib
{
    public class DataService : ISprint6Task0V27
    {
        public double Calculate(int x)
        {
           
            double result = -x * x * x + 4 * x * x - (3.0 / 2.0) * x;
            return Math.Round(result, 3);
        }
    }
}