using System;
using System.Collections.Generic;
using System.IO;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany - Done

            //Create 3 classes called Car , Truck , & SUV - Done

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; } - Done
             */

            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; } - Done
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; } - Done
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members. - Done
             */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            Car accord = new Car()
            {
                NameOfCompany = "Honda",
                AnAmericanCompany = false,
                TypeOfFeul= "Gasoline",
                OffroadCapable = false,
                NumberOfDoors = 4,
                DriveType = "Fornt wheel",
                MaxPassengers = 5,
                TypeOfCargoArea = "Trunk"
                
            };

            SUV escalade = new SUV()
            {
                NameOfCompany = "Cadillac",
                AnAmericanCompany = true,
                TypeOfFeul = "Gasoline",
                OffroadCapable = true,
                NumberOfDoors = 4,
                DriveType = "All wheel",
                MaxPassengers = 7,
                TypeOfCargoArea = "Cargo Area",

            };

            Truck f350 = new Truck()
            {
                NameOfCompany = "Ford",
                AnAmericanCompany = true,
                TypeOfFeul = "Diesel",
                OffroadCapable = true,
                NumberOfDoors = 4,
                DriveType = "4x4/2x4",
                MaxPassengers = 3,
                TypeOfCargoArea = "Cargo bed",
            };

            List<IVehicle> vheicles = new List<IVehicle>();
            vheicles.Add(accord);
            vheicles.Add(f350);
            vheicles.Add(escalade);


            foreach (IVehicle z in vheicles)
            {
                Console.WriteLine($"This is a {z.GetType().Name}");
                Console.WriteLine($"This vehicle is made by {z.NameOfCompany}");

                if (z.AnAmericanCompany == true)
                {
                    Console.WriteLine("This is an American company.");
                }
                else
                {
                    Console.WriteLine("This is not an American company.");
                }

                Console.WriteLine($"This vheicle is a {z.DriveType} drive. It uses {z.TypeOfFeul}.");
                Console.WriteLine($"It has {z.NumberOfDoors} doors.");
                
                Console.WriteLine();

            }

        }
    }
}
