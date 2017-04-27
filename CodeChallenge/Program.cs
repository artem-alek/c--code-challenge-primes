using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge
{
    class PrimeChallenge
    {
        static void Main(string[] args)
        {
            // Define variables
            string filePath;
            int counter = 0;
            string line;

            // Command-line arugment to enter a file containing one integer per line.
            Console.WriteLine("Please enter file path: ");
            filePath = Console.ReadLine();
 
            // Read the file and display it line by line.
            System.IO.StreamReader file =
                new System.IO.StreamReader(filePath);
            while ((line = file.ReadLine()) != null)
            {
                // Need to turn the string from ReadlLine() into a integer.
                int number = int.Parse(line);
                var primeList = primesLogic(number);

            // Needed to print out the values in the list and not the list object. Found a solution using string.Join().
                Console.WriteLine("{0}: {1}", line, string.Join(", ",primeList));
                counter++;
            }
            file.Close();
            Console.WriteLine("Thank You For Using This App!");

            
        }

        /// <summary>
        /// Reads a number and finds the primes of number.
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static List<int> primesLogic(int number)
        {
            var primeNums = new List<int>();

            // Logic to find prime numbers and then used a .Add() to add it to the new List.
            for (int i = 2; i <= number; i++)
            {
                while (number % i == 0)
                {
                    primeNums.Add(i);
                    number = number / i;
                }
            }
            return primeNums;
        }
    }
}
