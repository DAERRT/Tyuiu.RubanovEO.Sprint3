
using Tyuiu.RubanovEO.Sprint3.Task5.V4.Lib;

namespace Tyuiu.RubanovEO.Sprint3.Task5.V4.Test
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
            Assert.That(ds.GetSumSumSeries(5,1,1,3,13), Is.EqualTo(3328.185));
        }
    }
}