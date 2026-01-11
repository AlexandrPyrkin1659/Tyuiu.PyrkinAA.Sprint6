using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PyrkinAA.Sprint6.Task0.V27.Lib;

namespace Tyuiu.PyrkinAA.Sprint6.Task0.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            double res = ds.Calculate(4); 
            double wait = -6.000; 

            Assert.AreEqual(wait, res);
        }
    }
}