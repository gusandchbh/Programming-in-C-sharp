using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class MathWork
    {
        private void CalculateSquareRoots() {
            Console.Write("Enter a number and I will show you what the square root of that number is!");
            string input = Console.ReadLine()!;
            int number = int.Parse(input);
            Console.WriteLine("The square root of " + input + " is " + Math.Sqrt(number));
        
        }

        private bool ExitCalculations() {
            Console.WriteLine("\nWould you like to run again or would you like to go on to the next part? Enter yes to run again.");
            string reply = Console.ReadLine()!;
            if (reply == "")
            {
                return true;
            }
            if (reply?.Length > 0 && reply[0] == 'y' || reply == "yes")
            {
                return false; // if user enters yes or y we continue
            }
            return true;
        }

        private void ListLeapYears() { }

        private void PrintEvenNumbers(int number1, int number2) {
            Console.Write("Even numbers between " + number1 + " and " + number2 + " : ");

            for (int i = number1; i <= number2; i++)
            {
                if (i % 2 == 0) // using the modulo operator to determine if it is an even number 
                {
                    Console.Write(i + "   ");
                }
            }
        }

        private void PrintMultiplicationTable() { 
        Console.WriteLine("\n********* Multiplication table *********)");
        
            for (int i = 1; i <= 12; i++)
            {
                for (int j = 1; j <= 12; j++)
                {
                    Console.Write(string.Format("{0,4:d} ", i * j)); // using Format to structure the layout of the string in a nicer way
                }
            }
        }

        public void Start() {

            bool done = false;

            do
            {
                SumNumbers();

                done = ExitCalculations();
            } while (!done);
        }
      

        private void SumNumbers() {
            Console.WriteLine("Sum numbers between any two numbers.");
            string ans = "";
            do
            {
                Console.WriteLine("Give start number: ");
                string start = Console.ReadLine()!;
                int startnumber = int.Parse(start);
                Console.WriteLine("Give end number: ");
                string end = Console.ReadLine()!;
                int endnumber = int.Parse(end);
                if (startnumber > endnumber)
                {
                    int temp = startnumber;
                    startnumber = endnumber;
                    endnumber = temp;
                }
                int sum = SumNumbers(startnumber, endnumber);
                Console.WriteLine("The sum of numbers between " + start + "and " + end + " is: " + sum);
                PrintEvenNumbers(startnumber, endnumber);
                PrintMultiplicationTable();
                CalculateSquareRoots();
                Console.WriteLine("Exit calculations? (y/n)");
                ans = Console.ReadLine()!;
            } while (ans != "y");
        }

        private int SumNumbers(int start, int end) {
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                sum += i;
            }
            
            return sum; }




    }
}
