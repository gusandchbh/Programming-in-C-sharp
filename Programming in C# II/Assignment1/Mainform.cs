using System.Windows.Forms;
using Assignment1.MainCategory;
using Assignment1.Mammals;
using Assignment1.Fishes;

namespace Assignment1
{
    public partial class Mainform : Form
    {
        private Animal animal; // Declare animal
        public Mainform()
        {
            InitializeComponent();
            InitializeGui(); // Initialize GUI with default values
        }

        private void InitializeGui()
        {        
            this.Text = "Apu Animal Park";
            this.labelAge.Text = "Age";
            this.labelName.Text = "Name";
            this.labelGenderType.Text = "GenderType";
            this.buttonAdd.Text = "Add";
            this.listBoxCategoryType.Items.Add("Mammal");
            this.listBoxCategoryType.Items.Add("Fish");
            this.labelWeight.Text = "Weight (kg)";
            this.labelAnimalGender.Text = "Gender";
            this.labelAnimalAge.Text = "Age";
            this.groupBox1.Text = "Animal information";
            this.labelAnimalWeight.Text = "Weight (kg)";
            this.labelAnimalName.Text = "Name";
            this.labelID.Text = "ID";
            this.buttonAdd.Visible = false;
            foreach (var gender in Enum.GetValues(typeof(Gender))) // Add MALE, FEMALE and UNKNOWN from gender enum
            {
                this.listBoxGenderType.Items.Add(gender);
            }
            this.listBoxGenderType.Items.RemoveAt(2); // Remove UNKNOWN
            this.labelSpecifications.Visible = false; // make gui element invisible
            this.labelSpecific1.Visible = false; // make gui element invisible
            this.labelSpecific2.Visible = false; // make gui element invisible
            this.textBoxSpecific1.Visible = false; // make gui element invisible
            this.textBoxSpecific2.Visible = false; // make gui element invisible
            groupBox1.Visible = false; // make gui element invisible
            this.groupBoxAnimalSpecifications.Text = "Animal Specifications";

        }

        private void listBoxCategoryType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.listBoxAnimalObject.Items.Clear(); // Initially clear the values so that duplicates are not created
            if (this.listBoxCategoryType.SelectedIndex == 0)
            {
                this.listBoxAnimalObject.Items.Add("Dog"); // Add dog and monkey if Mammal is selected
                this.listBoxAnimalObject.Items.Add("Monkey");
            } else if (this.listBoxCategoryType.SelectedIndex == 1)
            {
                this.listBoxAnimalObject.Items.Add("Whale"); // Add whale and shark if Fish is selected
                this.listBoxAnimalObject.Items.Add("Shark");
            }
        }
        
        /// <summary>
        /// Retrieves a string representation of the animal that has been selected through the listboxes
        /// </summary>
        /// <returns></returns>
        private string getAnimal()
        {
            if (this.listBoxCategoryType.SelectedIndex == 0 && this.listBoxAnimalObject.SelectedIndex == 0)
            {
                return "DOG"; 
            }
            else if (this.listBoxCategoryType.SelectedIndex == 0 && this.listBoxAnimalObject.SelectedIndex == 1)
            {
                return "MONKEY";
            }
            else if (this.listBoxCategoryType.SelectedIndex == 1 && this.listBoxAnimalObject.SelectedIndex == 0)
            {
                return "WHALE";
            }
            else if (this.listBoxCategoryType.SelectedIndex == 1 && this.listBoxAnimalObject.SelectedIndex == 1)
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
            this.buttonAdd.Visible = true;
            if (getAnimal().Equals("DOG"))
            {
                this.labelSpecifications.Text = "Mammal Specifications";
                this.labelSpecific2.Text = "Expected lifespan";
                this.labelSpecific1.Text = "Dog breed";
            } else if (getAnimal().Equals("MONKEY"))
            {
                this.labelSpecifications.Text = "Mammal Specifications";
                this.labelSpecific2.Text = "Expected lifespan";
                this.labelSpecific1.Text = "Favorite fruit"; 
            } else if (getAnimal().Equals("WHALE"))
            {
                this.labelSpecifications.Text = "Fish Specifications";
                this.labelSpecific2.Text = "Swim speed (km/h)";
                this.labelSpecific1.Text = "Number of blowholes";
            } else if (getAnimal().Equals("SHARK"))
            {
                this.labelSpecifications.Text = "Fish Specifications";
                this.labelSpecific2.Text = "Swim speed (km/h)";
                this.labelSpecific1.Text = "Number of teeth";
            }

            this.labelSpecifications.Visible = true;
            this.labelSpecific1.Visible = true;
            this.labelSpecific2.Visible = true;
            this.textBoxSpecific1.Visible = true;
            this.textBoxSpecific2.Visible = true;
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
            if (this.textBoxAge.Text.Length == 0 || this.textBoxName.Text.Length == 0 || this.textBoxWeight.Text.Length == 0 || this.textBoxSpecific1.Text.Length == 0 || this.textBoxSpecific2.Text.Length == 0)
            {
                MessageBox.Show("Fill in all input boxes!");
                return false;
            } else if (!onlyDigits(this.textBoxAge.Text) || !onlyDigits(this.textBoxWeight.Text)) {
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
                    animal = new Dog("0000", this.textBoxName.Text, int.Parse(this.textBoxAge.Text), determineGender(), int.Parse(this.textBoxWeight.Text), int.Parse(this.textBoxSpecific2.Text), this.textBoxSpecific1.Text);
                    Dog dog = (Dog)animal;
                    this.labelAnimalSpecific1Output.Text = dog.Breed;
                    this.labelAnimalSpecific2Output.Text = dog.ExpectedLifeSpan.ToString();
                    this.labelAnimalSpecific1.Text = "Breed";
                    this.labelAnimalSpecific2.Text = "Expected lifespan";
                    break;
                case "MONKEY":
                    if (!onlyDigits(this.textBoxSpecific2.Text))
                    {
                        MessageBox.Show("Expected lifespan has to be a number!");
                        return;
                    }
                    animal = new Monkey("0000", this.textBoxName.Text, int.Parse(this.textBoxAge.Text), determineGender(), int.Parse(this.textBoxWeight.Text), int.Parse(this.textBoxSpecific2.Text), this.textBoxSpecific1.Text);
                    Monkey monkey = (Monkey)animal;
                    this.labelAnimalSpecific1Output.Text = monkey.FavoriteFruit;
                    this.labelAnimalSpecific2Output.Text = monkey.ExpectedLifeSpan.ToString();
                    this.labelAnimalSpecific1.Text = "Favorite fruit";
                    this.labelAnimalSpecific2.Text = "Expected lifespan";
                    break;
                case "WHALE":
                    if (!onlyDigits(this.textBoxSpecific1.Text))
                    {
                        MessageBox.Show("Blowholes has to be a number!");
                        return;
                    }
                    if (!onlyDigits(this.textBoxSpecific2.Text))
                    {
                        MessageBox.Show("Swim speed has to be a number!");
                        return;
                    }
                    animal = new Whale("0000", this.textBoxName.Text, int.Parse(this.textBoxAge.Text), determineGender(), int.Parse(this.textBoxWeight.Text), int.Parse(this.textBoxSpecific2.Text), int.Parse(this.textBoxSpecific1.Text));
                    Whale whale = (Whale)animal;
                    this.labelAnimalSpecific1Output.Text = whale.Blowholes.ToString();
                    this.labelAnimalSpecific2Output.Text = whale.SwimSpeed.ToString();
                    this.labelAnimalSpecific1.Text = "Blowholes";
                    this.labelAnimalSpecific2.Text = "Swim speed (km/h)";
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
                    animal = new Shark("0000", this.textBoxName.Text, int.Parse(this.textBoxAge.Text), determineGender(), int.Parse(this.textBoxWeight.Text), int.Parse(this.textBoxSpecific2.Text), int.Parse(this.textBoxSpecific1.Text));
                    Shark shark = (Shark)animal;
                    this.labelAnimalSpecific1Output.Text = shark.Teeth.ToString();
                    this.labelAnimalSpecific2Output.Text = shark.SwimSpeed.ToString();
                    this.labelAnimalSpecific1.Text = "Teeth";
                    this.labelAnimalSpecific2.Text = "Swim speed (km/h)";
                    break;
            }
            this.labelIDOutput.Text = animal.Id;
            this.labelAnimalAgeOutput.Text = animal.Age.ToString();
            this.labelAnimalGenderOutput.Text = animal.Gender.ToString();
            this.labelAnimalNameOutput.Text = animal.Name;
            this.labelAnimalWeightOutput.Text = animal.Weight.ToString();
            groupBox1.Visible = true;
        }

     
    }
    }