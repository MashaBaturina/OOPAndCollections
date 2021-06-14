namespace OOP
{
    public abstract class VehicleUnit
    {
       public Engine Engine { get; set; }
       public Transmission Transmission { get; set; }
       public Chassis Chassis { get; set; }

        public VehicleUnit(Engine engine, Transmission transmission, Chassis chassis)
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
