using System.Collections.Generic;

namespace OOP
{
    public class EngineManufacturer
    {
        public Dictionary<Engines, List<Engine>> GetEngines()
        {
            Engine carEngine = new(600, 4.1, "petrol", "RADWE243132");
            Engine truckEngine = new(800, 1.0, "diesel", "JDKJDLWOM1312");
            Engine busEngine = new(900, 4.0, "petrol", "DJSJFOKSNJER68452");
            Engine scooterEngine = new(300, 1.3, "diesel", "JWLEJLEW0329");

            List<Engine> carEngines = new() { carEngine };
            List<Engine> truckEngines = new() { truckEngine };
            List<Engine> busEngines = new() { busEngine };
            List<Engine> scooterEngines = new() { scooterEngine };

            Dictionary<Engines, List<Engine>> engines = new()
            {
                { Engines.CarEngine, carEngines },
                { Engines.TruckEngine, truckEngines },
                { Engines.BusEngine, busEngines },
                { Engines.ScooterEngine, scooterEngines }
            };

            return engines;
        }
    }
}
