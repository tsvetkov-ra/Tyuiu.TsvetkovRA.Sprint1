using Microsoft.Testing.Platform.MSBuild;
using Tyuiu.TsvetkovRA.Sprint1.Task6.V10.lib;
namespace Tyuiu.TsvetkovRA.Sprint1.Task6.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            string strTest = "AVSS ABB ETT";
            DataService ds = new DataService(); 
            string res = ds.DeleteMiddleLetter(strTest);
            string wait = "AVSS AB ET";
            Assert.AreEqual(wait, res);

        }
    }
}
