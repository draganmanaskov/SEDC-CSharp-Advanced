using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise1
{
    internal static class DogShelter
    {
        public static List<Dog> DogList = new List<Dog>();

        public static void PrintAll()
        {
            Console.WriteLine("Welcome to the Dog Shelter");
            foreach(Dog dog in DogList)
            {
                Console.WriteLine($"{dog.Name}");
            }
        }
    }
}
