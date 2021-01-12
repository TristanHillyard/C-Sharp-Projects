using System;
using System.Collections.Generic;
using System.Text;

namespace MoreClasses
{
    public class Div
    {
        public void Division(int num)
        {
            int result;
            result = num / 2;
            Console.WriteLine(result);
        }
        public void getValue(out int x)
        {
            int temp = 5;
            x = temp;
        }
        
    }
}
