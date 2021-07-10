using System;
using System.Xml.Serialization;

namespace OOP
{
    [XmlInclude(typeof(Car))]
    [XmlInclude(typeof(Truck))]
    [XmlInclude(typeof(Scooter))]
    [XmlInclude(typeof(Bus))]
    [Serializable]
    public abstract class VehicleUnit
    {
       public Engine Engine { get; set; }
       public Transmission Transmission { get; set; }
       public Chassis Chassis { get; set; }

        public VehicleUnit() { }

        protected VehicleUnit(Engine engine, Transmission transmission, Chassis chassis)
        {
            Engine = engine;
            Transmission = transmission;
            Chassis = chassis;
        }

        public override string ToString()
        {
            return $"Engine: {Engine} \nTransmission: {Transmission} \nChassis: {Chassis}";
        }
    }
}
