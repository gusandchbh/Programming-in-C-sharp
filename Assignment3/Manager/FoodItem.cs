namespace Assignment3.Manager
{
    public class FoodItem
    {
        private ListManager<string> ingredients;
        private string name;


        /// <summary>
        /// Constructor for FoodItem, takes no arguments
        /// </summary>
        public FoodItem()
        {
            this.ingredients = new ListManager<string>();
            this.name = "";
        }

        /// <summary>
        /// Property with only get for ingredients
        /// </summary>
        public ListManager<string> Ingredients
        { get { return ingredients; } }


        /// <summary>
        /// Property for name
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        /// <summary>
        /// ToString representation of the FoodItem
        /// First add the name and then concatenate the strings in the getInfo array with an empty space between them
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strOut = "";
            strOut += Name;
            strOut += "   ";
            strOut += String.Join(" ",ingredients.GetÍnfo());
            return strOut;
        }
    }
}
