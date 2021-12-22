using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise {
    public class SUV : IVehicle, ICompany 
    {

        public bool HasTwoRows { get; set; }
        public bool HasTv { get; set; }

        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public bool HasTrunk { get; set; }
        public string Color { get; set; }

        public string Logo { get; set; }
        public string Slogan { get; set; }
    }
}
