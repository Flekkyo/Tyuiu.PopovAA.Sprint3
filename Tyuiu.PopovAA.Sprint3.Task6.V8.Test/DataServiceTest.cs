using Tyuiu.PopovAA.Sprint3.Task6.V8.Lib;
namespace Tyuiu.PopovAA.Sprint3.Task6.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int s = 18;
            int f = 28;
            var res = ds.GetSumTheDivisors(s, f);
            Assert.AreEqual(292, res);
        }
    }
}
