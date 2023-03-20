namespace Thermostat
{
    public class Sensor : ISensor
    {
        public double getCurrentTemperature()
        {
            var upperBound = 100;
            var lowerBound = -100;
            var random = new Random();
            var rDouble = random.NextDouble();
            return rDouble * (upperBound - lowerBound) + lowerBound;
        }
    }
}
