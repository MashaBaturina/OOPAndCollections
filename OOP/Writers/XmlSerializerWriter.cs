using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace OOP
{
    class XmlSerializerWriter
    {
        public static void WriteAllVehicleUnitsToXmlSerialize(List<VehicleUnit> vehicleUnits, string filename)
        {
            XmlSerializer formatter = new(typeof(List<VehicleUnit>));

            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, vehicleUnits);
            }
        }

        public static void WriteAllVehicleUnitsToXmlSerialize(Dictionary<string, List<VehicleUnit>> filteredVehicleUnits, string filename)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(VehicleUnit));

            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                foreach (KeyValuePair<string, List<VehicleUnit>> vehicleUnit in filteredVehicleUnits)
                {
                    //ВОЗМОЖНО СЮДА ЕЩЕ НАДО ВСУНУТЬ ПОЛЕ ПО КОТОРОМУ ГРУППИРУЕТСЯ, НО Я НЕ ЗНАЮ КАК ЭТО СДЕЛАТЬ
                    foreach (var vehicleUnitItem in vehicleUnit.Value)
                    {
                        formatter.Serialize(fs, vehicleUnitItem);
                    }
                }
            }
        }

        public static void WriteInfoAboutEnginesofBusAndTruckToXmlSerialize(List<VehicleUnit> vehicleUnits, string filename)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(Engine));

            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                for (int i = 0; i < vehicleUnits.Count; i++)
                {
                    if (vehicleUnits[i] is Bus || vehicleUnits[i] is Truck)
                    {
                        formatter.Serialize(fs, vehicleUnits[i].Engine);
                    }
                }
            }
        }

        public static List<VehicleUnit> CreateFilteredVehicleUnitList(List<VehicleUnit> vehicleUnit, double engineVolumeFilter)
        {
            List<VehicleUnit> filteredVehicleUnit = new() { };

            for (int i = 0; i < vehicleUnit.Count; i++)
            {
                if (vehicleUnit[i].Engine.Volume > engineVolumeFilter)
                {
                    filteredVehicleUnit.Add(vehicleUnit[i]);
                }
            }

            return filteredVehicleUnit;
        }
    }
}
