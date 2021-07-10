using System;

namespace OOP
{
    [Serializable]
    public class Scooter : VehicleUnit
    {
        public int SeatHeight { get; set; }

        public Scooter() { }

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
