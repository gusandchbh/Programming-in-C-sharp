using Assignment2.Animals.Categories;
using Assignment2.Manager;

namespace Assignment2.Animals
{
    public abstract class Animal : IAnimal
    {

        private string id; // Set accessibility to private
        private string name; // Set accessibility to private
        private int age; // Set accessibility to private
        private Gender gender; // Set accessibility to private
        private int weight; // Set accessibility to private
        private CategoryType category;

        /// <summary>
        /// Constructor for Animal
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="gender"></param>
        /// <param name="weight"></param>
        protected Animal(string id, string name, int age, Gender gender, int weight, CategoryType category) 
        {
            this.id = id;
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.weight = weight;
            this.category = category;
        }


        public virtual string GetExtraInfo()
        {
            string strOut = string.Empty;

            strOut = string.Format("{0,-20} {1,15}\n", "Category:", category.ToString()) + Environment.NewLine;

            return strOut;
        }

        /// <summary>
        /// Property for name
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public CategoryType Category
        {
            get { return category; }
            set { category = value; }
        }

        /// <summary>
        /// Property for age
        /// </summary>

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        /// <summary>
        /// Property for gender
        /// </summary>

        public Gender Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        /// <summary>
        /// Property for weight
        /// </summary>

        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        /// <summary>
        /// Property for id
        /// </summary>

        public string ID
        {
            get => id; 
            set { id = value; }
        }

        public override string ToString()
        {

            string strOut = string.Empty;

            strOut = string.Format("{0,-15} {1,-30} {2, -25} {3, -10}\n", ID, Name, Age, Gender);

            return strOut;
        }

        public abstract FoodSchedule getFoodSchedule();

    }
}
