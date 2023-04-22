using Assignment3.Animals;
using Assignment3.Animals.Categories;
using Assignment3.Animals.Categories.Birds;
using Assignment3.Animals.Categories.Fishes;
using Assignment3.Animals.Categories.Insects;
using Assignment3.Animals.Categories.Mammals;
using Assignment3.Manager;
using Assignment3.Utilities;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Assignment3.Forms;

public partial class Mainform : Form
{
    private FoodItem foodItem;
    private Animal animal; // Declare animal
    private string currentFilePath = string.Empty; // Used for the save option in the menu
    private readonly AnimalManager animalManager = new( 0);

    public Mainform()
    {
        InitializeComponent();
        InitializeGui(); // Initialize GUI with default values
    }

    private void InitializeGui()
    {
        ClearTextBoxes();
        ClearListBoxes();
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

    /// <summary>
    /// This method was taken from here: https://stackoverflow.com/questions/4811229/how-to-clear-the-text-of-all-textboxes-in-the-form
    /// It loops through all textboxes and clears them
    /// </summary>
    private void ClearTextBoxes()
    {
        Action<Control.ControlCollection> func = null;

        func = (controls) =>
        {
            foreach (Control control in controls)
                if (control is TextBox)
                    (control as TextBox).Clear();
                else
                    func(control.Controls);
        };

        func(Controls);
    }

    // Clearing in the case the user uses the New menu feature
    private void ClearListBoxes()
    {
        listBoxGenderType.Items.Clear(); 
        listBoxCategoryType.Items.Clear(); 
        listBox1.DataSource = null;
        listBox1.Items.Clear(); 
        listBox3.Items.Clear(); 
        listBox2.DataSource = null; 
        listBox2.Items.Clear();
        animalManager.deleteAll(); // clearing the datasource
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

    /// <summary>
    /// This method displays the appropriate information based on the animal that has been selected by the user
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        var index = listBox1.SelectedIndex;
        if (index != -1)
        {
            animal = animalManager.Get(index);
            labelEaterTypeOutput.Text = animal.getFoodSchedule().EaterType.ToString();
            listBox2.DataSource = animal.getFoodSchedule().GetFoodListInfoStrings();
            textBox1.Text = animal.GetExtraInfo();
        }
    }

    /// <summary>
    /// This method checks if the animal provided as argument is null, if not it sets the ID and adds it to the list and then returns true to indicate success
    /// </summary>
    /// <param name="animal"></param>
    /// <returns></returns>
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

    /// <summary>
    /// If a fooditem is selected we pass that to the foodform, if no fooditem is selected we pass a new empty fooditem to the foodform
    /// If it was selected and then updated in the form the old one is removed and the new one added, otherwise it is just added
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    private void buttonFoodItems_Click(object sender, EventArgs e)
    {
        int index = listBox3.SelectedIndex;
        FoodForm foodForm;
        bool existing = false;
        if (index == -1)
        {
            foodForm = new FoodForm(new FoodItem(), existing);
        }
        else
        {
            existing = true;
            foodItem = (FoodItem)listBox3.SelectedItem;
            foodForm = new FoodForm(foodItem, existing);
        }
        if (foodForm.ShowDialog() == DialogResult.OK)
        {
            if (existing)
            {
                listBox3.Items.RemoveAt(index);
                listBox3.Items.Insert(index, foodForm.FoodItem);
            }
            else
            {
                listBox3.Items.Add(foodForm.FoodItem);
            }
        }

    }

    /// <summary>
    /// Removes the fooditem selected by the user
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonDeleteFoodItem_Click(object sender, EventArgs e)
    {
 
        int index = listBox3.SelectedIndex;
        if (index == -1)
        {
            MessageBox.Show("No food item selected!");
            return;
        }
        listBox3.Items.RemoveAt(index);
    }

    /// <summary>
    /// The animal is deleted and then the listbox datasource is assigned again to reflect the change
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    private void buttonDeleteAnimal_Click(object sender, EventArgs e)
    {
        int index = listBox1.SelectedIndex;
        if (index < 0)
        {
            MessageBox.Show("You need to select an animal to delete!");
            return;
        }
        animalManager.DeleteAt(index);
        listBox1.DataSource = animalManager.GetÍnfo();
    }
    /// <summary>
    ///  If there are no animals in the list we just reset the gui, otherwise ask the user if he/she is sure, 
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void mnuFileNew_Click(object sender, EventArgs e)
    {
        if (animalManager.Count == 0)
        {
            InitializeGui();
        } else
        {
            var result = MessageBox.Show("Proceed without saving data?", "Yes", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                InitializeGui();
            }
        }
    }

    /// <summary>
    /// This method handles opening a json file
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void mnuFileOpenJson_Click(object sender, EventArgs e)
    {
        string testFolderPath = Path.Combine(Application.StartupPath, "tests"); // For easy access to the test files
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.InitialDirectory = testFolderPath;


        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string fileName = openFileDialog.FileName;
            if (!fileName.EndsWith(".json")) // if it's not a json file
            {
                MessageBox.Show("Wrong file format!");
            }
            else
            {
                try
                {
                    animalManager.JsonDeserialize(fileName); // try to deseralize the file
                    listBox1.DataSource = animalManager.GetÍnfo(); // Update the listbox
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            currentFilePath = openFileDialog.FileName; //Save the currentFilePath for use in the "Save" menu option
        }
    }
     

    private void mnuFileSave_Click(object sender, EventArgs e)
    {
        saveCurrent(currentFilePath); // If save is pressed in the menu we call this method
    }

    private void mnuFileSaveAsBinary_Click(object sender, EventArgs e)
    {
        if (animalManager.Count == 0)
        {
            MessageBox.Show("You need to add animals to the list first to be able to save!"); // No point in saving an empty list
            return;
        }
        string testsFolderPath = Path.Combine(Application.StartupPath, "tests");
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.InitialDirectory = testsFolderPath;
        saveFileDialog.DefaultExt = "bin";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filename = saveFileDialog.FileName;
            if (filename.EndsWith(".bin"))
            {
                try
                {
                    animalManager.BinarySerialize(filename); 
                    MessageBox.Show("List has been saved to binary file!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Wrong file format! Needs to be .bin");
            }
        }
    }



    private void mnuFileOpenBinary_Click(object sender, EventArgs e)
    {
        string testFolderPath = Path.Combine(Application.StartupPath, "tests");
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.InitialDirectory = testFolderPath;
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string fileName = openFileDialog.FileName;
            if (!fileName.EndsWith(".bin"))
            {
                MessageBox.Show("Wrong file format!");
            }
            else
            {
                try
                {
                    animalManager.BinaryDeserialize(fileName); // try to deseralize the binary file
                    listBox1.DataSource = animalManager.GetÍnfo(); //Update datasource for the list so that it renders correctly in the gui
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message); // Show error message
                }
            }
        }
        currentFilePath = openFileDialog.FileName;

    }
    /// <summary>
    /// This method handles the save option in the menu. The program keeps track of if a file has been opened and stores the path and it is used here
    /// so that the user doesn't have to provide the path and the right serialization method is called. 
    /// </summary>
    /// <param name="filepath"></param>
    private void saveCurrent(string filepath)
    {
        if (animalManager.Count == 0)
        {
            MessageBox.Show("You need to add animals to the list first to be able to save!");
            return;
        }
            if (filepath.EndsWith(".txt"))
            {
            List<string> list = animalManager.GetÍnfo().ToList();
            try
                {
                    BinSeralizerUtility.BinaryFileSerialize(filepath, list);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("List has been saved to text file!");
            }
            else if (filepath.EndsWith(".bin"))
        {
            List<string> list = animalManager.GetÍnfo().ToList();
            try
            {
                BinSeralizerUtility.BinaryFileSerialize(filepath, list);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("List has been saved to binary file!");
        } else if (filepath.EndsWith(".json"))
        {
            try
            {
                animalManager.JsonSerialize(filepath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("List has been saved in json format!");
        } else
        {
            MessageBox.Show("Open a file or save this file through the Save As menu option.");
        }
    }

    /// <summary>
    /// This method handles opening a textfile and tries to deserialize it
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>

    private void mnuFileOpenTextFile_Click(object sender, EventArgs e)
    {
        string testFolderPath = Path.Combine(Application.StartupPath, "tests");
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.InitialDirectory = testFolderPath;
        if (openFileDialog.ShowDialog() == DialogResult.OK)
        {
            string fileName = openFileDialog.FileName;
            if (!fileName.EndsWith(".txt")){
                MessageBox.Show("Wrong file format!");
            } else
            {
                try
                {
                    animalManager.BinaryDeserialize(fileName);
                    listBox1.DataSource = animalManager.GetÍnfo();
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
        currentFilePath = openFileDialog.FileName;
    }

    /// <summary>
    /// This method serializes to json
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void mnuFileSaveAsJson_Click(object sender, EventArgs e)
    {
        if (animalManager.Count == 0)
        {
            MessageBox.Show("You need to add animals to the list first to be able to save!");
            return;
        }
        string testsFolderPath = Path.Combine(Application.StartupPath, "tests");
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.InitialDirectory = testsFolderPath;
        saveFileDialog.DefaultExt = "json";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filename = saveFileDialog.FileName;
            if (filename.EndsWith(".json"))
            {
                try
                {
                    animalManager.JsonSerialize(filename);
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("List has been saved in json format!");
            }
            else
            {
                MessageBox.Show("Wrong file format! Needs to be .json");
            }
        }

    }

    /// <summary>
    /// Serializes the list in to a txt file using the binary serializer
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void mnuFileSaveAsTextFile_Click(object sender, EventArgs e)
    {
        if (animalManager.Count == 0)
        {
            MessageBox.Show("You need to add animals to the list first to be able to save!");
            return;
        }
        string testsFolderPath = Path.Combine(Application.StartupPath, "tests");
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.InitialDirectory = testsFolderPath;
        saveFileDialog.DefaultExt = "txt";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            string filename = saveFileDialog.FileName;
            if (filename.EndsWith(".txt"))
            {
                try
                {
                animalManager.BinarySerialize(filename);
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("List has been saved to text file!");
            }
            else
            {
                MessageBox.Show("Wrong file format! Needs to be .txt");
            }
        }
    }
}