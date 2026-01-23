using Tyuiu.PyrkinAA.Sprint6.Task2.V8.Lib;
namespace Tyuiu.PyrkinAA.Sprint6.Task2.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int start = -5;
            int end = 5;
            double[] res = dataService.GetMassFunction(start, end);
            Console.WriteLine(res);
        }
    }
}