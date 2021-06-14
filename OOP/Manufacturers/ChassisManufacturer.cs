using System.Collections.Generic;

namespace OOP
{
    public class ChassisManufacturer
    {
        public Dictionary<AvailableChassis, List<Chassis>> GetChassis()
        {
            Chassis carChassis = new(4, 813203, 8000);
            Chassis truckChassis = new(6, 931023, 19000);
            Chassis busChassis = new(4, 831983, 16000);
            Chassis scooterChassis = new(2, 957294, 4000);

            List<Chassis> listOfCarChassis = new() { carChassis };
            List<Chassis> listOftTuckTransmissions = new() { truckChassis };
            List<Chassis> listOfBusTransmissions = new() { busChassis };
            List<Chassis> listOfScooterTransmissions = new() { scooterChassis };

            Dictionary<AvailableChassis, List<Chassis>> chassis = new()
            {
                { AvailableChassis.CarChassis, listOfCarChassis },
                { AvailableChassis.TruckChassis, listOftTuckTransmissions },
                { AvailableChassis.BusChassis, listOfBusTransmissions },
                { AvailableChassis.ScooterChassis, listOfScooterTransmissions }
            };

            return chassis;
        }
    }
}
