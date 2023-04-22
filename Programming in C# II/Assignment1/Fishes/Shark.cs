using Assignment1.MainCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Fishes
{
    public class Shark : Fish // Inherit from Fish
    {
        private int teeth; // Set accessibility to private

        public Shark(string id, string name, int age, Gender gender, int weight, int swimSpeed, int teeth) 
            : base(id, name, age, gender, weight, teeth) // // call constructor of superclass
        {
            this.teeth = teeth;
        }

        public int Teeth //Property for teeth
        {
            get { return teeth; }
            set { teeth = value; }
        }

        public override string ToString()
        {
            return base.ToString() + " Teeth: " + teeth;
        }
    }
}
