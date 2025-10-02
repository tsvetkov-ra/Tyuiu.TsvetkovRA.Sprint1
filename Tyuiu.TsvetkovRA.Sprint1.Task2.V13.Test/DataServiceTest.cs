using Tyuiu.TsvetkovRA.Sprint1.Task2.V13.Lib;
namespace Tyuiu.TsvetkovRA.Sprint1.Task2.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 20;
            var res = ds.ConvertMilesToKm(x);
            Assert.AreEqual(32.187, res);
        }
    }
}
