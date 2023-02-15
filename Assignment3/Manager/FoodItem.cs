namespace Assignment3.Manager
{
    public class FoodItem
    {
        private ListManager<string> ingredients;
        private string name;

        public FoodItem()
        {
            this.ingredients = new ListManager<string>();
            this.name = "";
        }
        public ListManager<string> Ingredients
        { get { return ingredients; } }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}
