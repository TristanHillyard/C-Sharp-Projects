using System;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Number nums = new Number();
            nums.Amount = 3.2m;
            Console.WriteLine(nums.Amount);
        }
    }
}
