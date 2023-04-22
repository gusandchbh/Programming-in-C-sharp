using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.MainCategory
{
    public class Animal
    {

        private string id; // Set accessibility to private
        private string name; // Set accessibility to private
        private int age; // Set accessibility to private
        private Gender gender; // Set accessibility to private
        private int weight; // Set accessibility to private

        /// <summary>
        /// Constructor for Animal
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="weight"></param>
        public Animal(string id, string name, int age, Gender gender, int weight)
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.weight = weight;
        }

        /// <summary>
        /// Property for name
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Property for age
        /// </summary>

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        /// <summary>
        /// Property for gender
        /// </summary>

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        /// <summary>
        /// Property for weight
        /// </summary>

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        /// <summary>
        /// Property for id
        /// </summary>

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public override string ToString()
        {
            return "ID: " + id + " Name: " + name + " Age: " + age + " Gender: " + gender.ToString() + " Weight: " + weight; 
        }

    }
}
