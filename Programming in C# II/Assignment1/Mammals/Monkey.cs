using Assignment1.MainCategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Mammals
{
    public class Monkey : Mammal
    {
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

        public Monkey(string id, string name, int age, Gender gender, int weight, int expectedLifeSpan, string favoriteFruit) : base(id, name, age, gender, weight, expectedLifeSpan)
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

        public override string ToString()
        {
            return base.ToString() + " Favorite fruit: " + favoriteFruit;
        }
    }
}
