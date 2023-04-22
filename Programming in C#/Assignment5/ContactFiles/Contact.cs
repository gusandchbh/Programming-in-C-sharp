using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_ABC
{
    public class Contact
    {
        private Phone phone;
        private Email email;
        private Address address;
        private string lastName;
        private string firstName;


        /// <summary>
        /// Default constructor
        /// </summary>
        public Contact()
        {

        }

        /// <summary>
        /// Full constructor
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <param name="address"></param>
        /// <param name="lastName"></param>
        /// <param name="firstName"></param>
        public Contact(Phone phone, Email email, Address address, string lastName, string firstName)
        {
            this.phone = phone;
            this.email = email;
            this.address = address;
            this.lastName = lastName;
            this.firstName = firstName;
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="theOther"></param>

        public Contact(Contact theOther)
        {
            phone = theOther.phone;
            email = theOther.email;
            address = theOther.address;
            this.lastName = theOther.lastName;
            this.firstName = theOther.firstName;
        }

        /// <summary>
        /// Property for LastName
        /// </summary>

        public string LastName
        {
            //private mail
            get { return lastName; }

            set { lastName = value; }
        }

        /// <summary>
        /// Property for FirstName
        /// </summary>

        public string FirstName
        {
            get { return firstName; }

            set { firstName = value; }
        }

        /// <summary>
        /// Property for Phone
        /// </summary>

        public Phone Phone
        {
            get => phone;
            set => phone = value;
        }

        /// <summary>
        /// Property for Email
        /// </summary>

        public Email Email
        {
            get => email;
            set => email = value;
        }

        /// <summary>
        /// Property for Country
        /// </summary>
        
        public Countries Country
        {
            get => address.Country;
            set => address.Country = value;
        }

        /// <summary>
        /// Property for Address
        /// </summary>

        public Address Address
        {
            get => address;
            set => address = value;
        }

        /// <summary>
        /// ToString to display the data in the GUI
        /// </summary>
        /// <returns></returns>

        /// <summary>
        /// ToString to display the data in the GUI
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strOut = this.firstName + " " + this.LastName + Environment.NewLine;
            strOut += this.address.ToString() + Environment.NewLine + Environment.NewLine;
            strOut += this.email.ToString() + Environment.NewLine;
            strOut += this.phone.ToString() + Environment.NewLine;
            return strOut;
        }

    }
}
