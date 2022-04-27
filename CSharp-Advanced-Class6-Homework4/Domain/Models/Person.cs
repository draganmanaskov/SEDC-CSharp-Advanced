using Domain.Enums;

namespace Domain.Models
{
	public class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }
		public Job Occupation { get; set; }
		public List<Dog> Dogs { get; set; }

		public Person(string firstName, string lastName, int age, Job occupation)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			Occupation = occupation;
			Dogs = new List<Dog>();
		}

		public override string ToString()
		{
			string dogs = "Dogs:";
			foreach(Dog dog in Dogs)
            {
				dogs += $" {dog.Name}";
            }

			return $"{FirstName} {LastName} {Age} {Occupation} {dogs}";
		}
	}
}
