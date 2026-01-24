using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Tyuiu.PyrkinAA.Sprint6.Task5.V9.Lib;

namespace Tyuiu.PyrkinAA.Sprint6.Task5.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
           
            string path = @"C:\temp\TestFileV9.txt";

            try
            {
                
                string[] testData = {
                    "1.234567",
                    "0.000000",
                    "-2.345678",
                    "0",
                    "3.456789",
                    "-0.000123",
                    "4.567890",
                    "0.000000",
                    "-5.678901",
                    "0.001000", 
                    "6.789012",
                    "0.000000",
                    "-7.890123",
                    "0.000500", 
                    "8.901234",
                    "0.000000"
                };

                File.WriteAllLines(path, testData);

                DataService ds = new DataService();
                double[] res = ds.LoadFromDataFile(path);

                
                double[] waitArray = {
                    0.000,  
                    0.000,  
                    0.000,  
                    0.001,  
                    
                };

               
                List<double> expected = new List<double>();
                foreach (var num in testData)
                {
                    double d = Math.Round(Convert.ToDouble(num), 3);
                    if (Math.Abs(d) < 0.001)
                    {
                        expected.Add(d);
                    }
                }

                CollectionAssert.AreEqual(expected.ToArray(), res);
            }
            finally
            {
               
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
            }
        }
    }
}