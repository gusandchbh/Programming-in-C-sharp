using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1A
{
    internal class Pet
    {
        private string name; // name of the pet
        private int age; // age of the pet
        private bool isFemale; // gender of the pet


        public void Start ()
        {
            Console.WriteLine(); // new line
            Console.WriteLine("Greetings from the Pet Owner application!"); // write to console
            Console.WriteLine();

            ReadAndSavePetData();
            DisplayPetInfo();
        }

        public void ReadAndSavePetData()
        {
            ReadName(); // call ReadName method
            ReadGender(); // call ReadGender method
        }

        public void ReadName()
        {
            Console.Write("What is the name of your pet? ");
            name = Console.ReadLine(); // set name of the pet to whatever the user inputs
            ReadAge(name); // call the ReadAge method and pass along the name of the pet
        }

        public void ReadAge(string petName)
        {
            Console.Write("What is " + name + "'s age? "); // make use of the name passed along from the ReadName method
            string strAge = Console.ReadLine();
            age = int.Parse(strAge); // convert string to int and set age of the pet to that number

        }

        public void ReadGender()
        {
            Console.Write("Is your pet a female(yes/no)? ");
            string strGender = Console.ReadLine();
            strGender = strGender.Trim().ToLower(); // trim the string to avoid whitespace and if there are uppercase letters they will be turned in to lowercase
            char response = strGender[0]; // strGender[0] returns the first char in the string
            if (response == 'y') 
                isFemale = true; // the pets gender is set to female
            else
                isFemale = false; 
        }

        public void DisplayPetInfo()
        {
            string male = "Male"; // string used to represent the case if isFemale is false
            string female = "Female"; // string used to represent the case if isFemale is true
            string gender = ""; // string used as a placeholder for the pets gender as it does not make sense to print the bool isFemale
            if (isFemale)
                gender = female; // if isFemale is true gender is set to female
            else
                gender = male; // if isFemale is not true gender is set to male
            string textOut = "Name: " + name + " Age: " + age + " Gender: " + gender; // here we store name age and gender in a string
            Console.WriteLine(textOut); // here we print that string
        }
    }
}
