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

           
            valueWaitArray[0] = -40.80;   
            valueWaitArray[1] = -31.19;   
            valueWaitArray[2] = -23.54;   
            valueWaitArray[3] = -15.58;   
            valueWaitArray[4] = -7.76;    
            valueWaitArray[5] = 2.00;     
            valueWaitArray[6] = 9.44;     
            valueWaitArray[7] = 12.71;    
            valueWaitArray[8] = 6.02;     
            valueWaitArray[9] = -7.76;    
            valueWaitArray[10] = -27.64;  

            double[] res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }

        [TestMethod]
        public void TestDivisionByZero()
        {
            DataService ds = new DataService();

           
      
            double[] res = ds.GetMassFunction(0, 1);

           

            Assert.AreEqual(2.00, res[0]); 
            Assert.AreEqual(9.44, res[1]); 
        }
    }
}