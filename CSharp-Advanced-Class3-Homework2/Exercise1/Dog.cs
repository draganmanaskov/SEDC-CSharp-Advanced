using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    internal class Dog
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Color { get; set; }

        public void Bark()
        {
            Console.WriteLine("Bark Bark");
        }

        public static bool Validate(Dog dog)
        {
            if( String.IsNullOrEmpty(dog.Id.ToString()) ||
                String.IsNullOrEmpty(dog.Name) ||
                String.IsNullOrEmpty(dog.Color) ||
                dog.Id < 0 ||
                dog.Name.Length < 2
                )
            {
                Console.WriteLine("Invalid Dog");
                return false;
            }

            return true;
        }
    }
}
