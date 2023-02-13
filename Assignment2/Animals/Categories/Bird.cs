namespace Assignment2.Animals.Categories
{
    public abstract class Bird : Animal
    {
        private string species;
        public Bird(string id, string name, int age, Gender gender, int weight, CategoryType category, string species) : base(id, name, age, gender, weight, category)
        {
            this.species = species;
        }

        public string Species
        {
            get { return species; }
            set { species = value; }
        }

        public override string GetExtraInfo()
        {
            string strOut = base.GetExtraInfo();

            strOut += Environment.NewLine + string.Format("{0,-28}, {1, -17}\n", "Species:", Species).Replace(",", "") + Environment.NewLine;

            return strOut;
        }
    }
}
