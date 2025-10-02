using Tyuiu.TsvetkovRA.Sprint1.Task7.V5.Lib;
namespace Tyuiu.TsvetkovRA.Sprint1.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3.0;
            var res = ds.Calculate(x);
            Assert.AreEqual(-0.004, res);
        }
    }
}
