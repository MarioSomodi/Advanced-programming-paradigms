namespace UniversalConverter
{
    public class CelsiusToFahrenheit : IConverter
    {
        public CelsiusToFahrenheit()
        {
        }
        public double Convert(double value)
        {
            return ((value * 9) / 5) + 32;
        }
    }
}
