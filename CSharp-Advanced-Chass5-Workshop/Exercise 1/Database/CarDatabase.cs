using Exercise_1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1.Database
{
    internal class CarDatabase : BaseDatabase<Car>
    {
        public CarDatabase(List<Car> entities) : base(entities)
        {
        }

        public void PrintAllOperationalVehicles()
        {
            foreach(Car car in Entities)
            {
                if (DateTime.Compare(car.LicensePlateExpiryDate, DateTime.Now) > 0)
                {
                    Console.WriteLine($"{car.Model} is working");
                }
            }
        }
    }
}
