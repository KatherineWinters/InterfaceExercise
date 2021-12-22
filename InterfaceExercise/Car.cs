using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car: IVehicle, ICompany
    {

        public bool HasBackupCamera { get; set; }
        public bool HasFourWheelDrive { get; set; }

        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public bool HasTrunk { get; set; }
        public string Color { get; set; }

        public string Logo { get; set; }
        public string Slogan { get; set; }
    }
}
