using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            Car car = new Car();
            {
                car.HasBackupCamera = true;
                car.HasFourWheelDrive = true;
                car.NumberOfWheels = 4;
                car.NumberOfDoors = 4;
                car.HasTrunk = true;
                car.Color = "blue";
                car.Logo = "Honda Logo";
                car.Slogan = "Honda: The Power of Dreams";
            };

            Truck truck = new Truck();
            {
                truck.HasBedCover = true;
                truck.HasBackSeat = true;
                truck.NumberOfWheels = 4;
                truck.NumberOfDoors = 4;
                truck.HasTrunk = false;
                truck.Color = "orange";
                truck.Logo = "Hyundai Logo";
                truck.Slogan = "New Thinking, New Possibilities";
            };

            SUV suv = new SUV();
            {
                suv.HasTwoRows = true;
                suv.HasTv = false;
                suv.NumberOfWheels = 4;
                suv.NumberOfDoors = 4;
                suv.HasTrunk = true;
                suv.Color = "black";
                suv.Logo = "Kia Logo";
                suv.Slogan = "Movement that inspires";
            };
        }
    }
}









            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
        