using Fibonacci;

namespace Fibonacci.Test
{
    [TestClass]
    public class UnitTestFibonacci
    {
        private readonly FibonacciGenerator _fibonacciGenerator;
        public UnitTestFibonacci()
        {
            _fibonacciGenerator = new FibonacciGenerator();
        }
        [TestMethod]
        public void Is_FibonacciGenerator_Null()
        {
            Assert.IsNotNull(_fibonacciGenerator);
        }

        [TestMethod]
        public void IsFibonacci_Result_Correct()
        {
            Assert.AreEqual(0, _fibonacciGenerator.GenerateFibonacci(0));
            Assert.AreEqual(1, _fibonacciGenerator.GenerateFibonacci(1));
            Assert.AreEqual(1, _fibonacciGenerator.GenerateFibonacci(2));
            Assert.AreEqual(2, _fibonacciGenerator.GenerateFibonacci(3));
            Assert.AreEqual(3, _fibonacciGenerator.GenerateFibonacci(4));
            Assert.AreEqual(5, _fibonacciGenerator.GenerateFibonacci(5));
            Assert.AreEqual(8, _fibonacciGenerator.GenerateFibonacci(6));
            Assert.AreEqual(13, _fibonacciGenerator.GenerateFibonacci(7));
        }
    }
}