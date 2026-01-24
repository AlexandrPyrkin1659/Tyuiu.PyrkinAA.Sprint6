using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PyrkinAA.Sprint6.Task4.V27.Lib;

namespace Tyuiu.PyrkinAA.Sprint6.Task4.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            int start = -5;
            int stop = 5;
            DataService ds = new DataService();

           
            double[] wait = {
                Math.Round(Math.Cos(-5)/(-4) - Math.Cos(-5)*1.3 + 3*(-5), 2),
                Math.Round(Math.Cos(-4)/(-3) - Math.Cos(-4)*1.3 + 3*(-4), 2),
                Math.Round(Math.Cos(-3)/(-2) - Math.Cos(-3)*1.3 + 3*(-3), 2),
                Math.Round(Math.Cos(-2)/(-1) - Math.Cos(-2)*1.3 + 3*(-2), 2),
                0, 
                Math.Round(Math.Cos(0)/1 - Math.Cos(0)*1.3 + 3*0, 2),
                Math.Round(Math.Cos(1)/2 - Math.Cos(1)*1.3 + 3*1, 2),
                Math.Round(Math.Cos(2)/3 - Math.Cos(2)*1.3 + 3*2, 2),
                Math.Round(Math.Cos(3)/4 - Math.Cos(3)*1.3 + 3*3, 2),
                Math.Round(Math.Cos(4)/5 - Math.Cos(4)*1.3 + 3*4, 2),
                Math.Round(Math.Cos(5)/6 - Math.Cos(5)*1.3 + 3*5, 2)
            };

            double[] res = ds.GetMassFunction(start, stop);

            
            for (int i = 0; i < wait.Length; i++)
            {
                Assert.AreEqual(wait[i], res[i], 0.01, $"Ошибка на элементе {i}");
            }
        }

        [TestMethod]
        public void CheckDivisionByZero()
        {
            DataService ds = new DataService();

            
            double[] res = ds.GetMassFunction(-2, 0);

          
            Assert.AreEqual(0, res[1], "Неверная обработка деления на ноль");
        }
    }
}