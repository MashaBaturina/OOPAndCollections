using System.Collections.Generic;

namespace OOP
{
    public class Autopark
    {

       
        public List<VehicleUnit> AutoparkVehicleUnits { get; private set; }

        public Autopark(List<VehicleUnit> vehicleUnits)
        {
            AutoparkVehicleUnits = vehicleUnits;
        }
    }
}
