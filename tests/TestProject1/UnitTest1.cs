using ConsoleApp1;

namespace TestProject1
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
            Sample sample = new();
            int answer = sample.Add(2, 4);
            Assert.AreEqual(6,answer);

            Assert.Pass();
        }
    }
}