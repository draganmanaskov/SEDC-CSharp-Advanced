using System;
using System.Collections.Generic;
using System.Globalization;

namespace Exercise_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> holidaysArray = new List<string> { "1 Jan", "7 Jan", "20 Apr", "1 May", "25 May", "3 Aug", "8 Sep", "12 Oct", "23 Oct", "8 Dec" };

            //Start Program
            WorkDayChecker(holidaysArray);
        }

        //Get date input from user
        static DateTime GetUserInputDate()
        {
            Console.WriteLine("Please enter a date in this format: MM-DD-YYYY");
            string date = Console.ReadLine();

            //if entered an invalid date format call the method until a corect input is entered
            if (!DateTime.TryParse(date, out DateTime ourDate))
            {
                Console.WriteLine("Wrong format");
                return GetUserInputDate();
            }
            else
            {
                return ourDate;
            }
        }

        // main method. can call itself for another date 
        static void WorkDayChecker(List<string> holidays)
        {
            DateTime ourDate = GetUserInputDate();

            string montName = ourDate.ToString("MMM", CultureInfo.InvariantCulture);

            string dayOfWeek = ourDate.DayOfWeek.ToString();

            Console.WriteLine("=====NewDate======");

            if (holidays.Contains($"{ourDate.Day} {montName}") || dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                Console.WriteLine("Today is a non working-day! Party time!");
            }
            else
            {
                Console.WriteLine("Today is a work day! Off to work :( !");
            }

            Console.WriteLine("");

            // if we get a yes for checking another date call WorkDayChecker method again
            if (GetUserInputAction())
            {
                Console.WriteLine("");
                WorkDayChecker(holidays);
            }
        }

        //ask the user if he wants to check another date
        static bool GetUserInputAction()
        {
            Console.WriteLine("Check another date?");
            Console.WriteLine("Press 1 for yes");
            Console.WriteLine("Press 2 for no");
            string userContinue = Console.ReadLine();

            if(String.IsNullOrEmpty(userContinue) || (userContinue != "1" && userContinue != "2"))
            {
                //if entered an empty or invalid string input call the method again
                Console.WriteLine("Please enter 1(yes) or 2(no)");
                return GetUserInputAction();
            }

            if(userContinue == "1")
            {
                return true;
            }

            return false;
        }
            
    }
}
