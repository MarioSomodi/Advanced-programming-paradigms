namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FibonacciGenerator fG = new FibonacciGenerator();
            fG.GenerateFibonacci(1);
            fG.GenerateFibonacci(100);
        }
    }
}