using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.Animals;
using Assignment2.Animals.Categories;
using Assignment2.Manager;

namespace Assignment2.Birds
{
    public class Parrot : Bird
    {
        private string favoriteWord;
        private FoodSchedule foodSchedule;

        public Parrot(string id, string name, int age, Gender gender, int weight, string species,
            string favoriteWord, CategoryType category) : base(id, name, age, gender, weight, category, species)
        {
            this.favoriteWord = favoriteWord;
            SetFoodSchedule();
        }

        public string FavoriteWord
        {
            get { return favoriteWord; }
            set { favoriteWord = value; }
        }

        public override string GetExtraInfo()
        {
            string strOut = base.GetExtraInfo();

            strOut += Environment.NewLine + string.Format("{0,-22} {1,15}", "Favorite word:", FavoriteWord);

            return "Parrot" + Environment.NewLine + Environment.NewLine + strOut.Replace(",", "");
        }

        public override FoodSchedule getFoodSchedule()
        {
            return foodSchedule;
        }

        public void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = EaterType.Omnivorous;
            foodSchedule.Add("Morning: nuts and fruits");
            foodSchedule.Add("Lunch: 5 spiders");
            foodSchedule.Add("Evening: bowl of seeds");

        }
    }
}
