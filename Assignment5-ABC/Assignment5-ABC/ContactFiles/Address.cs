using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_ABC
{
    public class Address
    {
        private string street;
        private string city;
        private string zipCode;
        private Countries country;
 

        /// <summary>
        /// Default constructor
        /// </summary>
        public Address()
        {

        }


        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="theOther"></param>
        public Address(Address theOther)
        {
            this.country = theOther.country;
            this.street = theOther.street;
            this.city = theOther.city;
            this.zipCode = theOther.zipCode;
        }

        /// <summary>
        /// Full constructor
        /// </summary>
        /// <param name="street"></param>
        /// <param name="city"></param>
        /// <param name="zipCode"></param>
        /// <param name="country"></param>

        public Address(string street, string city, string zipCode, Countries country)
        {
            this.street = street;
            this.city = city;
            this.zipCode = zipCode;
            this.country = country;
        }

        /// <summary>
        /// Property for Country
        /// </summary>
        public Countries Country
        {
            get { return country; }
            set { country = value; }
        }

        /// <summary>
        /// Property for ZipCode
        /// </summary>
        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

        /// <summary>
        /// Property for Street
        /// </summary>

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        /// <summary>
        /// Property for City
        /// </summary>

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        /// <summary>
        /// Removes the '_' character from the countries for when it is shown in the GUI
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>

        private string removeUnderlinesFromCountry(Countries country)
        {
            var split = this.country.ToString().Split("_");
            string outStr = country.ToString();
            if (split.Length > 0)
            {
                outStr = this.country.ToString().Replace("_", " ");
            }
            return outStr;
        }

        /// <summary>
        /// ToString to display the data in the GUI
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            string strOut = this.Street + Environment.NewLine + this.zipCode + " " + this.city + Environment.NewLine + removeUnderlinesFromCountry(this.country);
            return strOut;
        }

    }
}
