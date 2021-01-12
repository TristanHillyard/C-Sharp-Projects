using System;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("What number do you want to do math operations on?");
            num1 = Convert.ToInt32(Console.ReadLine());
            MathMeth math = new MathMeth();
            math.Math(num1);
            Console.WriteLine(math.Math(num1));
            math.MathA(num1);
            Console.WriteLine(math.MathA(num1));
            math.MathS(num1);
            Console.WriteLine(math.MathS(num1));
            
             
        }
    }
}
