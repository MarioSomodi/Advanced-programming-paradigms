namespace Thermostat.Test;

[TestClass]
public class UnitTestThermostat
{
    private readonly Thermostat _thermostat;

    public UnitTestThermostat()
    {
        _thermostat = new Thermostat();
    }

    [TestMethod]
    public void TestThermostat()
    {
        var givenTemperature = 40.6;
        var stringWriter = new StringWriter();
        Console.SetOut(stringWriter);
        _thermostat.CheckTemp(givenTemperature);

        var thermostatResult = stringWriter.ToString();

        if(_thermostat.currentTemp < givenTemperature)
            Assert.AreEqual("True", thermostatResult);
        else
            Assert.AreEqual("False", thermostatResult);
    }
}