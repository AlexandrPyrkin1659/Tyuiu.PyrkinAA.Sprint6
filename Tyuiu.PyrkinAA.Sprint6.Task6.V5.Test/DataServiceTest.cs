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
            string path = @"C:\DataSprint6\InPutFileTask6V5.txt";

            string res = ds.CollectTextFromFile(path);
            string wait = "Hello world Well done Little friend";

            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckFileExists()
        {
            string path = @"C:\DataSprint6\InPutFileTask6V5.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}