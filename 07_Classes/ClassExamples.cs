using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Classes
{
    public enum Vehicletype {Car, Truck, Van, Suv, Minivan, Coupe, Boat}
    public class Vehicle
    {
        //accessModifier type propertName {get;set;}
        public string Make { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public double Mileage{get; set; }
        public Vehicletype Type{ get; set; }
        public Vehicle()
        {

        }
        public Vehicle(string make, string model, int year, double mileage, string color, Vehicletype type)
        {
            Make = make;
            Year = year;
            Model = model;
            Color = color;
            Mileage = mileage;
            Type = type;
        }

    }
    public class Person
    {
        public int _field;
        //height
        //age
        //gender
        //weight
        //firstname
        //lastname
        //DateOfBirth

        public string Firstname { get; set; }
        public string LastName { get; set; }

        public string FullName
        {
            get { return $"{Firstname} {LastName}"; }
        }

        public DateTime DateOfBirth { get; set; }

        public int AgeInYears
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                return Convert.ToInt32(Math.Floor(totalAgeInYears));

            }
        }

        public Vehicle Transport { get; set; }
        public Person()
        {

        }
        public Person(string firstName, string lastName, DateTime dateOfBirth, Vehicle transport)
        {
            Firstname = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Transport = transport;
        }
    }
    }
