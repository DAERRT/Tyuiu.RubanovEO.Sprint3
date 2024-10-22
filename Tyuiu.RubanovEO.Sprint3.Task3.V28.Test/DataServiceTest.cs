
using Tyuiu.RubanovEO.Sprint3.Task3.V28.Lib;

namespace Tyuiu.RubanovEO.Sprint3.Task3.V28.Test
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
            Assert.That(ds.ReplaceNumOnChar("22fff", 'r'), Is.EqualTo("rrfff"));
        }
    }
}