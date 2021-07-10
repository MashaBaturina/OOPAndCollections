using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    public class VehicleManufacturer
    {
        public VehicleManufacturer() { }

        public List<VehicleUnit> GetVehicles(Dictionary<Engines, List<Engine>> engines, Dictionary<Transmissions, List<Transmission>> transmissions, Dictionary<AvailableChassis, List<Chassis>> chassis)
        {
            string carBodyType = "sedan";
            int maxTruckCargoWeight = 7000;
            int maxBusPassengersNumber = 70;
            int scooterSeatHeight = 710;

            Engine carEngine = engines[Engines.Car].ElementAt(0);
            Engine truckEngine = engines[Engines.Truck].ElementAt(0);
            Engine busEngine = engines[Engines.Bus].ElementAt(0);
            Engine scooterEngine = engines[Engines.Scooter].ElementAt(0);

            Transmission carTransmission = transmissions[Transmissions.Car].ElementAt(0);
            Transmission truckTransmission = transmissions[Transmissions.Truck].ElementAt(0);
            Transmission busTransmission = transmissions[Transmissions.Bus].ElementAt(0);
            Transmission scooterTransmission = transmissions[Transmissions.Scooter].ElementAt(0);

            Chassis carChassis = chassis[AvailableChassis.Car].ElementAt(0);
            Chassis truckChassis = chassis[AvailableChassis.Truck].ElementAt(0);
            Chassis busChassis = chassis[AvailableChassis.Bus].ElementAt(0);
            Chassis scooterChassis = chassis[AvailableChassis.Scooter].ElementAt(0);

            Car nissanCar = new(carBodyType, carEngine, carTransmission, carChassis);
            Truck mazTruck = new(maxTruckCargoWeight, truckEngine, truckTransmission, truckChassis);
            Bus mazBus = new(maxBusPassengersNumber, busEngine, busTransmission, busChassis);
            Scooter hondaScooter = new(scooterSeatHeight, scooterEngine, scooterTransmission, scooterChassis);

            List<VehicleUnit> vehicleUnits = new() { nissanCar, mazTruck, mazBus, hondaScooter};

            return vehicleUnits;
        }
    }
}
