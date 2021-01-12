using System;

namespace AgeException
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            try
            {
                var age = Convert.ToInt32(Console.ReadLine());
                DateTime now = DateTime.Now;
                if (age == 0 || age < 0)
                {
                    Console.WriteLine("Zero and negative numbers are invalid values");
                    return;
                }
                
                var yearOB = now.Year - age;
                Console.WriteLine("You were born in the year {0} ", yearOB);
            }
            catch(Exception)
            {
                Console.WriteLine("Please enter your age in number format.");
                return;
            }
        }
    }
}
