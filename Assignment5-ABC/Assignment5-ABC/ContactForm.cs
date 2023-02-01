using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment5_ABC
{
    public partial class ContactForm : Form
    {
        private ContactFormType contactFormType;
        private Contact contact;
        public ContactForm(ContactFormType contactFormType, Contact contact)
        {
            InitializeComponent();
            this.contactFormType = contactFormType;
            this.contact = contact;
            InitializeGui();
        }
        /// <summary>
        /// Getter for the contact. could have used a Property for this
        /// </summary>
        /// <returns></returns>
        public Contact GetCurrentContact()
        {
            return contact;
        }

        private void InitializeGui()
        {
            if (this.contactFormType == ContactFormType.Add) //If the user presses add
            {
                this.Text = "Add new customer";
            }
            else if (this.contactFormType == ContactFormType.Edit) // If the user presses edit
            { // Fill with data from the current contact
                this.Text = "Edit customer";
                this.textBoxFirstName.Text = contact.FirstName;
                this.textBoxLastName.Text = contact.LastName;
                this.textBoxCellPhone.Text = contact.Phone.CellPhone;
                this.textBoxHomePhone.Text = contact.Phone.HomePhone;
                this.textBoxEmailPrivate.Text = contact.Email.Personal;
                this.textBoxEmailBusiness.Text = contact.Email.Work;
                this.textBoxCity.Text = contact.Address.City;
                this.textBoxStreet.Text = contact.Address.Street;
                this.textBoxZipCode.Text = contact.Address.ZipCode;
                this.comboBoxCountry.Text = contact.Address.Country.ToString();
            }
            // Set appropriate names for labels etc
            this.groupBoxName.Text = "Name";
            this.labelFirstName.Text = "First name";
            this.labelLastName.Text = "Last name";
            this.groupBoxEmailPhone.Text = "Email and phone";
            this.labelHomePhone.Text = "Home phone";
            this.labelCellPhone.Text = "Cell phone";
            this.labelEmailBusiness.Text = "E-mail, business";
            this.labelEmailPrivate.Text = "E-mail, private";
            this.groupBoxAddress.Text = "Address";
            this.labelStreet.Text = "Street";
            this.labelCity.Text = "City";
            this.labelZipCode.Text = "Zip code";
            this.labelCountry.Text = "Country";
            this.buttonAdd.Text = "OK";
            this.buttonCancel.Text = "Cancel";
            fillCountries();
        }
        /// <summary>
        /// Add countries to the combobox
        /// </summary>
        private void fillCountries()
        {
            foreach (var country in Enum.GetNames(typeof(Countries)))
            {
                this.comboBoxCountry.Items.Add(country.Replace("_", " ")); 
            }
        }

        /// <summary>
        /// If User presses close, close the contactform
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        /// <summary>
        /// Here I require the user to input something on each row. Could've been more lenient. Create a contact from the input provided and return a dialogresult of OK.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text == string.Empty || textBoxLastName.Text == string.Empty || textBoxHomePhone.Text == string.Empty || textBoxCellPhone.Text == String.Empty || textBoxEmailBusiness.Text == String.Empty
                || textBoxEmailPrivate.Text == String.Empty || textBoxStreet.Text == String.Empty || textBoxCity.Text == String.Empty || textBoxZipCode.Text == String.Empty || comboBoxCountry.Text == String.Empty)
            {
                MessageBox.Show("Fill in all contact details");
                return;
            }
            Phone phone = new Phone(textBoxCellPhone.Text, textBoxHomePhone.Text);
            var split = comboBoxCountry.Text.ToString().Split(" ");
            Countries country;
            if (split.Length > 0)
            {
                var x = comboBoxCountry.Text.ToString().Replace(" ", "_");
                country = (Countries)Enum.Parse(typeof(Countries), x);
            }
            else
            { country = (Countries)Enum.Parse(typeof(Countries), comboBoxCountry.Text);
            }
            Address address = new Address(textBoxStreet.Text, textBoxCity.Text, textBoxZipCode.Text, country);
            Email email = new Email(textBoxEmailBusiness.Text, textBoxEmailPrivate.Text);
            Contact currentContact = new Contact(phone, email, address, textBoxLastName.Text, textBoxFirstName.Text);
            this.contact = currentContact;
            DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
