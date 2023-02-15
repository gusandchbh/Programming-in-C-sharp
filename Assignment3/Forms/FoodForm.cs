using Assignment3.Manager;

namespace Assignment3.Forms
{
    public partial class FoodForm : Form
    {
        private FoodItem foodItem;
        public FoodForm()
        {
            InitializeComponent();
        }

        public FoodItem FoodItem
        {
            get { return foodItem; }
            set { foodItem = value; }
        }

        bool CheckInput()
        {
            return false;
        }

        void UpdateGUI()
        {

        }
    }
}
