using Exercise_1.Database;
using Exercise_1.Enums;
using Exercise_1.Models;
using System;
using System.Collections.Generic;

namespace Exercise_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car firstCar1 = new Car("Audi", "ADSR22");
            Car firstCar2 = new Car("BMW", "EWG3f1");
            Car firstCar3 = new Car("Ford", "VASH1B");
            Car firstCar4 = new Car("Nissan", "FFT6H3");

            Driver firstDriver1 = new Driver("John", "Smith", ShiftsEnum.Afternoon, firstCar1, "1224566");
            Driver firstDriver2 = new Driver("Anna", "Bell", ShiftsEnum.Morning, firstCar1, "52362121");
            Driver firstDriver3 = new Driver("Tom", "Oliver", ShiftsEnum.Evening, firstCar1, "9897642");

            List<Car> carList = new List<Car>
            {
                firstCar1,
                firstCar2,
                firstCar3,
                firstCar4
            };

            List<Driver> driverList = new List<Driver>
            {
                firstDriver1,
                firstDriver2,
                firstDriver3
            };

            //Database ourDatabase = new Database(carList, driverList);

            //ourDatabase.PrintAllCars();
            //ourDatabase.PrintAllDrivers();

            CarDatabase carDB = new CarDatabase(carList);
            DriverDatabase driverDB = new DriverDatabase(driverList);

            UserDatabase userDB = new UserDatabase();

            Menu(userDB, carDB, driverDB);

        }

        public static void Menu(UserDatabase userDB, CarDatabase carDB, DriverDatabase driverDB)
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("1 - Log in");
            Console.WriteLine("2 - Register");

            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "1":
                    LogIn(userDB, carDB, driverDB);
                    break;
                case "2":
                    Register(userDB, carDB, driverDB);
                    break;
                default:
                    Console.WriteLine("Invalid Input!\n");
                    Menu(userDB, carDB, driverDB);
                    break;
            }
        }

        private static void LogIn(UserDatabase userDB, CarDatabase carDB, DriverDatabase driverDB)
        {
            string userName = GetUsername(userDB);

            string password = GetPassword();

            User loggedIn = userDB.ValidLogin(userName, password);

            if (loggedIn == null)
            {
                Console.WriteLine("User does not exist");
                LogIn(userDB, carDB, driverDB);
            }
            else
            {
                ActionsMenu(loggedIn, userDB, carDB, driverDB);
            }

        }

        private static void ActionsMenu(User loggedIn, UserDatabase userDB, CarDatabase carDB, DriverDatabase driverDB)
        {
            Console.WriteLine($"Welcome {loggedIn.Username}");
            Console.WriteLine("1 - List All vehicles");
            Console.WriteLine("2 - List All operational vehicles");
            Console.WriteLine("3 - List all driver");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    carDB.PrintAll();
                    ActionsMenu(loggedIn, userDB, carDB, driverDB);
                    break;
                case "2":
                    carDB.PrintAllOperationalVehicles();
                    ActionsMenu(loggedIn, userDB, carDB, driverDB);
                    break;
                case "3":
                    driverDB.PrintAll();
                    ActionsMenu(loggedIn, userDB, carDB, driverDB);
                    break;
                default:
                    Console.WriteLine("Invalid Input!\n");
                    ActionsMenu(loggedIn, userDB, carDB, driverDB);
                    break;
            }
        }

        private static void Register(UserDatabase userDB, CarDatabase carDB, DriverDatabase driverDB)
        {
            string userName = GetUsername(userDB);

            string password = GetPassword();

            userDB.Insert(new User(userName, password));

            Menu(userDB, carDB, driverDB);
        }


        private static string GetUsername(UserDatabase userDB)
        {
            string userName;

            do
            {
                Console.WriteLine("Enter username");
                userName = Console.ReadLine();


                if (userDB.UserExists(userName))
                {
                    Console.WriteLine("User already Exists");
                    continue;
                }

                if (!String.IsNullOrEmpty(userName))
                {
                    break;
                }
                Console.WriteLine("Invalid Username");


            }
            while (true);

            return userName;
        }

        private static string GetPassword()
        {
            string password;

            do
            {
                Console.WriteLine("Enter password");
                password = Console.ReadLine();
                Console.WriteLine(password.Length);

                if (!String.IsNullOrEmpty(password) && password.Length > 6)
                {
                    break;
                }
                Console.WriteLine("Invalid Password");
            }
            while (true);

            return password;
        }
    }
}
