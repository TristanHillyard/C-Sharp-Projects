using System;

namespace MathAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            double result;
            Console.WriteLine("Type any number, your number will be times by 50");
            num = Convert.ToInt32(Console.ReadLine());

            result = num * 50;
            Console.WriteLine(result);
            Console.ReadLine();

            int num1;
            int result1;
            Console.WriteLine("Type any number, 25 will be added to what number you type in.");
            num1 = Convert.ToInt32(Console.ReadLine());
            result1 = num1 + 25;
            Console.WriteLine(result1);
            Console.ReadLine();

            float num2;
            double result2;
            Console.WriteLine("Type any number, your number will be divided by 12.5");
            num2 = Convert.ToInt32(Console.ReadLine());
            result2 = num2 / 12.5;
            Console.WriteLine(result2);
            Console.ReadLine();

            int num3;
            int num4 = 50;
            Console.WriteLine("Type any number, this will check if your number is greater than 50");
            num3 = Convert.ToInt32(Console.ReadLine());

            bool result3 = num3 > num4;
            Console.WriteLine(result3);
            Console.ReadLine();

            int num5;
            float num6 = 7;
            float result4;
            Console.WriteLine("Type any number, it will be divided by 7 and the remainder will be shown");
            num5 = Convert.ToInt32(Console.ReadLine());
            result4 = num5 % num6;
            Console.WriteLine(result4);
        }
    }
}
