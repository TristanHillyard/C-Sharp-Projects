using System;
using System.Collections.Generic;

namespace ArrayAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select an Index from 0, 1, 2, 3");
            string[] nameArray = { "John", "Tim", "Chloe", "Kim K" };
            int result = Convert.ToInt32(Console.ReadLine());
            if (result > 4)
            {
                Console.WriteLine("Invalid Entry");
            }
            else
            {
                Console.WriteLine(nameArray[result]);
            }


            Console.WriteLine("Select an index from 0, 1, 2, 3, 4");
            int[] intArray = { 2, 10, 20, 30, 50 };
            int numResult = Convert.ToInt32(Console.ReadLine());
            if(numResult > 5)
            {
                Console.WriteLine("Invalid Entry");
            }
            else
            {
                Console.WriteLine(intArray[numResult]);
            }
            

            Console.WriteLine("Select an Index of 0, 1, or 2");
            List<string> strgList = new List<string>();
            strgList.Add("Hello");
            strgList.Add("Crazy");
            strgList.Add("Mello");
            int strgResult = Convert.ToInt32(Console.ReadLine());
            if(strgResult > 3)
            {
                Console.WriteLine("Invalid Entry");
            }
            else
            {
                Console.WriteLine(strgList[strgResult]);
            }

        }
    }
}
