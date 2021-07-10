using System;

namespace OOP
{
    [Serializable]
    public class Bus : VehicleUnit
    {
        public int PassengersNumbers { get; set; }

        public Bus(){}

        public Bus(int passengersNumbers, Engine engine, Transmission transmission, Chassis chassis) : base(engine, transmission, chassis)
        {
            PassengersNumbers = passengersNumbers;
        }

        public override string ToString()
        {           
            return base.ToString() + $"\nPassengersNumbers: {PassengersNumbers} \n";
        }
    }
}
