using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */
             

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */

            List<Vehicle> vehicles = new List<Vehicle>();

            vehicles.Add(new Car { Year = "2010", Make = "Ford", Model = "Mustang", HasTrunk = true });
            vehicles.Add(new Motorcycle { Year = "2005", Make = "Harley-Davidson", Model = "Electra Glide" });

            Car car1 = new Car("1995", "Chevrolet", "Camaro");
            vehicles.Add(car1);

            Motorcycle motorcycle1 = new Motorcycle("1980", "Honda", "CB750");
            vehicles.Add(motorcycle1);

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */
            foreach (Vehicle vehicle in vehicles) {
                Console.WriteLine($"Make: {vehicle.Make}");
                Console.WriteLine($"Model: {vehicle.Model}");
                Console.WriteLine($"Year: {vehicle.Year}\n");
            }

            // Call each of the drive methods for one car and one motorcycle
            vehicles[0].DriveAbstract();
            vehicles[0].DriveVirtual();
            vehicles[1].DriveAbstract();
            vehicles[1].DriveVirtual();

            #endregion            
            Console.ReadLine();
        }
    }
}
