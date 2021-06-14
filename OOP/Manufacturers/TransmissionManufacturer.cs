using System.Collections.Generic;

namespace OOP
{
    public class TransmissionManufacturer
    {
        public Dictionary<Transmissions, List<Transmission>> GetTransmissions()
        {
            Transmission carTransmission = new("Automatic  gearbox", 6, "Jatco");
            Transmission truckTransmission = new("Mechanical gearbox", 6, "Zahnrad Fabrik");
            Transmission busTransmission = new("Mechanical gearbox", 6, "Zahnrad Fabrik");
            Transmission scooterTransmission = new("Automatic  gearbox", 6, "Jatco");

            List<Transmission> carTransmissions = new() { carTransmission };
            List<Transmission> truckTransmissions = new() { truckTransmission };
            List<Transmission> busTransmissions = new() { busTransmission };
            List<Transmission> scooterTransmissions = new() { scooterTransmission };

            Dictionary<Transmissions, List<Transmission>> transmissions = new()
            {
                { Transmissions.CarTransmission, carTransmissions },
                { Transmissions.TruckTransmission, truckTransmissions },
                { Transmissions.BusTransmission, busTransmissions },
                { Transmissions.ScooterTransmission, scooterTransmissions }
            };

            return transmissions;
        }
    }
}
