using MeasureRuntimeAttribute;

namespace Fibonacci
{
    public class FibonacciGenerator
    {
        public FibonacciGenerator()
        {}

        [MeasureRuntime]
        public int GenerateFibonacci(int n)
        {
            if (n <= 1)
                return n;
            else
                return GenerateFibonacci(n - 1) + GenerateFibonacci(n - 2);
        }
    }
}
