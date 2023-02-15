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
                listBox1.Items.AddRange(foodItem.Ingredients.GetÍnfo());
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            foodItem.Name = textBoxName.Text;
            listBox1.Items.Remove(foodItem);
            foodItem.Ingredients.Add(textBoxIngredient.Text);
            listBox1.Items.Add(textBoxIngredient.Text);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                foodItem.Ingredients.Replace(foodItem.Ingredients.Get(index), textBoxIngredient.Text);
                listBox1.Items.RemoveAt(index);
                listBox1.Items.Add(textBoxIngredient.Text);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (listBox1.SelectedIndex != -1)
            {
                foodItem.Ingredients.DeleteAt(index);
                listBox1.Items.RemoveAt(index);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            foodItem.Name = textBoxName.Text;
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
