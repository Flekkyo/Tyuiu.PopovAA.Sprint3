using Tyuiu.PopovAA.Sprint3.Task5.V19.Lib;
namespace Tyuiu.PopovAA.Sprint3.Task5.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 2;
            int si = 1;
            int fi = 3;
            int sk = 1;
            int fk = 6;
            double res = ds.GetSumSumSeries(x, si, fi, sk, fk);
            Assert.AreEqual(10181.042, res);
        }
    }
}
