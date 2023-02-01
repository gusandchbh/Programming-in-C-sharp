namespace PartyOrganizer
{
    public partial class MainForm : Form
    {
        PartyManager partyManager;
        public MainForm()
        {
            InitializeComponent();
            InitializeGui();
        }

        /// <summary>
        /// Initializes the GUI, setting the correct descriptions for the different texts
        /// </summary>
        private void InitializeGui()
        {
            ClearInputControls();
            ClearOutputControls();
            this.Text = "Party Organizer by Christopher";
            this.GroupBoxNewParty.Text = "New Party";
            this.GroupBoxInviteGuest.Text = "Invite Guest";
            this.LabelMaxGuests.Text = "Max number of guests";
            this.LabelCostPerPerson.Text = "Cost per person";
            this.LabelFeePerPerson.Text = "Fee per person";
            this.ButtonCreateList.Text = "Create List";
            this.LabelFirstName.Text = "First Name";
            this.LabelLastName.Text = "Last Name";
            this.button1.Text = "Add";
            this.LabelNumberOfGuests.Text = "Number of guests";
            this.LabelTotalCost.Text = "Total cost";
            this.LabelTotalFees.Text = "Total fees";
            this.LabelSurplus.Text = "Surplus/deficit";
            this.ButtonDelete.Text = "Delete";
            this.LabelGuestList.Text = "Guest List";
        }
        /// <summary>
        ///  Updates the Listbox so that it is updated when guests are removed from the guestlist
        /// </summary>
        private void UpdateGUI()
        {
            this.ListBoxGuestList.Items.Clear();
            string[] arr = partyManager.GetGuestList()!;
            if (arr != null)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    ListBoxGuestList.Items.Add(arr.Length + " " + arr[arr.Length - 1]);
                }
            }
        }
        /// <summary>
        ///  Used to validate strings
        /// </summary>
        /// <param name="text"></param>
        /// <param name="errMessage"></param>
        /// <returns></returns>
        private bool ValidateText(string text, string errMessage)
        {
            text = text.Trim();
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show(errMessage + "Error");
                return false;
            }
            return true;
        }


        private void ClearInputControls()
        {
            this.Text = "Party Organizer by Christopher";
            this.GroupBoxNewParty.Text = "New Party";
            this.GroupBoxInviteGuest.Text = "Invite Guest";
            this.LabelMaxGuests.Text = "Max number of guests";
            this.LabelCostPerPerson.Text = "Cost per person";
            this.LabelFeePerPerson.Text = "Fee per person";
            this.ButtonCreateList.Text = "Create List";
            this.LabelFirstName.Text = "First Name";
            this.LabelLastName.Text = "Last Name";
            this.button1.Text = "Add";
            this.LabelNumberOfGuests.Text = "Number of guests";
            this.LabelTotalCost.Text = "Total cost";
            this.LabelTotalFees.Text = "Total fees";
            this.LabelSurplus.Text = "Surplus/deficit";
            this.ButtonDelete.Text = "Delete";
            this.LabelGuestList.Text = "Guest List";
        }

        private void ClearOutputControls()
        {
            LabelNumberOfGuests.Text = string.Empty;
            LabelTotalCost.Text = string.Empty;
            LabelTotalFees.Text = string.Empty;
            LabelSurplusOutput.Text = string.Empty;
            ListBoxGuestList.Items.Clear();
        }

        /// <summary>
        /// Takes input about the max number of guests and checks if it is a valid number, all the read methods are variations of this concept
        /// </summary>
        /// <returns></returns>
        private int ReadMaxGuests() 
        {
            int outValue = 0;
            bool ok = int.TryParse(InputMaxGuests.Text, out outValue);
            if (ok)
            {
                if (outValue > 0)
                {
                    ok = true;
                }
                else
                {
                    ok = false;
                }
            }
            if (!ok)
            {
                return -1;
            }
            return outValue;
        }

        private double ReadCostPerPerson()
        {
            double outValue = 0;
            bool ok = double.TryParse(InputCostPerPerson.Text, out outValue);
            if (ok)
            {
                if (outValue > 0)
                {
                    ok = true;
                }
                else
                {
                    ok = false;
                }
            }
            if (!ok)
            {
                return -1;
            }
            return outValue;
        }

        private double ReadFeePerPerson()
        {
            double outValue = 0;
            bool ok = double.TryParse(InputFeePerPerson.Text, out outValue);
            if (ok)
            {
                if (outValue > 0)
                {
                    ok = true;
                }
                else
                {
                    ok = false;
                }
            }
            if (!ok)
            {
                return -1;
            }
            return outValue;
        }

        /// <summary>
        /// Logic for when the user presses the Add button, it performs a number of read operations and then if these return valid input it a partymanager is instantiated and we set values, if not a message box appears 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            int maxGuests = ReadMaxGuests();
            double feePerPerson = ReadFeePerPerson();
            double costPerPerson = ReadCostPerPerson();
            if (maxGuests != -1 && feePerPerson != -1 && costPerPerson != -1)
            {
                partyManager = new PartyManager(maxGuests);
                partyManager.SetCostPerPerson(costPerPerson);
                partyManager.SetFeePerPerson(feePerPerson);
                MessageBox.Show("Party list with space for " + maxGuests + " guests created!");
                
            } else
            {
                MessageBox.Show("Invalid input!");
            }

            

        }

        private string ReadFirstName()
        {
            bool ok = ValidateText(InputFirstName.Text, "Enter the firstname of the guest.");
            if (ok)
            {
                return InputFirstName.Text;
            }
            else
            {
                return string.Empty;
            }
        }


            private string ReadLastName()
            {
                bool ok = ValidateText(InputLastName.Text, "Enter the lastname of the guest.");
                if (ok)
                {
                    return InputLastName.Text;
                }
                else
                {
                    return string.Empty;
                }
            }
        /// <summary>
        /// Calculates the total cost and returns the value as a string
        /// </summary>
        /// <returns></returns>
        private string CalculateTotalCost()
        {
            double totalCost = 0;
            double numOfGuests = partyManager.GetGuestList()!.Length;
            totalCost= numOfGuests * partyManager.GetCostPerPerson();
            return totalCost.ToString();
        }

        private string NumberOfGuests()
        {
            int guests = partyManager.GetGuestList()!.Length;
            return guests.ToString();
        }

        private string CalculateTotalFees()
        {
            double totalFees = 0;
            double numOfGuests = partyManager.GetGuestList()!.Length;
            totalFees = numOfGuests * partyManager.GetFeePerPerson();
            return totalFees.ToString();
        }

        private double calculateProfit()
        {
            double totalFees = partyManager.GetFeePerPerson() * partyManager.GetGuestList()!.Length;
            double totalCost = partyManager.GetCostPerPerson() * partyManager.GetGuestList()!.Length;
            return totalFees - totalCost;
        }

            private void button1_Click(object sender, EventArgs e)
        {
            if (partyManager == null)
            {
                MessageBox.Show("Create a party first!");
                return;
            }
            string firstname = ReadFirstName();
            string lastname = ReadLastName();
            if (firstname == string.Empty || lastname == string.Empty)
            {
                return;
            }
                partyManager.AddNewGuest(firstname, lastname);
            MessageBox.Show("Guest added!");
            InputFirstName.Text = "";
            InputLastName.Text = "";
            string[] arr = partyManager.GetGuestList()!;
            ListBoxGuestList.Items.Add(arr.Length + " " + arr[arr.Length -1]);
            LabelTotalCostOutput.Text = CalculateTotalCost();
            LabelTotalFeesOutput.Text = CalculateTotalFees();
            LabelNumberOfGuestsOutput.Text = NumberOfGuests();
            LabelSurplusOutput.Text = calculateProfit().ToString("f2");
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            int index = ListBoxGuestList.SelectedIndex;
            if (index < 0 || index >= partyManager.NumOfGuests())
            {
                return;
            }
            partyManager.DeleteAt(index);
            this.UpdateGUI();
        }
    }
}