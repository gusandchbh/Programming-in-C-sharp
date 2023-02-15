using Assignment3.Animals;
using Assignment3.Animals.Categories;
using Assignment3.Animals.Categories.Birds;
using Assignment3.Animals.Categories.Fishes;
using Assignment3.Animals.Categories.Insects;
using Assignment3.Animals.Categories.Mammals;
using Assignment3.Manager;

namespace Assignment3.Forms;

public partial class Mainform : Form
{
    private Animal animal; // Declare animal
    private readonly AnimalManager animalManager = new( 0);

    public Mainform()
    {
        InitializeComponent();
        InitializeGui(); // Initialize GUI with default values
    }

    private void InitializeGui()
    {
        Text = "Apu Animal Park";
        labelAge.Text = "Age";
        labelName.Text = "Name";
        labelGenderType.Text = "GenderType";
        buttonAdd.Text = "Add";
        listBoxCategoryType.Items.Add("Mammal");
        listBoxCategoryType.Items.Add("Fish");
        listBoxCategoryType.Items.Add("Insect");
        listBoxCategoryType.Items.Add("Bird");
        labelWeight.Text = "Weight (kg)";
        labelAnimalGender.Text = "Gender";
        labelAnimalAge.Text = "Age";
        labelAnimalName.Text = "Name";
        labelID.Text = "ID";
        labelList.Text = "List of registered animals";
        buttonAdd.Visible = false;
        foreach (var gender in Enum.GetValues(typeof(Gender))) // Add MALE, FEMALE and UNKNOWN from gender enum
            listBoxGenderType.Items.Add(gender);
        listBoxGenderType.Items.RemoveAt(2); // Remove UNKNOWN
        labelSpecifications.Visible = false; // make gui element invisible
        labelSpecific1.Visible = false; // make gui element invisible
        labelSpecific2.Visible = false; // make gui element invisible
        textBoxSpecific1.Visible = false; // make gui element invisible
        textBoxSpecific2.Visible = false; // make gui element invisible
        groupBoxAnimalSpecifications.Text = "Animal Specifications";
        textBox1.ReadOnly = true;
    }

    private void listBoxCategoryType_SelectedIndexChanged(object sender, EventArgs e)
    {
        listBoxAnimalObject.Items.Clear(); // Initially clear the values so that duplicates are not created
        if (listBoxCategoryType.SelectedIndex == 0)
        {
            listBoxAnimalObject.Items.Add("Dog"); // Add dog and monkey if Mammal is selected
            listBoxAnimalObject.Items.Add("Monkey");
        }
        else if (listBoxCategoryType.SelectedIndex == 1)
        {
            listBoxAnimalObject.Items.Add("Whale"); // Add whale and shark if Fish is selected
            listBoxAnimalObject.Items.Add("Shark");
        }
        else if (listBoxCategoryType.SelectedIndex == 2)
        {
            listBoxAnimalObject.Items.Add("Spider");
            listBoxAnimalObject.Items.Add("Ant");
        }
        else if (listBoxCategoryType.SelectedIndex == 3)
        {
            listBoxAnimalObject.Items.Add("Penguin");
            listBoxAnimalObject.Items.Add("Parrot");
        }
    }

    /// <summary>
    ///     Retrieves a string representation of the animal that has been selected through the listboxes
    /// </summary>
    /// <returns></returns>
    private string getAnimal()
    {
        if (listBoxCategoryType.SelectedIndex == 0 && listBoxAnimalObject.SelectedIndex == 0)
            return "DOG";
        if (listBoxCategoryType.SelectedIndex == 0 && listBoxAnimalObject.SelectedIndex == 1)
            return "MONKEY";
        if (listBoxCategoryType.SelectedIndex == 1 && listBoxAnimalObject.SelectedIndex == 0)
            return "WHALE";
        if (listBoxCategoryType.SelectedIndex == 1 && listBoxAnimalObject.SelectedIndex == 1)
            return "SHARK";
        if (listBoxCategoryType.SelectedIndex == 2 && listBoxAnimalObject.SelectedIndex == 0)
            return "SPIDER";
        if (listBoxCategoryType.SelectedIndex == 2 && listBoxAnimalObject.SelectedIndex == 1)
            return "ANT";
        if (listBoxCategoryType.SelectedIndex == 3 && listBoxAnimalObject.SelectedIndex == 0)
            return "PENGUIN";
        if (listBoxCategoryType.SelectedIndex == 3 && listBoxAnimalObject.SelectedIndex == 1) return "PARROT";
        return "";
    }

    /// <summary>
    ///     Make labels that are specific to the animal appear based on the animal that has been selected
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void listBoxAnimalObject_SelectedIndexChanged(object sender, EventArgs e)
    {
        buttonAdd.Visible = true;
        if (getAnimal().Equals("DOG"))
        {
            labelSpecifications.Text = "Mammal Specifications";
            labelSpecific2.Text = "Expected lifespan";
            labelSpecific1.Text = "Dog breed";
        }
        else if (getAnimal().Equals("MONKEY"))
        {
            labelSpecifications.Text = "Mammal Specifications";
            labelSpecific2.Text = "Expected lifespan";
            labelSpecific1.Text = "Favorite fruit";
        }
        else if (getAnimal().Equals("WHALE"))
        {
            labelSpecifications.Text = "Fish Specifications";
            labelSpecific2.Text = "Swim speed (km/h)";
            labelSpecific1.Text = "Number of blowholes";
        }
        else if (getAnimal().Equals("SHARK"))
        {
            labelSpecifications.Text = "Fish Specifications";
            labelSpecific2.Text = "Swim speed (km/h)";
            labelSpecific1.Text = "Number of teeth";
        }
        else if (getAnimal().Equals("SPIDER"))
        {
            labelSpecifications.Text = "Insect Specifications";
            labelSpecific2.Text = "Number of legs";
            labelSpecific1.Text = "Size of web";
        }
        else if (getAnimal().Equals("ANT"))
        {
            labelSpecifications.Text = "Insect Specifications";
            labelSpecific2.Text = "Number of legs";
            labelSpecific1.Text = "Size of colony";
        }
        else if (getAnimal().Equals("PENGUIN"))
        {
            labelSpecifications.Text = "Bird Specifications";
            labelSpecific2.Text = "Species";
            labelSpecific1.Text = "Cuteness";
        }
        else if (getAnimal().Equals("PARROT"))
        {
            labelSpecifications.Text = "Bird Specifications";
            labelSpecific2.Text = "Species";
            labelSpecific1.Text = "Favorite word";
        }

        labelSpecifications.Visible = true;
        labelSpecific1.Visible = true;
        labelSpecific2.Visible = true;
        textBoxSpecific1.Visible = true;
        textBoxSpecific2.Visible = true;
    }

    /// <summary>
    ///     Return the gender that has been selected in the listbox
    /// </summary>
    /// <returns></returns>
    public Gender determineGender()
    {
        if (listBoxGenderType.SelectedIndex == 0)
            return Gender.MALE;
        if (listBoxGenderType.SelectedIndex == 1)
            return Gender.FEMALE;
        return Gender.UNKNOWN;
    }


    /// <summary>
    ///     Check if the string only contains digits, if so return true, otherwise false
    /// </summary>
    /// <param name="s"></param>
    /// <returns></returns>
    private bool onlyDigits(string s)
    {
        foreach (var c in s)
            if (c < '0' || c > '9')
                return false;

        return true;
    }

    /// <summary>
    ///     Check that all input boxes are filled in, and check that Age and Weight only contain digits
    /// </summary>
    /// <returns></returns>
    public bool validInput()
    {
        if (textBoxAge.Text.Length == 0 || textBoxName.Text.Length == 0 || textBoxWeight.Text.Length == 0 ||
            textBoxSpecific1.Text.Length == 0 || textBoxSpecific2.Text.Length == 0)
        {
            MessageBox.Show("Fill in all input boxes!");
            return false;
        }

        if (!onlyDigits(textBoxAge.Text) || !onlyDigits(textBoxWeight.Text))
        {
            MessageBox.Show("Invalid input!");
            return false;
        }

        return true;
    }

    /// <summary>
    ///     Check that we are only dealing with valid input so that the program doesn't crash.
    ///     Then create the animal with the values provided by the user. Cast the animal to access the values that are specific
    ///     to that animal
    ///     Update labels with the information contained in the animal
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonAdd_Click(object sender, EventArgs e)
    {
        if (!validInput()) return;

        switch (getAnimal())
        {
            case "DOG":
                if (!onlyDigits(textBoxSpecific2.Text))
                {
                    MessageBox.Show("Expected lifespan has to be a number!");
                    return;
                }

                animal = new Dog("0", textBoxName.Text,
                    int.Parse(textBoxAge.Text), determineGender(), int.Parse(textBoxWeight.Text),
                    int.Parse(textBoxSpecific2.Text), textBoxSpecific1.Text, CategoryType.Mammal);
                break;
            case "MONKEY":
                if (!onlyDigits(textBoxSpecific2.Text))
                {
                    MessageBox.Show("Expected lifespan has to be a number!");
                    return;
                }

                animal = new Monkey("0", textBoxName.Text,
                    int.Parse(textBoxAge.Text), determineGender(), int.Parse(textBoxWeight.Text),
                    int.Parse(textBoxSpecific2.Text), textBoxSpecific1.Text, CategoryType.Mammal);
                break;
            case "WHALE":
                if (!onlyDigits(textBoxSpecific1.Text))
                {
                    MessageBox.Show("Blowholes has to be a number!");
                    return;
                }

                if (!onlyDigits(textBoxSpecific2.Text))
                {
                    MessageBox.Show("Swim speed has to be a number!");
                    return;
                }

                animal = new Whale("0", textBoxName.Text,
                    int.Parse(textBoxAge.Text), determineGender(), int.Parse(textBoxWeight.Text),
                    int.Parse(textBoxSpecific2.Text), int.Parse(textBoxSpecific1.Text), CategoryType.Fish);
                break;
            case "SHARK":
                if (!onlyDigits(textBoxSpecific1.Text))
                {
                    MessageBox.Show("Teeth has to be a number!");
                    return;
                }

                if (!onlyDigits(textBoxSpecific2.Text))
                {
                    MessageBox.Show("Swim speed has to be a number!");
                    return;
                }

                animal = new Shark("0", textBoxName.Text,
                    int.Parse(textBoxAge.Text), determineGender(), int.Parse(textBoxWeight.Text),
                    int.Parse(textBoxSpecific2.Text), int.Parse(textBoxSpecific1.Text), CategoryType.Fish);
                break;
            case "SPIDER":
                if (!onlyDigits(textBoxSpecific1.Text))
                {
                    MessageBox.Show("Number of legs has to be a number!");
                    return;
                }

                if (!onlyDigits(textBoxSpecific2.Text))
                {
                    MessageBox.Show("Web size has to be a number!");
                    return;
                }

                animal = new Spider("0", textBoxName.Text,
                    int.Parse(textBoxAge.Text), determineGender(), int.Parse(textBoxWeight.Text),
                    int.Parse(textBoxSpecific2.Text), int.Parse(textBoxSpecific1.Text), CategoryType.Insect);
                break;
            case "ANT":
                if (!onlyDigits(textBoxSpecific2.Text))
                {
                    MessageBox.Show("Number of legs has to be a number!");
                    return;
                }

                if (!onlyDigits(textBoxSpecific1.Text))
                {
                    MessageBox.Show("Colony size has to be a number!");
                    return;
                }

                animal = new Spider("0", textBoxName.Text,
                    int.Parse(textBoxAge.Text), determineGender(), int.Parse(textBoxWeight.Text),
                    int.Parse(textBoxSpecific2.Text), int.Parse(textBoxSpecific1.Text), CategoryType.Insect);
                break;
            case "PENGUIN":
                if (!onlyDigits(textBoxSpecific1.Text))
                {
                    MessageBox.Show("Cuteness has to be a number!");
                    return;
                }

                animal = new Penguin("0", textBoxName.Text,
                    int.Parse(textBoxAge.Text), determineGender(), int.Parse(textBoxWeight.Text), textBoxSpecific2.Text,
                    int.Parse(textBoxSpecific1.Text), CategoryType.Bird);
                break;
            case "PARROT":
                animal = new Parrot("0", textBoxName.Text,
                    int.Parse(textBoxAge.Text), determineGender(), int.Parse(textBoxWeight.Text), textBoxSpecific2.Text,
                    textBoxSpecific1.Text, CategoryType.Bird);
                break;
        }

        AddAnimal(animal);
        labelEaterTypeOutput.Text = animal.getFoodSchedule().EaterType.ToString();
        listBox2.DataSource = animal.getFoodSchedule().GetFoodListInfoStrings();
        listBox1.DataSource = animalManager.GetÍnfo();
        textBox1.Text = animal.GetExtraInfo();
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        var index = listBox1.SelectedIndex;
        animal = animalManager.Get(index);
        labelEaterTypeOutput.Text = animal.getFoodSchedule().EaterType.ToString();
        listBox2.DataSource = animal.getFoodSchedule().GetFoodListInfoStrings();
        textBox1.Text = animal.GetExtraInfo();
    }

    public bool AddAnimal(Animal animal)
    {
        bool ok = false;

        if (animal != null)
        {
            animal.ID = animalManager.GetNewId().ToString();
            animalManager.Add(animal);
            ok = true;
        }

        return ok;
    }

    private void buttonFoodItems_Click(object sender, EventArgs e)
    {
        FoodForm foodForm = new FoodForm();
        if (foodForm.ShowDialog() == DialogResult.OK)
        {
            textBox2.Text = foodForm.FoodItem.ToString();
        }
    }
}