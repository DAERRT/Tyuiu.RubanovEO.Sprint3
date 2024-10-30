
using Tyuiu.RubanovEO.Sprint3.Task6.V16.Lib;

namespace Tyuiu.RubanovEO.Sprint3.Task6.V16.Test
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
            Assert.That(ds.GetSumTheDivisors(5,16), Is.EqualTo(42));
        }
    }
}