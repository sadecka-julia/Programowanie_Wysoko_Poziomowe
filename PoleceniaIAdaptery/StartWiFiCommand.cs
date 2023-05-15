namespace C7
{
    class StartWiFiCommand : ISmartHomeExecutable
    {
        protected WiFi _wifi;
        protected string _password;
        public StartWiFiCommand(WiFi wifi, string password)
        {
            _wifi = wifi;
            _password = password;
        }

        public void Execute()
        {
            _wifi.IsCurrentlyOn = true;
            _wifi.Login(_password);
        }

    }
}