using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public bool HasTrunk { get; set; }
        public string Color { get; set; }
    }
}
