using System;

using Exercise_1.Enums;

namespace Exercise_1
{
    internal class User : BaseEntity
    {
        private static int _id = 0;
        public string Username { get; set; }

        public string Password { get; set; }

        public RolesEnum Role { get; set; }

        public User(string userName, string password)
        {
            Username = userName;

            Password = password;

            Role = RolesEnum.Customer;

            Id = _id;
            _id++;
        }

        public override void Print()
        {
            Console.WriteLine($"{Username}");
        }
    }
}
