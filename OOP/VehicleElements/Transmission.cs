namespace OOP
{
    public class Transmission
    {
        public string TransmissionType { get; private set; }
        public int GearsQuantity { get; private set; }
        public string Manufacturer { get; private set; }

        public Transmission(string transmissionType, int gearsQuantity, string manufacturer)
        {
            TransmissionType = transmissionType;
            GearsQuantity = gearsQuantity;
            Manufacturer = manufacturer;
        }

        public override string ToString()
        {
            return $"TransmissionType: {TransmissionType}, GearsQuantity: {GearsQuantity}, Manufacturer: {Manufacturer}";
        }
    }
}
