using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.MainCategory
{
    public class Fish : Animal // Inherit from Animal
    {
        private int swimSpeed; // Set accessibility to private

        /// <summary>
        /// Constructor for Fish, also calls constructor in superclass (animal)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="weight"></param>
        /// <param name="swimSpeed"></param>
        public Fish(string id, string name, int age, Gender gender, int weight, int swimSpeed) : base(id, name, age, gender, weight)
        {
            this.swimSpeed = swimSpeed;
        }

        public int SwimSpeed
        {
            get { return swimSpeed; }
            set { swimSpeed = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " Swimspeed: " + swimSpeed;
        }
    }


}
