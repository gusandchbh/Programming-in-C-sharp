using Assignment2.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.Animals.Categories;
using Assignment2.Animals;

namespace Assignment2.Birds
{
    public class Penguin : Bird
    {
        private FoodSchedule foodSchedule;
        private int cuteness;
        public Penguin(string id, string name, int age, Gender gender, int weight, string species, int cuteness, CategoryType category) : base(id, name, age, gender, weight, category, species)
        {
            this.cuteness = cuteness;
            SetFoodSchedule();
        }

        public int Cuteness
        {
            get { return cuteness; }
            set { cuteness = value; }
        }

        public override string GetExtraInfo()
        {
            string strOut = base.GetExtraInfo();

            strOut += Environment.NewLine + string.Format("{0,-22} {1,15}", "Cuteness:", Cuteness);

            return "Penguin" + Environment.NewLine + Environment.NewLine + strOut.Replace(",", "");
        }

        public override FoodSchedule getFoodSchedule()
        {
            return foodSchedule;
        }

        public void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = EaterType.Carnivore;
            foodSchedule.Add("Morning: 1-2 large squids");
            foodSchedule.Add("Lunch: mixed fish");
            foodSchedule.Add("Evening: fish soup");

        }
    }
}
