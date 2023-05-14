﻿class Program
    {
        static void Main(string[] args)
        {
            // C2
            //Train train = new Train("electric", 120);
            // Console.WriteLine(train);
            /*List<Vehicle> myVehicles = new List<Vehicle>();
            myVehicles.Add(new Train("electric", 120));
            myVehicles.Add(new Motorcycle("electric", 90));
            myVehicles.Add(new Car("hybrid", 150));
            foreach (Vehicle v in myVehicles) Console.WriteLine(v);
            */
            // C5 zadanie 1
            
            Console.WriteLine();
            List<VehicleFactory> factories = new List<VehicleFactory>() { new TrainFactory(),
                new MotorCycleFactory(), new CarFactory() };
            foreach (VehicleFactory factory in factories)
            {
                Vehicle v = factory.Create();
                Console.WriteLine(v);
            }
        }
    }