using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LevakovaAA.Sprint6.Task4.V19.Lib;
using System;
namespace Tyuiu.LevakovaAA.Sprint6.Task4.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] res = ds.GetMassFunction(startValue, stopValue);
            Assert.AreEqual(23.61, res[0]);
        }
    }
}