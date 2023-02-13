using System.Windows.Forms;
using Assignment2.Animals;
using Assignment2.Animals.Categories;
using Assignment2.Mammals;
using Assignment2.Fishes;
using Assignment2.Manager;

namespace Assignment2
{
    public partial class Mainform : Form
    {
        private Animal animal; // Declare animal
        private AnimalManager animalManager = new AnimalManager(new List<Animal>(), 1);
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
            labelWeight.Text = "Weight (kg)";
            labelAnimalGender.Text = "Gender";
            labelAnimalAge.Text = "Age";
            labelAnimalName.Text = "Name";
            labelID.Text = "ID";
            labelList.Text = "List of registered animals";
            buttonAdd.Visible = false;
            foreach (var gender in Enum.GetValues(typeof(Gender))) // Add MALE, FEMALE and UNKNOWN from gender enum
            {
                listBoxGenderType.Items.Add(gender);
            }
            listBoxGenderType.Items.RemoveAt(2); // Remove UNKNOWN
            labelSpecifications.Visible = false; // make gui element invisible
            labelSpecific1.Visible = false; // make gui element invisible
            labelSpecific2.Visible = false; // make gui element invisible
            textBoxSpecific1.Visible = false; // make gui element invisible
            textBoxSpecific2.Visible = false; // make gui element invisible
            groupBoxAnimalSpecifications.Text = "Animal Specifications";

        }

        private void listBoxCategoryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxAnimalObject.Items.Clear(); // Initially clear the values so that duplicates are not created
            if (listBoxCategoryType.SelectedIndex == 0)
            {
                listBoxAnimalObject.Items.Add("Dog"); // Add dog and monkey if Mammal is selected
                listBoxAnimalObject.Items.Add("Monkey");
            } else if (this.listBoxCategoryType.SelectedIndex == 1)
            {
                listBoxAnimalObject.Items.Add("Whale"); // Add whale and shark if Fish is selected
                listBoxAnimalObject.Items.Add("Shark");
            }
        }
        
        /// <summary>
        /// Retrieves a string representation of the animal that has been selected through the listboxes
        /// </summary>
        /// <returns></returns>
        private string getAnimal()
        {
            if (listBoxCategoryType.SelectedIndex == 0 && listBoxAnimalObject.SelectedIndex == 0)
            {
                return "DOG"; 
            }
            else if (listBoxCategoryType.SelectedIndex == 0 && listBoxAnimalObject.SelectedIndex == 1)
            {
                return "MONKEY";
            }
            else if (listBoxCategoryType.SelectedIndex == 1 && listBoxAnimalObject.SelectedIndex == 0)
            {
                return "WHALE";
            }
            else if (listBoxCategoryType.SelectedIndex == 1 && this.listBoxAnimalObject.SelectedIndex == 1)
            {
                return "SHARK";
            }
            return "";
        }

        /// <summary>
        /// Make labels that are specific to the animal appear based on the animal that has been selected
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
            } else if (getAnimal().Equals("MONKEY"))
            {
                labelSpecifications.Text = "Mammal Specifications";
                labelSpecific2.Text = "Expected lifespan";
                labelSpecific1.Text = "Favorite fruit"; 
            } else if (getAnimal().Equals("WHALE"))
            {
                labelSpecifications.Text = "Fish Specifications";
                labelSpecific2.Text = "Swim speed (km/h)";
                labelSpecific1.Text = "Number of blowholes";
            } else if (getAnimal().Equals("SHARK"))
            {
                labelSpecifications.Text = "Fish Specifications";
                labelSpecific2.Text = "Swim speed (km/h)";
                labelSpecific1.Text = "Number of teeth";
            }

            labelSpecifications.Visible = true;
            labelSpecific1.Visible = true;
            labelSpecific2.Visible = true;
            textBoxSpecific1.Visible = true;
            textBoxSpecific2.Visible = true;
        }

        /// <summary>
        /// Return the gender that has been selected in the listbox
        /// </summary>
        /// <returns></returns>

        public Gender determineGender()
        {
            if (this.listBoxGenderType.SelectedIndex == 0)
            {
                return Gender.MALE;
            } else if (this.listBoxGenderType.SelectedIndex == 1)
            {
                return Gender.FEMALE;
            } else
            {
                return Gender.UNKNOWN;
            }
        }


        /// <summary>
        /// Check if the string only contains digits, if so return true, otherwise false
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        bool onlyDigits(string s)
        {
            foreach (char c in s)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        /// <summary>
        /// Check that all input boxes are filled in, and check that Age and Weight only contain digits
        /// </summary>
        /// <returns></returns>

        public bool validInput()
        {
            if (textBoxAge.Text.Length == 0 || textBoxName.Text.Length == 0 || textBoxWeight.Text.Length == 0 || textBoxSpecific1.Text.Length == 0 || textBoxSpecific2.Text.Length == 0)
            {
                MessageBox.Show("Fill in all input boxes!");
                return false;
            } else if (!onlyDigits(this.textBoxAge.Text) || !onlyDigits(textBoxWeight.Text)) {
                MessageBox.Show("Invalid input!");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Check that we are only dealing with valid input so that the program doesn't crash.
        /// Then create the animal with the values provided by the user. Cast the animal to access the values that are specific to that animal
        /// Update labels with the information contained in the animal 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!validInput())
            {
                return;
            }

            switch (getAnimal())
            {
                case "DOG":
                    if (!onlyDigits(this.textBoxSpecific2.Text))
                    {
                        MessageBox.Show("Expected lifespan has to be a number!");
                        return;
                    }
                    animal = new Dog("0000", this.textBoxName.Text, int.Parse(this.textBoxAge.Text), determineGender(), int.Parse(this.textBoxWeight.Text), int.Parse(this.textBoxSpecific2.Text), this.textBoxSpecific1.Text, CategoryType.Mammal);
                    Dog dog = (Dog)animal;
                    break;
                case "MONKEY":
                    if (!onlyDigits(this.textBoxSpecific2.Text))
                    {
                        MessageBox.Show("Expected lifespan has to be a number!");
                        return;
                    }
                    animal = new Monkey(animalManager.GetNewID(CategoryType.Mammal), this.textBoxName.Text, int.Parse(this.textBoxAge.Text), determineGender(), int.Parse(this.textBoxWeight.Text), int.Parse(this.textBoxSpecific2.Text), this.textBoxSpecific1.Text, CategoryType.Mammal);
                    Monkey monkey = (Monkey)animal;
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
                    animal = new Whale("0000", textBoxName.Text, int.Parse(textBoxAge.Text), determineGender(), int.Parse(textBoxWeight.Text), int.Parse(textBoxSpecific2.Text), int.Parse(textBoxSpecific1.Text), CategoryType.Fish);
                    Whale whale = (Whale)animal;
                    break;
                case "SHARK":
                    if (!onlyDigits(this.textBoxSpecific1.Text))
                    {
                        MessageBox.Show("Teeth has to be a number!");
                        return;
                    }
                    if (!onlyDigits(this.textBoxSpecific2.Text))
                    {
                        MessageBox.Show("Swim speed has to be a number!");
                        return;
                    }
                    animal = new Shark(animalManager.GetNewID(CategoryType.Mammal), textBoxName.Text, int.Parse(textBoxAge.Text), determineGender(), int.Parse(textBoxWeight.Text), int.Parse(textBoxSpecific2.Text), int.Parse(textBoxSpecific1.Text), CategoryType.Fish);
                    Shark shark = (Shark)animal;

                    labelEaterTypeOutput.Text = animal.getFoodSchedule().EaterType.ToString();
                    listBox2.DataSource = animal.getFoodSchedule().GetFoodListInfoStrings();
                    break;
            }
            animalManager.Add(animal);
            listBox1.DataSource = animalManager.GetAnimalInfoStrings();
            textBox1.Text = animal.GetExtraInfo();

        }
    }
    }