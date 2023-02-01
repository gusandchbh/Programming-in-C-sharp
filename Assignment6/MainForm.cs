namespace Assignment6
{
    public partial class MainForm : Form
    {

        private TaskManager taskManager;

        /// <summary>
        /// Used for reading from and writing to file
        /// </summary>
        string fileName = Application.StartupPath + "\\Tasks.txt";
        public MainForm()
        {
            InitializeComponent();
            InitializeGui();
        }

        /// <summary>
        /// Set appropriates text values for labels etc
        /// </summary>
        public void InitializeGui()
        {
            this.Text = "ToDo Reminder by Christopher Andersson";
            taskManager = new TaskManager();
            comboBoxPriorityType.Items.Clear();
            comboBoxPriorityType.Items.AddRange(Enum.GetNames(typeof(PriorityType)).Select(prio => prio.Replace("_"," ")).ToArray());
            comboBoxPriorityType.SelectedIndex = (int)PriorityType.Normal;
            listBoxTasks.Items.Clear();
            labelClock.Text = string.Empty;
            clockTimer.Start();
            textBoxDescription.Text = String.Empty;
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd HH:mm";
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(dateTimePicker1, "Click to open calendar.");
            toolTip1.SetToolTip(comboBoxPriorityType, "Select priority.");
            toolTip1.SetToolTip(buttonAdd, "Press to add the task to the list.");
            toolStripMenuItemExit.Text = "Exit";
            toolStripMenuFile.Text = "File";
            toolStripMenuItemHelp.Text = "Help";
            toolStripMenuItemNew.Text = "New";
            toolStripMenuItemOpenDataFile.Text = "Open data file";
            toolStripMenuItemSaveDataFile.Text = "Save data file";
            buttonAdd.Text = "Add";
            buttonChange.Text = "Change";
            buttonDelete.Text = "Delete";
            labelToDo.Text = "To do";
            labelDateAndTime.Text = "Date and time";
            labelToDo2.Text = "To do list";
            labelToDo2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            labelDate.Text = "Date";
            labelHour.Text = "Hour";
            labelPriority.Text = "Priority";
            labelDescription.Text = "Description";
            labelPriority.Text = "Priority";
        }

        /// <summary>
        /// Updates the labelClock text to the current time
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void clockTimer_Tick(object sender, EventArgs e)
        {
             labelClock.Text = DateTime.Now.ToLongTimeString();
        }

        /// <summary>
        /// Retrieves an array of toString representations of tasks and uses it to display the tasks in the listbox
        /// </summary>

        private void UpdateGui()
        {
            listBoxTasks.Items.Clear();
            string[] infoStrings = taskManager.GetInfoStringsList();
            if (infoStrings != null)
            {
                listBoxTasks.Items.AddRange(infoStrings);
            }
        }

        /// <summary>
        /// Resets the app to initial state
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            InitializeGui();
        }


        /// <summary>
        /// Checks if the user really wants to exit the program and if the user really wants to exit the program the programs exits
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Sure to exit program?", "Think twice", MessageBoxButtons.OKCancel);
            if (dialogResult == DialogResult.OK)
                Application.Exit();
        }

        /// <summary>
        /// Create new task based on the user input and adds the task to the list of tasks through the taskManager, and then updates the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxDescription.Text == String.Empty)
            {
                MessageBox.Show("Enter a description of the task!");
                return;
            }
            DateTime date = dateTimePicker1.Value;
            string description = textBoxDescription.Text;
            string prio = comboBoxPriorityType.SelectedItem.ToString().Replace(" ","_");
            PriorityType priority = (PriorityType)Enum.Parse(typeof(PriorityType), prio);
            Task task = new Task(description, priority, date);
            taskManager.AddTask(task);
            textBoxDescription.Text = String.Empty;
            UpdateGui();
        }

        /// <summary>
        /// Tries to open file, if successful shows the contents of the file, if not shows an error message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void toolStripMenuItemOpenDataFile_Click(object sender, EventArgs e)
        {
            string errMessage = "Something went wrong when opening the file";

            bool ok = taskManager.ReadDataFromFile(fileName);
            if (!ok)
            {
                MessageBox.Show(errMessage);
            }
            else
                UpdateGui();
        }

        /// <summary>
        /// Tries to save data to file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void toolStripMenuItemSaveDataFile_Click(object sender, EventArgs e)
        {
            string errMessage = "Something went wrong while saving data to file";

            bool ok = taskManager.WriteDataToFile(fileName);
            if (!ok)
            {
                MessageBox.Show(errMessage);
            }
            else
            {
                MessageBox.Show("Data saved to file:" + Environment.NewLine + fileName);
            }
        }

        /// <summary>
        /// If no task is selected shows messagebox with prompt to select a task, if a task is selected it is deleted and then the GUI is updated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = listBoxTasks.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Select a task!");
                return;
            }
            taskManager.Delete(index);
            UpdateGui();
        }


        /// <summary>
        /// Did not implement this further than that it shows a messageBox with a prompt to select a task if no task was selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChange_Click(object sender, EventArgs e)
        {
            int index = listBoxTasks.SelectedIndex;

            if (index < 0)
            {
                MessageBox.Show("Select a task!");
                return;
            }
           
        }
    }
}