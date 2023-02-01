using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_ABC
{
    public class Phone
    {
        private string homePhone;
        private string cellPhone;

        public Phone()
        {
        }

        /// <summary>
        /// Constructor with one parameter - calls the constructor with 
        /// two parameters, using a default value as the second argument.
        /// </summary>
        /// <param name="workPhone">input coming from the client object</param>
        /// <remarks></remarks>
        public Phone(string workPhone) : this(workPhone, string.Empty)
        {
        }

        /// <summary>
        /// Copy constructor returning copy
        /// </summary>
        public Phone(Phone theOther)
        {
            this.homePhone = theOther.homePhone;
            this.cellPhone = theOther.cellPhone;
        }

        /// <summary>
        /// Constructor with two parameters. This is  constructor that has most
        /// number of parameters. It is in tis constructor that all coding 
        /// should be done.
        /// </summary>
        /// <param name="workPhone">Input - work phone</param>
        /// <param name="homePhone">Input - home phone</param>
        /// <remarks></remarks>
        public Phone(string workPhone, string homePhone)
        {
            cellPhone = workPhone;
            this.homePhone = homePhone;
        }

        /// <summary>
        /// Property for HomePhone
        /// </summary>

        public string HomePhone
        {
            get { return homePhone; }

            set { homePhone = value; }
        }


        /// <summary>
        /// Property for CellPhone
        /// </summary>
        public string CellPhone
        {
            get { return cellPhone; }
            set { cellPhone = value; }
        }

        /// <summary>
        /// ToString to display the data in the GUI
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strOut = "Phone numbers" + Environment.NewLine;

            strOut += string.Format(" {0,-10} {1, -10}\n", "Private", homePhone) + Environment.NewLine;
            strOut += string.Format(" {0,-10} {1, -10}\n\n", "Office", cellPhone);

            return strOut;
        }
    }
}
