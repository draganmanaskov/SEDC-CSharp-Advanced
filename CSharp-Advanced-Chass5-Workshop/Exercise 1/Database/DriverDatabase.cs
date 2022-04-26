using Exercise_1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1.Database
{
    internal class DriverDatabase : BaseDatabase<Driver>
    {
        public DriverDatabase(List<Driver> entities) : base(entities)
        {
        }
    }
}
