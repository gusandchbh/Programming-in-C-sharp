using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.Animals;
using Assignment2.Animals.Categories;
using Assignment2.Manager;

namespace Assignment2.Insects
{
    internal class Ant : Insect // Omni
    {
        private int colonySize;
        private FoodSchedule foodSchedule;

        public Ant(string id, string name, int age, Gender gender, int weight, int numberOfLegs, int colonySize, CategoryType category) : base(id, name, age, gender, weight, category, numberOfLegs)
        {
            this.colonySize = colonySize;
            SetFoodSchedule();
        }

        public int ColonySize
        {
            get { return colonySize; }
            set { colonySize = value; }
        }



        public override string GetExtraInfo()
        {
            string strOut = base.GetExtraInfo();

            strOut += Environment.NewLine + string.Format("{0,-22} {1,15}", "Size of colony:", ColonySize);

            return "Ant" + Environment.NewLine + Environment.NewLine + strOut.Replace(",", "");
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
