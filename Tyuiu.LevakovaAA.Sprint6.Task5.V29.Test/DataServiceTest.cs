using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LevakovaAA.Sprint6.Task5.V29.Lib;
namespace Tyuiu.LevakovaAA.Sprint6.Task5.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\levak\Desktop\repos\Tyuiu.LevakovaAA.Sprint6\Tyuiu.LevakovaAA.Sprint6.Task5.V29\bin\Debug\net8.0-windows\InPutDataFileTask5V29.txt";
            double[] result = ds.LoadFromDataFile(path);
            Assert.AreEqual(12, result[0]);
        }
    }
}
