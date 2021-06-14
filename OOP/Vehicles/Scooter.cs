namespace OOP
{
    public class Scooter : VehicleUnit
    {
        public int SeatHeight { get; private set; }

        public Scooter(int seatHeight, Engine engine, Transmission transmission, Chassis chassis) : base(engine, transmission, chassis)
        {
            SeatHeight = seatHeight;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nSeatHeight: {SeatHeight} \n";
        }
    }
}
