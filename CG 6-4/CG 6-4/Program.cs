using System;

namespace CG_6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user to enter a date, specify the format you'd like them to enter the date in
            //store the date as a DateTime
            Console.WriteLine("Enter any date in the format MM/DD/YYYY: ");
            DateTime firstDate = DateTime.Parse(Console.ReadLine());

            //ask the user to enter a second date and store it as a DateTime
            Console.WriteLine("Enter a second date using the same format and we will find the number of days between the two dates: ");
            DateTime secondDate = DateTime.Parse(Console.ReadLine());

            //use TimeSpan to find the days between the dates. Because this is TimeSpan we can subtract
            TimeSpan daysBetween = secondDate.Subtract(firstDate);
            //using the $ lets us insert the daysBetween.Total days in the sentence that is printed to the screen. Use totalDays because we are only interested in days
            Console.WriteLine($"There are {daysBetween.TotalDays} days between the two dates.");
            Console.ReadLine();
        }

    }
}
