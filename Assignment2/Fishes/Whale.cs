using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.Animals;
using Assignment2.Animals.Categories;
using Assignment2.Manager;
using static System.Net.Mime.MediaTypeNames;

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
            SetFoodSchedule();
        }

        public int Blowholes // Property for blowholes
        { 
            get { return blowholes; } 
            set { blowholes = value; }
        }

        public override string GetExtraInfo()
        {
            string strOut = base.GetExtraInfo();

            strOut += Environment.NewLine + string.Format("{0,-22} {1,15}", "Blowholes:", Blowholes);

            return "Whale" + Environment.NewLine + Environment.NewLine + strOut;
        }

        public override FoodSchedule getFoodSchedule()
        {
            return foodSchedule;
        }

        public void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = EaterType.Carnivore;
            foodSchedule.Add("Morning: squid sallad");
            foodSchedule.Add("Lunch: plankton");
            foodSchedule.Add("Evening: 2-3 sharks");
        }
    }
}
