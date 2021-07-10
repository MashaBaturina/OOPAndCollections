using System;

namespace OOP
{
    [Serializable]
    public class Transmission
    {
        public string TransmissionType { get; set; }
        public int GearsQuantity { get; set; }
        public string Manufacturer { get; set; }

        public Transmission() { }

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
