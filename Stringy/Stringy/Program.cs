using System;
using System.Text;

namespace Stringy
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Tristan";
            //string quote = "The man said, \"Hello\", Tristan. \n Hello on a new line. \n \t Hello on a tab.";
            //string fileName = @"C: \Users\Tristan";

            //bool trueOrFalse = name.Contains("s");
            //Console.WriteLine(trueOrFalse);
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();

            //Console.WriteLine(fileName);
            //Console.WriteLine(quote);
            //Console.ReadLine();

            string name = "Tristan";
            name = "Joe";

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse");

            Console.WriteLine(sb);

            Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}
