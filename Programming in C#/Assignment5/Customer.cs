using Assignment5_ABC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_ABC
{
    public class Customer
    {
        private Contact contact;
        private int id;
 

        /// <summary>
        /// Default constructor
        /// </summary>
        public Customer()
        {
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="theOther"></param>

        public Customer(Customer theOther)
        {
            this.contact = theOther.contact;
            id = theOther.id;
        }

        /// <summary>
        /// Full constructor
        /// </summary>
        /// <param name="contact"></param>
        /// <param name="id"></param>
        public Customer(Contact contact, int id)
        {
            this.contact = contact;
            this.id = id;
        }

        /// <summary>
        /// Property for Contact
        /// </summary>

        public Contact Contact
        {
            get { return this.contact; }
            set { contact = value; }
        }

        /// <summary>
        /// Property for Id
        /// </summary>

        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        /// <summary>
        /// ToString to display the data in the GUI
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            String strOut = string.Format(" {0,-10} {1,-10} {2,-20} {3,-20} {4,-20} ", this.id, this.contact.FirstName, this.contact.LastName, this.contact.Phone.CellPhone, this.contact.Email.Work);

            
            return strOut;
        }



    }
}
