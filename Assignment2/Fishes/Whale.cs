using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.Animals;
using Assignment2.Animals.Categories;
using Assignment2.Manager;

namespace Assignment2.Fishes
{
    public class Whale : Fish // Inherit from Fish
    {
        private FoodSchedule foodSchedule;
        private int blowholes; //Set accessibility to private


        public Whale(string id, string name, int age, Gender gender, int weight, int swimSpeed, int blowholes, CategoryType category) 
            : base(id, name, age, gender, weight, swimSpeed, category) // call constructor of superclass
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

        public override FoodSchedule getFoodSchedule()
        {
            return foodSchedule;
        }

        public void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = EaterType.Omnivorous;
            foodSchedule.Add("Morning: bones and milk");
            foodSchedule.Add("Lunch: beef and water");
            foodSchedule.Add("Evening: chicken");

        }



    }
}
