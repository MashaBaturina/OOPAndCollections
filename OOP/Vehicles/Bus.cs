namespace OOP
{
    public class Bus : VehicleUnit
    {
        public int PassengersNumbers { get; private set; }

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
