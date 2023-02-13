using Assignment2.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.Animals;
using Assignment2.Animals.Categories;
using System.Drawing.Drawing2D;

namespace Assignment2.Mammals
{
    public class Monkey : Mammal
    {
        private FoodSchedule foodSchedule;
        private string favoriteFruit; // Set accessibility to private
        
        
        /// <summary>
        /// Constructor for monkey, also calls constructor in superclass
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="weight"></param>
        /// <param name="expectedLifeSpan"></param>
        /// <param name="favoriteFruit"></param>

        public Monkey(string id, string name, int age, Gender gender, int weight, int expectedLifeSpan, string favoriteFruit, CategoryType category) : base(id, name, age, gender, weight, expectedLifeSpan, category)
        {
            this.favoriteFruit = favoriteFruit;
            SetFoodSchedule();
        }


        /// <summary>
        /// Property for breed
        /// </summary>
        public string FavoriteFruit
        {
            get { return favoriteFruit; }
            set { favoriteFruit = value; }
        }

        public override string GetExtraInfo()
        {
            string strOut = base.GetExtraInfo();

            strOut += Environment.NewLine + string.Format("{0,-22} {1,15}", "Favorite fruit:", FavoriteFruit);

            return "Monkey" + Environment.NewLine + Environment.NewLine + strOut.Replace(",", ""); ;
        }


        public override FoodSchedule getFoodSchedule()
        {
            return foodSchedule;
        }

        public void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = EaterType.Omnivorous;
            foodSchedule.Add("Morning: 10 bananas");
            foodSchedule.Add("Lunch: nuts and berries");
            foodSchedule.Add("Evening: leaves and insect sallad");
        }
    }
}
