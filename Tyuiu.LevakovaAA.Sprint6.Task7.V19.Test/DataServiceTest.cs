using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LevakovaAA.Sprint6.Task7.V19.Lib;
namespace Tyuiu.LevakovaAA.Sprint6.Task7.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\levak\Downloads\InPutDataFileTask7V19.csv";
            int[,] res = ds.GetMatrix(path);
            Assert.AreEqual(2, res[1, 0]);
        }
    }
}
