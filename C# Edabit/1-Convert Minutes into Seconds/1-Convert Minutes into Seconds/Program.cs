using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Write a function that takes an integer minutes and converts it to seconds.
 * convert(5) ➞ 300
 * convert(3) ➞ 180
 */



namespace _1_Convert_Minutes_into_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            bool i = false;
            int minutes = 0;
            int seconds = 0;

            Console.WriteLine("This Program will take the input an input of minutes and then will return the number of seconds. ");
            Console.Write("Input number of minutes: ");

            while (i == false)
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out minutes) == true)
                {

                    seconds = minutes * 60;
                    i = true;
                    Console.WriteLine("The number of seconds in " + minutes + " minutes is: " +seconds + " seconds");


                }
                else
                {
                    Console.WriteLine("Input isn't a number");
                    Console.Write("Input another number: ");

                }


            }
            Console.WriteLine("Press Enter to exit ");
            input = Console.ReadLine();

        }
    }
}
