using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tyuiu.PyrkinAA.Sprint6.Task7.V25.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            string path = @"C:\DataSprint6\InPutFileTask7V25.csv";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            Assert.AreEqual(true, fileExist);
        }
    }
}
