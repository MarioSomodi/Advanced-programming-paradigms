namespace Thermostat
{
    public class SignalListener : ISignalListener
    {
        public SignalListener()
        {}
        public void onSignal(bool highLow)
        {
            Console.Write(highLow);
        }
    }
}
