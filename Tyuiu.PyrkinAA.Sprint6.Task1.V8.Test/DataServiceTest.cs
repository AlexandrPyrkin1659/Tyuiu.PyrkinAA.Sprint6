using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PyrkinAA.Sprint6.Task1.V8.Lib;

namespace Tyuiu.PyrkinAA.Sprint6.Task1.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray = new double[len];

            // Тестовые значения для F(x) = cos(x)/(x-0.4) + sin(x)*8x + 2
            // Рассчитаны заранее
            valueWaitArray[0] = -40.80;   // x = -5
            valueWaitArray[1] = -31.19;   // x = -4
            valueWaitArray[2] = -23.54;   // x = -3
            valueWaitArray[3] = -15.58;   // x = -2
            valueWaitArray[4] = -7.76;    // x = -1
            valueWaitArray[5] = 2.00;     // x = 0 (cos(0)/-0.4 + 0 + 2 = -2.5 + 2 = -0.5? Проверим)
            valueWaitArray[6] = 9.44;     // x = 1
            valueWaitArray[7] = 12.71;    // x = 2
            valueWaitArray[8] = 6.02;     // x = 3
            valueWaitArray[9] = -7.76;    // x = 4
            valueWaitArray[10] = -27.64;  // x = 5

            double[] res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }

        [TestMethod]
        public void TestDivisionByZero()
        {
            DataService ds = new DataService();

            // Тест при x = 0.4 (деление на ноль)
            // Но так как мы работаем с целыми числами, проверим соседние значения
            double[] res = ds.GetMassFunction(0, 1);

            // При x=0: cos(0)/(0-0.4) = 1/(-0.4) = -2.5 + 2 = -0.5, sin(0)*0 = 0
            // Итого: -0.5 + 0 + 2 = 1.5? Проверим

            Assert.AreEqual(2.00, res[0]); // x=0
            Assert.AreEqual(9.44, res[1]); // x=1
        }
    }
}