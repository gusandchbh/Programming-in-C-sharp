namespace Assignment3.Manager
{
    public class FoodItem
    {
        private string id;
        private ListManager<string> ingredients;
        private string name;

        public string ID
        {
            get { return id; }
            set { id = value; }
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
