
using Tyuiu.RubanovEO.Sprint3.Task7.V26.Lib;

namespace Tyuiu.RubanovEO.Sprint3.Task7.V26.Test
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
            DataService dataService = new DataService();
            Assert.That(dataService.GetMassFunction(-5,5), Is.EqualTo(new double[11] {19.81,16.79,13.87,10.98,7.94,3,3.23,-0.45,-3.79,-6.97,-10}));
        }
    }
}