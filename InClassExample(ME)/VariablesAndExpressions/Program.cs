using System;

namespace VariablesAndExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Instructor";
            string lastName = "Ackerman";
            Console.WriteLine("Boomer Sooner");

            Console.WriteLine("What is your first name? >>");
            firstName = Console.ReadLine();

            Console.WriteLine("What is your last name? >>");
            lastName = Console.ReadLine();

            int luckynumber = 7;

            System.Console.WriteLine("What is your Favorite Number? >>");
            string answer = Console.ReadLine();
            luckynumber = Convert.ToInt32(answer);

            double evenLuckierNumber = 7 * luckynumber;

            Console.WriteLine(firstName + " " + lastName + " " + evenLuckierNumber);
        }
    }
}
