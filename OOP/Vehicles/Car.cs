using System;
using System.Xml.Serialization;

namespace OOP
{
    [Serializable]
    public class Car : VehicleUnit
    {
        public Car() { }

        public string CarBodyType { get; set; }

       
        public Car(string carBodyType, Engine engine, Transmission transmission, Chassis chassis) : base(engine, transmission, chassis)
        {
            CarBodyType = carBodyType;         
        }

        public override string ToString()
        {
            return base.ToString() + $"\nCarBodyType: {CarBodyType}\n";
        }
    }
}
