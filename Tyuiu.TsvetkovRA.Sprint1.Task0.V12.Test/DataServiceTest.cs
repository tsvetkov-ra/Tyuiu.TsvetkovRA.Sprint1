﻿using Tyuiu.TsvetkovRA.Sprint1.Task0.V12.Lib;
namespace Tyuiu.TsvetkovRA.Sprint1.Task0.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(6, res);
        }
    }
}
