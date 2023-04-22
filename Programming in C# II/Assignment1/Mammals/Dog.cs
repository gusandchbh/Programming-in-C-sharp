using Assignment1.MainCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Mammals
{
    public class Dog : Mammal
    {
        private string breed; // Set accessibility to private


        /// <summary>
        /// Constructor for Dog, also calls constructor of superclass (mammal)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="weight"></param>
        /// <param name="expectedLifeSpan"></param>
        /// <param name="breed"></param>
        public Dog(string id, string name, int age, Gender gender, int weight, int expectedLifeSpan, string breed) : base(id, name, age, gender, weight, expectedLifeSpan)
        {
            this.breed = breed;
        }


        /// <summary>
        /// Property for breed
        /// </summary>
        public string Breed 
        {
            get { return breed; }
            set { breed = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " Breed: " + breed;
        }
    }
}
