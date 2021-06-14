namespace OOP
{
    public class Truck : VehicleUnit
    {
        public int MaxCargoWeight { get; private set; }

        public Truck(int maxCargoWeight, Engine engine, Transmission transmission, Chassis chassis) : base(engine, transmission, chassis)
        {
            MaxCargoWeight = maxCargoWeight;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nMaxWeight: {MaxCargoWeight} \n";
        }
    }
}
