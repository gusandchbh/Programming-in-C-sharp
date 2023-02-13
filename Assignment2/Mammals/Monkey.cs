using Assignment2.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.Animals;
using Assignment2.Animals.Categories;

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
        }


        /// <summary>
        /// Property for breed
        /// </summary>
        public string FavoriteFruit
        {
            get { return favoriteFruit; }
            set { favoriteFruit = value; }
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
        public override string ToString()
        {
            return base.ToString() + " Favorite fruit: " + favoriteFruit;
        }
    }
}
