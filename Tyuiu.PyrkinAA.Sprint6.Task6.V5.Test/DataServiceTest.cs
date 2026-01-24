using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.PyrkinAA.Sprint6.Task6.V5.Lib;

namespace Tyuiu.PyrkinAA.Sprint6.Task6.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();

          
            string testFilePath = @"C:\Temp\testInput.txt";
            string testContent = @"ulzPXa gLertvwzs sMLuPzlvneiTo hZznJL tfouGdncXlJ
                                  Второя строка с словами hello world test";

            File.WriteAllText(testFilePath, testContent);

            string res = ds.CollectTextFromFile(testFilePath);
            string wait = "ulzPXa sMLuPzlvneiTo tfouGdncXlJ";

            Assert.AreEqual(wait, res);

           
            File.Delete(testFilePath);
        }
    }
}