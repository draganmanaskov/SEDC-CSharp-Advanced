using System;
using System.Collections.Generic;
using Exercise_1.Enums;

namespace Exercise_1.Models
{
    internal class Car : BaseEntity
    {
        private static int _id = 0;
        public string Model { get; set; }

        public string LicensePlate { get; set; }

        public DateTime LicensePlateExpiryDate { get; set; }

        public List<Driver> AssignedDrivers = new List<Driver>();

        public Car(string model, string licensePlate)
        {
            Model = model;
            LicensePlate = licensePlate;
            LicensePlateExpiryDate = DateTime.Now.AddYears(4);

            Id = _id;
            _id++;
        }

        public void AddDriver(Driver driver)
        {
            AssignedDrivers.Add(driver);
        }

        public override void Print()
        {
            Console.WriteLine($"{Model}");
        }
    }
}
