namespace OOP
{
   public class Chassis
    {
        public int WheelsQuantity { get; private set; }
        public int Number { get; private set; }
        public int PermissibleCapacity { get; private set; }

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
