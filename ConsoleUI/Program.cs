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
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
              var vehicle = new List<Vehicle>();
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
             Motorcycle harley = new Motorcycle() {Make = "Harley Davidson", Model = "Street 500", Year = 2015, HasSideCart = false};
             Car honda = new Car() { Make = "Honda", Model = "Accord", Year = 2010, HasRoofWindow = false };
             Vehicle jeep = new Car() { Make = "Jeep", Model = "Wrangler", Year = 2010, HasRoofWindow = false };
             Vehicle motorcycle = new Motorcycle() {Make = "Honda", Model = "Cruiser", Year = 2017, HasSideCart = false};

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */
             vehicle.Add(harley);
             vehicle.Add(honda);
             vehicle.Add(jeep);
             vehicle.Add(motorcycle);

              foreach(var vehicles in vehicle)
            {
                Console.WriteLine($"Make {vehicles.Make} Model {vehicles.Model} Year {vehicles.Year}");
                vehicles.DriveAbstract();
            }
            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
