namespace UniversalConverter.Test
{
    [TestClass]
    public class UnitTestUniversalConverter
    {
        private readonly IConverter _celsiusToFahrenheit;
        private readonly IConverter _fahrenheitToCelsius;

        public UnitTestUniversalConverter()
        {
            _celsiusToFahrenheit = new CelsiusToFahrenheit();
            _fahrenheitToCelsius = new FahrenheitToCelsius();
        }
        [TestMethod]
        public void Is_CelsiusToFahrenheit_Converter_Null()
        {
            Assert.IsNotNull(_celsiusToFahrenheit);
        }
        [TestMethod]
        public void Is_FahrenheitToCelsius_Converter_Null()
        {
            Assert.IsNotNull(_celsiusToFahrenheit);
        }
        [DataTestMethod]
        [DataRow(37.77778, 100)]
        [DataRow(65.55556, 150)]
        [DataRow(93.33333, 200)]
        [DataRow(121.1111, 250)]
        public void Is_Result_OfConvertion_From_CelsiusToFahrenheit_Correct(double celsius, double fahrenheit)
        {
            Assert.AreEqual(fahrenheit, _celsiusToFahrenheit.Convert(celsius), 0.1);
        }
        [DataTestMethod]
        [DataRow(37.77778, 100)]
        [DataRow(65.55556, 150)]
        [DataRow(93.33333, 200)]
        [DataRow(121.1111, 250)]
        public void Is_Result_OfConvertion_From_FahrenheitToCelsius_Correct(double celsius, double fahrenheit)
        {
            Assert.AreEqual(celsius, _fahrenheitToCelsius.Convert(fahrenheit), 0.1);
        }
    }
}
