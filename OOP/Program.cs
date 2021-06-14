using System.Collections.Generic;
using System.Linq;

namespace OOP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Engine volume filter
            double engineVolumeFilter = 1.5;

            // Get engines 
            EngineManufacturer enginesManufacturer = new();
            Dictionary<Engines, List<Engine>> vehicleEngines = enginesManufacturer.GetEngines();

            // Get transmissions
            TransmissionManufacturer transmissionManufacturer = new();
            Dictionary<Transmissions, List<Transmission>> vehicleTransmissions = transmissionManufacturer.GetTransmissions();

            // Get chassis 
            ChassisManufacturer chassisManufacturer = new();
            Dictionary<AvailableChassis, List<Chassis>> vehicleChassis = chassisManufacturer.GetChassis();

            // Get vehicles 
            VehicleManufacturer vehiclesManufacturer = new();
            List<VehicleUnit> vehicles = vehiclesManufacturer.GetVehicles(vehicleEngines, vehicleTransmissions, vehicleChassis);

            // Create an autopark 
            Autopark autopark = new(vehicles);

            // Group vehicle units by the transmisson type
            Dictionary<string, List<VehicleUnit>> filteredVehicleUnits = vehicles.GroupBy(x => x.Transmission.TransmissionType).
                ToDictionary(g => g.Key, g => g.ToList());

            // Task OOP - white vehicle units to console
            ConsoleWriter.WriteVehicleUnitsToConsole(autopark.AutoparkVehicleUnits);

            // Task Collections - write units to xml 
            XmlWriter.WriteAllVehicleUnitsToXml(autopark.AutoparkVehicleUnits);
            XmlWriter.WriteFilteredVehicleUnitsToXml(autopark.AutoparkVehicleUnits, engineVolumeFilter);
            XmlWriter.WriteVehicleUnitsGroupedByTransmissionTypeToXml(filteredVehicleUnits);
            XmlWriter.WriteEnginesOfBusesAndTrucksToXml(autopark.AutoparkVehicleUnits);
        }
    }
}
