namespace C7
{
    // command interface
    interface ISmartHomeExecutable
    {
        void Execute();
    }

    class SecurityAlarm
    {
        private string password;
        public bool Enterable { get; private set; }
        public void Lock(string pwd)
        {
            if (pwd == password)
            {
                Enterable = false;
                Console.WriteLine("Security alarm is now active.");
            }
        }
        public void Unlock(string pwd)
        {
            if (pwd == password)
            {
                Enterable = true;
            }
        }
        public SecurityAlarm(string pwd)
        {
            password = pwd;
            Enterable = false;
        }

    }

    class SmartHomeScheduler
    {
        public Dictionary<int, ISmartHomeExecutable> Commands { get; set; }
        public void Run()
        {
            for (int i = 0; i < 24; i++)
            {
                if(Commands.ContainsKey(i))
                {
                    Console.WriteLine(i + ":00");
                    Commands[i].Execute();
                }
            }
        }

        public SmartHomeScheduler()
        {
            Commands = new Dictionary<int, ISmartHomeExecutable>();
        }
    }

    class Thermostat
    {
        private int targetTemperature;
        public int TargetTemperature
        {
            get { return targetTemperature; }
            set
            {
                if (value < 18) targetTemperature = 18;
                else if (value > 30) targetTemperature = 30;
                else targetTemperature = value;
                Console.WriteLine("Thermostat set to " + targetTemperature + "C.");
            }
        }
        public Thermostat()
        {
            targetTemperature = 21;
        }
    }

    class WiFi
    {
        protected string network, password;
        protected bool isCurrentlyOn;
        public virtual bool IsCurrentlyOn 
        {
            get { return isCurrentlyOn; }
            set
            {
                if (value == true) { Console.WriteLine("WiFi turned on."); }
                else { Console.WriteLine("WiFi turned off."); }
                isCurrentlyOn = value;
            }
        }
        public virtual void Login(string pwd)
        {
            if (IsCurrentlyOn == false) return;
            if (password != pwd) Console.WriteLine("Wrong password!");
            else
            {
                Console.WriteLine("Attempting to log to " + network + "...");
                Console.Write("Password: ");
                for (int i = 0; i < password.Length; i++) Console.Write("*");
                Console.WriteLine("\nLogin successful!");
            }
        }
        public WiFi(string net, string pwd)
        {
            network = net;
            password = pwd;
            isCurrentlyOn = false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // urzadzenia w domu
            WiFi myWiFi = new WiFi("routerXYZ", "bezpieczneHaslo1");
            Thermostat myThermostat = new Thermostat();
            SecurityAlarm myAlarm = new SecurityAlarm("bezpieczneHaslo2");


            // wersja bez wzorca polecenie - wracamy do domu o 17
            // te komendy trzeba bedzie powtarzac kazdego dnia
            /*
            myWiFi.IsCurrentlyOn = true; 
            myWiFi.Login("bezpieczneHaslo1"); // trzeba wywolac metody z odpowiednimi parametrami - kazda klasa ktora chce uzyc WiFi musi znac do niego hasło
            myThermostat.TargetTemperature = 22; // niestety termostat potrzebuje troche czasu - wlasciwa temperature osiagniemy dopiero za godzine
            // teraz cos robie...
            myAlarm.Lock("bezpieczneHaslo2"); // o 23 ide spac i musze pamietac o wlaczeniu alarmu
            */


            // wersja z wzorcem polecenie - rowniez wracamy do domu o 17
            // zdefiniujmy czynnosci do automatycznego wykonywania codziennie
            /*
            SmartHomeScheduler controller = new SmartHomeScheduler();
            StartWiFiCommand command1 = new StartWiFiCommand(myWiFi, "bezpieczneHaslo1"); // polecenie samo przechowa swoje parametry do przyszlego uzycia - klasa ktora bedzie chciała uzyc WiFi nie musi juz znac do niego hasła, wystarczy ze uzyje gotowego obiektu typu polecenie
            SetThermostatCommand command2 = new SetThermostatCommand(myThermostat, 22);
            SetAlarmCommand command3 = new SetAlarmCommand(myAlarm, "bezpieczneHaslo2");
            controller.Commands.Add(16, command2); // niech termostat uruchomi sie automatycznie juz o 16:00
            controller.Commands.Add(17, command1); // wifi wystarczy uruchomic o 17:00
            controller.Commands.Add(23, command3); // o 23:00 alarm wlaczy sie sam
            controller.Run();
            */


            // test adaptera
            /*
            WiFi2 oldRouter = new WiFi2("stareHaslo7"); // stary router nie potrafi ustawic stalej nazwy sieci
            WiFiAdapter myAdapter = new WiFiAdapter(oldRouter, "routerXYZ"); // ale nasz adapter bedzie potrafil
            // gotowego adaptera mozna uzywac jak standardowego routera typu WiFi
            myAdapter.IsCurrentlyOn = true;
            myAdapter.Login("stareHaslo7");
            StartWiFiCommand testCommand = new StartWiFiCommand(myAdapter, "stareHaslo7");
            */

        }
    }


}
