namespace UniversalConverter
{
    public class FahrenheitToCelsius : IConverter
    {
        public FahrenheitToCelsius()
        {
        }
        public double Convert(double value)
        {
            return (value - 32) * 5 / 9;
        }
    }
}
