using _07_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ClassConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle firstVehicle = new Vehicle();

            firstVehicle.Make = "Honda";
            firstVehicle.Model = "Civic";
            firstVehicle.Year = 2012;
            firstVehicle.Type = Vehicletype.Car;
            firstVehicle.Mileage = 150000;
            firstVehicle.Color = "Grey";


            Vehicle secondVehicle = new Vehicle("Chevy", "Silverado", 1994, 98000, "black", Vehicletype.Truck);

            Console.WriteLine(secondVehicle.Make);

            Console.ReadLine();

            Person FirstPerson = new Person("Garry", "Banks", new DateTime(1991, 08, 24), firstVehicle);

            Console.WriteLine(FirstPerson.FullName);
            Console.WriteLine(FirstPerson.AgeInYears);

            Console.ReadLine();
        }
    }
}
