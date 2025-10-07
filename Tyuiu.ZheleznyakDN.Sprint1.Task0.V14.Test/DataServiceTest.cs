using Tyuiu.ZheleznyakDN.Sprint1.Task0.V14.Lib;
namespace Tyuiu.ZheleznyakDN.Sprint1.Task0.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void damir1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(res, 25);
        }

    }
}
