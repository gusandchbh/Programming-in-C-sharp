using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.MainCategory
{
    public class Mammal : Animal // Inherit from Animal
    {
        private int expectedLifeSpan; // Set accessibility to private


        /// <summary>
        /// Constructor for Mammal, also calls constructor of superclass (animal)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="weight"></param>
        /// <param name="expectedLifeSpan"></param>
        public Mammal(string id, string name, int age, Gender gender, int weight, int expectedLifeSpan) : base(id, name, age, gender, weight)
        {
            this.expectedLifeSpan = expectedLifeSpan;
        }

        /// <summary>
        /// Property for expected lifespan
        /// </summary>

        public int ExpectedLifeSpan 
        {
            get { return expectedLifeSpan; }
            set { expectedLifeSpan = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " Expected lifespan: " + expectedLifeSpan;
        }

    }
}
