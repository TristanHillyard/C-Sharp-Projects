using System;

namespace MoreClasses
{
    class Program
    {
        static int PlusMeth(int x, int y)
        {
            return x + y;
        }
        static double PlusMeth(double x, double y)
        {
            return x + y;
        }
        static void Main(string[] args)
        {
            Div div = new Div();
            int result;
            Console.WriteLine("Enter any number.");
            result = Convert.ToInt32(Console.ReadLine());
            div.Division(result);

            int a = 100;
            div.getValue(out a);
            Console.WriteLine(a);

            int myNum = PlusMeth(8, 5);
            double myNum1 = PlusMeth(2.3, 3.4);
            Console.WriteLine(myNum);
            Console.WriteLine(myNum1);
        }
    }
}
