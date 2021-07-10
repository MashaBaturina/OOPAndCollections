using System;

namespace OOP
{
    [Serializable]
    public class Chassis
    {
        public int WheelsQuantity { get; set; }
        public int Number { get; set; }
        public int PermissibleCapacity { get; set; }

        public Chassis() { }

        public Chassis(int wheelsQuantity, int number, int permissibleCapacity)
        {
            WheelsQuantity = wheelsQuantity;
            Number = number;
            PermissibleCapacity = permissibleCapacity;
        }

        public override string ToString()
        {
            return $"WheelsQuantity: {WheelsQuantity}, Number: {Number}, PermissibleCapacity: {PermissibleCapacity}";
        }
    }
}
