using System;

using Exercise_1.Enums;

namespace Exercise_1.Models
{
    internal class Driver : BaseEntity
    {
        private static int _id = 0;
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public ShiftsEnum Shift { get; set; }

        public Car Car { get; set; }

        public string License { get; set; }

        public DateTime LicenseExpiryDate { get; set; }

        public Driver(string firstName, string lastName, ShiftsEnum shift, Car car, string license)
        {
            FirstName = firstName;
            LastName = lastName;
            Shift = shift;
            Car = car;
            License = license;
            LicenseExpiryDate = DateTime.Now.AddYears(5);
            Id = _id;
            _id++;
        }

        public override void Print()
        {
            Console.WriteLine($"{FirstName} {LastName} is availble: {Shift}");
        }
    }
}
