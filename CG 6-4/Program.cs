using System;

namespace CG_6_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user for a date
            // convert date to variable
            // parse to get numeric date values
            Console.WriteLine("Please enter a date in MM/DD/YYYY format");
            DateTime dateOne = DateTime.Parse(Console.ReadLine());

            // repeat above steps for second date
            Console.WriteLine("Please enter another date in MM/DD/YYYY format");
            DateTime dateTwo = DateTime.Parse(Console.ReadLine());

            // set the total number as a variable
            // set what to do with the dates here, subtract
            TimeSpan numberDays = dateTwo.Subtract(dateOne);


            // output the number of days between the dates by using .Days to call only the days
            
            Console.WriteLine("There are " +  numberDays.Days + " days between the two dates you entered.");
            Console.ReadLine();

        }
    }
}
