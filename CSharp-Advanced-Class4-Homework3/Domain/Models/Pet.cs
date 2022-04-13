using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public abstract class Pet
    {
        public string Name { get; set; }

        public string Type { get; set; }

        public int Age { get; set; }

        protected Pet(string name, string type, int age)
        {
            Name = name;
            Type = type;
            Age = age;
        }

        public abstract void PrintInfo();
    }
}
