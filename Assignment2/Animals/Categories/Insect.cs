namespace Assignment2.Animals.Categories
{
    public abstract class Insect : Animal
    {
        private int numberOfLegs;
        protected Insect(string id, string name, int age, Gender gender, int weight, CategoryType category, int numberOfLegs) : base(id, name, age, gender, weight, category)
        {
            this.numberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs
        {
            get { return numberOfLegs; }
            set { numberOfLegs = value; }
        }

        public override string GetExtraInfo()
        {
            string strOut = base.GetExtraInfo();

            strOut += Environment.NewLine + string.Format("{0,-28}, {1, -17}\n", "Number of legs:", NumberOfLegs).Replace(",", "") + Environment.NewLine;

            return strOut;
        }
    }
}
