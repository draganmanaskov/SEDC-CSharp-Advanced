using Domain.Models;
using System;
using System.Collections.Generic;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PetStore<Dog> dogStore = new PetStore<Dog>(
                new List<Dog>
                    {
                        new Dog("Dog1", "Dog", 7, true, "bones"),
                        new Dog("Dog2", "Dog", 4, false, "beef"),
                    });

            PetStore<Cat> catStore = new PetStore<Cat>(
                new List<Cat>
                {
                    new Cat("Cat1", "Cat", 3, false, 4),
                    new Cat("Cat2", "Cat", 1, true, 7)
                });


            PetStore<Fish> fishStore = new PetStore<Fish>(
                    new List<Fish>
                    {
                        new Fish("Fish1", "Fish", 1, "golden", 3),
                        new Fish("Fish2", "Fish", 2, "red", 4),
                    }
                );

            //Dogs
            dogStore.BuyPet("Dog1");
            //if the dog doesnt exist
            dogStore.BuyPet("Dog1");

            dogStore.PrintPets();


            //Cats
            catStore.BuyPet("Cat1");
            catStore.PrintPets();

            //Fish
            fishStore.PrintPets();

            fishStore.InsertMany(
                new List<Fish>
                {
                    new Fish("Fish3", "Fish", 3, "blue", 2),
                    new Fish("Fish4", "Fish", 4, "green", 1)
                });

            fishStore.PrintPets();

        }
    }
}
