using Tyuiu.TsvetkovRA.Sprint1.Task5.V3.Lib;
namespace Tyuiu.TsvetkovRA.Sprint1.Task5.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int k = 189424;
            var res = ds.Calculate(k);
            Assert.AreEqual(4, res);

        }
    }
}
