using Assignment1.MainCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Fishes
{
    public class Whale : Fish // Inherit from Fish
    {
        private int blowholes; //Set accessibility to private


        public Whale(string id, string name, int age, Gender gender, int weight, int swimSpeed, int blowholes) 
            : base(id, name, age, gender, weight, swimSpeed) // call constructor of superclass
        {
            this.blowholes = blowholes;
        }

        public int Blowholes // Property for blowholes
        { 
            get { return blowholes; } 
            set { blowholes = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " Blowholes: " + blowholes;
        }




    }
}
