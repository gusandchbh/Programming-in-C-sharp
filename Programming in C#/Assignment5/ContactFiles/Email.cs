using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5_ABC
{
    public class Email
    {
        private string personalMail;

        private string officeMail;

        //Constructors are overloaded and called in a chain

        /// <summary>
        /// Default constructor - calls another constructor in this class
        /// </summary>
        /// <remarks></remarks>
        public Email()
        {
        }

        /// <summary>
        /// Constructor with one parameter - calls the constructor with 
        /// two parameters, using a default value as the second argument.
        /// </summary>
        /// <param name="workMail">input coming from the client object</param>
        /// <remarks></remarks>
        public Email(string workMail) : this(workMail, string.Empty)
        {
        }
        /// <summary>
        /// Copy constructor returning copy
        /// </summary>
        public Email(Email theOther)
        {
            this.personalMail = theOther.personalMail;
            this.officeMail = theOther.officeMail;
        }
        /// <summary>
        /// Constructor with two parameters. This is  constructor that has most
        /// number of parameters. It is in tis constructor that all coding 
        /// should be done.
        /// </summary>
        /// <param name="workMail">Input - office mail</param>
        /// <param name="personalMail">Input - private mail</param>
        /// <remarks></remarks>
        public Email(string workMail, string personalMail)
        {
            officeMail = workMail;
            this.personalMail = personalMail;
        }

        /// <summary>
        /// Property related to the field m_Personal
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string Personal
        {
            //private mail
            get { return personalMail; }

            set { personalMail = value; }
        }


        /// <summary>
        /// Property related to officeMail field
        /// Both read and write access
        /// </summary>
        /// <value></value>
        /// <returns></returns>
        /// <remarks></remarks>
        public string Work
        {
            get { return officeMail; }

            set { officeMail = value; }
        }

        public override string ToString()
        {
            string strOut = "Emails" + Environment.NewLine;

            strOut += string.Format(" {0,-10} {1, -10}", "Private", personalMail) + Environment.NewLine;
            strOut += string.Format(" {0,-10} {1, -10}", "Office", officeMail) + Environment.NewLine;

            return strOut;
        }

    }
}
