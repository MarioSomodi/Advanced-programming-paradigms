namespace Thermostat
{
    public class Thermostat
    {
        private readonly ISignalListener _signalListener;
        private readonly ISensor _sensor;
        public double currentTemp;

        public Thermostat()
        {
            _signalListener = new SignalListener();
            _sensor = new Sensor();
        }

        public void CheckTemp(double givenTemperature)
        {
            currentTemp = _sensor.getCurrentTemperature();
            if(currentTemp < givenTemperature) {
                _signalListener.onSignal(true);
            }
            else
            {
                _signalListener.onSignal(false);
            }
        }
    }
}
