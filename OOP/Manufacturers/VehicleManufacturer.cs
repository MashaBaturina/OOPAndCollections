using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    public class VehicleManufacturer
    {
        public List<VehicleUnit> GetVehicles(Dictionary<Engines, List<Engine>> engines, Dictionary<Transmissions, List<Transmission>> transmissions, Dictionary<AvailableChassis, List<Chassis>> chassis)
        {
            string carBodyType = "sedan";
            int maxTruckCargoWeight = 7000;
            int maxBusPassengersNumber = 70;
            int scooterSeatHeight = 710;

            Engine carEngine = engines[Engines.CarEngine].ElementAt(0);
            Engine truckEngine = engines[Engines.TruckEngine].ElementAt(0);
            Engine busEngine = engines[Engines.BusEngine].ElementAt(0);
            Engine scooterEngine = engines[Engines.ScooterEngine].ElementAt(0);

            Transmission carTransmission = transmissions[Transmissions.CarTransmission].ElementAt(0);
            Transmission truckTransmission = transmissions[Transmissions.TruckTransmission].ElementAt(0);
            Transmission busTransmission = transmissions[Transmissions.BusTransmission].ElementAt(0);
            Transmission scooterTransmission = transmissions[Transmissions.ScooterTransmission].ElementAt(0);

            Chassis carChassis = chassis[AvailableChassis.CarChassis].ElementAt(0);
            Chassis truckChassis = chassis[AvailableChassis.TruckChassis].ElementAt(0);
            Chassis busChassis = chassis[AvailableChassis.BusChassis].ElementAt(0);
            Chassis scooterChassis = chassis[AvailableChassis.ScooterChassis].ElementAt(0);

            Car nissanCar = new(carBodyType, carEngine, carTransmission, carChassis);
            Truck mazTruck = new(maxTruckCargoWeight, truckEngine, truckTransmission, truckChassis);
            Bus mazBus = new(maxBusPassengersNumber, busEngine, busTransmission, busChassis);
            Scooter hondaScooter = new(scooterSeatHeight, scooterEngine, scooterTransmission, scooterChassis);

            List<VehicleUnit> vehicleUnits = new() { nissanCar, mazTruck, mazBus, hondaScooter};

            return vehicleUnits;
        }
    }
}
