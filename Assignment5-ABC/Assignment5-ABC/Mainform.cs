namespace Assignment5_ABC
{
    public partial class Mainform : Form
    {

        private CustomerManager customerManager;
        private Contact contact;
        public Mainform()
        {
            InitializeComponent();
            InitializeGui();
        }
        private void InitializeGui()
        {
            customerManager = new CustomerManager();
            this.Text = "Customer Registry by Christopher";
            this.labelId.Text = "ID";
            this.labelNames.Text = "Names";
            this.labelOfficePhone.Text = "Office phone";
            this.labelOfficeEmail.Text = "Office E-Mail";
            this.buttonAdd.Text = "Add";
            this.buttonDelete.Text = "Delete";
            this.buttonEdit.Text = "Edit";
            this.labelContactDetails.Text = "Contact Details";
        }

        /// <summary>
        /// Updates the listbox
        /// </summary>

        private void updateList()
        {
            this.listBox.Items.Clear();
            foreach(Customer customer in customerManager.GetCustomerList())
            {
                this.listBox.Items.Add(customer.ToString());
            }
        }

        /// <summary>
        /// If DialogResult is OK we create a new customer and add it to the customerlist, and then update the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm(ContactFormType.Add, contact);
            if (contactForm.ShowDialog() == DialogResult.OK)
            {
                // The contact object has been modified or created
                contact = contactForm.GetCurrentContact();
                Customer customer = new Customer(contact, this.customerManager.GetCurrentID());
                customerManager.AddCustomer(customer);
                updateList();
            } 
        }

        /// <summary>
        /// If a customer is not selected, show a message. If a customer is selected, open a customer edit form with the customer details. 
        /// If dialog result is OK update the customer and then update the listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm(ContactFormType.Edit, contact);
            if (contact == null)
            {
                MessageBox.Show("Select a customer first!");
                return;
            }
            if (contactForm.ShowDialog() == DialogResult.OK)
            {
                contact = contactForm.GetCurrentContact();
                int index = listBox.SelectedIndex;
                Customer customer = customerManager.GetCustomer(index);
                customer.Contact = contact;
                customerManager.ChangeCustomer(customer, index);
                updateList();
            }
        }

        /// <summary>
        /// Updates the textbox to show the contact details of the currently selected customer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndex;
            if (index < 0)
                return;
            Customer customer = customerManager.GetCustomer(index);
            textBoxContactDetails.Text = customer.Contact.ToString();
        }

        /// <summary>
        /// If no customer is selected, show a message. If a customer is selected, remove the customer and then update the listbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int index = listBox.SelectedIndex;
            if (index < 0)
            {
                MessageBox.Show("Select a customer first!");
                return;
            }
            customerManager.RemoveCustomer(index);
            updateList();
        }
    }
}