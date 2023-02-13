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
    internal class Spider : Insect // Carnivore
    {
        private int webSize;
        private FoodSchedule foodSchedule;
        public Spider(string id, string name, int age, Gender gender, int weight, int numberOfLegs, int webSize, CategoryType category) : base(id, name, age, gender, weight, category, numberOfLegs)
        {
            this.webSize = webSize;
            SetFoodSchedule();
        }

        public int WebSize
        {
            get { return webSize; }
            set { webSize = value; }
        }

        public override string GetExtraInfo()
        {
            string strOut = base.GetExtraInfo();

            strOut += Environment.NewLine + string.Format("{0,-22} {1,15}", "Size of web:", WebSize);

            return "Spider" + Environment.NewLine + Environment.NewLine + strOut.Replace(",", "");
        }

        public override FoodSchedule getFoodSchedule()
        {
            return foodSchedule;
        }

        public void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = EaterType.Carnivore;
            foodSchedule.Add("Morning: 10-15 ants");
            foodSchedule.Add("Lunch: 1-2 worms");
            foodSchedule.Add("Evening: 1 small bird");

        }
    }
}
