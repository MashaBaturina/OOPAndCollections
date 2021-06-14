namespace OOP
{
   public class Engine
    {
        public int Power { get; private set; }
        public double Volume { get; private set; }
        public  string Type { get; private set; }
        public string SerialNumber { get; private set; }

        public Engine(int power, double volume, string type, string serialNumber)
        {
            Power = power;
            Volume = volume;
            Type = type;
            SerialNumber = serialNumber;
        }

        public override string ToString()
        {
            return $"Power: {Power}, Volume: {Volume}, Type: {Type}, SerialNumber: {SerialNumber}";
        }
    }
}
