using Tyuiu.ZheleznyakDN.Sprint1.Task1.V16.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint1.Task1.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void damir2()
        {
            DataService ds = new DataService();
            double x, y, a;
            x = 10 ; y = 20; a = 30;
            var res = ds.Calculate(a, x, y);
            Assert.AreEqual(1540, res);
        }
    }
}
