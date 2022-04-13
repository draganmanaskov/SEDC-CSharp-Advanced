using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public class PetStore<T> where T: Pet
    {
        private List<T> _petsList;

        public PetStore(List<T> pets)
        {
            _petsList = pets;
        }

        public void Insert(T pet)
        {
            _petsList.Add(pet);

            Console.WriteLine($"There is a new {pet.GetType().Name} in the {pet.GetType().Name} Store!");
        }

        public void InsertMany(List<T> pets)
        {
            _petsList.AddRange(pets);

            Console.WriteLine($"{pets.Count} new {typeof(T).Name} were added in the {typeof(T).Name} Store!");
        }

        public void PrintPets()
        {
            Console.WriteLine($"Welcome to the {typeof(T).Name} Store");
            foreach (var pet in _petsList)
            {
                Console.WriteLine($"{pet.Name}");
            }
        }

        public void BuyPet(string name)
        {
            foreach(var pet in _petsList)
            {
                if(pet.Name == name)
                {
                    _petsList.Remove(pet);
                    Console.WriteLine($"{pet.Name} has been bought");
                    return;
                }
            }
            Console.WriteLine($"No {typeof(T).Name} with name {name} found");

        }
    }
}
