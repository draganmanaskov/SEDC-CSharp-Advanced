using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

using Domain.Enums;
using Domain.Models;

namespace Exercise1 
{
    internal class Program
    {
        static void Main(string[] args)
        {
			List<Dog> dogs = new List<Dog>()
				{
					new Dog("Charlie", "Black", 3, Race.Collie), // 0
					new Dog("Buddy", "Brown", 1, Race.Doberman),
					new Dog("Max", "Olive", 1, Race.Plott),
					new Dog("Archie", "Black", 2, Race.Mutt),
					new Dog("Oscar", "White", 1, Race.Mudi),
					new Dog("Toby", "Maroon", 3, Race.Bulldog), // 5
					new Dog("Ollie", "Silver", 4, Race.Dalmatian),
					new Dog("Bailey", "White", 4, Race.Pointer),
					new Dog("Frankie", "Gray", 2, Race.Pug),
					new Dog("Jack", "Black", 5, Race.Dalmatian),
					new Dog("Chanel", "Black", 1, Race.Pug), // 10
					new Dog("Henry", "White", 7, Race.Plott),
					new Dog("Bo", "Maroon", 1, Race.Boxer),
					new Dog("Scout", "Olive", 2, Race.Boxer),
					new Dog("Ellie", "Brown", 6, Race.Doberman),
					new Dog("Hank", "Silver", 2, Race.Collie), // 15
					new Dog("Shadow", "Silver", 3, Race.Mudi),
					new Dog("Diesel", "Brown", 4, Race.Bulldog),
					new Dog("Abby", "Black", 1, Race.Dalmatian),
					new Dog("Trixie", "White", 8, Race.Pointer), // 19
				};

			List<Person> people = new List<Person>()
				{
					new Person("Nathanael", "Holt", 20, Job.Choreographer),
					new Person("Rick", "Chapman", 35, Job.Dentist),
					new Person("Oswaldo", "Wilson", 19, Job.Developer),
					new Person("Kody", "Walton", 43, Job.Sculptor),
					new Person("Andreas", "Weeks", 17, Job.Developer),
					new Person("Kayla", "Douglas", 28, Job.Developer),
					new Person("Richie", "Campbell", 19, Job.Waiter),
					new Person("Soren", "Velasquez", 33, Job.Interpreter),
					new Person("August", "Rubio", 21, Job.Developer),
					new Person("Rocky", "Mcgee", 57, Job.Barber),
					new Person("Emerson", "Rollins", 42, Job.Choreographer),
					new Person("Everett", "Parks", 39, Job.Sculptor),
					new Person("Amelia", "Moody", 24, Job.Waiter)
					{ Dogs = new List<Dog>() {dogs[16], dogs[18] } },
					new Person("Emilie", "Horn", 16, Job.Waiter),
					new Person("Leroy", "Baker", 44, Job.Interpreter),
					new Person("Nathen", "Higgins", 60, Job.Archivist)
					{ Dogs = new List<Dog>(){dogs[6], dogs[0] } },
					new Person("Erin", "Rocha", 37, Job.Developer)
					{ Dogs = new List<Dog>() {dogs[2], dogs[3], dogs[19] } },
					new Person("Freddy", "Gordon", 26, Job.Sculptor)
					{ Dogs = new List<Dog>() {dogs[4], dogs[5], dogs[10], dogs[12], dogs[13] } },
					new Person("Valeria", "Reynolds", 26, Job.Dentist),
					new Person("Cristofer", "Stanley", 28, Job.Dentist)
					{ Dogs = new List<Dog>() {dogs[9], dogs[14], dogs[15] } }
				};


			Linq1(people, 'R');

			Linq2(dogs, "Brown", 3);

			Linq3(people, 2);

			Linq4(people, "Freddy", 1);

			Linq5(people, "Nathen");

			Linq6(people, "White", "Cristofer", "Freddy", "Erin", "Amelia");
		}

		//Find and print all white dogs names from Cristofer, Freddy, Erin
		//and Amelia, ordered by Name - ASCENDING ORDER
		private static void Linq6(List<Person> people, string color, string name1, string name2, string name3, string name4)
        {
			List<string> dogNames = people
							.Where(person => person.FirstName == name1 || person.FirstName == name2 || person.FirstName == name3 || person.FirstName == name4)
							.SelectMany(person => person.Dogs)
							.Where(dog => dog.Color == color)
							.OrderBy(dog => dog.Name)
							.Select(dog => $"Dog:{dog.Name} Age:{dog.Age}").ToList();

			Console.WriteLine("=====LINQ-6=======");
			foreach (string dog in dogNames)
			{
				Console.WriteLine(dog);
			}
			Console.WriteLine("");

		}

		//Find and print Nathen`s first dog
		private static void Linq5(List<Person> people, string firstName)
        {
			Dog firstDog = people
                                .Where(person => person.FirstName == firstName && person.Dogs.Count > 0)
								.SelectMany(person => person.Dogs).ToList()
								.First();

			Console.WriteLine("===== LINQ-5 =======");
			Console.WriteLine(firstDog.ToString());
			Console.WriteLine("");

		}

		//Find and print all Freddy`s dogs names older than 1 year
		private static void Linq4(List<Person> people, string firstName, int age)
        {
			List<string> dogNames = people
										.Where(person => person.FirstName == firstName)
										.SelectMany(person => person.Dogs)
										.Where(dog => dog.Age > age)
										.Select(dog => $"Dog:{dog.Name} Age:{dog.Age}").ToList();

			Console.WriteLine("===== LINQ-4 =======");
			foreach (string dog in dogNames)
            {
                Console.WriteLine(dog);
            }
            Console.WriteLine("");

        }

		//Find and print all persons with more than 2 dogs, ordered by
		//Name - DESCENDING ORDER
		private static void Linq3(List<Person> people, int numberOfDogs)
        {
			IEnumerable<Person> newPeopleList = people
													.Where(person => person.Dogs.Count > numberOfDogs)
													.OrderByDescending(person => person.FirstName);

			Console.WriteLine("===== LINQ-3 =======");
			foreach (Person person in newPeopleList)
			{
				Console.WriteLine(person.ToString());
			}
			Console.WriteLine("");
		}

		//Find and print all brown dogs names and ages older than 3 years,
		//ordered by Age - ASCENDING ORDER
		private static void Linq2(List<Dog> dogs, string color, int age)
        {
			IEnumerable<Dog> newDogsList = dogs
											.Where(dog => dog.Color == color && dog.Age > age)
											.OrderBy(dog => dog.Age);

			Console.WriteLine("===== LINQ-2 =======");
			foreach (Dog dog in newDogsList)
            {
				Console.WriteLine(dog.ToString());
            }
			Console.WriteLine("");
        }

		//Find and print all persons firstnames starting with 'R', ordered by
		//Age - DESCENDING ORDER
		private static void Linq1(List<Person> people, char v)
        {

			IEnumerable<Person> newPeopleList = people	
													.Where(person => person.FirstName[0] == v)
													.OrderByDescending(person => person.Age);

			Console.WriteLine("===== LINQ-1 =======");
			foreach (Person person in newPeopleList)
			{
				Console.WriteLine(person.ToString());
			}
			Console.WriteLine("");
		}
	}
}