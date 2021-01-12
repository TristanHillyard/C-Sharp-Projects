using System;
using System.Text;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string jobOffer = "I have recieved a job offer from a tech company, " +
                "but I am not sure if I am going to take it.";

            Console.WriteLine(jobOffer);
            Console.ReadLine();

            string jobResponse = "I replied \"Thank you for looking at me, I will reply shortly with my decision.\"";

            Console.WriteLine(jobResponse);
            Console.ReadLine();

            string decision = "I have decided to \n \t Yes, I'll take it!";
            Console.WriteLine(decision);

            string name = "Tristan";
            name = name.ToUpper();
            Console.WriteLine(name);

            StringBuilder sb = new StringBuilder();

            sb.Append("This is going to be a long paragraph ");
            sb.Append("talking about the job opportunity that I have recieved over the past week ");
            sb.Append("and I still don't know what I am going to decide.");

            Console.WriteLine(sb);

        }
    }
}
