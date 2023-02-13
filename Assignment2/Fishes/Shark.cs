using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Assignment2.Animals;
using Assignment2.Animals.Categories;
using Assignment2.Manager;

namespace Assignment2.Fishes
{
    public class Shark : Fish // Inherit from Fish
    {
        private FoodSchedule foodSchedule;
        private int teeth; // Set accessibility to private

        public Shark(string id, string name, int age, Gender gender, int weight, int swimSpeed, int teeth, CategoryType category) 
            : base(id, name, age, gender, weight, teeth, category) // // call constructor of superclass
        {
            this.teeth = teeth;
            SetFoodSchedule();
        }

        public int Teeth //Property for teeth
        {
            get { return teeth; }
            set { teeth = value; }
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override string GetExtraInfo()
        {
            string strOut = base.GetExtraInfo();

            strOut += Environment.NewLine + string.Format("{0,-22} {1,15}", "Teeth:", teeth.ToString());

            return strOut;
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
