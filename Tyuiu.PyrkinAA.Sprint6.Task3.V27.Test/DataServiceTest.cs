using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PyrkinAA.Sprint6.Task3.V27.Lib;

namespace Tyuiu.PyrkinAA.Sprint6.Task3.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int[,] matrix = {
                { 9, 13, -14, 23, 1 },
                { 15, -17, 21, 25, 23 },
                { -4, 29, -20, -10, 14 },
                { 27, 33, 12, 33, -12 },
                { 18, -9, -5, 6, 3 }
            };

            int[,] resMatrix = ds.Calculate(matrix);

            int[,] wait = {
                { -4, 29, -20, -10, 14 },
                { 18, -9, -5, 6, 3 },
                { 9, 13, -14, 23, 1 },
                { 15, -17, 21, 25, 23 },
                { 27, 33, 12, 33, -12 }
            };

            CollectionAssert.AreEqual(wait, resMatrix);
        }
    }
}
