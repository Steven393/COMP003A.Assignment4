/* 
 * Author: Steven Gonzalez
 * Course: COMP-003A
 * Purpose: Code for Lecture Activity 4
 * Reference: \
 */

using System.Diagnostics.Metrics;
using System.Xml;

namespace COMP003A.LectureActivity4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***************************************************");
            Console.WriteLine("for loop section");
            Console.WriteLine("Output a right triangle based on user input");
            Console.WriteLine("***************************************************");
            Console.WriteLine("Enter a positive whole number");
            int limit = Convert.ToInt32(Console.ReadLine());
            
               string output = ("#");

            for (int i = 0; i <= limit; i++)
            {

                Console.WriteLine(output);
                output += "#";
            }
            Console.WriteLine("\n");

            Console.WriteLine("***************************************************");
            Console.WriteLine("foreach section");
            Console.WriteLine("Output all of the friends in an array");
            Console.WriteLine("***************************************************");

            string[] friends = new string[] { "Rachel", "Joey", "Chandler", "Ross", "Monica", "Phoebe" };
            foreach (string friend in friends) Console.WriteLine(friend);

            Console.WriteLine("\n");

            Console.WriteLine("***************************************************");
            Console.WriteLine("do-while section");
            Console.WriteLine("Output 0-50 by 5s");
            Console.WriteLine("***************************************************");

            int counter = 0;

            do
            {
                Console.WriteLine(counter);
                counter+=5;

            } while (counter <= 50);
           

            Console.WriteLine("\n");

            Console.WriteLine("***************************************************");
            Console.WriteLine("while section");
            Console.WriteLine("Output 1-20");
            Console.WriteLine("If the number is divisible by 2, output Foo");
            Console.WriteLine("If the number is divisible by 5, output Bar");
            Console.WriteLine("If the number is divisible by 2 & 5, output FooBar");
            Console.WriteLine("***************************************************");

            int counter2 = 1;

            while (counter2 <= 20) 
            {
                if (counter2 % 2 == 0)
                {
                    Console.WriteLine("Foo");
                    counter2++;
                }
                if (counter2 % 5 == 0)
                {
                    Console.WriteLine("Bar");
                    counter2++;
                }
                if (counter2 % 2 == 0 && counter2 % 5 == 0) 
                {
                    Console.WriteLine("FooBar");
                    counter2++;
                }
                else
                {
                    Console.WriteLine(counter2);
                    counter2++;

                }
            }

        }
    }
}