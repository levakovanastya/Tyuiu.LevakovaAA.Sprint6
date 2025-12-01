using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.LevakovaAA.Sprint6.Task0.V20.Lib;
using System;
namespace Tyuiu.LevakovaAA.Sprint6.Task0.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            Assert.AreEqual(9.038, res);
        }
    }
}
