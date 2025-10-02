using Tyuiu.TsvetkovRA.Sprint1.Task3.V19.Lib;
namespace Tyuiu.TsvetkovRA.Sprint1.Task3.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x1 = 1.0;
            double x2 = 1.0;
            double y1 = 5.0;
            double y2 = 6.0;
            var res = ds.ElephCanMove(x1, y1, x2, y2);
            Assert.IsTrue(res);
        }
    }
}
