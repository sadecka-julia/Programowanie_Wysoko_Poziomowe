namespace C7
{
    class SetAlarmCommand : ISmartHomeExecutable
    {
        private SecurityAlarm _alarm;
        private string _password;
        public SetAlarmCommand(SecurityAlarm alarm, string password)
        {
            _alarm = alarm;
            _password = password;
        }

        public void Execute()
        {
            _alarm.Lock(_password);
        }
    }
}