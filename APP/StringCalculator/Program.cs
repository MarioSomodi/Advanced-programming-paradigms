namespace StringCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IStringCalculator stringCalculator = new StringCalculator();
            Console.WriteLine(stringCalculator.Add("\\;\n5;5;5\n5;5\n5;1001"));
        }
    }
}