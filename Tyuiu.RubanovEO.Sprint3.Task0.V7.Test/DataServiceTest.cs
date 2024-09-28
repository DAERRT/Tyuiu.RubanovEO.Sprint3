
using Tyuiu.RubanovEO.Sprint3.Task0.V7.Lib;

namespace Tyuiu.RubanovEO.Sprint3.Task0.V7.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DataService ds = new DataService();
            Assert.That(ds.GetSumSeries(0.75,1,20), Is.EqualTo(0.333));
        }
    }
}