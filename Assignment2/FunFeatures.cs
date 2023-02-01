using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class FunFeatures
    {
        private string name = "";
        private string email = "";


        public void Start() {
            Introduce();

            bool done = false;

            do
            {
                PredictTheDay();

                CalculateStrengthLength();

                done = RunAgain();
            } while (!done);
        }

        private void CalculateStrengthLength()   {
            Console.WriteLine("\nWrite a text with any number of characters and press Enter.\nI will then calculate the number of chars included in the text.");
            string text = Console.ReadLine()!;
            Console.WriteLine("Your text was: " + text);
            Console.WriteLine("It contains " + text.Length + " characters."); // Length gives the length of the string
        }


        private string Readname() {
            Console.WriteLine("\nPlease enter your first name:");
            return Console.ReadLine()!;
        }

        private string Readlastname()
        {
            Console.WriteLine("\nPlease enter your last name:");
            return Console.ReadLine()!;
        }

        private string Reademail() {
            Console.WriteLine("\nPlease enter your email:");
            return Console.ReadLine()!;
        }



        private void Introduce() {
            Console.WriteLine("\nHi! My name is Christopher and I am the creator of this application.");
            string firstName = Readname();
            string lastName = Readlastname();
            email = Reademail();
            name = lastName.ToUpper() + ", " + firstName; // ToUpper converts to an equivalent string but with uppercase letters
            Console.WriteLine("\nHere is your full name and your email:\n" + name + " " + email);
        }

        private void PredictTheDay() {
            Console.WriteLine("\nI am a fortune teller.\nEnter a number between 1 and 7.");
            string option = Console.ReadLine()!;
            if (option.Length == 0)
            {
                return; // if user enters, thereby entering an empty string, we leave this method
            }
            int day = int.Parse(option);
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday: Keep calm my friend! You can fall apart!");
                    break;
                case 2:
                    Console.WriteLine("Tuesday and Wednesday break your heart!");
                    break;
                case 3:
                    Console.WriteLine("Wednesday is a GREAT day.");
                    break;
                case 4:
                    Console.WriteLine("Thursday, OMG, still one day to Friday!");
                    break;
                case 5:
                    Console.WriteLine("It's Friday! You are in love!");
                    break;
                case 6:
                    Console.WriteLine("Saturday, do nothing and do plenty of it!");
                    break;
                case 7:
                    Console.WriteLine("And Sunday always comes too soon!");
                    break;
                default:
                    Console.WriteLine("Why didn't you enter a number between 1 and 7? :(");
                    break;
            }
        }

        private bool RunAgain() 
        {
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

    }







}
