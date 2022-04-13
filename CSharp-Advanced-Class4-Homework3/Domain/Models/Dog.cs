using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class Dog : Pet
    {
        public bool GoodBoi { get; set; }

        public string FavoriteFood { get; set; }

        public Dog(string name, string type, int age, bool goodBoi, string favoriteFood) : base(name, type, age)
        {
            GoodBoi = goodBoi;
            FavoriteFood = favoriteFood;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{Name} favorite food is {FavoriteFood}");
        }
    }
}
