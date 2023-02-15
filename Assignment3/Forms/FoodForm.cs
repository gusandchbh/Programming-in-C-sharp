using Assignment3.Manager;

namespace Assignment3.Forms
{
    public partial class FoodForm : Form
    {
        private FoodItem foodItem;
        public FoodForm(FoodItem foodItem, bool existing)
        {
            InitializeComponent();
            this.foodItem = foodItem;
            UpdateGUI();
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
            textBoxName.Text = foodItem.Name;
            if (foodItem.Ingredients.Count > 0)
            {
                listBox1.Items.Add(foodItem);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            foodItem.Name = textBoxName.Text;
            foodItem.Ingredients.Add(textBoxIngredient.Text);
            listBox1.Items.Add(foodItem);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string ingredient = foodItem.Ingredients.Get(listBox1.SelectedIndex);
                
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (listBox1.SelectedIndex != -1)
            {
                foodItem.Ingredients.DeleteAt(index);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
