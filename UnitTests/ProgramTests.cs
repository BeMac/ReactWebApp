using NUnit.Framework;

namespace Tests
{
    public class ProgramTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FibTest0()
        {
            ReactWebApp.Program program = new ReactWebApp.Program();
            int result = program.FibonacciGenerator(0);
            Assert.That(result == 0);
        }

        [Test]
        public void FibTest1()
        {
            ReactWebApp.Program program = new ReactWebApp.Program();
            int result = program.FibonacciGenerator(1);
            Assert.That(result == 1);
        }

        [Test]
        public void FibTest5()
        {
            ReactWebApp.Program program = new ReactWebApp.Program();
            int result = program.FibonacciGenerator(5);
            Assert.That(result == 5);
        }

        [Test]
        public void FibTest10()
        {
            ReactWebApp.Program program = new ReactWebApp.Program();
            int result = program.FibonacciGenerator(10);
            Assert.That(result == 55);
        }

    }
}