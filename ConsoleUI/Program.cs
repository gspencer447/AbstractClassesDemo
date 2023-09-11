using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>();

            Car car1 = new Car() { Year = "2016", Make = "Toyota", Model = "Camry", HasTrunk = true };
            Motorcycle motorcycle1 = new Motorcycle() { Year = "2021", Make = "Ducati", Model = "Scrambler", HasSideCar = false };
            Vehicle vehicle1 = new Car() { Year = "2023", Make = "Ford", Model = "F-150", HasTrunk = true };
            Vehicle vehicle2 = new Motorcycle() { Year = "2023", Make = "Harley Davidson", Model = "Nightster", HasSideCar = false };

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties with object initializer syntax
             */

            vehicles.Add(car1);
            vehicles.Add(motorcycle1);
            vehicles.Add(vehicle1);
            vehicles.Add(vehicle2);

            /*
             * Add the 4 vehicles to the list
             *
             * Using a foreach loop iterate over each of the properties
             */

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"This is a {vehicle.Year} {vehicle.Make} {vehicle.Model}.");
            }

            // Call each of the drive methods for one car and one motorcycle
            Console.WriteLine("------------------");
            car1.DriveAbstract();
            car1.DriveVirtual();
            Console.WriteLine("------------------");
            motorcycle1.DriveAbstract();
            motorcycle1.DriveVirtual();

            #endregion            
            Console.ReadLine();
        }
    }
}
