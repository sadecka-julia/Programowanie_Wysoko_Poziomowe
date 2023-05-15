
namespace C7
{
    class SetThermostatCommand : ISmartHomeExecutable
    {
        protected Thermostat _thermostat;
        protected int _temperature;
        public SetThermostatCommand(Thermostat thermostat, int temperature)
        {
            _thermostat = thermostat;
            _temperature = temperature;
        }

        public void Execute()
        {
            _thermostat.TargetTemperature = _temperature;
        }

    }
}