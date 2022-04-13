using System;
using System.Collections.Generic;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog newDog1 = new Dog()
            {
                Id = 1,
                Name = "Dog1",
                Color = "brown",
            };

            Dog newDog2 = new Dog()
            {
                Id = 2,
                Name = "Dog2",
                Color = "white",
            };

            Dog newDog3 = new Dog()
            {
                Id = 3,
                Name = "Dog3",
                Color = "black",
            };

            Dog newDog4 = new Dog()
            {
                Id = -1,
                Name = "Dog4",
                Color = "golden",
            };

            List<Dog> dogList = new List<Dog>
            {
                newDog1,
                newDog2,
                newDog3,
                newDog4
            };


            foreach(Dog dog in dogList)
            {
                if(Dog.Validate(dog))
                {
                    DogShelter.DogList.Add(dog);
                }
            }

            DogShelter.PrintAll();

        }
    }
}
