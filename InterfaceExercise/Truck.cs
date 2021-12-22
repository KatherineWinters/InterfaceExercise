using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public bool HasBedCover { get; set; }
        public bool HasBackSeat { get; set; }

        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public bool HasTrunk { get; set; }
        public string Color { get; set; }

        public string Logo { get; set; }
        public string Slogan { get; set; }
    }
}
