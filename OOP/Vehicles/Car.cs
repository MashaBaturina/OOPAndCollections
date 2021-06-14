namespace OOP
{
    public class Car : VehicleUnit
    {
        public string CarBodyType { get; private set; }
        
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
