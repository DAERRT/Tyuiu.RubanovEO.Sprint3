
using Tyuiu.RubanovEO.Sprint3.Task2.V16.Lib;

namespace Tyuiu.RubanovEO.Sprint3.Task2.V16.Test
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
            Assert.That(ds.GetMultiplySeries(2,1,5),Is.EqualTo(14400));
        }
    }
}